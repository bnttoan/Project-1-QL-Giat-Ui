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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            LoadKH();
            TaoMoi();
        }
        public void LoadKH()
        {
            try
            {
                SqlConnection conn = Ketnoi.GetConnect();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("select * from KHACHHANG", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Dispose();
                if (dt.Rows.Count > 0)
                    dgvKH.DataSource = dt;
                LoadLKH();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message.ToString());
            }
        }
        private void LoadLKH()
        {
            try
            {
                SqlConnection conn = Ketnoi.GetConnect();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string strSQL = "select * from PHANLOAIKH ";
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("PHANLOAIKH");
                da.Fill(dt);
                da.Dispose();
                conn.Close();
                cbMA_LKH.DataSource = dt;
                cbMA_LKH.ValueMember = "MA_LOAIKH";
                cbMA_LKH.DisplayMember = "LOAIKH";
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi " + e.Message.ToString());
            }
        }
        private void btnPL_Click(object sender, EventArgs e)
        {
            frmPLKH fpl = new frmPLKH();
            fpl.Show();
            this.Hide();
        }
        private void TaoMoi()
        {
            txtMAKH.Text = "";
            txtTENKH.Text = "";
            txtDIACHI.Text = "";
            txtSDT.Text = "";
            txtMAKH.ReadOnly = false;
            LoadKH();

        }

        string chuoidung = "1234567890_QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopas dfghjklzxcvbnm";
        private bool testKT(string chuoiCanKiemTra)
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
            string makh = txtMAKH.Text.Trim();
            string tenkh = txtTENKH.Text.Trim();
            string diachi = txtDIACHI.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            if (makh.Length == 4 && sdt.Length == 10)
            {
                try
                {
                    SqlConnection Connet = Ketnoi.GetConnect();
                    if (Connet.State == ConnectionState.Closed)
                        Connet.Open();
                    string ktMaKH = "Select * From KHACHHANG where MAKH='" + txtMAKH.Text + "'";
                    SqlCommand cmd = new SqlCommand(ktMaKH, Connet);
                    SqlDataReader sdr;
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        MessageBox.Show("Bạn đã nhập trùng mã khách hàng", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMAKH.Focus();
                        cmd.Dispose();
                        sdr.Dispose();
                    }
                    if (testKT(makh) == false)
                    {
                        MessageBox.Show("Mã khách hàng không được sử dụng ký tự đặc biệt!!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        cmd.Dispose();
                        sdr.Dispose();
                        string strCommand = "insert into KHACHHANG values(@makh,@ma_loaikh, @tenkh, @diachi, @sdt)";
                        SqlCommand Command = new SqlCommand(strCommand, Connet);
                        Command.Parameters.AddWithValue("@makh", txtMAKH.Text.Trim());
                        Command.Parameters.AddWithValue("@ma_loaikh", cbMA_LKH.SelectedValue.ToString());
                        Command.Parameters.AddWithValue("@tenkh", txtTENKH.Text.Trim());
                        Command.Parameters.AddWithValue("@diachi", txtDIACHI.Text.Trim());
                        Command.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
                        Command.ExecuteNonQuery();
                        LoadKH();
                        TaoMoi();
                        MessageBox.Show("Thêm khách hàng thành công");
                        Command.Dispose();
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(" lỗi " + exp.Message);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu hoặc nhập sai", "Thông báo");
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hienthi = e.RowIndex;
            txtMAKH.Text = dgvKH.Rows[hienthi].Cells[0].Value.ToString();
            cbMA_LKH.SelectedValue = dgvKH.Rows[hienthi].Cells[1].Value.ToString();
            txtTENKH.Text = dgvKH.Rows[hienthi].Cells[2].Value.ToString();
            txtDIACHI.Text = dgvKH.Rows[hienthi].Cells[3].Value.ToString();
            txtSDT.Text = dgvKH.Rows[hienthi].Cells[4].Value.ToString();
            txtMAKH.ReadOnly = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string makh = txtMAKH.Text.Trim();
            string tenkh = txtTENKH.Text.Trim();
            string diachi = txtDIACHI.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            if (sdt.Length == 10)
            {
                try
                {
                        SqlConnection Connet = Ketnoi.GetConnect();
                        string strCommand = "update KHACHHANG set MA_LOAIKH = @ma_loaikh, TENKH = @tenkh, DIACHI = @diachi, SDT = @sdt where MAKH = @makh ";
                        SqlCommand cmd = new SqlCommand(strCommand, Connet);
                        cmd.Parameters.AddWithValue("@makh", txtMAKH.Text.Trim());
                        cmd.Parameters.AddWithValue("@ma_loaikh", cbMA_LKH.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@tenkh", txtTENKH.Text.Trim());
                        cmd.Parameters.AddWithValue("@diachi", txtDIACHI.Text.Trim());
                        cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
                        cmd.ExecuteNonQuery();
                        LoadKH();
                        TaoMoi();
                        MessageBox.Show("Cập nhật khách hàng thành công");
                    
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Lỗi " + exp.Message);
                }
            }
            else
            {
                MessageBox.Show("số điện thoại chỉ 10 chữ số");
                if (sdt.Length != 10)
                {
                    txtSDT.Focus();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Ketnoi.GetConnect();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string strCommand = "DELETE FROM KHACHHANG WHERE MAKH=@makh ";
            SqlCommand cmd = new SqlCommand(strCommand, conn);
            cmd.Parameters.AddWithValue("@makh", txtMAKH.Text.Trim());
            cmd.Parameters.AddWithValue("@tenkh", txtTENKH.Text.Trim());
            cmd.Parameters.AddWithValue("@diachi", txtDIACHI.Text.Trim());
            cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa khách hàng thành công!");
            LoadKH();
            TaoMoi();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            TaoMoi();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            TaoMoi();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
