using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDHS
{
    public partial class frm_QuanLyDiem : Form
    {
        public frm_QuanLyDiem()
        {
            InitializeComponent();
        }
        public Boolean Kiemtra(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(name))
                {
                    frm.Focus();
                    return true;
                }
            }
            return false;
        }
        private void mnuHS_Click(object sender, EventArgs e)
        {
            frmHocSinh frm = new frmHocSinh();
            if (Kiemtra("frmHocSinh"))
            {
                frm.Focus();
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuDSHS_Click(object sender, EventArgs e)
        {
            frmDSHS frm = new frmDSHS();
            frm.Show();
        }

        private void mnuKhoiLop_Click(object sender, EventArgs e)
        {
            frm_KhoiLop frm = new frm_KhoiLop();
            if (Kiemtra("frm_KhoiLop"))
            {
                frm.Focus();
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuMH_Click(object sender, EventArgs e)
        {
            frmMonHoc frm = new frmMonHoc();
            if (Kiemtra("frmMonHoc"))
            {
                frm.Focus();
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuGV_Click(object sender, EventArgs e)
        {
            frm_GiaoVien frm = new frm_GiaoVien();
            if (Kiemtra("frm_GiaoVien"))
            {
                frm.Focus();
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuDiem_Click(object sender, EventArgs e)
        {
            frm_Diem frm = new frm_Diem();
            if (Kiemtra("frm_Diem"))
            {
                frm.Focus();
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frm_Lop frm = new frm_Lop();
            if (Kiemtra("frm_Lop"))
            {
                frm.Focus();
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuNamHoc_Click(object sender, EventArgs e)
        {
            frm_NamHoc frm = new frm_NamHoc();
            if (Kiemtra("frm_NamHoc"))
            {
                frm.Focus();
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuHocKy_Click(object sender, EventArgs e)
        {
            frm_HocKy frm = new frm_HocKy();
            if (Kiemtra("frm_HocKy"))
            {
                frm.Focus();
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void frm_QuanLyDiem_Load(object sender, EventArgs e)
        {
            //frm_QuanLyDiem frm = new frm_QuanLyDiem();
            //ActivateMdiChild(frm);
        }

        private void mnuTimHS_Click(object sender, EventArgs e)
        {
            frm_TimKiemHS frm = new frm_TimKiemHS();
            if (Kiemtra("frm_TimKiemHS"))
            {
                frm.Focus();
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuTimGV_Click(object sender, EventArgs e)
        {
            frm_TimGV frm = new frm_TimGV();
            if (Kiemtra("frm_TimGV"))
            {
                frm.Focus();
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuTimLop_Click(object sender, EventArgs e)
        {
            frm_TimLop frm = new frm_TimLop();
            if (Kiemtra("frm_TimLop"))
            {
                frm.Focus();
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuDiemTheoMon_Click(object sender, EventArgs e)
        {
            frm_DSDiem frm = new frm_DSDiem();
            if (Kiemtra("frm_DSDiem"))
            {
                frm.Focus();
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
