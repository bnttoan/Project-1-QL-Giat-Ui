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
using System.IO;


namespace HeThongGiatUi
{
    public partial class frmDonHang : Form
    {
        public frmDonHang()
        {
            InitializeComponent();
        }
        public void LoadDH()
        {
            try
            {
                SqlConnection conn = Ketnoi.GetConnect();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("select * from DONHANG", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Dispose();
                if (dt.Rows.Count > 0)
                    dgvDH.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message.ToString());
            }
        }
        private void TaoMoi()
        {
            txtMADH.Text = "";
            txtMAKH.Text = "";
            txtMANV.Text = "";
            txtTONG.Text = "";
            dtpNgayban.Value = DateTime.Today;
            txtMADH.ReadOnly = false;
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
            string madh = txtMADH.Text.Trim();
            string makh = txtMAKH.Text.Trim();
            string manv = txtMANV.Text.Trim();
            string ngban = dtpNgayban.Text.Trim();
            string tongtien = txtTONG.Text.Trim();
            if (madh.Length == 5 && makh.Length == 4 && manv.Length == 5)
            {
                try
                {
                    SqlConnection Connet = Ketnoi.GetConnect();
                    if (Connet.State == ConnectionState.Closed)
                        Connet.Open();
                    string ktMaDH = "Select * From DONHANG where MADH='" + txtMADH.Text + "'";
                    SqlCommand cmd = new SqlCommand(ktMaDH, Connet);
                    SqlDataReader sdr;
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        MessageBox.Show("Bạn đã nhập trùng mã đơn hàng","Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMADH.Focus();
                        cmd.Dispose();
                        sdr.Dispose();
                    }
                    if (testKT(manv) == false)
                    {
                        MessageBox.Show("Mã nhân viên không được sử dụng ký tự đặc biệt!!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (testKT(madh) == false)
                    {
                        MessageBox.Show("Mã đơn hàng không được sử dụng ký tự đặc biệt!!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (testKT(makh) == false)
                    {
                        MessageBox.Show("Mã khách hàng không được sử dụng ký tự đặc biệt!!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (tongtien.Length == 0)
                    {
                        MessageBox.Show("Số tiền không hợp lệ", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        cmd.Dispose();
                        sdr.Dispose();
                        SqlCommand Command = new SqlCommand("insert into DONHANG values(@madh, @manv, @ngayban," +
                            "@makh,@tongtien)", Connet);
                        Command.Parameters.AddWithValue("@madh", txtMADH.Text.Trim());
                        Command.Parameters.AddWithValue("@manv", txtMANV.Text.Trim());
                        Command.Parameters.AddWithValue("@ngayban", dtpNgayban.Value.Date);
                        Command.Parameters.AddWithValue("@makh", txtMAKH.Text.Trim());
                        Command.Parameters.AddWithValue("@tongtien", txtTONG.Text.Trim());
                        Command.ExecuteNonQuery();
                        LoadDH();
                        TaoMoi();
                        MessageBox.Show("Thêm đơn hàng thành công!");
                        Command.Dispose();
                    }
                }
                catch (Exception Ecp)
                {
                    MessageBox.Show("Lỗi: " + Ecp.Message);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu hoặc nhập sai", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string madh = txtMADH.Text.Trim();
            string makh = txtMAKH.Text.Trim();
            string manv = txtMANV.Text.Trim();
            string ngayban = dtpNgayban.Text.Trim();
            string tongtien = txtTONG.Text.Trim();
            if (madh.Length == 5 && makh.Length == 4 && manv.Length == 5)
            {
                try
                {
                    if (testKT(madh) == false)
                    {
                        MessageBox.Show("Mã đơn hàng không được sử dụng ký tự đặc biệt!!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (testKT(makh) == false)
                    {
                        MessageBox.Show("Mã khách hàng không được sử dụng ký tự đặc biệt!!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (tongtien.Length == 0)
                    {
                        MessageBox.Show("Số tiền không hợp lệ", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SqlConnection Connet = Ketnoi.GetConnect();
                        SqlCommand Command = new SqlCommand("update DONHANG set MANV = @manv, NGAYBAN = @ngayban," +
                            " MAKH = @makh, TONGTIEN = @tongtien where  MADH = @madh", Connet);
                        Command.Parameters.AddWithValue("@madh", txtMADH.Text.Trim());
                        Command.Parameters.AddWithValue("@manv", txtMANV.Text.Trim());
                        Command.Parameters.AddWithValue("@ngayban", dtpNgayban.Value.Date);
                        Command.Parameters.AddWithValue("@makh", txtMAKH.Text.Trim());
                        Command.Parameters.AddWithValue("@tongtien", txtTONG.Text.Trim());
                        Command.ExecuteNonQuery();
                        LoadDH();
                        TaoMoi();
                        MessageBox.Show("Cập nhật đơn hàng thành công!");
                    }
                }
                catch (Exception Ecp)
                {
                    MessageBox.Show("Lỗi! " + Ecp.Message);
                }
            }
            else
            {
                MessageBox.Show("Mã đơn hàng, mã nhân viên phải có 5 chữ số và mã khách hàng phải có 4 chữ số!!");
                if (madh.Length != 5)
                {
                    txtMADH.Focus();
                }
                else if (makh.Length != 4)
                {
                    txtMAKH.Focus();
                }
                else if (manv.Length != 5)
                {
                    txtMANV.Focus();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = Ketnoi.GetConnect();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string strCommand = "delete from DONHANG where MADH = @madh";
                SqlCommand cmd = new SqlCommand(strCommand, conn);
                cmd.Parameters.AddWithValue("@madh", txtMADH.Text.Trim());
                cmd.Parameters.AddWithValue("@manv", txtMANV.Text.Trim());
                cmd.Parameters.AddWithValue("@ngayban", dtpNgayban.Value.Date);
                cmd.Parameters.AddWithValue("@makh", txtMAKH.Text.Trim());
                cmd.Parameters.AddWithValue("@tongtien", txtTONG.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa đơn hàng thành công!!");
                TaoMoi();
                LoadDH();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi " + exp.Message.ToString());
            }
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            LoadDH();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            TaoMoi();
        }

        private void dgvDH_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMADH.ReadOnly = true;
            txtMADH.Text = dgvDH.Rows[row].Cells[0].Value.ToString();
            txtMANV.Text = dgvDH.Rows[row].Cells[1].Value.ToString();
            dtpNgayban.Value = Convert.ToDateTime(dgvDH.Rows[row].Cells[2].Value.ToString());
            txtMAKH.Text = dgvDH.Rows[row].Cells[3].Value.ToString();
            txtTONG.Text = dgvDH.Rows[row].Cells[4].Value.ToString();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            nhapFileJSon();
        }
        public void nhapFileJSon()
        {
            OpenFileDialog chonFileJSon = new OpenFileDialog();
            chonFileJSon.InitialDirectory = @"D:\";
            chonFileJSon.Filter = "json files (*.json)|*.json";
            if (chonFileJSon.ShowDialog() == DialogResult.OK)
            {
                StreamReader stRead = new StreamReader(chonFileJSon.FileName);
                txtPath.Text = chonFileJSon.FileName;
                DataTable dtttb = new DataTable();
                if (dtttb == null && dtttb.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để import", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string madh = "", manv = "", ngayban = "", makh = "", tongtien = "";
                try
                {
                    SqlConnection Connet = Ketnoi.GetConnect();
                    if (Connet.State == ConnectionState.Closed)
                        Connet.Open();
                    for (int i = 0; i < dtttb.Rows.Count; i++)
                    {
                        madh = dtttb.Rows[i]["madh"].ToString().Trim();
                        manv = dtttb.Rows[i]["manv"].ToString().Trim();
                        ngayban = dtttb.Rows[i]["ngayban"].ToString().Trim();
                        makh = dtttb.Rows[i]["makh"].ToString().Trim();
                        tongtien = dtttb.Rows[i]["tongtien"].ToString().Trim();

                        string sql = @"INSERT INTO DONHANG (madh, manv, ngayban, makh, tongtien)
                                        Values (@madh, @manv, @ngayban, @makh, @tongtien)";
                        SqlCommand cmd = new SqlCommand(sql, Connet);
                        cmd.Parameters.Add("@madh", SqlDbType.VarChar).Value = madh;
                        cmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = manv;
                        cmd.Parameters.Add("@ngayban", SqlDbType.DateTime).Value = ngayban;
                        cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = makh;
                        cmd.Parameters.Add("@tongtien", SqlDbType.VarChar).Value = tongtien;
                        cmd.ExecuteNonQuery();
                        Connet.Close();                        
                        MessageBox.Show("Đã thêm đơn hàng", "Thông báo");
                    }
                }
                catch (Exception Ecp)
                {
                    MessageBox.Show("Lỗi: " + Ecp.Message);
                }
            }
        }
    }
}
 