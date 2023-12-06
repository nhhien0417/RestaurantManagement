namespace Restaurant_Management_App.Model
{
    partial class frmAddCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExit = new Guna.UI.WinForms.GunaPictureBox();
            this.header = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.tbDriver = new Guna.UI.WinForms.GunaComboBox();
            this.lbdriver = new Guna.UI.WinForms.GunaLabel();
            this.tbName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.tbPhone = new Guna.UI.WinForms.GunaTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.header);
            this.panel1.Controls.Add(this.rjCircularPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 139);
            this.panel1.TabIndex = 1;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BaseColor = System.Drawing.Color.White;
            this.btExit.Image = global::Restaurant_Management_App.Properties.Resources.button;
            this.btExit.Location = new System.Drawing.Point(504, 32);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(64, 63);
            this.btExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btExit.TabIndex = 12;
            this.btExit.TabStop = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.header.Location = new System.Drawing.Point(146, 50);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(249, 31);
            this.header.TabIndex = 1;
            this.header.Text = "Thông tin khách hàng";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.Transparent;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.Transparent;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::Restaurant_Management_App.Properties.Resources.cogwheel_3953226__1_;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(25, 12);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(98, 98);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // tbDriver
            // 
            this.tbDriver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDriver.BackColor = System.Drawing.Color.Transparent;
            this.tbDriver.BaseColor = System.Drawing.Color.White;
            this.tbDriver.BorderColor = System.Drawing.Color.Silver;
            this.tbDriver.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbDriver.FocusedColor = System.Drawing.Color.Empty;
            this.tbDriver.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbDriver.ForeColor = System.Drawing.Color.Black;
            this.tbDriver.FormattingEnabled = true;
            this.tbDriver.ItemHeight = 38;
            this.tbDriver.Items.AddRange(new object[] {
            "Phục vụ",
            "Quản lý",
            "Giao hàng",
            "Bảo vệ",
            "Đầu bếp",
            "Thu ngân"});
            this.tbDriver.Location = new System.Drawing.Point(3, 31);
            this.tbDriver.Name = "tbDriver";
            this.tbDriver.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbDriver.OnHoverItemForeColor = System.Drawing.Color.White;
            this.tbDriver.Size = new System.Drawing.Size(315, 44);
            this.tbDriver.TabIndex = 14;
            this.tbDriver.SelectedIndexChanged += new System.EventHandler(this.tbDriver_SelectedIndexChanged);
            // 
            // lbdriver
            // 
            this.lbdriver.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbdriver.AutoSize = true;
            this.lbdriver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdriver.Location = new System.Drawing.Point(3, 0);
            this.lbdriver.Name = "lbdriver";
            this.lbdriver.Size = new System.Drawing.Size(209, 28);
            this.lbdriver.TabIndex = 16;
            this.lbdriver.Text = "Nhân viên giao hàng";
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbName.BaseColor = System.Drawing.Color.White;
            this.tbName.BorderColor = System.Drawing.Color.Silver;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.FocusedBaseColor = System.Drawing.Color.White;
            this.tbName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.tbName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(3, 109);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.SelectedText = "";
            this.tbName.Size = new System.Drawing.Size(315, 45);
            this.tbName.TabIndex = 13;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(3, 78);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(45, 28);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "Tên";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.lbdriver);
            this.flowLayoutPanel1.Controls.Add(this.tbDriver);
            this.flowLayoutPanel1.Controls.Add(this.gunaLabel1);
            this.flowLayoutPanel1.Controls.Add(this.tbName);
            this.flowLayoutPanel1.Controls.Add(this.gunaLabel3);
            this.flowLayoutPanel1.Controls.Add(this.tbPhone);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(123, 145);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(321, 286);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(3, 157);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(138, 28);
            this.gunaLabel3.TabIndex = 18;
            this.gunaLabel3.Text = "Số điện thoại";
            // 
            // tbPhone
            // 
            this.tbPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPhone.BaseColor = System.Drawing.Color.White;
            this.tbPhone.BorderColor = System.Drawing.Color.Silver;
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.tbPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.tbPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(3, 188);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PasswordChar = '\0';
            this.tbPhone.SelectedText = "";
            this.tbPhone.Size = new System.Drawing.Size(315, 45);
            this.tbPhone.TabIndex = 17;
            // 
            // frmAddCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(599, 498);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddCustomer";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label header;
        public CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        public Guna.UI.WinForms.GunaComboBox tbDriver;
        private Guna.UI.WinForms.GunaLabel lbdriver;
        public Guna.UI.WinForms.GunaTextBox tbName;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaTextBox tbPhone;
        private Guna.UI.WinForms.GunaPictureBox btExit;
    }
}