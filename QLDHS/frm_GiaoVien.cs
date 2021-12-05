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
    public partial class frm_GiaoVien : Form
    {
        public frm_GiaoVien()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source =.; Initial Catalog = QLDHS; Integrated Security = True");

        private void frm_GiaoVien_Load(object sender, EventArgs e)
        {
            LoadFrmGV();
            cboMaKL.DataSource = LoadFrmKL();
            cboMaKL.DisplayMember = "TENKL";
            cboMaKL.ValueMember = "MAKL";
        }
        public void LoadFrmGV()
        {
            try
            {
                //ket noi
                connect.Open();
                //command
                SqlCommand com = new SqlCommand("sp_LaydsGV", connect);
                com.CommandText = "sp_LaydsGV";
                com.CommandType = CommandType.StoredProcedure;

                //khai bao adapter
                SqlDataAdapter dagv = new SqlDataAdapter(com);
                //khai bao datatable
                DataTable dtgv = new DataTable();

                dagv.Fill(dtgv);
                //dua du lieu vao datagrid
                dgvGV.DataSource = dtgv;
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
        public DataTable LoadFrmKL()
        {
            DataTable dtkl = new DataTable();
            try
            {
                //ket noi
                connect.Open();
                //command
                SqlCommand com = new SqlCommand("sp_LaydsKL", connect);
                com.CommandText = "sp_LaydsKL";
                com.CommandType = CommandType.StoredProcedure;

                //khai bao adapter
                SqlDataAdapter dakl = new SqlDataAdapter(com);
                //khai bao datatable

                dakl.Fill(dtkl);
            }
            catch (Exception)
            {
                MessageBox.Show("Không ket noi duoc");
            }
            finally
            {
                connect.Close();
            }
            return dtkl;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmdthemgv = new SqlCommand();
                cmdthemgv.CommandType = CommandType.StoredProcedure;
                cmdthemgv.CommandText = "sp_ThemGV";
                cmdthemgv.Connection = connect;

                //them cac tham so
                cmdthemgv.Parameters.Add(new SqlParameter("@ma", txtMaGV.Text));
                cmdthemgv.Parameters.Add(new SqlParameter("@hoten", txtHoTen.Text));
                cmdthemgv.Parameters.Add(new SqlParameter("@diachi", txtDiaChi.Text));
                cmdthemgv.Parameters.Add(new SqlParameter("@makl", cboMaKL.SelectedValue.ToString()));

                //thucthi
                if (cmdthemgv.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them khong thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them khong duoc" + ex);
            }
            finally
            {
                connect.Close();
                LoadFrmGV();
            }
        }

        private void dgvGV_Click(object sender, EventArgs e)
        {
            int dong = dgvGV.CurrentCell.RowIndex;
            txtMaGV.Text = dgvGV.Rows[dong].Cells[0].Value.ToString();
            txtHoTen.Text = dgvGV.Rows[dong].Cells[0].Value.ToString();
            txtDiaChi.Text = dgvGV.Rows[dong].Cells[0].Value.ToString();
            cboMaKL.Text = dgvGV.Rows[dong].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("ban co muon xoa khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (kq == DialogResult.Yes)
                {
                    connect.Open();
                    SqlCommand cmdxoagv = new SqlCommand();
                    cmdxoagv.CommandType = CommandType.StoredProcedure;
                    cmdxoagv.CommandText = "sp_XoaGV";
                    cmdxoagv.Connection = connect;

                    cmdxoagv.Parameters.Add(new SqlParameter("@magv", txtMaGV.Text));

                    if (cmdxoagv.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Ban da xoa thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Ban da xoa khong thanh cong");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex);
            }
            finally
            {
                connect.Close();
                LoadFrmGV();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("ban co muon sua khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (kq == DialogResult.Yes)
                {
                    connect.Open();
                    SqlCommand cmdsuagv = new SqlCommand();
                    cmdsuagv.CommandType = CommandType.StoredProcedure;
                    cmdsuagv.CommandText = "sp_SuaGV";
                    cmdsuagv.Connection = connect;

                    cmdsuagv.Parameters.Add(new SqlParameter("@ma", txtMaGV.Text));
                    cmdsuagv.Parameters.Add(new SqlParameter("@hoten", txtHoTen.Text));
                    cmdsuagv.Parameters.Add(new SqlParameter("@diachi", txtDiaChi.Text));

                    SqlParameter para = new SqlParameter("@makl", cboMaKL.SelectedValue.ToString());

                    cmdsuagv.Parameters.Add(para);

                    if (cmdsuagv.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Ban da sua thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Ban da sua khong thanh cong");
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connect.Close();
                LoadFrmGV();
            }
        }
    }
}
