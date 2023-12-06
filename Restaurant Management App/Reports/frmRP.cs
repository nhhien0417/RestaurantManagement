using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_App.Reports
{
    public partial class frmRP : Form
    {
        public frmRP()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string qry = @"Select * from Orders o join Details d on o.mainID=d.mainID
                           join Product p on p.productID=d.productID join Category c on c.CatID=p.catID
                            where orderStatus=N'Đã thanh toán' and orderDate between @sDate and @eDate";
            SqlCommand cmd = new SqlCommand(qry, MainClass_.conn);
            cmd.Parameters.AddWithValue("@sDate", Convert.ToDateTime(sDate.Value).Date);
            cmd.Parameters.AddWithValue("@eDate", Convert.ToDateTime(eDate.Value).Date);
            MainClass_.conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass_.conn.Close();
            frmPrint frm = new frmPrint();
            report cr = new report();
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
