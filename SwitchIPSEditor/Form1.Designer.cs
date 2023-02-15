namespace SwitchIPSEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.table_main = new System.Windows.Forms.TableLayoutPanel();
            this.table_menu_bar = new System.Windows.Forms.TableLayoutPanel();
            this.btn_save_as_ips_file = new System.Windows.Forms.Button();
            this.btn_save_ips_file = new System.Windows.Forms.Button();
            this.btn_close_ips_file = new System.Windows.Forms.Button();
            this.btn_open_ips_file = new System.Windows.Forms.Button();
            this.table_status_bar = new System.Windows.Forms.TableLayoutPanel();
            this.txt_box_status_bar = new System.Windows.Forms.TextBox();
            this.lbl_status_bar = new System.Windows.Forms.Label();
            this.table_ips_viewer = new System.Windows.Forms.TableLayoutPanel();
            this.tab_manager = new System.Windows.Forms.TabControl();
            this.table_ips_viewer_commands = new System.Windows.Forms.TableLayoutPanel();
            this.btn_remove_patch = new System.Windows.Forms.Button();
            this.btn_add_patch = new System.Windows.Forms.Button();
            this.table_main.SuspendLayout();
            this.table_menu_bar.SuspendLayout();
            this.table_status_bar.SuspendLayout();
            this.table_ips_viewer.SuspendLayout();
            this.table_ips_viewer_commands.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_main
            // 
            this.table_main.ColumnCount = 1;
            this.table_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_main.Controls.Add(this.table_menu_bar, 0, 0);
            this.table_main.Controls.Add(this.table_status_bar, 0, 2);
            this.table_main.Controls.Add(this.table_ips_viewer, 0, 1);
            this.table_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_main.Location = new System.Drawing.Point(0, 0);
            this.table_main.Name = "table_main";
            this.table_main.RowCount = 3;
            this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.table_main.Size = new System.Drawing.Size(800, 450);
            this.table_main.TabIndex = 0;
            // 
            // table_menu_bar
            // 
            this.table_menu_bar.ColumnCount = 5;
            this.table_menu_bar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.table_menu_bar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.table_menu_bar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.table_menu_bar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.table_menu_bar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_menu_bar.Controls.Add(this.btn_save_as_ips_file, 2, 0);
            this.table_menu_bar.Controls.Add(this.btn_save_ips_file, 1, 0);
            this.table_menu_bar.Controls.Add(this.btn_close_ips_file, 3, 0);
            this.table_menu_bar.Controls.Add(this.btn_open_ips_file, 0, 0);
            this.table_menu_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_menu_bar.Location = new System.Drawing.Point(0, 0);
            this.table_menu_bar.Margin = new System.Windows.Forms.Padding(0);
            this.table_menu_bar.Name = "table_menu_bar";
            this.table_menu_bar.RowCount = 1;
            this.table_menu_bar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_menu_bar.Size = new System.Drawing.Size(800, 32);
            this.table_menu_bar.TabIndex = 2;
            // 
            // btn_save_as_ips_file
            // 
            this.btn_save_as_ips_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save_as_ips_file.Enabled = false;
            this.btn_save_as_ips_file.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save_as_ips_file.Location = new System.Drawing.Point(243, 3);
            this.btn_save_as_ips_file.Name = "btn_save_as_ips_file";
            this.btn_save_as_ips_file.Size = new System.Drawing.Size(114, 26);
            this.btn_save_as_ips_file.TabIndex = 4;
            this.btn_save_as_ips_file.Text = "Save As";
            this.btn_save_as_ips_file.UseVisualStyleBackColor = true;
            this.btn_save_as_ips_file.Click += new System.EventHandler(this.btn_save_as_ips_file_Click);
            // 
            // btn_save_ips_file
            // 
            this.btn_save_ips_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save_ips_file.Enabled = false;
            this.btn_save_ips_file.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save_ips_file.Location = new System.Drawing.Point(123, 3);
            this.btn_save_ips_file.Name = "btn_save_ips_file";
            this.btn_save_ips_file.Size = new System.Drawing.Size(114, 26);
            this.btn_save_ips_file.TabIndex = 3;
            this.btn_save_ips_file.Text = "Save";
            this.btn_save_ips_file.UseVisualStyleBackColor = true;
            this.btn_save_ips_file.Click += new System.EventHandler(this.btn_save_ips_file_Click);
            // 
            // btn_close_ips_file
            // 
            this.btn_close_ips_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close_ips_file.Enabled = false;
            this.btn_close_ips_file.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close_ips_file.Location = new System.Drawing.Point(363, 3);
            this.btn_close_ips_file.Name = "btn_close_ips_file";
            this.btn_close_ips_file.Size = new System.Drawing.Size(114, 26);
            this.btn_close_ips_file.TabIndex = 2;
            this.btn_close_ips_file.Text = "Close";
            this.btn_close_ips_file.UseVisualStyleBackColor = true;
            this.btn_close_ips_file.Click += new System.EventHandler(this.btn_close_ips_file_Click);
            // 
            // btn_open_ips_file
            // 
            this.btn_open_ips_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_open_ips_file.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_open_ips_file.Location = new System.Drawing.Point(3, 3);
            this.btn_open_ips_file.Name = "btn_open_ips_file";
            this.btn_open_ips_file.Size = new System.Drawing.Size(114, 26);
            this.btn_open_ips_file.TabIndex = 1;
            this.btn_open_ips_file.Text = "Open";
            this.btn_open_ips_file.UseVisualStyleBackColor = true;
            this.btn_open_ips_file.Click += new System.EventHandler(this.btn_open_ips_file_Click);
            // 
            // table_status_bar
            // 
            this.table_status_bar.ColumnCount = 2;
            this.table_status_bar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.table_status_bar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_status_bar.Controls.Add(this.txt_box_status_bar, 1, 0);
            this.table_status_bar.Controls.Add(this.lbl_status_bar, 0, 0);
            this.table_status_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_status_bar.Location = new System.Drawing.Point(0, 450);
            this.table_status_bar.Margin = new System.Windows.Forms.Padding(0);
            this.table_status_bar.Name = "table_status_bar";
            this.table_status_bar.RowCount = 1;
            this.table_status_bar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_status_bar.Size = new System.Drawing.Size(800, 1);
            this.table_status_bar.TabIndex = 3;
            // 
            // txt_box_status_bar
            // 
            this.txt_box_status_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_box_status_bar.Location = new System.Drawing.Point(60, 0);
            this.txt_box_status_bar.Margin = new System.Windows.Forms.Padding(0);
            this.txt_box_status_bar.Name = "txt_box_status_bar";
            this.txt_box_status_bar.ReadOnly = true;
            this.txt_box_status_bar.Size = new System.Drawing.Size(740, 23);
            this.txt_box_status_bar.TabIndex = 4;
            // 
            // lbl_status_bar
            // 
            this.lbl_status_bar.AutoSize = true;
            this.lbl_status_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_status_bar.Location = new System.Drawing.Point(0, 0);
            this.lbl_status_bar.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_status_bar.Name = "lbl_status_bar";
            this.lbl_status_bar.Size = new System.Drawing.Size(60, 1);
            this.lbl_status_bar.TabIndex = 5;
            this.lbl_status_bar.Text = "Path :";
            this.lbl_status_bar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // table_ips_viewer
            // 
            this.table_ips_viewer.ColumnCount = 2;
            this.table_ips_viewer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_ips_viewer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.table_ips_viewer.Controls.Add(this.tab_manager, 0, 0);
            this.table_ips_viewer.Controls.Add(this.table_ips_viewer_commands, 1, 0);
            this.table_ips_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_ips_viewer.Location = new System.Drawing.Point(3, 35);
            this.table_ips_viewer.Name = "table_ips_viewer";
            this.table_ips_viewer.RowCount = 1;
            this.table_ips_viewer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_ips_viewer.Size = new System.Drawing.Size(794, 412);
            this.table_ips_viewer.TabIndex = 4;
            this.table_ips_viewer.Visible = false;
            // 
            // tab_manager
            // 
            this.tab_manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_manager.Location = new System.Drawing.Point(3, 3);
            this.tab_manager.Name = "tab_manager";
            this.tab_manager.SelectedIndex = 0;
            this.tab_manager.Size = new System.Drawing.Size(756, 406);
            this.tab_manager.TabIndex = 5;
            // 
            // table_ips_viewer_commands
            // 
            this.table_ips_viewer_commands.ColumnCount = 1;
            this.table_ips_viewer_commands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_ips_viewer_commands.Controls.Add(this.btn_remove_patch, 0, 1);
            this.table_ips_viewer_commands.Controls.Add(this.btn_add_patch, 0, 0);
            this.table_ips_viewer_commands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_ips_viewer_commands.Location = new System.Drawing.Point(762, 0);
            this.table_ips_viewer_commands.Margin = new System.Windows.Forms.Padding(0);
            this.table_ips_viewer_commands.Name = "table_ips_viewer_commands";
            this.table_ips_viewer_commands.RowCount = 3;
            this.table_ips_viewer_commands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.table_ips_viewer_commands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.table_ips_viewer_commands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_ips_viewer_commands.Size = new System.Drawing.Size(32, 412);
            this.table_ips_viewer_commands.TabIndex = 6;
            // 
            // btn_remove_patch
            // 
            this.btn_remove_patch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_remove_patch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove_patch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_remove_patch.Location = new System.Drawing.Point(3, 35);
            this.btn_remove_patch.Name = "btn_remove_patch";
            this.btn_remove_patch.Size = new System.Drawing.Size(26, 26);
            this.btn_remove_patch.TabIndex = 3;
            this.btn_remove_patch.Text = "-";
            this.btn_remove_patch.UseVisualStyleBackColor = true;
            this.btn_remove_patch.Click += new System.EventHandler(this.btn_remove_patch_Click);
            // 
            // btn_add_patch
            // 
            this.btn_add_patch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add_patch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_patch.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_patch.Location = new System.Drawing.Point(3, 3);
            this.btn_add_patch.Name = "btn_add_patch";
            this.btn_add_patch.Size = new System.Drawing.Size(26, 26);
            this.btn_add_patch.TabIndex = 2;
            this.btn_add_patch.Text = "+";
            this.btn_add_patch.UseVisualStyleBackColor = true;
            this.btn_add_patch.Click += new System.EventHandler(this.btn_add_patch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table_main);
            this.Name = "Form1";
            this.Text = "Switch IPS Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.table_main.ResumeLayout(false);
            this.table_menu_bar.ResumeLayout(false);
            this.table_status_bar.ResumeLayout(false);
            this.table_status_bar.PerformLayout();
            this.table_ips_viewer.ResumeLayout(false);
            this.table_ips_viewer_commands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel table_main;
        private TableLayoutPanel table_menu_bar;
        private Button btn_open_ips_file;
        private Button btn_close_ips_file;
        private Button btn_save_ips_file;
        private Button btn_save_as_ips_file;
        private TableLayoutPanel table_status_bar;
        private TextBox txt_box_status_bar;
        private Label lbl_status_bar;
        private TableLayoutPanel table_ips_viewer;
        private TabControl tab_manager;
        private TableLayoutPanel table_ips_viewer_commands;
        private Button btn_remove_patch;
        private Button btn_add_patch;
    }
}