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

namespace assigment__thanh
{
    public partial class timkiemcbb : Form
    {
        public timkiemcbb()
        {
            InitializeComponent();
        }

        string sql;
        private void ketnoi()
        {
            try
            {
                SqlConnection cn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                cn.Open();
                sql = "select * from Khachhang, Sanpham";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataAdapter sa = new SqlDataAdapter(cmd);//van chuyen du lieu 
                DataTable dt = new DataTable();//tạo 1 bảng trong he thong
                cmd.ExecuteNonQuery();
                sa.Fill(dt);//do du lieu vao bang ao
                dgvtim.DataSource = dt; //bang ao du lieu do vao datagridview
            }
            catch
            {
                MessageBox.Show("Lỗi không kết nối được");
            }
            finally
            {
                SqlConnection cn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                cn.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mã khách hàng")
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                SqlDataAdapter sa = new SqlDataAdapter("select Ma_kh,Ten_kh, Diachi, Sdt, Email, Ma_hd from Khachhang where Ma_kh like '" + txttk.Text + "%'", kn);
                DataTable dt = new DataTable();
                sa.Fill(dt);
                dgvtim.DataSource = dt;
            }
            else if (comboBox1.Text == "Tên khách hàng")
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                SqlDataAdapter sa = new SqlDataAdapter("select Ma_kh,Ten_kh, Diachi, Sdt, Email, Ma_hd from Khachhang where Ten_kh like '" + txttk.Text + "%'", kn);
                DataTable dt = new DataTable();
                sa.Fill(dt);
                dgvtim.DataSource = dt;
            }
            if (comboBox1.Text == "Mã sản phẩm")
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                SqlDataAdapter sa = new SqlDataAdapter("select Ma_sp,Ten_sp, Gia, Ngay_sx, Loai_sp from Sanpham where Ma_sp like '" + txttk.Text + "%'", kn);
                DataTable dt = new DataTable();
                sa.Fill(dt);
                dgvtim.DataSource = dt;
            }
            else if (comboBox1.Text == "Tên sản phẩm")
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                SqlDataAdapter sa = new SqlDataAdapter("select Ma_sp,Ten_sp, Gia, Ngay_sx, Loai_sp from Sanpham where Ten_sp like '" + txttk.Text + "%'", kn);
                DataTable dt = new DataTable();
                sa.Fill(dt);
                dgvtim.DataSource = dt;
            }
        }

        private void timkiemcbb_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void dgvtim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không?", "Thống báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
      

            }
        }
    }
}
