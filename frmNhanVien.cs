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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        
        private void TaoMoi()
        {
            txtMANV.Text = "";
            txtDIACHI.Text = "";
            txtLUONG.Text = "";
            txtMA_NQL.Text = "";
            txtSDT.Text = "";
            txtTENNV.Text = "";
            dtpNGSINH.Value = DateTime.Today;
            rdbNam.Checked = true;
            txtMANV.ReadOnly = false;
            
        }
        public void LoadNV()
        {
            try
            {
                SqlConnection conn = Ketnoi.GetConnect();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("select * from NHANVIEN", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Dispose();
                if (dt.Rows.Count > 0)
                    dgvNhanvien.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message.ToString());
            }

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
            string manv = txtMANV.Text.Trim();
            string tennv = txtTENNV.Text.Trim();
            string diachi = txtDIACHI.Text.Trim();
            string ma_nql = txtMA_NQL.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            if (manv.Length == 5 && ma_nql.Length == 5 && sdt.Length == 10)
            {
                try
                {
                    SqlConnection Connet = Ketnoi.GetConnect();
                    if (Connet.State == ConnectionState.Closed)
                        Connet.Open();
                    string ktMaNV = "Select * From NHANVIEN where MANV='" + txtMANV.Text + "'";
                    SqlCommand cmd = new SqlCommand(ktMaNV, Connet);
                    SqlDataReader sdr;
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        MessageBox.Show("Bạn đã nhập trùng mã nhân viên", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMANV.Focus();
                        cmd.Dispose();
                        sdr.Dispose();
                    }

                    if (testKT(manv) == false)
                    {
                        MessageBox.Show("Mã nhân viên không được sử dụng ký tự đặc biệt!!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (testKT(ma_nql) == false)
                    {
                        MessageBox.Show("Mã người quản lý không được sử dụng ký tự đặc biệt!!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        cmd.Dispose();
                        sdr.Dispose();
                    SqlCommand Command = new SqlCommand("insert into NHANVIEN values(@manv, @tennv, @ngsinh," +
                            "@diachi, @sdt, @luong, @ma_nql, @phai)", Connet);
                        Command.Parameters.AddWithValue("@manv", txtMANV.Text.Trim());
                        Command.Parameters.AddWithValue("@tennv", txtTENNV.Text.Trim());
                        Command.Parameters.AddWithValue("@ngsinh", dtpNGSINH.Value.Date);
                        Command.Parameters.AddWithValue("@diachi", txtDIACHI.Text.Trim());
                        Command.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
                        Command.Parameters.AddWithValue("@luong", txtLUONG.Text.Trim());
                        Command.Parameters.AddWithValue("@ma_nql", txtMA_NQL.Text.Trim());
                        Command.Parameters.AddWithValue("@phai", rdbNam.Checked);
                        Command.ExecuteNonQuery();
                        LoadNV();
                        TaoMoi();
                        MessageBox.Show("Thêm nhân viên thành công!");
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

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMANV.Text = dgvNhanvien.Rows[row].Cells[0].Value.ToString();
            txtTENNV.Text = dgvNhanvien.Rows[row].Cells[1].Value.ToString();
            dtpNGSINH.Value = Convert.ToDateTime(dgvNhanvien.Rows[row].Cells[2].Value.ToString());
            txtDIACHI.Text = dgvNhanvien.Rows[row].Cells[3].Value.ToString();
            txtSDT.Text = dgvNhanvien.Rows[row].Cells[4].Value.ToString();
            txtLUONG.Text = dgvNhanvien.Rows[row].Cells[5].Value.ToString();
            txtMA_NQL.Text = dgvNhanvien.Rows[row].Cells[6].Value.ToString();
            bool isPhai = Convert.ToBoolean(dgvNhanvien.Rows[row].Cells[7].Value.ToString());
            rdbNam.Checked = isPhai;
            rdbNu.Checked = !isPhai;
            txtMANV.ReadOnly = true;
        }

        private void bthSua_Click(object sender, EventArgs e)
        {
            string manv = txtMANV.Text.Trim();
            string tennv = txtTENNV.Text.Trim();
            string diachi = txtDIACHI.Text.Trim();
            string ma_nql = txtMA_NQL.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            if (ma_nql.Length == 5 && sdt.Length == 10)
            {
                try
                {
                    if (testKT(ma_nql) == false)
                    {
                        MessageBox.Show("Mã người quản lý không được sử dụng ký tự đặc biệt!!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SqlConnection Connet = Ketnoi.GetConnect();
                        SqlCommand Command = new SqlCommand("update NHANVIEN set TENNV = @tennv," +
                            "NGSINH = @ngsinh, DIACHI = @diachi, SDT = @sdt, LUONG = @luong, " +
                            "MA_NQL = @ma_nql, PHAI = @phai where MANV = @manv", Connet);
                        Command.Parameters.AddWithValue("@manv", txtMANV.Text.Trim());
                        Command.Parameters.AddWithValue("@tennv", txtTENNV.Text.Trim());
                        Command.Parameters.AddWithValue("@ngsinh", dtpNGSINH.Value.Date);
                        Command.Parameters.AddWithValue("@diachi", txtDIACHI.Text.Trim());
                        Command.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
                        Command.Parameters.AddWithValue("@luong", txtLUONG.Text.Trim());
                        Command.Parameters.AddWithValue("@ma_nql", txtMA_NQL.Text.Trim());
                        Command.Parameters.AddWithValue("@phai", rdbNam.Checked);
                        Command.ExecuteNonQuery();
                        LoadNV();
                        TaoMoi();
                        MessageBox.Show("Sửa nhân viên thành công!");
                    }
                }
                catch (Exception Ecp)
                {
                    MessageBox.Show("Lỗi! " + Ecp.Message);
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại 10 chữ số, Ma_NQL 5 kí tự");
                if (ma_nql.Length != 5)
                {
                    txtMA_NQL.Focus();
                }
                else if (sdt.Length != 10)
                {
                    txtSDT.Focus();
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
                string strCommand = "delete from NHANVIEN where MANV = @manv";
                SqlCommand cmd = new SqlCommand(strCommand, conn);
                cmd.Parameters.AddWithValue("@manv", txtMANV.Text.Trim());
                cmd.Parameters.AddWithValue("@tennv", txtTENNV.Text.Trim());
                cmd.Parameters.AddWithValue("@ngsinh", dtpNGSINH.Value.Date);
                cmd.Parameters.AddWithValue("@diachi", txtDIACHI.Text.Trim());
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
                cmd.Parameters.AddWithValue("@luong", txtLUONG.Text.Trim());
                cmd.Parameters.AddWithValue("@ma_nql", txtMA_NQL.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa nhân viên thành công!!");
                LoadNV();
                TaoMoi();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi " + exp.Message.ToString());
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            // IsDigit(e.KeyChar) 
            //–> kiểm tra xem phím vừa nhập vào textbox có phải là ký tự số hay không,
            // hàm này trả về kiểu bool
            //Char.IsContro(e.KeyChar) 
            //–> kiểm tra xem phím vừa nhập vào textbox có phải là các ký tự điều khiển
            //(các phím mũi tên,Delete,Insert,backspace,space bar) hay không,
           // mục đích dùng hàm này là để cho phép người dùng xóa số trong trường hợp nhập sai.
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            TaoMoi();
        }

        private void dgvNhanvien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }

            }
        }
    }
}
