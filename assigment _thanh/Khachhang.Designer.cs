namespace assigment__thanh
{
    partial class Khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khachhang));
            this.dgvdulieu = new System.Windows.Forms.DataGridView();
            this.Ma_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhassigmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thanh_assigmentDataSet = new assigment__thanh.Thanh_assigmentDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmkh = new System.Windows.Forms.TextBox();
            this.txttkh = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmhd = new System.Windows.Forms.TextBox();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdulieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhassigmentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanh_assigmentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdulieu
            // 
            this.dgvdulieu.AutoGenerateColumns = false;
            this.dgvdulieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdulieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdulieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_kh,
            this.Ten_kh,
            this.Diachi,
            this.Sdt,
            this.Email,
            this.Ma_hd});
            this.dgvdulieu.DataSource = this.thanhassigmentDataSetBindingSource;
            this.dgvdulieu.Location = new System.Drawing.Point(28, 227);
            this.dgvdulieu.Name = "dgvdulieu";
            this.dgvdulieu.Size = new System.Drawing.Size(554, 150);
            this.dgvdulieu.TabIndex = 0;
            this.dgvdulieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Sdt.HeaderText = "Số đt";
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
            this.Ma_hd.HeaderText = "mã hóa đơn";
            this.Ma_hd.Name = "Ma_hd";
            // 
            // thanhassigmentDataSetBindingSource
            // 
            this.thanhassigmentDataSetBindingSource.DataSource = this.thanh_assigmentDataSet;
            this.thanhassigmentDataSetBindingSource.Position = 0;
            // 
            // thanh_assigmentDataSet
            // 
            this.thanh_assigmentDataSet.DataSetName = "Thanh_assigmentDataSet";
            this.thanh_assigmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(25, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(25, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(421, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số đt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(421, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // txtmkh
            // 
            this.txtmkh.Location = new System.Drawing.Point(113, 70);
            this.txtmkh.Name = "txtmkh";
            this.txtmkh.Size = new System.Drawing.Size(91, 20);
            this.txtmkh.TabIndex = 2;
            // 
            // txttkh
            // 
            this.txttkh.Location = new System.Drawing.Point(113, 108);
            this.txttkh.Name = "txttkh";
            this.txttkh.Size = new System.Drawing.Size(91, 20);
            this.txttkh.TabIndex = 2;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(113, 143);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(91, 20);
            this.txtdiachi.TabIndex = 2;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(491, 70);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(91, 20);
            this.txtsdt.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(491, 108);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(91, 20);
            this.txtemail.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(421, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã hóa đơn";
            // 
            // txtmhd
            // 
            this.txtmhd.Location = new System.Drawing.Point(491, 143);
            this.txtmhd.Name = "txtmhd";
            this.txtmhd.Size = new System.Drawing.Size(91, 20);
            this.txtmhd.TabIndex = 2;
            // 
            // btthem
            // 
            this.btthem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthem.BackgroundImage")));
            this.btthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btthem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btthem.Location = new System.Drawing.Point(229, 55);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(55, 47);
            this.btthem.TabIndex = 3;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btsua.BackgroundImage")));
            this.btsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btsua.Location = new System.Drawing.Point(338, 55);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(55, 47);
            this.btsua.TabIndex = 3;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btxoa.BackgroundImage")));
            this.btxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btxoa.Location = new System.Drawing.Point(229, 116);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(55, 47);
            this.btxoa.TabIndex = 3;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthoat
            // 
            this.btthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthoat.BackgroundImage")));
            this.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btthoat.Location = new System.Drawing.Point(338, 116);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(55, 47);
            this.btthoat.TabIndex = 3;
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 41);
            this.label7.TabIndex = 1;
            this.label7.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(616, 389);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.txtmhd);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttkh);
            this.Controls.Add(this.txtmkh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdulieu);
            this.Name = "Khachhang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdulieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhassigmentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanh_assigmentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdulieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmkh;
        private System.Windows.Forms.TextBox txttkh;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmhd;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.BindingSource thanhassigmentDataSetBindingSource;
        private Thanh_assigmentDataSet thanh_assigmentDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_hd;
        private System.Windows.Forms.Label label7;
    }
}

