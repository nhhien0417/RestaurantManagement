namespace Restaurant_Management_App.Model
{
    partial class frmChangeUser
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOldpw
            // 
            this.tbOldpw.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbOldpw.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbOldpw.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbOldpw.Location = new System.Drawing.Point(61, 185);
            this.tbOldpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(61, 150);
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(61, 236);
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.Text = "Tên tài khoản mới";
            // 
            // tbNewpw
            // 
            this.tbNewpw.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbNewpw.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbNewpw.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNewpw.Location = new System.Drawing.Point(61, 272);
            this.tbNewpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(61, 336);
            this.label3.Size = new System.Drawing.Size(225, 23);
            this.label3.Text = "Nhập lại tên tài khoản mới";
            // 
            // tbConfirm
            // 
            this.tbConfirm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbConfirm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbConfirm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbConfirm.Location = new System.Drawing.Point(61, 371);
            this.tbConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(379, 139);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 468);
            this.panel2.Size = new System.Drawing.Size(379, 70);
            // 
            // header
            // 
            this.header.Size = new System.Drawing.Size(200, 31);
            this.header.Text = "Đổi tên tài khoản";
            // 
            // btSave
            // 
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.Location = new System.Drawing.Point(49, 11);
            this.btSave.Click += new System.EventHandler(this.btSave_Click_1);
            // 
            // btExit
            // 
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // frmChangeUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(379, 538);
            this.Name = "frmChangeUser";
            this.Text = "frmChangeUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}