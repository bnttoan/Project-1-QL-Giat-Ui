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

namespace HeThongGiatUi
{
    public partial class frmPLKH : Form
    {
        public frmPLKH()
        {
            InitializeComponent();
            LoadPLKH();
        }

        private void LoadPLKH()
        {
            SqlConnection conn = Ketnoi.GetConnect();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select* from PHANLOAIKH", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sda.Dispose();
            if (dt.Rows.Count > 0)
                dgvPLKH.DataSource = dt;
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            frmKhachHang fkh = new frmKhachHang();
            fkh.Show();
            this.Hide();
        }
    }
}
