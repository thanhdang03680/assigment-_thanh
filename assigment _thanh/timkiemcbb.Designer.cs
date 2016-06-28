namespace assigment__thanh
{
    partial class timkiemcbb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timkiemcbb));
            this.dgvtim = new System.Windows.Forms.DataGridView();
            this.Ma_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_sx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtim
            // 
            this.dgvtim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_kh,
            this.Ten_kh,
            this.Diachi,
            this.Sdt,
            this.Email,
            this.Ma_hd,
            this.Ten_sp,
            this.Gia,
            this.Ngay_sx,
            this.Loai_sp});
            this.dgvtim.Location = new System.Drawing.Point(12, 135);
            this.dgvtim.Name = "dgvtim";
            this.dgvtim.Size = new System.Drawing.Size(963, 241);
            this.dgvtim.TabIndex = 0;
            this.dgvtim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtim_CellContentClick);
            // 
            // Ma_kh
            // 
            this.Ma_kh.DataPropertyName = "Ma_kh";
            this.Ma_kh.HeaderText = "Mã khách hàng";
            this.Ma_kh.Name = "Ma_kh";
            // 
            // Ten_kh
            // 
            this.Ten_kh.DataPropertyName = "Ten_kh";
            this.Ten_kh.HeaderText = "Tên khách hàng";
            this.Ten_kh.Name = "Ten_kh";
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.Name = "Diachi";
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.Name = "Sdt";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Ma_hd
            // 
            this.Ma_hd.DataPropertyName = "Ma_hd";
            this.Ma_hd.HeaderText = "Mã hóa đơn";
            this.Ma_hd.Name = "Ma_hd";
            // 
            // Ten_sp
            // 
            this.Ten_sp.DataPropertyName = "Ten_sp";
            this.Ten_sp.HeaderText = "Tên sản phảm";
            this.Ten_sp.Name = "Ten_sp";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá tiền";
            this.Gia.Name = "Gia";
            // 
            // Ngay_sx
            // 
            this.Ngay_sx.DataPropertyName = "Ngay_sx";
            this.Ngay_sx.HeaderText = "Ngày sản xuất";
            this.Ngay_sx.Name = "Ngay_sx";
            // 
            // Loai_sp
            // 
            this.Loai_sp.DataPropertyName = "Loai_sp";
            this.Loai_sp.HeaderText = "Loại sản phẩm";
            this.Loai_sp.Name = "Loai_sp";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Tên khách hàng",
            "Mã sản phẩm",
            "Tên sản phẩm"});
            this.comboBox1.Location = new System.Drawing.Point(288, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txttk
            // 
            this.txttk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txttk.Location = new System.Drawing.Point(538, 87);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(186, 20);
            this.txttk.TabIndex = 2;
            this.txttk.TextChanged += new System.EventHandler(this.txttk_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "từ tìm kiếm";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 57);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm Kiếm";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btthoat
            // 
            this.btthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthoat.BackgroundImage")));
            this.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btthoat.Location = new System.Drawing.Point(799, 12);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(135, 98);
            this.btthoat.TabIndex = 5;
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // timkiemcbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 388);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvtim);
            this.Name = "timkiemcbb";
            this.Text = "timkiemcbb";
            this.Load += new System.EventHandler(this.timkiemcbb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_sx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai_sp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btthoat;
    }
}