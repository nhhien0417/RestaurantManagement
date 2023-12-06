namespace Restaurant_Management_App
{
    partial class frmPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrint));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClose = new Guna.UI.WinForms.GunaButton();
            this.btMin = new Guna.UI.WinForms.GunaButton();
            this.btMax = new Guna.UI.WinForms.GunaButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btMin);
            this.panel1.Controls.Add(this.btMax);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 78);
            this.panel1.TabIndex = 0;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.AnimationHoverSpeed = 0.07F;
            this.btClose.AnimationSpeed = 0.03F;
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btClose.BorderColor = System.Drawing.Color.Black;
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btClose.FocusedColor = System.Drawing.Color.Empty;
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Image = global::Restaurant_Management_App.Properties.Resources.close1;
            this.btClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btClose.Location = new System.Drawing.Point(942, 12);
            this.btClose.Name = "btClose";
            this.btClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.btClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btClose.OnHoverImage = null;
            this.btClose.OnPressedColor = System.Drawing.Color.Black;
            this.btClose.Radius = 20;
            this.btClose.Size = new System.Drawing.Size(61, 59);
            this.btClose.TabIndex = 10;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMin
            // 
            this.btMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMin.AnimationHoverSpeed = 0.07F;
            this.btMin.AnimationSpeed = 0.03F;
            this.btMin.BackColor = System.Drawing.Color.Transparent;
            this.btMin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btMin.BorderColor = System.Drawing.Color.Black;
            this.btMin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btMin.FocusedColor = System.Drawing.Color.Empty;
            this.btMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btMin.ForeColor = System.Drawing.Color.White;
            this.btMin.Image = ((System.Drawing.Image)(resources.GetObject("btMin.Image")));
            this.btMin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btMin.ImageSize = new System.Drawing.Size(20, 20);
            this.btMin.Location = new System.Drawing.Point(786, 12);
            this.btMin.Name = "btMin";
            this.btMin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.btMin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btMin.OnHoverForeColor = System.Drawing.Color.White;
            this.btMin.OnHoverImage = null;
            this.btMin.OnPressedColor = System.Drawing.Color.Black;
            this.btMin.Radius = 20;
            this.btMin.Size = new System.Drawing.Size(61, 59);
            this.btMin.TabIndex = 9;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // btMax
            // 
            this.btMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMax.AnimationHoverSpeed = 0.07F;
            this.btMax.AnimationSpeed = 0.03F;
            this.btMax.BackColor = System.Drawing.Color.Transparent;
            this.btMax.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btMax.BorderColor = System.Drawing.Color.Black;
            this.btMax.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btMax.FocusedColor = System.Drawing.Color.Empty;
            this.btMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btMax.ForeColor = System.Drawing.Color.White;
            this.btMax.Image = ((System.Drawing.Image)(resources.GetObject("btMax.Image")));
            this.btMax.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btMax.ImageSize = new System.Drawing.Size(20, 20);
            this.btMax.Location = new System.Drawing.Point(863, 12);
            this.btMax.Name = "btMax";
            this.btMax.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.btMax.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btMax.OnHoverForeColor = System.Drawing.Color.White;
            this.btMax.OnHoverImage = null;
            this.btMax.OnPressedColor = System.Drawing.Color.Black;
            this.btMax.Radius = 20;
            this.btMax.Size = new System.Drawing.Size(61, 59);
            this.btMax.TabIndex = 8;
            this.btMax.Click += new System.EventHandler(this.btMax_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 78);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1015, 517);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // frmPrint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1015, 595);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrint";
            this.Text = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btClose;
        private Guna.UI.WinForms.GunaButton btMin;
        private Guna.UI.WinForms.GunaButton btMax;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}