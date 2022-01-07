
namespace HeThongGiatUi
{
    partial class frmPLKH
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
            this.dgvPLKH = new System.Windows.Forms.DataGridView();
            this.MA_LOAIKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAIKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPLKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPLKH
            // 
            this.dgvPLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPLKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_LOAIKH,
            this.LOAIKH});
            this.dgvPLKH.Location = new System.Drawing.Point(12, 40);
            this.dgvPLKH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPLKH.Name = "dgvPLKH";
            this.dgvPLKH.RowHeadersWidth = 51;
            this.dgvPLKH.RowTemplate.Height = 24;
            this.dgvPLKH.Size = new System.Drawing.Size(303, 166);
            this.dgvPLKH.TabIndex = 7;
            // 
            // MA_LOAIKH
            // 
            this.MA_LOAIKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MA_LOAIKH.DataPropertyName = "MA_LOAIKH";
            this.MA_LOAIKH.HeaderText = "Mã loại KH";
            this.MA_LOAIKH.MinimumWidth = 6;
            this.MA_LOAIKH.Name = "MA_LOAIKH";
            // 
            // LOAIKH
            // 
            this.LOAIKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LOAIKH.DataPropertyName = "LOAIKH";
            this.LOAIKH.HeaderText = "Loại KH";
            this.LOAIKH.MinimumWidth = 6;
            this.LOAIKH.Name = "LOAIKH";
            // 
            // picBack
            // 
            this.picBack.Image = global::HeThongGiatUi.Properties.Resources.Back;
            this.picBack.Location = new System.Drawing.Point(12, 12);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(35, 22);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 8;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // frmPLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 217);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.dgvPLKH);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPLKH";
            this.Text = "Phân Loại Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPLKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPLKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_LOAIKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIKH;
        private System.Windows.Forms.PictureBox picBack;
    }
}