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
    public partial class frm_TimKiemHS : Form
    {
        public frm_TimKiemHS()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source =.; Initial Catalog = QLDHS; Integrated Security = True");
        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dths = new DataTable();
            try
            {
                //ket noi
                connect.Open();
                //command
                SqlCommand cmdTimHS = new SqlCommand("sp_LaydsHS", connect);
                cmdTimHS.CommandText = "sp_TimHS";
                cmdTimHS.CommandType = CommandType.StoredProcedure;

                cmdTimHS.Parameters.Add(new SqlParameter("@mahs", txtMaHS.Text));

                //khai bao adapter
                SqlDataAdapter dahs = new SqlDataAdapter(cmdTimHS);
                //khai bao datatable

                dahs.Fill(dths);
                dgvHocSinh.DataSource = dths;
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
            txtMaHS.Clear();
            txtMaHS.Focus();
            dgvHocSinh.ClearSelection();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
