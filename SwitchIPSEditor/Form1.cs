using Dark.Net;
using SwitchIPSEditor.Dialogs;
using System.Security.Cryptography;

namespace SwitchIPSEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SwitchTheme(DarkNet.Instance.UserDefaultAppThemeIsDark);
        }

        /* EVENTS */

        private void Form1_Load(object sender, EventArgs e)
        {
            tab_manager.SelectedIndexChanged += (s, ev) =>
            {
                UpdateListViewColumns();
                UpdateButtons();
                UpdateStatusBar();
            };

            SizeChanged += (s, ev) => UpdateListViewColumns();
        }

        internal void Form_ThemeChanged(object? sender, bool isDarkMode)
        {
            SwitchTheme(isDarkMode);
        }

        public void SwitchTheme(bool isDarkMode)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => SwitchTheme(isDarkMode)));
                return;
            }

            var backColor = isDarkMode ? SystemColors.ControlDarkDark : SystemColors.ControlLightLight;
            var foreColor = isDarkMode ? SystemColors.ControlDark : SystemColors.ControlLight;

            BackColor = backColor;
            ForeColor = foreColor;

            btn_open_ips_file.BackColor = backColor;
            btn_open_ips_file.ForeColor = foreColor;
            btn_save_ips_file.BackColor = backColor;
            btn_save_ips_file.ForeColor = foreColor;
            btn_save_as_ips_file.BackColor = backColor;
            btn_save_as_ips_file.ForeColor = foreColor;
            btn_close_ips_file.BackColor = backColor;
            btn_close_ips_file.ForeColor = foreColor;

            tab_manager.BackColor = backColor;
            tab_manager.ForeColor = foreColor;

            txt_box_status_bar.BackColor = backColor;
            txt_box_status_bar.ForeColor = foreColor;

            foreach (TabPage page in tab_manager.TabPages)
            {
                page.BackColor = backColor;
                page.ForeColor = foreColor;
                foreach (Control control in page.Controls)
                {
                    control.BackColor = backColor;
                    control.ForeColor = foreColor;
                }
            }
        }

        /*   */

        public void UpdateButtons()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateButtons()));
                return;
            }

            btn_close_ips_file.Enabled = tab_manager.SelectedIndex != -1;
            btn_save_ips_file.Enabled = tab_manager.SelectedIndex != -1;
            btn_save_as_ips_file.Enabled = tab_manager.SelectedIndex != -1;
            btn_add_patch.Enabled = tab_manager.SelectedIndex != -1;
            btn_remove_patch.Enabled = tab_manager.SelectedIndex != -1 && tab_manager.SelectedTab.Controls.OfType<ListView>().First().SelectedItems.Count > 0;
        }

        public void UpdateStatusBar()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateStatusBar()));
                return;
            }

            if (this.tab_manager.SelectedIndex == -1)
            {
                this.table_main.RowStyles[2].Height = 0f;
                this.txt_box_status_bar.Text = string.Empty;                
            }
            else
            {
                this.table_main.RowStyles[2].Height = 24f;
                this.txt_box_status_bar.Text = this.tab_manager.GetExtendedNameFromTabName(this.tab_manager.SelectedTab.Text);
            }
        }

        public void UpdateListViewColumns()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateListViewColumns()));
                return;
            }

            if (tab_manager.SelectedIndex != -1)
            {
                ListView listView = tab_manager.SelectedTab.Controls.OfType<ListView>().First();
                listView.Columns[0].Width = 70;
                listView.Columns[1].Width = listView.ClientSize.Width - listView.Columns[0].Width;
            }
        }

        void SaveFile(string filepath)
        {
            List<IPS.Patch> patches = new List<IPS.Patch>();
            foreach (ListViewItem item in tab_manager.SelectedTab.Controls.OfType<ListView>().First().Items)
            {
                patches.Add(new IPS.Patch()
                {
                    Address = Convert.ToUInt32($"0x{item.SubItems[0].Text:X8}", 16),
                    Datas = item.SubItems[1].Text.Split(" ").Select(b => Convert.ToByte($"0x{b:X2}", 16)).ToArray()
                });
                // don't add empty patches
                if (patches.Last().Datas == null || patches.Last().Datas.Length == 0) patches.RemoveAt(patches.Count - 1);
            }
            IPS.Save(filepath, patches.ToArray());
        }

        private void btn_open_ips_file_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog()) 
            {
                ofd.Filter = "IPS patch (*.ips)|*.ips|All files (*.*)|*.*";
                ofd.RestoreDirectory = true;

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(ofd.FileName))
                    {
                        var patches = IPS.Load(ofd.FileName);
                        var listView = new ListView()
                        {
                            Dock = DockStyle.Fill,
                            View = View.Details
                        };
                        listView.Columns.Add("Address");
                        listView.Columns.Add("Value");
                        foreach(var patch in patches)
                        {
                            if (patch.Datas == null)
                                throw new NullReferenceException("patch.Datas is null!");
                            listView.Items.Add(new ListViewItem(new string[] { $"{patch.Address:X8}", string.Join(" ", patch.Datas.Select(b => $"{b:X2}").ToArray()) }));
                        }
                        listView.FullRowSelect = true;
                        listView.SelectedIndexChanged += (s, ev) => UpdateButtons();
                        listView.MouseDoubleClick += (s, ev) =>
                        {
                            var hitTest = listView.HitTest(ev.X, ev.Y);
                            if (hitTest != null)
                            {
                                var colIdx = listView.Items[hitTest.Item.Index].SubItems.IndexOf(hitTest.SubItem);
                                if (colIdx == 0)
                                {
                                    var inputDialog = new InputDialog("Enter an address (The one you got with ghidra) :", this.Text);
                                    inputDialog.Value = hitTest.SubItem.Text;

                                    DarkNet.Instance.SetWindowThemeForms(inputDialog, Theme.Auto);
                                    DarkNet.Instance.UserDefaultAppThemeIsDarkChanged += inputDialog.Form_ThemeChanged;
                                    if (inputDialog.ShowDialog() == DialogResult.OK)
                                    {
                                        try {
                                            hitTest.SubItem.Text = $"{Convert.ToUInt32(inputDialog.Value, 16):X8}";
                                        } catch {
                                            throw new Exception($"Invalid value ({inputDialog.Value})");
                                        }
                                    }
                                }

                                if (colIdx == 1)
                                {
                                    var inputDialog = new InputDialog("Enter a value (ex : 1F 20 03 D5) :", this.Text);
                                    inputDialog.Value = hitTest.SubItem.Text;

                                    DarkNet.Instance.SetWindowThemeForms(inputDialog, Theme.Auto);
                                    DarkNet.Instance.UserDefaultAppThemeIsDarkChanged += inputDialog.Form_ThemeChanged;
                                    if (inputDialog.ShowDialog() == DialogResult.OK)
                                    {
                                        while(inputDialog.Value.Contains("  ")) inputDialog.Value = inputDialog.Value.Replace("  ", " ");
                                        var parsedDatas = "";
                                        foreach (var data in inputDialog.Value.Split(" "))
                                        {
                                            try {
                                                parsedDatas += $"{Convert.ToByte(data, 16):X2} ";
                                            } catch {
                                                throw new Exception($"Invalid value ({inputDialog.Value})");
                                            }
                                        }
                                        if (parsedDatas.Last() == ' ') parsedDatas = parsedDatas.Remove(parsedDatas.Length - 1);
                                        hitTest.SubItem.Text = parsedDatas;
                                    }
                                }
                            }
                        };
                        tab_manager.AddTab(Path.GetFileName(ofd.FileName), Path.GetFullPath(ofd.FileName), listView);
                        UpdateListViewColumns();
                        UpdateButtons();
                        UpdateStatusBar();
                        SwitchTheme(DarkNet.Instance.UserDefaultAppThemeIsDark);
                    }
                }
            }
        }

        private void btn_save_ips_file_Click(object sender, EventArgs e)
        {
            if (tab_manager.SelectedIndex != -1)
            {
                if (File.Exists(txt_box_status_bar.Text))
                {
                    if (MessageBox.Show("Do you want to replace the file?", this.Text, MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
                SaveFile(txt_box_status_bar.Text);
            }
        }

        private void btn_save_as_ips_file_Click(object sender, EventArgs e)
        {
            if (tab_manager.SelectedIndex != -1)
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "IPS patch (*.ips)|*.ips|All files (*.*)|*.*";
                    sfd.RestoreDirectory = true;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            if (MessageBox.Show("Do you want to replace the file?", this.Text, MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                return;
                            }
                        }

                        SaveFile(sfd.FileName);
                        tab_manager.SetExtendedNameFromTabName(tab_manager.SelectedTab.Text, Path.GetFullPath(sfd.FileName));
                        UpdateStatusBar();
                    }
                }
            }
        }

        private void btn_close_ips_file_Click(object sender, EventArgs e)
        {
            if (tab_manager.SelectedIndex != -1)
            {
                tab_manager.RemoveTab(txt_box_status_bar.Text);
                UpdateListViewColumns();
                UpdateButtons();
                UpdateStatusBar();
            }
        }

        private void btn_add_patch_Click(object sender, EventArgs e)
        {
            if (tab_manager.SelectedIndex != -1)
            {
                var listView = tab_manager.SelectedTab.Controls.OfType<ListView>().First();
                if (listView.SelectedItems.Count == 1)
                    listView.Items.Insert(listView.SelectedItems[0].Index + 1, new ListViewItem(new string[] { "00000000", "" }));
                else if (listView.SelectedItems.Count == 0 || (listView.SelectedItems.Count == 1 && listView.SelectedItems[0].Index + 1 >= listView.Items.Count))
                    listView.Items.Add(new ListViewItem(new string[] { "00000000", "" }));
                UpdateButtons();
            }
        }

        private void btn_remove_patch_Click(object sender, EventArgs e)
        {
            if (tab_manager.SelectedIndex != -1)
            {
                var listView = tab_manager.SelectedTab.Controls.OfType<ListView>().First();
                foreach (ListViewItem item in listView.SelectedItems)
                    listView.Items.Remove(item);
                UpdateButtons();
            }
        }
    }
}