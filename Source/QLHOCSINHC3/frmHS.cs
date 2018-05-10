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
    public partial class frmHS : Form
    {
        //Khai báo đối tượng Commonconnect
        private CommonConnect cc = new CommonConnect();
        //Khai báo đối tượng SqlConnection
        private SqlConnection conn = null;
        private string query;
        public frmHS()
        {
            InitializeComponent();
        }

        private void frmHS_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataSet GetAll(string query)
        {
            DataSet data = new DataSet();
            // Mở kết nối
            conn = cc.Connected();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(data);
            return data;
        }

        private void btnTTLop_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM LOP";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAll(query).Tables[0];

        }

        private void btnTTHs_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM HOCSINH";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAll(query).Tables[0];
        }

        private void btnTTDiem_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM DIEM";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAll(query).Tables[0];
        }
    }
}
