
namespace HeThongGiatUi
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMKC = new System.Windows.Forms.TextBox();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.txtNLMK = new System.Windows.Forms.TextBox();
            this.btnXN = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ckbMKC = new System.Windows.Forms.CheckBox();
            this.ckbMKM = new System.Windows.Forms.CheckBox();
            this.ckbMK = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(119, 62);
            this.txtTK.Margin = new System.Windows.Forms.Padding(2);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(160, 20);
            this.txtTK.TabIndex = 4;
            // 
            // txtMKC
            // 
            this.txtMKC.Location = new System.Drawing.Point(119, 86);
            this.txtMKC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.PasswordChar = '*';
            this.txtMKC.Size = new System.Drawing.Size(160, 20);
            this.txtMKC.TabIndex = 5;
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(119, 129);
            this.txtMKM.Margin = new System.Windows.Forms.Padding(2);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '*';
            this.txtMKM.Size = new System.Drawing.Size(160, 20);
            this.txtMKM.TabIndex = 7;
            // 
            // txtNLMK
            // 
            this.txtNLMK.Location = new System.Drawing.Point(119, 171);
            this.txtNLMK.Margin = new System.Windows.Forms.Padding(2);
            this.txtNLMK.Name = "txtNLMK";
            this.txtNLMK.PasswordChar = '*';
            this.txtNLMK.Size = new System.Drawing.Size(160, 20);
            this.txtNLMK.TabIndex = 9;
            // 
            // btnXN
            // 
            this.btnXN.Image = global::HeThongGiatUi.Properties.Resources.Save;
            this.btnXN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXN.Location = new System.Drawing.Point(119, 221);
            this.btnXN.Margin = new System.Windows.Forms.Padding(2);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(67, 32);
            this.btnXN.TabIndex = 11;
            this.btnXN.Text = "Lưu";
            this.btnXN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXN.UseVisualStyleBackColor = true;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::HeThongGiatUi.Properties.Resources.Exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(212, 221);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(67, 32);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ckbMKC
            // 
            this.ckbMKC.AutoSize = true;
            this.ckbMKC.Location = new System.Drawing.Point(119, 108);
            this.ckbMKC.Margin = new System.Windows.Forms.Padding(2);
            this.ckbMKC.Name = "ckbMKC";
            this.ckbMKC.Size = new System.Drawing.Size(124, 17);
            this.ckbMKC.TabIndex = 6;
            this.ckbMKC.Text = "Hiển thị mật khẩu cũ";
            this.ckbMKC.UseVisualStyleBackColor = true;
            this.ckbMKC.CheckedChanged += new System.EventHandler(this.ckbMKC_CheckedChanged);
            // 
            // ckbMKM
            // 
            this.ckbMKM.AutoSize = true;
            this.ckbMKM.Location = new System.Drawing.Point(119, 151);
            this.ckbMKM.Margin = new System.Windows.Forms.Padding(2);
            this.ckbMKM.Name = "ckbMKM";
            this.ckbMKM.Size = new System.Drawing.Size(128, 17);
            this.ckbMKM.TabIndex = 8;
            this.ckbMKM.Text = "Hiển thị mật khẩu mới";
            this.ckbMKM.UseVisualStyleBackColor = true;
            this.ckbMKM.CheckedChanged += new System.EventHandler(this.ckbMKM_CheckedChanged);
            // 
            // ckbMK
            // 
            this.ckbMK.AutoSize = true;
            this.ckbMK.Location = new System.Drawing.Point(119, 193);
            this.ckbMK.Margin = new System.Windows.Forms.Padding(2);
            this.ckbMK.Name = "ckbMK";
            this.ckbMK.Size = new System.Drawing.Size(109, 17);
            this.ckbMK.TabIndex = 10;
            this.ckbMK.Text = "Hiển thị mật khẩu";
            this.ckbMK.UseVisualStyleBackColor = true;
            this.ckbMK.CheckedChanged += new System.EventHandler(this.ckbMK_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 263);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ckbMK);
            this.Controls.Add(this.ckbMKM);
            this.Controls.Add(this.ckbMKC);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXN);
            this.Controls.Add(this.txtNLMK);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.txtMKC);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMKC;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.TextBox txtNLMK;
        private System.Windows.Forms.Button btnXN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox ckbMK;
        private System.Windows.Forms.CheckBox ckbMKM;
        private System.Windows.Forms.CheckBox ckbMKC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}