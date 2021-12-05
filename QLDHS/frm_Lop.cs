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
    public partial class frm_Lop : Form
    {
        public frm_Lop()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=HBNGUYEN-LAPTOP\\SQLEXPRESS;Initial Catalog=QLDHS;Integrated Security=True");
        private void frm_Lop_Load(object sender, EventArgs e)
        {
            LoadfrmLOP();
            cbbMaKL.DataSource = LoadfrmKhoiLop();
            cbbMaKL.DisplayMember = "TENKL";
            cbbMaKL.ValueMember = "MAKL";
            cbbMaNH.DataSource = LoadNamHoc();
            cbbMaNH.DisplayMember = "TENNH";
            cbbMaNH.ValueMember = "MANH";
        }
        private void LoadfrmLOP()
        {
            try
            {
                //ket noi
                connect.Open();
                //command
                SqlCommand com = new SqlCommand("sp_LaydsLOP", connect);
                com.CommandText = "sp_LaydsLOP";
                com.CommandType = CommandType.StoredProcedure;

                //khai bao adapter
                SqlDataAdapter dahk = new SqlDataAdapter(com);
                //khai bao datatable
                DataTable dthk = new DataTable();

                dahk.Fill(dthk);
                dgvLop.DataSource = dthk;
            }
            catch (Exception)
            {
                MessageBox.Show("Không kết nối được");
            }
            finally
            {
                connect.Close();
            }
        }
        private DataTable LoadfrmKhoiLop()
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
                MessageBox.Show("Không kết nối được");
            }
            finally
            {
                connect.Close();
            }
            return dtkl;
        }
        private DataTable LoadNamHoc()
        {
            DataTable dtnh = new DataTable();
            try
            {
             
                //ket noi
                connect.Open();
                //command
                SqlCommand com = new SqlCommand("sp_LaydsNAMHOC", connect);
                com.CommandText = "sp_LaydsNAMHOC";
                com.CommandType = CommandType.StoredProcedure;

                //khai bao adapter
                SqlDataAdapter danh = new SqlDataAdapter(com);
                //khai bao datatable
               

                danh.Fill(dtnh);
            }
            catch (Exception)
            {
                MessageBox.Show("Không ket noi duoc");
            }
            finally
            {
                
                connect.Close();
            }
            return dtnh;
        }

        private void dgvLop_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow  row in dgvLop.SelectedRows)
            {
                txtMaLop.Text = row.Cells[0].Value.ToString();
                txtTenLop.Text = row.Cells[1].Value.ToString();
                cbbMaKL.SelectedValue = row.Cells[2].Value.ToString();
                cbbMaNH.SelectedValue = row.Cells[3].Value.ToString();
                txtSiSo.Text = row.Cells[4].Value.ToString();
            }
        }
        private void ClearDL()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            cbbMaKL.SelectedValue = "";
            cbbMaNH.SelectedValue = "";
            txtSiSo.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmdThemLOp = new SqlCommand();
                cmdThemLOp.CommandType = CommandType.StoredProcedure;
                cmdThemLOp.CommandText = "sp_ThemLOP";
                cmdThemLOp.Connection = connect;

                //them cac tham so
                cmdThemLOp.Parameters.Add(new SqlParameter("@malop", txtMaLop.Text));
                cmdThemLOp.Parameters.Add(new SqlParameter("@ten", txtTenLop.Text));
                cmdThemLOp.Parameters.Add(new SqlParameter("@makl", cbbMaKL.SelectedValue.ToString()));
                cmdThemLOp.Parameters.Add(new SqlParameter("@manh", cbbMaNH.SelectedValue.ToString()));
                cmdThemLOp.Parameters.Add(new SqlParameter("@siso", txtSiSo.Text));

                //thucthi
                if (cmdThemLOp.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không được" + ex);
            }
            finally
            {
                connect.Close();
                LoadfrmLOP();
                ClearDL();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (kq == DialogResult.Yes)
                {
                    connect.Open();
                    SqlCommand cmdthemHK = new SqlCommand();
                    cmdthemHK.CommandType = CommandType.StoredProcedure;
                    cmdthemHK.CommandText = "sp_XoaLOP";
                    cmdthemHK.Connection = connect;

                    //them cac tham so
                    cmdthemHK.Parameters.Add(new SqlParameter("@malop", txtMaLop.Text));

                    //thucthi
                    if (cmdthemHK.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xoá thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Xoá khong thanh cong");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xoá khong duoc" + ex);
            }
            finally
            {
                connect.Close();
                LoadfrmLOP();
                ClearDL();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (kq == DialogResult.Yes)
                {
                    connect.Open();
                    SqlCommand cmdSua = new SqlCommand();
                    cmdSua.CommandType = CommandType.StoredProcedure;
                    cmdSua.CommandText = "sp_SuaLOP";
                    cmdSua.Connection = connect;

                    //them cac tham so
                    cmdSua.Parameters.Add(new SqlParameter("@malop", txtMaLop.Text));
                    cmdSua.Parameters.Add(new SqlParameter("@ten", txtTenLop.Text));
                    cmdSua.Parameters.Add(new SqlParameter("@makl", cbbMaKL.SelectedValue.ToString()));
                    cmdSua.Parameters.Add(new SqlParameter("@manh", cbbMaNH.SelectedValue.ToString()));
                    cmdSua.Parameters.Add(new SqlParameter("@siso", txtSiSo.Text));

                    //thucthi
                    if (cmdSua.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không được" + ex);
            }
            finally
            {
                connect.Close();
                LoadfrmLOP();
                ClearDL();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_Lop_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình hay không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
