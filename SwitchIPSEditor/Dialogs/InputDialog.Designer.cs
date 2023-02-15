namespace SwitchIPSEditor.Dialogs
{
    partial class InputDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.table_main = new System.Windows.Forms.TableLayoutPanel();
            this.table_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_box_value = new System.Windows.Forms.TextBox();
            this.lbl_text = new System.Windows.Forms.Label();
            this.table_main.SuspendLayout();
            this.table_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_main
            // 
            this.table_main.ColumnCount = 1;
            this.table_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_main.Controls.Add(this.table_buttons, 0, 2);
            this.table_main.Controls.Add(this.txt_box_value, 0, 1);
            this.table_main.Controls.Add(this.lbl_text, 0, 0);
            this.table_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_main.Location = new System.Drawing.Point(0, 0);
            this.table_main.Name = "table_main";
            this.table_main.RowCount = 3;
            this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.table_main.Size = new System.Drawing.Size(284, 111);
            this.table_main.TabIndex = 0;
            // 
            // table_buttons
            // 
            this.table_buttons.ColumnCount = 2;
            this.table_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_buttons.Controls.Add(this.btn_cancel, 1, 0);
            this.table_buttons.Controls.Add(this.btn_ok, 0, 0);
            this.table_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_buttons.Location = new System.Drawing.Point(3, 87);
            this.table_buttons.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.table_buttons.Name = "table_buttons";
            this.table_buttons.RowCount = 1;
            this.table_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_buttons.Size = new System.Drawing.Size(278, 24);
            this.table_buttons.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Location = new System.Drawing.Point(139, 0);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(139, 24);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ok.Location = new System.Drawing.Point(0, 0);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(139, 24);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_box_value
            // 
            this.txt_box_value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_box_value.Location = new System.Drawing.Point(3, 58);
            this.txt_box_value.Name = "txt_box_value";
            this.txt_box_value.Size = new System.Drawing.Size(278, 23);
            this.txt_box_value.TabIndex = 2;
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_text.Location = new System.Drawing.Point(3, 0);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(278, 55);
            this.lbl_text.TabIndex = 3;
            this.lbl_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.table_main);
            this.Name = "InputDialog";
            this.table_main.ResumeLayout(false);
            this.table_main.PerformLayout();
            this.table_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel table_main;
        private TableLayoutPanel table_buttons;
        private Button btn_cancel;
        private Button btn_ok;
        private TextBox txt_box_value;
        private Label lbl_text;
    }
}