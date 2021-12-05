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
    public partial class frm_Diem : Form
    {
        public frm_Diem()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source =.; Initial Catalog = QLDHS; Integrated Security = True");
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void LoadFrmDiem()
        {
            try
            {
                //ket noi
                connect.Open();
                //command
                SqlCommand com = new SqlCommand("sp_LaydsDIEM", connect);
                com.CommandText = "sp_LaydsDIEM";
                com.CommandType = CommandType.StoredProcedure;

                //khai bao adapter
                SqlDataAdapter dadiem = new SqlDataAdapter(com);
                //khai bao datatable
                DataTable dtdiem = new DataTable();

                dadiem.Fill(dtdiem);
                //dua du lieu vao datagrid
                dgvDiem.DataSource = dtdiem;
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
        public DataTable LoadFrmHS()
        {
            DataTable dths = new DataTable();
            try
            {
                //ket noi
                connect.Open();
                //command
                SqlCommand com = new SqlCommand("sp_LaydsHS", connect);
                com.CommandText = "sp_LaydsHS";
                com.CommandType = CommandType.StoredProcedure;

                //khai bao adapter
                SqlDataAdapter dahs = new SqlDataAdapter(com);
                //khai bao datatable

                dahs.Fill(dths);
            }
            catch (Exception)
            {
                MessageBox.Show("Không ket noi duoc");
            }
            finally
            {
                connect.Close();
            }
            return dths;
        }
        public DataTable LoadFrmMH()
        {
            DataTable dtmh = new DataTable();
            try
            {
                //ket noi
                connect.Open();
                //command
                SqlCommand com = new SqlCommand("sp_LaydsMH", connect);
                com.CommandText = "sp_LaydsMH";
                com.CommandType = CommandType.StoredProcedure;

                //khai bao adapter
                SqlDataAdapter damh = new SqlDataAdapter(com);
                //khai bao datatable

                damh.Fill(dtmh);
            }
            catch (Exception)
            {
                MessageBox.Show("Không ket noi duoc");
            }
            finally
            {
                connect.Close();
            }
            return dtmh;
        }

        private void frm_Diem_Load(object sender, EventArgs e)
        {
            LoadFrmDiem();
            cboMaHS.DataSource = LoadFrmHS();
            cboMaHS.DisplayMember = "HOTEN";
            cboMaHS.ValueMember = "MAHS";
            cboMaMH.DataSource = LoadFrmMH();
            cboMaMH.DisplayMember = "TENLOP";
            cboMaMH.ValueMember = "MALOP";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmdthemd = new SqlCommand();
                cmdthemd.CommandType = CommandType.StoredProcedure;
                cmdthemd.CommandText = "sp_ThemDIEM";
                cmdthemd.Connection = connect;

                //them cac tham so
                cmdthemd.Parameters.Add(new SqlParameter("@stt", txtSTT.Text));
                cmdthemd.Parameters.Add(new SqlParameter("@mahs", cboMaHS.SelectedValue.ToString()));
                cmdthemd.Parameters.Add(new SqlParameter("@mamh", cboMaMH.SelectedValue.ToString()));
                cmdthemd.Parameters.Add(new SqlParameter("@dmieng", txtDiemM.Text));
                cmdthemd.Parameters.Add(new SqlParameter("@d15p", txtDiem15p.Text));
                cmdthemd.Parameters.Add(new SqlParameter("@d45p", txtDiem45p.Text));
                cmdthemd.Parameters.Add(new SqlParameter("@dthi", txtDiemThi.Text));

                //thucthi
                if (cmdthemd.ExecuteNonQuery() > 0)
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
                LoadFrmDiem();
            }
        }

        private void dgvDiem_Click(object sender, EventArgs e)
        {
            int dong = dgvDiem.CurrentCell.RowIndex;
            txtSTT.Text = dgvDiem.Rows[dong].Cells[0].Value.ToString();
            cboMaHS.Text = dgvDiem.Rows[dong].Cells[1].Value.ToString();
            cboMaMH.Text = dgvDiem.Rows[dong].Cells[2].Value.ToString();
            txtDiemM.Text = dgvDiem.Rows[dong].Cells[3].Value.ToString();
            txtDiem15p.Text = dgvDiem.Rows[dong].Cells[4].Value.ToString();
            txtDiem45p.Text = dgvDiem.Rows[dong].Cells[5].Value.ToString();
            txtDiemThi.Text = dgvDiem.Rows[dong].Cells[6].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("ban co muon xoa khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (kq == DialogResult.Yes)
                {
                    connect.Open();
                    SqlCommand cmdxoad = new SqlCommand();
                    cmdxoad.CommandType = CommandType.StoredProcedure;
                    cmdxoad.CommandText = "sp_XoaDIEM";
                    cmdxoad.Connection = connect;

                    cmdxoad.Parameters.Add(new SqlParameter("@stt", txtSTT.Text));

                    if (cmdxoad.ExecuteNonQuery() > 0)
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
                LoadFrmDiem();
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
                    SqlCommand cmdsuad = new SqlCommand();
                    cmdsuad.CommandType = CommandType.StoredProcedure;
                    cmdsuad.CommandText = "sp_SuaDIEM";
                    cmdsuad.Connection = connect;

                    cmdsuad.Parameters.Add(new SqlParameter("@stt", txtSTT.Text));
                    cmdsuad.Parameters.Add(new SqlParameter("@mahs", cboMaHS.SelectedValue.ToString()));
                    cmdsuad.Parameters.Add(new SqlParameter("@mamh", cboMaMH.SelectedValue.ToString()));
                    cmdsuad.Parameters.Add(new SqlParameter("@dmieng", txtDiemM.Text));
                    cmdsuad.Parameters.Add(new SqlParameter("@d15p", txtDiem15p.Text));
                    cmdsuad.Parameters.Add(new SqlParameter("@d45p", txtDiem45p.Text));

                    SqlParameter para = new SqlParameter("@dthi", txtDiemThi.Text);

                    cmdsuad.Parameters.Add(para);

                    if (cmdsuad.ExecuteNonQuery() > 0)
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
                LoadFrmDiem();
            }
        }
    }
}
