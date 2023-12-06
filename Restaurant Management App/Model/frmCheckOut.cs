using System;
using System.Collections;
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
    public partial class frmCheckOut : SampleAdd
    {
        public bool check = false;
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            check = false;
            this.Close();
        }
        public double total;
        public int mainID=0;
        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            double total = 0;
            double receipt = 0;
            double change = 0;
            double.TryParse(tbTotal.Text, out total);
            double.TryParse(tbreceived.Text, out receipt);
            if (receipt < total)
            {
                total = 0;
                tbChange.Text = "0";
            }
            else
            {
                change = receipt - total;
            }
            if (change > 0) { tbChange.Text = change.ToString(); }
        }
        public override void btSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToSingle(tbreceived.Text) < Convert.ToSingle(tbTotal.Text))
            {
                tbChange.Text = "0";
                MessageBox.Show("Số tiền không hợp lệ");

            }
            else
            {
                string qry = @" Update Orders set total=@total, received =@received, change =@change,orderStatus =N'Đã thanh toán' where mainID= @id";
                Hashtable ht = new Hashtable();
                ht.Add("id", mainID);
                ht.Add("@total", tbTotal.Text);
                ht.Add("@received", tbreceived.Text);
                ht.Add("@change", tbChange.Text);
                if (MainClass_.SQL(qry, ht) > 0)
                {
                    check = true;
                    MessageBox.Show("Đã thanh toán thành công");
                    this.Close();
                }
            }
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            tbTotal.Text=total.ToString();
        }
    }
}
