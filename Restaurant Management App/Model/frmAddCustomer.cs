using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_App.Model
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string orderType = "";
        public int mainID = 0;
        public int driverID = 0;
        public string cusName = "";
        public string cusPhone = "";
        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            if(orderType=="Mang đi")
            {
                tbDriver.Visible = false;
                lbdriver.Visible = false;
            }
            string qry = "Select staffID id ,staffName Name from Staff where staffRole like N'Giao hàng'";
            MainClass_.CBFill(qry, tbDriver);
            if (mainID > 0)
            {
                tbDriver.SelectedValue = driverID;
            }
        }

        private void tbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            driverID=Convert.ToInt32(tbDriver.SelectedValue);
        }
    }
}
