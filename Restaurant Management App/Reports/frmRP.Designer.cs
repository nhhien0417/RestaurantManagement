namespace Restaurant_Management_App.Reports
{
    partial class frmRP
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
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.sDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.eDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaButton11 = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(416, 180);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(167)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(160, 55);
            this.gunaButton1.TabIndex = 15;
            this.gunaButton1.Text = "In Báo Cáo";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(35, 89);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(119, 23);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "Ngày bắt đầu";
            // 
            // sDate
            // 
            this.sDate.BaseColor = System.Drawing.Color.White;
            this.sDate.BorderColor = System.Drawing.Color.Silver;
            this.sDate.CustomFormat = null;
            this.sDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.sDate.FocusedColor = System.Drawing.Color.Teal;
            this.sDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDate.ForeColor = System.Drawing.Color.Black;
            this.sDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sDate.Location = new System.Drawing.Point(39, 112);
            this.sDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.sDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.sDate.Name = "sDate";
            this.sDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.sDate.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.sDate.OnHoverForeColor = System.Drawing.Color.Black;
            this.sDate.OnPressedColor = System.Drawing.Color.Black;
            this.sDate.Size = new System.Drawing.Size(223, 30);
            this.sDate.TabIndex = 17;
            this.sDate.Text = "4/12/2023";
            this.sDate.Value = new System.DateTime(2023, 12, 4, 9, 17, 57, 48);
            // 
            // eDate
            // 
            this.eDate.BaseColor = System.Drawing.Color.White;
            this.eDate.BorderColor = System.Drawing.Color.Transparent;
            this.eDate.CustomFormat = null;
            this.eDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.eDate.FocusedColor = System.Drawing.Color.Teal;
            this.eDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDate.ForeColor = System.Drawing.Color.Black;
            this.eDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.eDate.Location = new System.Drawing.Point(353, 112);
            this.eDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.eDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.eDate.Name = "eDate";
            this.eDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.eDate.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.eDate.OnHoverForeColor = System.Drawing.Color.Black;
            this.eDate.OnPressedColor = System.Drawing.Color.Black;
            this.eDate.Size = new System.Drawing.Size(223, 30);
            this.eDate.TabIndex = 19;
            this.eDate.Text = "31/3/2025";
            this.eDate.Value = new System.DateTime(2025, 3, 31, 0, 0, 0, 0);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(349, 89);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(123, 23);
            this.gunaLabel2.TabIndex = 18;
            this.gunaLabel2.Text = "Ngày kết thúc";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.gunaButton11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 71);
            this.panel1.TabIndex = 20;
            // 
            // gunaButton11
            // 
            this.gunaButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton11.AnimationHoverSpeed = 0.07F;
            this.gunaButton11.AnimationSpeed = 0.03F;
            this.gunaButton11.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton11.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.gunaButton11.BorderColor = System.Drawing.Color.Black;
            this.gunaButton11.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton11.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton11.ForeColor = System.Drawing.Color.White;
            this.gunaButton11.Image = global::Restaurant_Management_App.Properties.Resources.close1;
            this.gunaButton11.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton11.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton11.Location = new System.Drawing.Point(574, 12);
            this.gunaButton11.Name = "gunaButton11";
            this.gunaButton11.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.gunaButton11.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton11.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton11.OnHoverImage = null;
            this.gunaButton11.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton11.Radius = 20;
            this.gunaButton11.Size = new System.Drawing.Size(54, 50);
            this.gunaButton11.TabIndex = 8;
            this.gunaButton11.Click += new System.EventHandler(this.gunaButton11_Click);
            // 
            // frmRP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(640, 260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eDate);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.sDate);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDateTimePicker sDate;
        private Guna.UI.WinForms.GunaDateTimePicker eDate;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton gunaButton11;
    }
}