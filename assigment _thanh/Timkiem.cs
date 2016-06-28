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
    public partial class formtim : Form
    {
        DataTable dt;
        DataView dv;
        SqlDataAdapter sa;
        public formtim()
        {
            InitializeComponent();
        }

        private void bttim_Load(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=THANH-PC;Initial Catalog=Thanh_assigment;Integrated Security=True");
            sa = new SqlDataAdapter("select * from Khachhang", kn);
            
            dt = new DataTable("Ten_kh");
            
            sa.Fill(dt);
            dv = new DataView(dt);
            dgvhiendulieu.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            dv.RowFilter = "Ten_kh like'"+timkiem+"%'";
            
            dgvhiendulieu.DataSource = dv;
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
