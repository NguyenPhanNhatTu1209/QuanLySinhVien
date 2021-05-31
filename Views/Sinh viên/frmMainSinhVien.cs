using Đồ_án.Controllers;
using Đồ_án.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án.Views.Sinh_viên
{
    public partial class frmMainSinhVien : Form
    {
        frmDeTaiSinhVien formDetai;
        frmThongTinSinhVien formThongTinSinhVien;
        SinhVien sinhvien1;
        frmDoiMatKhauSV formDoiMatKhau;
        public frmMainSinhVien(SinhVien sinhvien)
        {
            InitializeComponent();
            sinhvien1 = sinhvien;
            
        }

        

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formThongTinSinhVien is null || this.formThongTinSinhVien.IsDisposed)
            {
                this.formThongTinSinhVien = new frmThongTinSinhVien(sinhvien1);
                this.formThongTinSinhVien.MdiParent = this;
                this.formThongTinSinhVien.Show();
            }
            else
            {
                this.formThongTinSinhVien.Select();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab != null && this.tabControl1.SelectedTab.Tag != null)
            {
                (this.tabControl1.SelectedTab.Tag as Form).Select();
            }
        }

        private void đềTàiSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formDetai is null || this.formDetai.IsDisposed)
            {
                this.formDetai = new frmDeTaiSinhVien(sinhvien1);
                this.formDetai.MdiParent = this;
                this.formDetai.Show();
            }
            else
            {
                this.formDetai.Select();
            }
        }

        private void frmMainSinhVien_MdiChildActivate(object sender, EventArgs e)
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
                this.formDoiMatKhau = new frmDoiMatKhauSV(sinhvien1);
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
