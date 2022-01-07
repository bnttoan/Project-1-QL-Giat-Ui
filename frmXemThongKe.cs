using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HeThongGiatUi
{
    public partial class frmXemThongKe : Form
    {
        public frmXemThongKe()
        {
            InitializeComponent();
        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = Ketnoi.GetConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "dbo.BCDH";
                cmd.CommandType = CommandType.StoredProcedure;
                int num = Convert.ToInt32(txtTongtien.Text.ToString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message.ToString());
            }
        }
    }
}
