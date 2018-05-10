using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Diagnostics;

namespace QLHOCSINHC3
{
    public partial class frmDangNhap : Form
    {
        //Khai báo đối tượng Commonconnect
        private CommonConnect cc = new CommonConnect();
        //Khai báo đối tượng SqlConnection
        private SqlConnection conn = null;
        //public static bool kt1, kt2;
        public frmDangNhap()
        { 
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        { 
            // Mở kết nối
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open)
                cboName.Items.Add(SystemInformation.UserDomainName.ToString() + "\\SQLServer");
            cboName.Text = cboName.Items[0].ToString();
            string select = "select*from sys.servers";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string select = "Select * From TAIKHOAN where TENTK='" + txtTaiKhoan.Text + "' AND MATKHAU='" + txtMatKhau.Text + "' AND QUYEN='BGH'";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");
                frmMain frm = new frmMain();
                frm.Show();
                //frm.mnuDN.Enabled = false;
                this.Hide();

                cmd.Dispose();
                reader.Close();
                reader.Dispose();
            }
            else
            {
                cmd.Dispose();
                reader.Close();
                reader.Dispose();
                string select1 = "Select * From TAIKHOAN where TENTK='" + txtTaiKhoan.Text + "' AND MATKHAU='" + txtMatKhau.Text + "' AND QUYEN='HS'";
                SqlCommand cmd1 = new SqlCommand(select1, conn);
                SqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();

                if (reader1.Read())
                {
                    MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");

                    frmHS frmhs = new frmHS();
                    frmhs.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                cmd1.Dispose();
                reader1.Close();
                reader1.Dispose();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
