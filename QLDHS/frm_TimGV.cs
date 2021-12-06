using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDHS
{
    public partial class frm_TimGV : Form
    {
        public frm_TimGV()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source =.; Initial Catalog = QLDHS; Integrated Security = True");
        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dtgv = new DataTable();
            try
            {
                //ket noi
                connect.Open();
                //command
                SqlCommand cmdTimGV = new SqlCommand("sp_LaydsGV", connect);
                cmdTimGV.CommandText = "sp_TimGV";
                cmdTimGV.CommandType = CommandType.StoredProcedure;

                cmdTimGV.Parameters.Add(new SqlParameter("@ma", txtMaGV.Text));

                //khai bao adapter
                SqlDataAdapter dagv = new SqlDataAdapter(cmdTimGV);
                //khai bao datatable

                dagv.Fill(dtgv);
                dgvGiaoVien.DataSource = dtgv;
            }
            catch (Exception)
            {
                MessageBox.Show("Không ket noi duoc");
            }
            finally
            {
                connect.Close();
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtMaGV.Focus();
            dgvGiaoVien.Rows.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
