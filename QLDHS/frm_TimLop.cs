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
    public partial class frm_TimLop : Form
    {
        public frm_TimLop()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source =.; Initial Catalog = QLDHS; Integrated Security = True");
        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dtlop = new DataTable();
            try
            {
                //ket noi
                connect.Open();
                //command
                SqlCommand cmdTimLop = new SqlCommand("sp_LaydsLOP", connect);
                cmdTimLop.CommandText = "sp_TimLOP";
                cmdTimLop.CommandType = CommandType.StoredProcedure;

                cmdTimLop.Parameters.Add(new SqlParameter("@malop", txtMaLop.Text));

                //khai bao adapter
                SqlDataAdapter dalop = new SqlDataAdapter(cmdTimLop);
                //khai bao datatable

                dalop.Fill(dtlop);
                dgvLop.DataSource = dtlop;
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
            txtMaLop.Clear();
            txtMaLop.Focus();
            dgvLop.Rows.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
