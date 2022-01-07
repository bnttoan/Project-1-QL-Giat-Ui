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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = Ketnoi.GetConnect();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string xacNhan = " select * from TAIKHOAN where TENTK = '" + txtTK.Text +
                        "'and MK = '" + txtMKC.Text + "'";
                SqlCommand cmd = new SqlCommand(xacNhan, conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                errorProvider1.Clear();
                if (txtTK.Text == "")
                    errorProvider1.SetError(txtTK, "Chưa nhập tên tài khoản ");
                else if (txtMKC.Text == "")
                {
                    errorProvider1.SetError(txtMKC, "!");
                    txtMKC.Focus();
                }
                else if (txtMKM.Text == "")
                {
                    errorProvider1.SetError(txtMKM, "!");
                    txtMKM.Focus();
                }
                else if (txtNLMK.Text == "")
                {
                    errorProvider1.SetError(txtNLMK, "!");
                    txtNLMK.Focus();
                }
                else if (txtNLMK.Text != txtMKM.Text)
                    MessageBox.Show(" Mật khẩu không khớp ", " Thông báo ", MessageBoxButtons.OK);
                else if (dr.Read())
                {
                    cmd.Dispose();
                    dr.Dispose();
                    string capnhat = "update TAIKHOAN set MK='" + txtMKM.Text + "' where TENTK='" + txtTK.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(capnhat, conn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show(" Đổi mật khẩu thành công ", "Thông báo");
                    cmd2.Dispose();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản không tồn tại hoặc mật khẩu sai");
                    txtTK.Focus();
                }
                cmd.Dispose();
                dr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
                this.Close();

        }

        private void ckbMKC_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMKC.Checked)
                txtMKC.PasswordChar = (char)0;
            else
                txtMKC.PasswordChar = '*';
        }

        private void ckbMKM_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMKM.Checked)
                txtMKM.PasswordChar = (char)0;
            else
                txtMKM.PasswordChar = '*';
        }

        private void ckbMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMK.Checked)
                txtNLMK.PasswordChar = (char)0;
            else
                txtNLMK.PasswordChar = '*';
        }

    }
}
