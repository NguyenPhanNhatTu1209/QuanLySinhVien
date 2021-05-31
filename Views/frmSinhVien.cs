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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();

            
            this.listSinhVien.Items.Clear();
            displaySinhVien();
        }
        private void displaySinhVien()
        {
            List<SinhVien> lstsv = SinhVienController.danhsachSV();
            foreach (SinhVien sinhvien in lstsv)
            {
                
                
                ListViewItem sv = new ListViewItem(sinhvien.MaSV);
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.HoTen));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.Khoa));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.LopHoc));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.NgaySinh.ToString()));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.GioiTinh));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.SDT));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.Email));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.DiaChi));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.MaDT));
                this.listSinhVien.Items.Add(sv);
            }



        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtMaSV.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaSV, "Phai nhap Ma Sinh Vien");
                    return;
                }
                else this.errorProvider1.Clear();
                if (this.txtHoTen.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtHoTen, "Phai nhap Ho Ten");
                    return;
                }
                else this.errorProvider1.Clear();
                if (cbKhoa.Text == "")
                {
                    this.errorProvider1.SetError(this.cbKhoa, "Phai co Khoa");
                    return;
                }
                else this.errorProvider1.Clear();
                if (cbLop.Text == "")
                {
                    this.errorProvider1.SetError(this.cbLop, "Phai co Lop");
                    return;
                }
                else this.errorProvider1.Clear();
                if (cbGioiTinh.Text == "")
                {
                    this.errorProvider1.SetError(this.cbGioiTinh, "Phai co Gioi Tinh");
                    return;
                }
                else this.errorProvider1.Clear();
                if (NgaySinh.Value > DateTime.Now)
                {
                    this.errorProvider1.SetError(this.NgaySinh, "Ngay sinh phai be hon thoi gian hien tai");
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
                SinhVien sinhvien = new SinhVien();
                sinhvien.MaSV = txtMaSV.Text;
                sinhvien.HoTen = txtHoTen.Text;
                sinhvien.GioiTinh = cbGioiTinh.Text;
                sinhvien.SDT = txtSDT.Text;
                sinhvien.Khoa = cbKhoa.Text;
                sinhvien.Email = txtEmail.Text;
                sinhvien.LopHoc = cbLop.Text;
                sinhvien.NgaySinh = NgaySinh.Value;
                sinhvien.DiaChi = txtDiaChi.Text;
                sinhvien.MaDT = cbMaDT.Text;
                sinhvien.MatKhau = txtMatKhau.Text;
                if (SinhVienController.ThemSV(sinhvien) == false)
                {
                    MessageBox.Show("Lỗi thêm sinh viên");
                    return;
                }
                this.listSinhVien.Items.Clear();
                displaySinhVien();
            }
            catch
            {
                MessageBox.Show("Vui lòng không nhập trùng mã sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doanLTW_DeTai.DeTai' table. You can move, or remove it, as needed.

        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sinhvien = SinhVienController.getExistSV(listSinhVien.SelectedItems[0].SubItems[0].Text.Trim());
                this.listSinhVien.SelectedItems[0].Remove();
                SinhVienController.Deletesinhvien(sinhvien);

            }
            catch { }
        }

        private void listSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtMaSV.Text = this.listSinhVien.SelectedItems[0].SubItems[0].Text.Trim();
                this.txtHoTen.Text = this.listSinhVien.SelectedItems[0].SubItems[1].Text.Trim();
                this.cbKhoa.Text = this.listSinhVien.SelectedItems[0].SubItems[2].Text.Trim();
                this.cbLop.Text = this.listSinhVien.SelectedItems[0].SubItems[3].Text.Trim();
                this.NgaySinh.Value = DateTime.Parse(this.listSinhVien.SelectedItems[0].SubItems[4].Text.Trim());
                this.cbGioiTinh.Text = this.listSinhVien.SelectedItems[0].SubItems[5].Text.Trim();
                this.txtSDT.Text = this.listSinhVien.SelectedItems[0].SubItems[6].Text.Trim();
                this.txtEmail.Text = this.listSinhVien.SelectedItems[0].SubItems[7].Text.Trim();
                this.txtDiaChi.Text = this.listSinhVien.SelectedItems[0].SubItems[8].Text.Trim();
                this.cbMaDT.Text = this.listSinhVien.SelectedItems[0].SubItems[9].Text.Trim();
            }
            catch { }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtMaSV.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaSV, "Phai nhap Ma Sinh Vien");
                    return;
                }
                else this.errorProvider1.Clear();
                if (this.txtHoTen.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtHoTen, "Phai nhap Ho Ten");
                    return;
                }
                else this.errorProvider1.Clear();
                if (cbKhoa.Text == "")
                {
                    this.errorProvider1.SetError(this.cbKhoa, "Phai co Khoa");
                    return;
                }
                else this.errorProvider1.Clear();
                if (cbLop.Text == "")
                {
                    this.errorProvider1.SetError(this.cbLop, "Phai co Lop");
                    return;
                }
                else this.errorProvider1.Clear();
                if (cbGioiTinh.Text == "")
                {
                    this.errorProvider1.SetError(this.cbGioiTinh, "Phai co Gioi Tinh");
                    return;
                }
                else this.errorProvider1.Clear();
                if (NgaySinh.Value > DateTime.Now)
                {
                    this.errorProvider1.SetError(this.NgaySinh, "Ngay sinh phai be hon thoi gian hien tai");
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
                SinhVien sinhvien = new SinhVien();
                sinhvien.MaSV = txtMaSV.Text;
                sinhvien.HoTen = txtHoTen.Text;
                sinhvien.Khoa = cbKhoa.Text;
                sinhvien.LopHoc = cbLop.Text;
                sinhvien.NgaySinh = NgaySinh.Value;
                sinhvien.GioiTinh = cbGioiTinh.Text;
                sinhvien.SDT = txtSDT.Text;
                sinhvien.Email = txtEmail.Text;
                sinhvien.DiaChi = txtDiaChi.Text;
                sinhvien.MaDT = cbMaDT.Text;
                sinhvien.MatKhau = txtMatKhau.Text;



                if (SinhVienController.checkExistSV(sinhvien.MaSV))
                {
                    SinhVienController.UpdateSinhVien(sinhvien);
                }
                else
                {
                    MessageBox.Show("Vui lòng không sửa Mã sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                listSinhVien.Items.Clear();
                displaySinhVien();
            }

            catch
            {

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtTimMaSV_TextChanged(object sender, EventArgs e)
        {
            listSinhVien.Items.Clear();
            List<SinhVien> lstsv = SinhVienController.TimKiemSV(txtTimMaSV.Text, txtTimHoTen.Text, cbTimKhoa.Text, cbTimLop.Text);
            foreach (SinhVien sinhvien in lstsv)
            {

                ListViewItem sv = new ListViewItem(sinhvien.MaSV);
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.HoTen));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.Khoa));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.LopHoc));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.NgaySinh.ToString()));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.GioiTinh));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.SDT));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.Email));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.DiaChi));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.MaDT));
                this.listSinhVien.Items.Add(sv);
            }
        }

        private void txtTimHoTen_TextChanged(object sender, EventArgs e)
        {
            listSinhVien.Items.Clear();
            List<SinhVien> lstsv = SinhVienController.TimKiemSV(txtTimMaSV.Text,txtTimHoTen.Text,cbTimKhoa.Text,cbTimLop.Text);
            foreach (SinhVien sinhvien in lstsv)
            {
                
                ListViewItem sv = new ListViewItem(sinhvien.MaSV);
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.HoTen));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.Khoa));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.LopHoc));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.NgaySinh.ToString()));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.GioiTinh));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.SDT));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.Email));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.DiaChi));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.MaDT));
                this.listSinhVien.Items.Add(sv);
            }
           
        }

        private void cbTimKhoa_TextChanged(object sender, EventArgs e)
        {
            listSinhVien.Items.Clear();
            List<SinhVien> lstsv = SinhVienController.TimKiemSV(txtTimMaSV.Text, txtTimHoTen.Text, cbTimKhoa.Text, cbTimLop.Text);
            foreach (SinhVien sinhvien in lstsv)
            {

                ListViewItem sv = new ListViewItem(sinhvien.MaSV);
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.HoTen));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.Khoa));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.LopHoc));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.NgaySinh.ToString()));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.GioiTinh));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.SDT));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.Email));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.DiaChi));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.MaDT));
                this.listSinhVien.Items.Add(sv);
            }
        }

        private void cbTimLop_TextChanged(object sender, EventArgs e)
        {
            listSinhVien.Items.Clear();
            List<SinhVien> lstsv = SinhVienController.TimKiemSV(txtTimMaSV.Text, txtTimHoTen.Text, cbTimKhoa.Text, cbTimLop.Text);
            foreach (SinhVien sinhvien in lstsv)
            {

                ListViewItem sv = new ListViewItem(sinhvien.MaSV);
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.HoTen));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.Khoa));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.LopHoc));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.NgaySinh.ToString()));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.GioiTinh));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.SDT));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.Email));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.DiaChi));
                sv.SubItems.Add(new ListViewItem.ListViewSubItem(sv, sinhvien.MaDT));
                this.listSinhVien.Items.Add(sv);
            }
        }
    }
}
