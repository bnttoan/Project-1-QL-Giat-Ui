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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        public void LoadTK()
        {
            try
            {
                SqlConnection conn = Ketnoi.GetConnect();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("select * from TAIKHOAN", conn) ;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Dispose();
                if (dt.Rows.Count > 0)
                    dgvTK.DataSource = dt;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message.ToString());
            }
        }
        string chuoidung = "1234567890_QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopas dfghjklzxcvbnm";
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTK.Text.Trim();
            if (taikhoan.Length == 5)
            {
                try
                {

                    if (kiemtrakitu(taikhoan) == false)
                    {
                        MessageBox.Show("Bạn không được sử dụng ký tự đặc biệt!!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtTK.Text.Trim() != "" && txtMK.Text.Trim() != "")
                    {
                        SqlConnection conn = Ketnoi.GetConnect();
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        string ktMaNV = "Select * From TAIKHOAN where TENTK='" + txtTK.Text + "'";
                        SqlCommand cmd = new SqlCommand(ktMaNV, conn);
                        SqlDataReader sdr;
                        sdr = cmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            MessageBox.Show("Bạn đã nhập trùng tên tài khoản", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTK.Focus();
                            cmd.Dispose();
                            sdr.Dispose();
                        }
                        else
                        {
                            cmd.Dispose();
                            sdr.Dispose();
                            string strCommand = "insert into TAIKHOAN values(@tentk, @mk, @vaitro)";
                            SqlCommand cmd1 = new SqlCommand(strCommand, conn);
                            cmd1.Parameters.AddWithValue("@tentk", txtTK.Text.Trim());
                            cmd1.Parameters.AddWithValue("@mk", txtMK.Text.Trim());
                            cmd1.Parameters.AddWithValue("@vaitro", rdbAd.Checked);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Thêm tài khoản thành công!!");
                            reset();
                            LoadTK();
                            cmd1.Dispose();
                        }
                    }
                    else
                        MessageBox.Show("Thêm không thành công!!");
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Lỗi " + exp.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập dư hoặc thiếu ký tự!!", "Thông báo");
            }
        }

        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtTK.ReadOnly = true;
            txtTK.Text = dgvTK.Rows[row].Cells[0].Value.ToString();
            txtMK.Text = dgvTK.Rows[row].Cells[1].Value.ToString();
            bool vaitro = false;
            if (dgvTK.Rows[row].Cells[2].Value.ToString().Equals("Admin"))
            {
                vaitro = true;
            }
            rdbAd.Checked = vaitro;
            rdbNV.Checked = !vaitro;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTK.Text.Trim() != "" && txtMK.Text.Trim() != "")
                {
                    SqlConnection conn = Ketnoi.GetConnect();
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string strCommand = "update TAIKHOAN set MK = @mk, VAITRO = @vaitro where TENTK = @tentk";
                    SqlCommand cmd = new SqlCommand(strCommand, conn);
                    cmd.Parameters.AddWithValue("@tentk", txtTK.Text.Trim());
                    cmd.Parameters.AddWithValue("@mk", txtMK.Text.Trim());
                    cmd.Parameters.AddWithValue("@vaitro", rdbAd.Checked);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật tài khoản thành công!!");
                    reset();
                    LoadTK();
                }
                else
                    MessageBox.Show("Cật nhật không thành công!!");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi " + exp.Message.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = Ketnoi.GetConnect();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string strCommand = "delete from TAIKHOAN where TENTK = @tentk";
                SqlCommand cmd = new SqlCommand(strCommand, conn);
                cmd.Parameters.AddWithValue("@tentk", txtTK.Text.Trim());
                cmd.Parameters.AddWithValue("@mk", txtMK.Text.Trim());
                cmd.Parameters.AddWithValue("@vaitro", rdbAd.Checked);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa tài khoản thành công!!");
                reset(); 
                LoadTK();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi " + exp.Message.ToString());
            }
        }
        private void reset()
        {
            txtTK.Text = "";
            txtMK.Text = "";
            txtTK.ReadOnly = false;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTK();
            reset();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dgvTK_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Admin" : "Nhân viên";
                    e.FormattingApplied = true;
                }

            }
        }
    }
}
