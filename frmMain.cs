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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string TK;
        string VT;
        Timer ThoiGian = new Timer();
        public frmMain(string tenTK, string VaiTro)
        {
            InitializeComponent();
            this.TK = tenTK;
            this.VT = VaiTro;
            if (VaiTro == "Nhan vien")
            {
                tsmiNV.Visible = false;
                tsmiTK.Visible = false;
            }
            ThoiGian.Tick += new EventHandler(tmTG_Tick);
            ThoiGian.Interval = 1000;
            ThoiGian.Enabled = true;
            ThoiGian.Start();
        }

        private void tmTG_Tick(object sender, EventArgs e)
        {
            lbTG.Text = DateTime.Now.ToString();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lbChao.Text = "Xin chào " + this.TK + " đã đến với hệ thống quản lý giặt ủi";
        }

        private void tsmiTK_Click(object sender, EventArgs e)
        {
            frmTaiKhoan ftk = new frmTaiKhoan();
            ftk.Show();
            
        }

        private void tsmiNV_Click(object sender, EventArgs e)
        {
            frmNhanVien fnv = new frmNhanVien();
            fnv.Show();
        }

        private void tsmiKH_Click(object sender, EventArgs e)
        {
            frmKhachHang fkh = new frmKhachHang();
            fkh.Show();
        }

        private void tsmiDH_Click(object sender, EventArgs e)
        {
            frmDonHang fdh = new frmDonHang();
            fdh.Show();
        }

        private void tsmiDX_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap fdn = new frmDangNhap();
            fdn.Show();          
        }

        private void tsmiDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau fdmk = new frmDoiMatKhau();
            fdmk.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tsmiXTKe_Click(object sender, EventArgs e)
        {
            frmXemThongKe fXTK = new frmXemThongKe();
            fXTK.Show();
        }
    }
}
