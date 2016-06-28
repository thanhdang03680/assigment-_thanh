namespace assigment__thanh
{
    partial class Sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sanpham));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtloaisp = new System.Windows.Forms.TextBox();
            this.dgvdulieu = new System.Windows.Forms.DataGridView();
            this.Ma_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_sx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.txtngaysx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdulieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(54, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(54, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(54, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(345, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(345, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại sản phẩm";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(144, 69);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(122, 20);
            this.txtmasp.TabIndex = 1;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(144, 112);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(122, 20);
            this.txttensp.TabIndex = 1;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(144, 151);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(122, 20);
            this.txtgia.TabIndex = 1;
            // 
            // txtloaisp
            // 
            this.txtloaisp.Location = new System.Drawing.Point(426, 112);
            this.txtloaisp.Name = "txtloaisp";
            this.txtloaisp.Size = new System.Drawing.Size(100, 20);
            this.txtloaisp.TabIndex = 1;
            // 
            // dgvdulieu
            // 
            this.dgvdulieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdulieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdulieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_sp,
            this.Ten_sp,
            this.Gia,
            this.Ngay_sx,
            this.Loai_sp});
            this.dgvdulieu.Location = new System.Drawing.Point(54, 196);
            this.dgvdulieu.Name = "dgvdulieu";
            this.dgvdulieu.Size = new System.Drawing.Size(481, 181);
            this.dgvdulieu.TabIndex = 3;
            this.dgvdulieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdulieu_CellContentClick);
            // 
            // Ma_sp
            // 
            this.Ma_sp.DataPropertyName = "Ma_sp";
            this.Ma_sp.HeaderText = "Mã sản phẩm";
            this.Ma_sp.Name = "Ma_sp";
            // 
            // Ten_sp
            // 
            this.Ten_sp.DataPropertyName = "Ten_sp";
            this.Ten_sp.HeaderText = "Tên sản phẩm";
            this.Ten_sp.Name = "Ten_sp";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
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
            // btthem
            // 
            this.btthem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthem.BackgroundImage")));
            this.btthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btthem.Location = new System.Drawing.Point(562, 51);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(80, 68);
            this.btthem.TabIndex = 4;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btsua.BackgroundImage")));
            this.btsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btsua.Location = new System.Drawing.Point(562, 125);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(80, 69);
            this.btsua.TabIndex = 4;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btxoa.BackgroundImage")));
            this.btxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btxoa.Location = new System.Drawing.Point(562, 200);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(80, 69);
            this.btxoa.TabIndex = 4;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthoat
            // 
            this.btthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthoat.BackgroundImage")));
            this.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btthoat.Location = new System.Drawing.Point(562, 306);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(80, 71);
            this.btthoat.TabIndex = 4;
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // txtngaysx
            // 
            this.txtngaysx.Location = new System.Drawing.Point(426, 69);
            this.txtngaysx.Name = "txtngaysx";
            this.txtngaysx.Size = new System.Drawing.Size(100, 20);
            this.txtngaysx.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quản Lý Sản Phẩm";
            // 
            // Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(701, 389);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dgvdulieu);
            this.Controls.Add(this.txtngaysx);
            this.Controls.Add(this.txtloaisp);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Sanpham";
            this.Text = "Sanpham";
            this.Load += new System.EventHandler(this.Sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdulieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtloaisp;
        private System.Windows.Forms.DataGridView dgvdulieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_sx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai_sp;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.TextBox txtngaysx;
        private System.Windows.Forms.Label label6;
    }
}