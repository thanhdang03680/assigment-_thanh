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
    public partial class Sanpham : Form
    {
        public Sanpham()
        {
            InitializeComponent();
        }

        public void ketnoi()
    {
        try
    {
        SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
        kn.Open();
            string sql = "select * from Sanpham";
            SqlCommand cmd = new SqlCommand(sql, kn);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);//van chuyen du lieu 
            DataTable dt = new DataTable();//tạo 1 bảng trong he thong
            sa.Fill(dt);//do du lieu vao bang ao
            dgvdulieu.DataSource = dt; //bang ao du lieu do vao datagridview
    }
            catch
        {
            MessageBox.Show("Lỗi không kết nối được");
        }
            finally
        {
            SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
            kn.Close();
        }
    }
    
        private void Sanpham_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        int index;
        private void dgvdulieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvdulieu.CurrentRow.Index;
            txtmasp.Text = dgvdulieu.Rows[index].Cells[0].Value.ToString();
            txttensp.Text = dgvdulieu.Rows[index].Cells[1].Value.ToString();
            txtgia.Text = dgvdulieu.Rows[index].Cells[2].Value.ToString();
            txtngaysx.Text = dgvdulieu.Rows[index].Cells[3].Value.ToString(); 
            txtloaisp.Text = dgvdulieu.Rows[index].Cells[4].Value.ToString();
        }

        string themsp;
        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Open();
                themsp = "insert into Sanpham VALUES ('"+txtmasp.Text+"', '"+txttensp.Text+"','"+txtgia.Text+"','"+txtngaysx.Text+"','"+txtloaisp.Text+"')";
                SqlCommand cmthem = new SqlCommand(themsp, kn);
                cmthem.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi không thêm được");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Close();
            }
        }

       
        string xoachitiet;
        string xoasanpham;
        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Open();
                xoachitiet = "delete chitiethoadon where Ma_sp ='" + txtmasp.Text + "'";
                xoasanpham = "delete Sanpham where Ma_sp ='" + txtmasp.Text + "'";
                SqlCommand cmchitiet = new SqlCommand(xoachitiet, kn);
                SqlCommand cmsanpham = new SqlCommand(xoasanpham, kn);
                cmchitiet.ExecuteNonQuery();
                cmsanpham.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi không xóa được");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Close();
            }
        }

        string sua;
        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Open();
                sua = "update Sanpham set Ten_sp ='" + txttensp.Text + "', Gia = '" + txtgia.Text + "', Ngay_sx = '" + txtngaysx.Text + "', Loai_sp = '" + txtloaisp.Text + "' where Ma_sp = '"+txtmasp.Text+"'";
                SqlCommand cmdsua = new SqlCommand(sua, kn);
                cmdsua.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi không sửa được");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Close();
            }
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