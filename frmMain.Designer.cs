namespace HeThongGiatUi
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmTG = new System.Windows.Forms.Timer(this.components);
            this.lbTG = new System.Windows.Forms.Label();
            this.lbChao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsmiHT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDX = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTKe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXTKe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTG = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHT,
            this.tsmiQL,
            this.tsmiDT,
            this.tsmiTG});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(481, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tmTG
            // 
            this.tmTG.Tick += new System.EventHandler(this.tmTG_Tick);
            // 
            // lbTG
            // 
            this.lbTG.AutoSize = true;
            this.lbTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTG.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbTG.Location = new System.Drawing.Point(321, 291);
            this.lbTG.Name = "lbTG";
            this.lbTG.Size = new System.Drawing.Size(0, 13);
            this.lbTG.TabIndex = 2;
            // 
            // lbChao
            // 
            this.lbChao.AutoSize = true;
            this.lbChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChao.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbChao.Location = new System.Drawing.Point(12, 225);
            this.lbChao.Name = "lbChao";
            this.lbChao.Size = new System.Drawing.Size(57, 20);
            this.lbChao.TabIndex = 3;
            this.lbChao.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tsmiHT
            // 
            this.tsmiHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDX,
            this.tsmiDoiMK});
            this.tsmiHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiHT.Image = ((System.Drawing.Image)(resources.GetObject("tsmiHT.Image")));
            this.tsmiHT.Name = "tsmiHT";
            this.tsmiHT.Size = new System.Drawing.Size(97, 28);
            this.tsmiHT.Text = "Hệ Thống";
            // 
            // tsmiDX
            // 
            this.tsmiDX.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDX.Image")));
            this.tsmiDX.Name = "tsmiDX";
            this.tsmiDX.Size = new System.Drawing.Size(149, 22);
            this.tsmiDX.Text = "Đăng Xuất";
            this.tsmiDX.Click += new System.EventHandler(this.tsmiDX_Click);
            // 
            // tsmiDoiMK
            // 
            this.tsmiDoiMK.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDoiMK.Image")));
            this.tsmiDoiMK.Name = "tsmiDoiMK";
            this.tsmiDoiMK.Size = new System.Drawing.Size(149, 22);
            this.tsmiDoiMK.Text = "Đổi Mật Khẩu";
            this.tsmiDoiMK.Click += new System.EventHandler(this.tsmiDoiMK_Click);
            // 
            // tsmiQL
            // 
            this.tsmiQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTK,
            this.tsmiNV,
            this.tsmiKH,
            this.tsmiDH});
            this.tsmiQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiQL.Image = ((System.Drawing.Image)(resources.GetObject("tsmiQL.Image")));
            this.tsmiQL.Name = "tsmiQL";
            this.tsmiQL.Size = new System.Drawing.Size(88, 28);
            this.tsmiQL.Text = "Quản Lý";
            // 
            // tsmiTK
            // 
            this.tsmiTK.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTK.Image")));
            this.tsmiTK.Name = "tsmiTK";
            this.tsmiTK.Size = new System.Drawing.Size(142, 22);
            this.tsmiTK.Text = "Tài Khoản";
            this.tsmiTK.Click += new System.EventHandler(this.tsmiTK_Click);
            // 
            // tsmiNV
            // 
            this.tsmiNV.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNV.Image")));
            this.tsmiNV.Name = "tsmiNV";
            this.tsmiNV.Size = new System.Drawing.Size(142, 22);
            this.tsmiNV.Text = "Nhân Viên";
            this.tsmiNV.Click += new System.EventHandler(this.tsmiNV_Click);
            // 
            // tsmiKH
            // 
            this.tsmiKH.Image = ((System.Drawing.Image)(resources.GetObject("tsmiKH.Image")));
            this.tsmiKH.Name = "tsmiKH";
            this.tsmiKH.Size = new System.Drawing.Size(142, 22);
            this.tsmiKH.Text = "Khách Hàng";
            this.tsmiKH.Click += new System.EventHandler(this.tsmiKH_Click);
            // 
            // tsmiDH
            // 
            this.tsmiDH.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDH.Image")));
            this.tsmiDH.Name = "tsmiDH";
            this.tsmiDH.Size = new System.Drawing.Size(142, 22);
            this.tsmiDH.Text = "Đơn Hàng";
            this.tsmiDH.Click += new System.EventHandler(this.tsmiDH_Click);
            // 
            // tsmiDT
            // 
            this.tsmiDT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTKe,
            this.tsmiXTKe});
            this.tsmiDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiDT.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDT.Image")));
            this.tsmiDT.Name = "tsmiDT";
            this.tsmiDT.Size = new System.Drawing.Size(104, 28);
            this.tsmiDT.Text = "Doanh Thu";
            // 
            // tsmiTKe
            // 
            this.tsmiTKe.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTKe.Image")));
            this.tsmiTKe.Name = "tsmiTKe";
            this.tsmiTKe.Size = new System.Drawing.Size(188, 30);
            this.tsmiTKe.Text = "Thống Kê";
            // 
            // tsmiXTKe
            // 
            this.tsmiXTKe.Image = ((System.Drawing.Image)(resources.GetObject("tsmiXTKe.Image")));
            this.tsmiXTKe.Name = "tsmiXTKe";
            this.tsmiXTKe.Size = new System.Drawing.Size(188, 30);
            this.tsmiXTKe.Text = "Xem Thống Kê";
            this.tsmiXTKe.Click += new System.EventHandler(this.tsmiXTKe_Click);
            // 
            // tsmiTG
            // 
            this.tsmiTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiTG.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTG.Image")));
            this.tsmiTG.Name = "tsmiTG";
            this.tsmiTG.Size = new System.Drawing.Size(90, 28);
            this.tsmiTG.Text = "Trợ Giúp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbChao);
            this.Controls.Add(this.lbTG);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmMain";
            this.Text = "HỆ THỐNG QUẢN LÝ GIẶT ỦI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHT;
        private System.Windows.Forms.ToolStripMenuItem tsmiQL;
        private System.Windows.Forms.ToolStripMenuItem tsmiDT;
        private System.Windows.Forms.ToolStripMenuItem tsmiDX;
        private System.Windows.Forms.ToolStripMenuItem tsmiNV;
        private System.Windows.Forms.ToolStripMenuItem tsmiKH;
        private System.Windows.Forms.ToolStripMenuItem tsmiDH;
        private System.Windows.Forms.ToolStripMenuItem tsmiTG;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoiMK;
        private System.Windows.Forms.ToolStripMenuItem tsmiTKe;
        private System.Windows.Forms.ToolStripMenuItem tsmiXTKe;
        private System.Windows.Forms.ToolStripMenuItem tsmiTK;
        private System.Windows.Forms.Timer tmTG;
        private System.Windows.Forms.Label lbTG;
        private System.Windows.Forms.Label lbChao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}