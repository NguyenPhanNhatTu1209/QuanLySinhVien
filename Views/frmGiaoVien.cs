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

namespace Đồ_án.Views
{
    public partial class frmGiaoVien : Form 
    {
        public frmGiaoVien()
        {
            InitializeComponent();
            this.listGiaoVien.Items.Clear();
            displayGiaoVien();

        }
        private void displayGiaoVien()
        {
            string displaydetai = "";
            List<GiaoVien> lstgv = GiaoVienController.danhsachGV();
            foreach (GiaoVien giaovien in lstgv)
            {
                displaydetai = "";
                foreach (DeTai u in giaovien.DeTais)
                {
                    displaydetai = displaydetai + u + ", ";
                }
                ListViewItem gv = new ListViewItem( giaovien.MaGV);
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, giaovien.HoTen));
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, giaovien.GioiTinh));
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, giaovien.SDT));
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, giaovien.Email));
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, displaydetai));

                this.listGiaoVien.Items.Add(gv);
            }
            


        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtMaGV.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaGV, "Phai nhap Ma Giao Vien");
                    return;
                }
                else this.errorProvider1.Clear();
                if (this.txtHoTen.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtHoTen, "Phai nhap Ho Ten");
                    return;
                }
                else this.errorProvider1.Clear();
                if (cbGioiTinh.Text == "")
                {
                    this.errorProvider1.SetError(this.cbGioiTinh, "Phai co Gioi Tinh");
                    return;
                }
                else this.errorProvider1.Clear();
                if (this.txtSDT.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtSDT, "Phai nhap So Dien Thoai");
                    return;
                }
                else this.errorProvider1.Clear();
                if (this.txtEmail.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtEmail, "Phai nhap Email");
                    return;
                }
                else this.errorProvider1.Clear();
                if (this.txtMatKhau.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtEmail, "Phai nhap mat khau");
                    return;
                }
                else this.errorProvider1.Clear();

                GiaoVien giaovien = new GiaoVien();
                giaovien.MaGV = txtMaGV.Text;
                giaovien.HoTen = txtHoTen.Text;
                giaovien.GioiTinh = cbGioiTinh.Text;
                giaovien.SDT = txtSDT.Text;
                giaovien.Email = txtEmail.Text;
                giaovien.MatKhau = txtMatKhau.Text;
                // đề tài
                giaovien.DeTais = new List<DeTai>();
                string displayDT = "";
                for (int i = 0; i < lstDT.Items.Count; i++)
                {
                    displayDT = displayDT + this.lstDT.Items[i] + " ";
                    giaovien.DeTais.Add(this.lstDT.Items[i] as DeTai);
                }
                GiaoVienController.ThemGV(giaovien);
                listGiaoVien.Items.Clear();
                displayGiaoVien();
            }
            catch
            {
                MessageBox.Show("Vui lòng không nhập trùng mã giáo viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                GiaoVien giaovien = GiaoVienController.getExistGV(listGiaoVien.SelectedItems[0].SubItems[0].Text.Trim());
                this.listGiaoVien.SelectedItems[0].Remove();
                GiaoVienController.DeleteGiaoVien(giaovien);
                
            }
            catch { }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstSearchDT_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstSearchDT.SelectedIndex >= 0)
            {
                int n = lstDT.Items.Count;
                int i;
                for (i = 0; i < n; i++)
                    if (lstDT.Items[i].ToString().Trim() == lstSearchDT.Items[lstSearchDT.SelectedIndex].ToString().Trim())
                        break;
                if (i == n)
                    this.lstDT.Items.Add(this.lstSearchDT.SelectedItem);
                
            }
        }

        private void txtSearchDT_TextChanged(object sender, EventArgs e)
        {
            this.lstSearchDT.Items.Clear();
            //Tìm đề tài trong danh sách đề tài
            List<DeTai> searchdt = DeTaiController.danhsachDT(this.txtSearchDT.Text.Trim());
            if (searchdt.Count > 0)
            {
                this.lstSearchDT.Visible = true;
            }
            else
            {
                this.lstSearchDT.Visible = false;
            }
            for (int i = 0; i < searchdt.Count; i++)
            {
                this.lstSearchDT.Items.Add(searchdt[i]);
            }
        }

        private void lstDT_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstDT.SelectedIndex >= 0)
                this.lstDT.Items.RemoveAt(this.lstDT.SelectedIndex);
        }

        private void listGiaoVien_Click(object sender, EventArgs e)
        {
            this.txtMaGV.Text = this.listGiaoVien.SelectedItems[0].SubItems[0].Text.Trim();
            this.txtHoTen.Text = this.listGiaoVien.SelectedItems[0].SubItems[1].Text.Trim();
            this.cbGioiTinh.Text = this.listGiaoVien.SelectedItems[0].SubItems[2].Text.Trim();
            this.txtSDT.Text = this.listGiaoVien.SelectedItems[0].SubItems[3].Text.Trim();
            this.txtEmail.Text = this.listGiaoVien.SelectedItems[0].SubItems[4].Text.Trim();
            //hiển thị lại trên listdetai
            lstDT.Items.Clear();
            if (GiaoVienController.checkExistGiaoVien(listGiaoVien.SelectedItems[0].SubItems[0].Text))
            {

                int dem = GiaoVienController.demdetai(listGiaoVien.SelectedItems[0].SubItems[0].Text.Trim());
                for (int i = 0; i < dem; i++)
                    lstDT.Items.Add(GiaoVienController.danhsach(listGiaoVien.SelectedItems[0].SubItems[0].Text.Trim())[i]);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.txtMaGV.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaGV, "Phai nhap Ma Giao Vien");
                    return;
                }
                else this.errorProvider1.Clear();
                if (this.txtHoTen.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtHoTen, "Phai nhap Ho Ten");
                    return;
                }
                else this.errorProvider1.Clear();
                if (cbGioiTinh.Text == "")
                {
                    this.errorProvider1.SetError(this.cbGioiTinh, "Phai co Gioi Tinh");
                    return;
                }
                else this.errorProvider1.Clear();
                if (this.txtSDT.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtSDT, "Phai nhap So Dien Thoai");
                    return;
                }
                else this.errorProvider1.Clear();
                if (this.txtEmail.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtEmail, "Phai nhap Email");
                    return;
                }
                else this.errorProvider1.Clear();
                if (this.txtMatKhau.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtEmail, "Phai nhap mat khau");
                    return;
                }
                else this.errorProvider1.Clear();
                GiaoVien giaovien = new GiaoVien();
                giaovien.MaGV = txtMaGV.Text;
                giaovien.HoTen = txtHoTen.Text;
                giaovien.GioiTinh = cbGioiTinh.Text;
                giaovien.SDT = txtSDT.Text;
                giaovien.Email = txtEmail.Text;
                giaovien.MatKhau = txtMatKhau.Text;
                // đề tài
                giaovien.DeTais = new List<DeTai>();
                string displayDT = "";
                for (int i = 0; i < lstDT.Items.Count; i++)
                {
                    displayDT = displayDT + this.lstDT.Items[i] + " ";
                    giaovien.DeTais.Add(this.lstDT.Items[i] as DeTai);
                }

                if (GiaoVienController.checkExistGiaoVien(giaovien.MaGV))
                {
                    GiaoVienController.UpdateGiaoVien(giaovien);
                }
                else
                {
                    MessageBox.Show("Vui lòng không sửa Mã giáo viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                listGiaoVien.Items.Clear();
                displayGiaoVien();

            }
            catch { }
            
            
        }

        private void txtTimMaGV_TextChanged(object sender, EventArgs e)
        {
            listGiaoVien.Items.Clear();
            string displaydetai = "";
            List<GiaoVien> lstgv = GiaoVienController.TimKiemGV(txtTimMaGV.Text, txtTimHoTen.Text);
            foreach (GiaoVien giaovien in lstgv)
            {
                displaydetai = "";
                foreach (DeTai u in giaovien.DeTais) 
                {
                    displaydetai = displaydetai + u + " ";
                }
                ListViewItem gv = new ListViewItem(giaovien.MaGV);
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, giaovien.HoTen));
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, giaovien.GioiTinh));
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, giaovien.SDT));
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, giaovien.Email));
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, displaydetai));
                this.listGiaoVien.Items.Add(gv);
            }
        }

        private void txtTimHoTen_TextChanged(object sender, EventArgs e)
        {
            listGiaoVien.Items.Clear();
            string displaydetai = "";
            List<GiaoVien> lstgv = GiaoVienController.TimKiemGV(txtTimMaGV.Text, txtTimHoTen.Text);
            foreach (GiaoVien giaovien in lstgv)
            {
                displaydetai = "";
                foreach (DeTai u in giaovien.DeTais)
                {
                    displaydetai = displaydetai + u + " ";
                }
                ListViewItem gv = new ListViewItem(giaovien.MaGV);
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, giaovien.HoTen));
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, giaovien.GioiTinh));
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, giaovien.SDT));
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, giaovien.Email));
                gv.SubItems.Add(new ListViewItem.ListViewSubItem(gv, displaydetai));
                this.listGiaoVien.Items.Add(gv);
            }
        }
    }
}
