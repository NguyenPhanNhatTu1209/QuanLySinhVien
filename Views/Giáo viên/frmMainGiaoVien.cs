using Đồ_án.Models;
using Đồ_án.Views.Sinh_viên;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án.Views.Giáo_viên
{
    public partial class frmMainGiaoVien : Form
    {
        frmThongTinGiaoVien formThongTinGiaoVien;
        frmDeTaiGiaoVien formDeTai;
        GiaoVien giaovien;
        frmDoiMatKhauGV formDoiMatKhau;
        public frmMainGiaoVien(GiaoVien giaovien)
        {
            InitializeComponent();
            this.giaovien = giaovien;
        }

        

        private void thôngTinGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formThongTinGiaoVien is null || this.formThongTinGiaoVien.IsDisposed)
            {
                this.formThongTinGiaoVien = new frmThongTinGiaoVien(giaovien);
                this.formThongTinGiaoVien.MdiParent = this;
                this.formThongTinGiaoVien.Show();
            }
            else
            {
                this.formThongTinGiaoVien.Select();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab != null && this.tabControl1.SelectedTab.Tag != null)
            {
                (this.tabControl1.SelectedTab.Tag as Form).Select();
            }
        }

        private void đềTàiGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formDeTai is null || this.formDeTai.IsDisposed)
            {
                this.formDeTai = new frmDeTaiGiaoVien(giaovien);
                this.formDeTai.MdiParent = this;
                this.formDeTai.Show();
            }
            else
            {
                this.formDeTai.Select();
            }
        }

        private void frmMainGiaoVien_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if (this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabControl1;
                this.tabControl1.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formDoiMatKhau is null || this.formDoiMatKhau.IsDisposed)
            {
                this.formDoiMatKhau = new frmDoiMatKhauGV(this.giaovien);
                this.formDoiMatKhau.MdiParent = this;
                this.formDoiMatKhau.Show();
            }
            else
            {
                this.formDoiMatKhau.Select();
            }
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin formdangnhap = new frmLogin();
            formdangnhap.Show();
        }
    }
}
