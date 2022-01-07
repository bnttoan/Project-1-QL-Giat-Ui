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
    public partial class frmDangNhap : Form
    {
        public static string VaiTro;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        string chuoidung = "1234567890_QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopas dfghjklzxcvbnm";//Các kí tự đang nhập

        private bool kiemtrakitu(string chuoiCanKiemTra)
        {
            foreach (char kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (char kitu2 in chuoidung)
                {
                    if (kiTu == kitu2) dung = true;
                }
                if (dung == false) return false;
            }


            return true;

        }

    private void btnDN_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTK.Text.Trim();
            string matkhau = txtMK.Text.Trim();
            
            if (kiemtrakitu(taikhoan) == false)
            {
                MessageBox.Show("Bạn không được sử dụng ký tự đặc biệt!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((taikhoan == "") && (matkhau == ""))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu!!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Focus();
            }
            else
            {
                if (taikhoan.Length == 5)
                {
                    try
                    {
                        SqlConnection connect = Ketnoi.GetConnect();
                        if (connect.State == ConnectionState.Closed)
                            connect.Open();
                        string strCmd = "select * from TAIKHOAN where TENTK = '" + txtTK.Text +
                            "'and MK = '" + txtMK.Text + "'";
                        SqlCommand cmd = new SqlCommand(strCmd, connect);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VaiTro = ds.Tables[0].Rows[0]["VAITRO"].ToString();
                            frmMain frM = new frmMain(taikhoan, VaiTro);
                            frM.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thất bại!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi" + ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Bạn nhập dư hoặc thiếu ký tự!!","Thông báo");
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
                Application.Exit();          
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ckbHMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHMK.Checked)
                txtMK.PasswordChar = (char)0;
            else
                txtMK.PasswordChar = '*';
        }
    }
}
