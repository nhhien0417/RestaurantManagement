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

namespace Restaurant_Management_App.Model
{
    public partial class frmChangePW : SampleAdd
    {
        public frmChangePW()
        {
            InitializeComponent();
        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbOldpw.Text)||string.IsNullOrEmpty(tbNewpw.Text)||string.IsNullOrEmpty(tbConfirm.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if(tbConfirm.Text!=tbNewpw.Text)
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp");
                }
                else if(tbOldpw.Text!=MainClass_.password)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng");
                }
                else
                {
                    MainClass_.conn.Open();
                    string qry = @"Update Users set upass ='" + tbNewpw.Text + "' where username ='" + MainClass_.username + "'";
                    SqlCommand cmd = new SqlCommand(qry, MainClass_.conn);
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        DialogResult res = MessageBox.Show("Đổi mật khẩu thành công", "",MessageBoxButtons.OK);
                        if (res == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại, vui lòng thử lại sau");
                    }
                    MainClass_.conn.Close();
                }
            }
            
        }
    }
}
