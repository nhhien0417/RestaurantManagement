﻿using Guna.UI.WinForms;
using Restaurant_Management_App.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace Restaurant_Management_App.Model
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
           
        }
        public int mainID = 0;
        public string orderType;
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            gunaDataGridView1.BorderStyle = BorderStyle.FixedSingle;
            pnCategory.Controls.Add(btAllCategory);
            addCategory();
            pnProd.Controls.Clear();
            loadProd();
            gunaButton1.Visible = false;
        }
        private void addCategory()
        {
            string qry = "Select * from Category";
            SqlCommand cmd = new SqlCommand(qry, MainClass_.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Guna.UI.WinForms.GunaAdvenceButton b = new Guna.UI.WinForms.GunaAdvenceButton();
                    b.BaseColor = Color.FromArgb(119, 107, 93);
                    b.OnHoverBaseColor = Color.FromArgb(199, 220, 167);
                    b.CheckedBaseColor = Color.FromArgb(115, 144, 114);
                    b.Image = null;
                    b.Radius = 20;
                    b.CheckedImage = Resources._checked;
                    b.Size = new Size(170, 54);
                    b.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
                    b.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    b.Text = dr["CatName"].ToString();
                    b.MouseClick += new MouseEventHandler(catClick);
                    pnCategory.Controls.Add(b);
                }
            }
        }
        private void catClick(object sender, MouseEventArgs e)
        {
            Guna.UI.WinForms.GunaAdvenceButton b = (Guna.UI.WinForms.GunaAdvenceButton)sender;
            foreach (var item in pnProd.Controls)
            {
                var pro = (Product)item;
                pro.Visible = pro.Pcategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }
        private void addItems(string pid, string proID, string pname, string pcat, string pprice, Image pimage)
        {
            var w = new Product()
            {
                Pid = Convert.ToInt32(proID),
                Prodname = pname,
                Pcategory = pcat,
                Pprice = pprice,
                Pimage = pimage
            };
            pnProd.Controls.Add(w);
            w.onSelect += (ss, ee) =>
            {
                var wdg = (Product)ss;
                foreach (DataGridViewRow item in gunaDataGridView1.Rows)
                {
                    //check if already there then +1 to qty
                    if (Convert.ToInt32(item.Cells["dgvproid"].Value) == wdg.Pid)
                    {
                        item.Cells["dgvsl"].Value = int.Parse(item.Cells["dgvsl"].Value.ToString()) + 1;
                        item.Cells["dgvtong"].Value = float.Parse(item.Cells["dgvsl"].Value.ToString()) * float.Parse(item.Cells["dgvprice"].Value.ToString());
                        getTotal();
                        return;
                    }
                }
                //add new
                gunaDataGridView1.Rows.Add(new object[] {0, 0, wdg.Pid, wdg.Prodname, 1, wdg.Pprice, wdg.Pprice });
                getTotal();
            };
        }
        private void loadProd()
        {
            string qry = "Select * from product p join category c on p.catID=c.CatID";
            SqlCommand cmd = new SqlCommand(qry, MainClass_.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                Byte[] imarray = (byte[])item["productImage"];
                byte[] imagebytearray = imarray;
                addItems("0",item["productID"].ToString(), item["productName"].ToString(), item["CatName"].ToString(), item["productPrice"].ToString(), Image.FromStream(new MemoryStream(imagebytearray)));
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "🔎 Search here")
            {
                string temp = "";
                foreach (GunaAdvenceButton bt in pnCategory.Controls)
                {
                    if (bt.Checked == true) { temp = bt.Text; break; }
                }
                foreach (var item in pnProd.Controls)
                {
                    var pro = (Product)item;
                    pro.Visible = pro.Prodname.ToLower().Contains(tbSearch.Text.Trim().ToLower()) &&(btAllCategory.Checked=true ? true: pro.Pcategory == temp);
                }
            }
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "🔎 Search here")
                tbSearch.Text = string.Empty;
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == string.Empty)
                tbSearch.Text = "🔎 Search here";
        }

        private void gunaDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }
        private void getTotal()
        {
            float total = 0;
            txtSum.Text = "0";
            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                total += float.Parse(row.Cells["dgvtong"].Value.ToString());
            }
            txtSum.Text = total.ToString("N0") ;
        }

        private void gunaDataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            getTotal();
        }

        private void gunaDataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 4)
            {
                e.Cancel = true;
            }
        }

        private void gunaDataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.Rows.Count > 0)
            {
                DataGridViewRow item = gunaDataGridView1.CurrentCell.OwningRow;
                item.Cells["dgvtong"].Value = float.Parse(item.Cells["dgvsl"].Value.ToString()) * float.Parse(item.Cells["dgvprice"].Value.ToString());
                getTotal();
            }
        }

        private void frmOrder_MouseClick(object sender, MouseEventArgs e)
        {
            pnCategory.Focus();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            pnProd.Enabled = true;
            btDelivery.Checked = false;
            btTakeAway.Checked = false;
            btDinIn.Checked = false;
            lbtable.Text = string.Empty;
            lbwaiter.Text = string.Empty;
            lbtable.Visible = false;
            lbwaiter.Visible = false;
            gunaDataGridView1.Rows.Clear();
            mainID = 0;
            
        }
        public int driverID = 0;
        public string cusName = "";
        public string cusPhone = "";
        private void btDelivery_Click(object sender, EventArgs e)
        {
            cusName = string.Empty;
            cusPhone = string.Empty;
            driverID = 0;

            lbdrivername.Text = string.Empty;
            lbcusname.Text = string.Empty;
            lbcusphone.Text = string.Empty;
            lbtable.Text = string.Empty;
            lbwaiter.Text = string.Empty;

            lbcusname.Visible = true;
            lbcusphone.Visible = true;
            lbtable.Visible = false;
            lbwaiter.Visible = false;
            lbdrivername.Visible = true;

            orderType = "Giao hàng tận nơi";
            frmAddCustomer frm = new frmAddCustomer();
            frm.mainID = mainID;
            frm.orderType = orderType;
            MainClass_.blurBG(frm);
            if (frm.driverID > 0)
            {
                driverID = frm.driverID;
                cusName = frm.tbName.Text;
                cusPhone = frm.tbPhone.Text;
                lbcusname.Text = "Tên khách hàng: " + frm.tbName.Text;
                lbcusphone.Text = "Số điện thoại: " + frm.tbPhone.Text;
                lbdrivername.Text = "Nhân viên giao hàng: " + frm.tbDriver.Text;
            }
            
        }
        
        private void btTakeAway_Click(object sender, EventArgs e)
        {
            cusName = string.Empty;
            cusPhone = string.Empty;
            driverID = 0;

            lbdrivername.Text = string.Empty;
            lbcusname.Text = string.Empty;
            lbcusphone.Text = string.Empty;
            lbtable.Text = string.Empty;
            lbwaiter.Text = string.Empty;

            lbcusname.Visible = true;
            lbcusphone.Visible = true;
            lbtable.Visible = false;
            lbwaiter.Visible = false;
            lbdrivername.Visible = false;
            orderType = "Mang đi";

            frmAddCustomer frm = new frmAddCustomer();
            frm.mainID = mainID;
            frm.orderType = orderType;
            MainClass_.blurBG(frm);
            if (frm.tbName.Text != "")
            {
                driverID = frm.driverID;
                cusName = frm.tbName.Text;
                cusPhone = frm.tbPhone.Text;

                lbcusname.Text = "Tên khách hàng: " + frm.tbName.Text;
                lbcusphone.Text = "Số điện thoại: " + frm.tbPhone.Text;
                lbdrivername.Text = "Nhân viên giao hàng: " + frm.tbDriver.Text;
            }

            
        }

        private void btDineIn_Click(object sender, EventArgs e)
        {
            cusName=string.Empty;
            cusPhone=string.Empty;
            driverID = 0;

            lbdrivername.Text = string.Empty;
            lbcusname.Text = string.Empty;
            lbcusphone.Text = string.Empty;
            lbtable.Text = string.Empty;
            lbwaiter.Text = string.Empty;

            lbtable.Visible = true;
            lbwaiter.Visible = true;
            lbdrivername.Visible = false;
            lbcusname.Visible = false;
            lbcusphone.Visible = false;


            orderType = "Ăn tại bàn";


            frmTableSelect frm = new frmTableSelect();
            MainClass_.blurBG(frm);
            if (!string.IsNullOrEmpty(frm.tableName))
            {
                lbtable.Text = frm.tableName;
                frmWaiterSelect form = new frmWaiterSelect();
                MainClass_.blurBG(form);
                if (!string.IsNullOrEmpty(form.waiterName))
                {
                    lbwaiter.Text = form.waiterName;
                }
                else
                {
                    lbwaiter.Text = string.Empty;
                    btDinIn.Checked = false;
                }
            }
            else
            {
                lbtable.Text = string.Empty;
                btDinIn.Checked = false;
            }
            if (lbwaiter.Text == string.Empty || lbtable.Text == string.Empty)
            {
                lbwaiter.Text = string.Empty;
                lbtable.Text = string.Empty;
            }
            
        }
     
        private void btKOT_Click(object sender, EventArgs e)
        {
            pnProd.Enabled = true;
            if (gunaDataGridView1.Rows.Count == 0 || (btDelivery.Checked == false && btDinIn.Checked == false && btTakeAway.Checked == false) || ((btDelivery.Checked == true && (lbcusname.Text == string.Empty || lbcusphone.Text == string.Empty || lbdrivername.Text == string.Empty)) || (btTakeAway.Checked == true && (lbcusname.Text == string.Empty || lbcusphone.Text == string.Empty))))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                btKOT.OnHoverBaseColor = btKOT.BaseColor;
            }
            else
            {
                string qry1, qry2;
                int detailID = 0;
                if (mainID == 0)
                {
                    qry1 = @"Insert into Orders values(@orderDate,@orderTime,@tableName,@waiterName,@orderStatus,@orderType,@total,@received,@change,@driverID,@cusName,@cusPhone);
                            Select SCOPE_IDENTITY()";
                }
                else
                {
                    qry1 = @"Update Orders set orderStatus =@orderStatus, total =@total, received =@received,change =@change,orderType =@orderType,tableName=@tableName,waiterName=@waiterName,driverID=@driverID,cusName=@cusName,cusPhone=@cusPhone where mainID =@ID";
                }
                Hashtable ht = new Hashtable();
                SqlCommand cmd = new SqlCommand(qry1, MainClass_.conn);
                cmd.Parameters.AddWithValue("@ID", mainID);
                cmd.Parameters.AddWithValue("@orderDate", Convert.ToDateTime(DateTime.Now.Date));
                cmd.Parameters.AddWithValue("@orderTime", DateTime.Now.ToShortTimeString());
                cmd.Parameters.AddWithValue("@tableName", lbtable.Text);
                cmd.Parameters.AddWithValue("@waiterName", lbwaiter.Text);
                cmd.Parameters.AddWithValue("@orderStatus", "Chưa hoàn thành");
                cmd.Parameters.AddWithValue("@orderType", orderType);
                cmd.Parameters.AddWithValue("@total", Convert.ToDouble(txtSum.Text));
                cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
                cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
                cmd.Parameters.AddWithValue("@driverID", driverID);
                cmd.Parameters.AddWithValue("@cusName", cusName);
                cmd.Parameters.AddWithValue("@cusPhone", cusPhone);
                if (MainClass_.conn.State == ConnectionState.Closed)
                {
                    MainClass_.conn.Open();
                }
                if (mainID == 0)
                {
                    mainID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                else
                {
                    cmd.ExecuteNonQuery();
                }
                if (MainClass_.conn.State == ConnectionState.Open)
                {
                    MainClass_.conn.Close();
                }
                foreach (DataGridViewRow row in gunaDataGridView1.Rows)
                {
                    detailID = Convert.ToInt32(row.Cells["dgvid"].Value);
                    if (detailID == 0)
                    {
                        qry2 = @"Insert into Details values(@mainID,@productID,@qty,@price,@total)";
                    }
                    else
                    {
                        qry2 = @"Update Details set productID=@productID,qty=@qty,price=@price,summary=@total where detailID =@ID";
                    }
                    SqlCommand cmd2 = new SqlCommand(qry2, MainClass_.conn);
                    cmd2.Parameters.AddWithValue("@ID", detailID);
                    cmd2.Parameters.AddWithValue("@mainID", mainID);
                    cmd2.Parameters.AddWithValue("@productID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                    cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvsl"].Value));
                    cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvprice"].Value));
                    cmd2.Parameters.AddWithValue("@total", Convert.ToDouble(row.Cells["dgvtong"].Value));
                    if (MainClass_.conn.State == ConnectionState.Closed)
                    {
                        MainClass_.conn.Open();
                    }
                    cmd2.ExecuteNonQuery();
                    if (MainClass_.conn.State == ConnectionState.Open)
                    {
                        MainClass_.conn.Close();
                    }
                }
                MessageBox.Show("Đã lưu thành công!");
                btKOT.OnHoverBaseColor = btKOT.BaseColor;
                mainID = 0;
                detailID = 0;
                gunaDataGridView1.Rows.Clear();
                btDelivery.Checked = false;
                btTakeAway.Checked = false;
                btDinIn.Checked = false;
                
                lbtable.Visible = false;
                lbwaiter.Visible = false;
                lbcusname.Visible = false;
                lbcusphone.Visible = false;
                lbdrivername.Visible = false;

                lbcusname.Text = string.Empty;
                lbcusphone.Text = string.Empty;
                lbdrivername.Text = string.Empty;
                lbtable.Text = string.Empty;
                lbwaiter.Text = string.Empty;
            }
            
        }

        private void gunaAdvenceButton1_MouseClick(object sender, MouseEventArgs e)
        {
            Guna.UI.WinForms.GunaAdvenceButton b = (Guna.UI.WinForms.GunaAdvenceButton)sender;
            foreach (var item in pnProd.Controls)
            {
                var pro = (Product)item;
                pro.Visible = true;
            }
        }
        public int id = 0;
        public string billType = "", billStatus = "";
        private void btBill_Click(object sender, EventArgs e)
        {
            btBill.OnHoverBaseColor = btBill.BaseColor;
            frmBillList frm = new frmBillList();
            MainClass_.blurBG(frm);
            if(frm.mainID > 0)
            {
                id=frm.mainID;
                mainID = frm.mainID;
                billStatus = frm.billStatus;
                billType = frm.billType;
                if (billType == "Giao hàng tận nơi")
                {
                    btDelivery.Checked = true;
                    orderType = "Giao hàng tận nơi";
                }
                else if (billType == "Mang đi")
                {
                    btTakeAway.Checked = true;
                    orderType = "Mang đi";
                }
                else if (billType == "Ăn tại bàn")
                {
                    btDinIn.Checked = true;
                    orderType = "Ăn tại bàn";
                }
                if (billStatus == "Đã hoàn thành")
                {
                    gunaButton1.Visible = true;
                    pnProd.Enabled = false;
                }
                else if (billStatus == "Chưa hoàn thành")
                {
                    gunaButton1.Visible = false;
                    pnProd.Enabled = false;
                }
                else if (billStatus == "Đang chờ")
                {
                    lbcusname.Text = frm.cusName;
                    lbcusphone.Text = frm.cusPhone;
                    lbdrivername.Text = frm.driverName;
                    lbcusname.Visible = false;
                    lbcusphone.Visible = false;
                    lbdrivername.Visible = false;
                    gunaButton1.Visible = false;
                    pnProd.Enabled = true;
                }
                loadEntries();
              
            }
        }
        private void loadEntries()
        {
            string qry = @"Select * from Orders o join Details d on o.mainID=d.mainID join Product p on p.productID=d.productID where o.mainID =" + id + "";
            SqlCommand cmd2 = new SqlCommand(qry, MainClass_.conn);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            gunaDataGridView1.Rows.Clear();
            foreach (DataRow dataRow in dt2.Rows)
            {
                string detailID = dataRow["detailID"].ToString();
                string proName = dataRow["productName"].ToString();
                string productID = dataRow["productID"].ToString();
                string qty = dataRow["qty"].ToString();
                string price = dataRow["price"].ToString();
                string summary = dataRow["summary"].ToString();
                object[] obj = { 0, detailID, productID,proName, qty, price, summary };
                gunaDataGridView1.Rows.Add(obj);
            }
            getTotal();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frmCheckOut frm = new frmCheckOut();
            frm.mainID = id;
            frm.total=Convert.ToDouble(txtSum.Text);
            MainClass_.blurBG(frm);
            if (frm.check == true) { 
                mainID = 0;
                gunaDataGridView1.Rows.Clear();
                lbwaiter.Text=string.Empty; lbtable.Text=string.Empty;
                lbwaiter.Visible=false;
                lbtable.Visible=false;
                gunaButton1.Visible=false;
                txtSum.Text = "0";
                btDelivery.Checked = false;
                btTakeAway.Checked = false;
                btDinIn.Checked = false;

            }
        }

        private void btHold_MouseHover(object sender, EventArgs e)
        {
            btHold.OnHoverBaseColor = Color.FromArgb(115, 144, 114);
        }

        private void btBill_MouseHover(object sender, EventArgs e)
        {
            btBill.OnHoverBaseColor = Color.FromArgb(115, 144, 114);
        }

        private void btKOT_MouseHover(object sender, EventArgs e)
        {
            btKOT.OnHoverBaseColor = Color.FromArgb(115, 144, 114);
        }

        private void btHold_Click(object sender, EventArgs e)
        {
            pnProd.Enabled = true;

            if (gunaDataGridView1.Rows.Count == 0 || (btDelivery.Checked == false && btDinIn.Checked == false && btTakeAway.Checked == false) || ((btDelivery.Checked == true && (lbcusname.Text == string.Empty || lbcusphone.Text == string.Empty || lbdrivername.Text == string.Empty)) || (btTakeAway.Checked == true && (lbcusname.Text == string.Empty || lbcusphone.Text == string.Empty))))
            {
               MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                btHold.OnHoverBaseColor = btHold.BaseColor;
            }
            else
            {
                string qry1, qry2;
                int detailID = 0;
                if (mainID == 0)
                {
                    qry1 = @"Insert into Orders values(@orderDate,@orderTime,@tableName,@waiterName,@orderStatus,@orderType,@total,@received,@change,@driverID,@cusName,@cusPhone);
                            Select SCOPE_IDENTITY()";
                }
                else
                {
                    qry1 = @"Update Orders set orderStatus =@orderStatus, total =@total, received =@received,change =@change,orderType =@orderType,tableName=@tableName,waiterName=@waiterName,driverID=@driverID,cusName=@cusName,cusPhone=@cusPhone where mainID =@ID";
                }
                Hashtable ht = new Hashtable();
                SqlCommand cmd = new SqlCommand(qry1, MainClass_.conn);
                cmd.Parameters.AddWithValue("@ID", mainID);
                cmd.Parameters.AddWithValue("@orderDate", Convert.ToDateTime(DateTime.Now.Date));
                cmd.Parameters.AddWithValue("@orderTime", DateTime.Now.ToShortTimeString());
                cmd.Parameters.AddWithValue("@tableName", lbtable.Text);
                cmd.Parameters.AddWithValue("@waiterName", lbwaiter.Text);
                cmd.Parameters.AddWithValue("@orderStatus", "Đang chờ");
                cmd.Parameters.AddWithValue("@orderType", orderType);
                cmd.Parameters.AddWithValue("@total", Convert.ToDouble(txtSum.Text));
                cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
                cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
                cmd.Parameters.AddWithValue("@driverID", driverID);
                cmd.Parameters.AddWithValue("@cusName", cusName);
                cmd.Parameters.AddWithValue("@cusPhone", cusPhone);
                if (MainClass_.conn.State == ConnectionState.Closed)
                {
                    MainClass_.conn.Open();
                }
                if (mainID == 0)
                {
                    mainID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                else
                {
                    cmd.ExecuteNonQuery();
                }
                if (MainClass_.conn.State == ConnectionState.Open)
                {
                    MainClass_.conn.Close();
                }
                foreach (DataGridViewRow row in gunaDataGridView1.Rows)
                {
                    detailID = Convert.ToInt32(row.Cells["dgvid"].Value);
                    if (detailID == 0)
                    {
                        qry2 = @"Insert into Details values(@mainID,@productID,@qty,@price,@total)";
                    }
                    else
                    {
                        qry2 = @"Update Details set productID=@productID,qty=@qty,price=@price,summary=@total where detailID =@ID";
                    }
                    SqlCommand cmd2 = new SqlCommand(qry2, MainClass_.conn);
                    cmd2.Parameters.AddWithValue("@ID", detailID);
                    cmd2.Parameters.AddWithValue("@mainID", mainID);
                    cmd2.Parameters.AddWithValue("@productID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                    cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvsl"].Value));
                    cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvprice"].Value));
                    cmd2.Parameters.AddWithValue("@total", Convert.ToDouble(row.Cells["dgvtong"].Value));
                    if (MainClass_.conn.State == ConnectionState.Closed)
                    {
                        MainClass_.conn.Open();
                    }
                    cmd2.ExecuteNonQuery();
                    if (MainClass_.conn.State == ConnectionState.Open)
                    {
                        MainClass_.conn.Close();
                    }
                }

                mainID = 0;
                detailID = 0;
                gunaDataGridView1.Rows.Clear();
                btDelivery.Checked = false;
                btTakeAway.Checked = false;
                btDinIn.Checked = false;

                lbtable.Visible = false;
                lbwaiter.Visible = false;
                lbcusname.Visible = false;
                lbcusphone.Visible = false;
                lbdrivername.Visible = false;

                lbcusname.Text = string.Empty;
                lbcusphone.Text = string.Empty;
                lbdrivername.Text = string.Empty;
                lbtable.Text = string.Empty;
                lbwaiter.Text = string.Empty;
                MessageBox.Show("Đã lưu thành công!");
                btHold.OnHoverBaseColor = btHold.BaseColor;
            }
        }
    }
}
