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

namespace Đồ_án.Views
{
    public partial class frmMainGUI : Form
    {
        frmGiaoVien formGiaoVien;
        frmSinhVien formSinhVien;
        public frmDeTai formDeTai;

        public frmMainGUI()
        {
            InitializeComponent();
        }

        private void frmMainGUI_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedTab != null && this.tabMain.SelectedTab.Tag != null)
            {
                (this.tabMain.SelectedTab.Tag as Form).Select();
            }
        }

        private void mGiaoVien_Click(object sender, EventArgs e)
        {
            if(this.formGiaoVien is null || this.formGiaoVien.IsDisposed)
            {
                this.formGiaoVien = new frmGiaoVien();
                this.formGiaoVien.MdiParent = this;
                this.formGiaoVien.Show();
            }
            else
            {
                this.formGiaoVien.Select();
            }
        }

        private void mSinhVien_Click(object sender, EventArgs e)
        {
            if (this.formSinhVien is null || this.formSinhVien.IsDisposed)
            {
                this.formSinhVien = new frmSinhVien();
                this.formSinhVien.MdiParent = this;
                this.formSinhVien.Show();
            }
            else
            {
                this.formSinhVien.Select();
            }
        }
        private void frmMainGUI_MdiChildActivate(object sender, EventArgs e)
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
                tp.Parent = this.tabMain;
                this.tabMain.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }
        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        

        private void mDeTai_Click(object sender, EventArgs e)
        {
            if (this.formDeTai is null || this.formDeTai.IsDisposed)
            {
                this.formDeTai = new frmDeTai();
                this.formDeTai.MdiParent = this;
                this.formDeTai.Show();
            }
            else
            {
                this.formDeTai.Select();
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
