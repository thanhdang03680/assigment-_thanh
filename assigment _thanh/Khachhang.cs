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
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Open();//mo ket noi 
                string sql = "select * from Khachhang";
                SqlCommand cmd = new SqlCommand(sql, kn);// thuc thi cac lenh query
                SqlDataAdapter sa = new SqlDataAdapter(cmd);//van chuyen du lieu 
                DataTable dt = new DataTable();//tạo 1 bảng trong he thong
                sa.Fill(dt);//do du lieu vao bang ao
                dgvdulieu.DataSource = dt; //bang ao du lieu do vao datagridview
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối bạn vui lòng liên kết lại");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Close();//dong ket noi
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        int index;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvdulieu.CurrentRow.Index;
            txtmkh.Text = dgvdulieu.Rows[index].Cells[0].Value.ToString();
            txttkh.Text = dgvdulieu.Rows[index].Cells[1].Value.ToString();
            txtdiachi.Text = dgvdulieu.Rows[index].Cells[2].Value.ToString();
            txtsdt.Text = dgvdulieu.Rows[index].Cells[3].Value.ToString();
            txtemail.Text = dgvdulieu.Rows[index].Cells[4].Value.ToString();
            txtmhd.Text = dgvdulieu.Rows[index].Cells[5].Value.ToString();

            //click vào hiển thị trên o chi tiet
        }     
        string them;
        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Open();//mo ket noi
                them = "insert into Khachhang VALUES('"+txtmkh.Text+"','"+txttkh.Text+"','"+txtdiachi.Text+"','"+txtsdt.Text+"','"+txtemail.Text+"','"+txtmhd.Text+"')";
                SqlCommand cmthem = new SqlCommand(them, kn);   
                cmthem.ExecuteNonQuery();
                ketnoi();
            }
            catch 
            {
                MessageBox.Show("Không thêm được");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Close();//mo ket noi
            }
        }

        string xoahoadon;
        string xoakhachhang;
        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Open();//mo ket noi
                 xoahoadon = "delete hoadon where Ma_hd = '" + txtmhd.Text + "'";
                 xoakhachhang = "delete Khachhang where Ma_hd = '" + txtmhd.Text + "'";
                SqlCommand cmd = new SqlCommand(xoahoadon, kn);
                SqlCommand cmk = new SqlCommand(xoakhachhang, kn);
                cmd.ExecuteNonQuery();
                cmk.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Xóa không thành công");

            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Close();//mo ket noi
            }
        }

        string sua;
        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Open();//mo ket noi
                sua = "update Khachhang set Ten_kh ='" + txttkh.Text + "', Diachi = '" + txtdiachi.Text + "', Sdt = '" + txtsdt.Text + "', Email = '" + txtemail.Text + "', Ma_hd = '" + txtmhd.Text + "' where Ma_kh = '" + txtmkh.Text + "'";
                SqlCommand cms = new SqlCommand(sua, kn);
                cms.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"workstation id=ThanhAssigment.mssql.somee.com;packet size=4096;user id=thanh03680_SQLLogin_1;pwd=nwvu5pivst;data source=ThanhAssigment.mssql.somee.com;persist security info=False;initial catalog=ThanhAssigment");
                kn.Close();//dong ket noi
                
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
