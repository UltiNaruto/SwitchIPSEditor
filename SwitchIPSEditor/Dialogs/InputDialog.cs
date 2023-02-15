using Dark.Net;

namespace SwitchIPSEditor.Dialogs
{
    public partial class InputDialog : Form
    {
        public string Value
        {
            get
            {
                return txt_box_value.Text;
            }

            set
            {
                txt_box_value.Text = value;
            }
        }

        InputDialog()
        {
            InitializeComponent();
            SwitchTheme(DarkNet.Instance.UserDefaultAppThemeIsDark);
        }

        public InputDialog(string text, string caption) : this()
        {
            this.Text = caption;
            this.lbl_text.Text = text;
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

            txt_box_value.BackColor = backColor;
            txt_box_value.ForeColor = foreColor;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
