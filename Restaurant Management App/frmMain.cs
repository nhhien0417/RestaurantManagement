using Restaurant_Management_App.Model;
using Restaurant_Management_App.Reports;
using Restaurant_Management_App.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Restaurant_Management_App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        static frmMain obj;
        public static frmMain Instance { get { if(obj == null) {  obj = new frmMain(); } return obj; } }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lbUser.Text = MainClass_.USER;
            obj = this;
            gunaButton1.PerformClick();
        }
        public void AddControls(Form f)
        {
            pnMid.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            pnMid.Controls.Add(f);
            f.Show();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) { this.WindowState = FormWindowState.Normal; }
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btCategories_Click(object sender, EventArgs e)
        {
            AddControls(new CategoryView());
        }

        private void btTables_Click(object sender, EventArgs e)
        {
            AddControls(new TableView());
        }

        private void btStaff_Click(object sender, EventArgs e)
        {
            AddControls(new StaffView());
        }

        private void btProducts_Click(object sender, EventArgs e)
        {
            AddControls(new ProductView());
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            gunaButton7.OnHoverBaseColor = gunaButton7.BaseColor;
            frmOrder frm = new frmOrder();
            frm.ShowDialog();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            AddControls(new KitchenView());
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            gunaButton9.OnHoverBaseColor = gunaButton9.BaseColor;
            frmRP frm = new frmRP();
            frm.ShowDialog();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            gunaButton2.OnHoverBaseColor = gunaButton2.BaseColor;
            Setting frmSetting = new Setting();
            frmSetting.ShowDialog();
        }

        private void gunaButton7_MouseHover(object sender, EventArgs e)
        {
            gunaButton7.OnHoverBaseColor = Color.FromArgb(115, 144, 114);
        }

        private void gunaButton9_MouseHover(object sender, EventArgs e)
        {
            gunaButton9.OnHoverBaseColor = Color.FromArgb(115, 144, 114);
        }

        private void gunaButton2_MouseHover(object sender, EventArgs e)
        {
            gunaButton2.OnHoverBaseColor = Color.FromArgb(115, 144, 114);
        }
    }
}
