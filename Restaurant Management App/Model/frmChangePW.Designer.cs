namespace Restaurant_Management_App.Model
{
    partial class frmChangePW
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
            this.tbOldpw = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewpw = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbConfirm = new Guna.UI.WinForms.GunaTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.Size = new System.Drawing.Size(400, 139);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(191)))), ((int)(((byte)(150)))));
            this.panel2.Location = new System.Drawing.Point(0, 517);
            this.panel2.Size = new System.Drawing.Size(400, 70);
            // 
            // header
            // 
            this.header.Size = new System.Drawing.Size(159, 31);
            this.header.Text = "Đổi mật khẩu";
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(90)))), ((int)(((byte)(103)))));
            this.btSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(90)))), ((int)(((byte)(103)))));
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.Location = new System.Drawing.Point(61, 11);
            this.btSave.Size = new System.Drawing.Size(124, 47);
            this.btSave.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click_1);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(90)))), ((int)(((byte)(103)))));
            this.btExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(90)))), ((int)(((byte)(103)))));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.Location = new System.Drawing.Point(209, 11);
            this.btExit.Size = new System.Drawing.Size(124, 47);
            this.btExit.Text = "Đóng";
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // tbOldpw
            // 
            this.tbOldpw.BaseColor = System.Drawing.Color.White;
            this.tbOldpw.BorderColor = System.Drawing.Color.Silver;
            this.tbOldpw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOldpw.FocusedBaseColor = System.Drawing.Color.White;
            this.tbOldpw.FocusedBorderColor = System.Drawing.Color.Teal;
            this.tbOldpw.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbOldpw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbOldpw.Location = new System.Drawing.Point(62, 224);
            this.tbOldpw.Name = "tbOldpw";
            this.tbOldpw.PasswordChar = '\0';
            this.tbOldpw.SelectedText = "";
            this.tbOldpw.Size = new System.Drawing.Size(271, 42);
            this.tbOldpw.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu mới";
            // 
            // tbNewpw
            // 
            this.tbNewpw.BaseColor = System.Drawing.Color.White;
            this.tbNewpw.BorderColor = System.Drawing.Color.Silver;
            this.tbNewpw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewpw.FocusedBaseColor = System.Drawing.Color.White;
            this.tbNewpw.FocusedBorderColor = System.Drawing.Color.Teal;
            this.tbNewpw.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbNewpw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNewpw.Location = new System.Drawing.Point(62, 310);
            this.tbNewpw.Name = "tbNewpw";
            this.tbNewpw.PasswordChar = '\0';
            this.tbNewpw.SelectedText = "";
            this.tbNewpw.Size = new System.Drawing.Size(271, 42);
            this.tbNewpw.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // tbConfirm
            // 
            this.tbConfirm.BaseColor = System.Drawing.Color.White;
            this.tbConfirm.BorderColor = System.Drawing.Color.Silver;
            this.tbConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirm.FocusedBaseColor = System.Drawing.Color.White;
            this.tbConfirm.FocusedBorderColor = System.Drawing.Color.Teal;
            this.tbConfirm.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbConfirm.Location = new System.Drawing.Point(62, 400);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.PasswordChar = '\0';
            this.tbConfirm.SelectedText = "";
            this.tbConfirm.Size = new System.Drawing.Size(271, 42);
            this.tbConfirm.TabIndex = 6;
            // 
            // frmChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(400, 587);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNewpw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOldpw);
            this.Name = "frmChangePW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePW";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.tbOldpw, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbNewpw, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbConfirm, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaTextBox tbOldpw;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox tbNewpw;
        public System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaTextBox tbConfirm;
    }
}