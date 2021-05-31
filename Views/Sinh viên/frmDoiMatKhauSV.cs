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
    public partial class frmDoiMatKhauSV : Form
    {
        SinhVien sinhvien;
        public frmDoiMatKhauSV(SinhVien sinhvien)
        {
            InitializeComponent();
            this.sinhvien = sinhvien;
            txtTaiKhoan.Text = sinhvien.MaSV;
        }

        private void txtMKCu_TextChanged(object sender, EventArgs e)
        {
            txtMKCu.UseSystemPasswordChar = false;

        }

        private void txtMKMoi_TextChanged(object sender, EventArgs e)
        {
            txtMKMoi.UseSystemPasswordChar = false;

        }

        private void txtConfimMk_TextChanged(object sender, EventArgs e)
        {
            txtConfimMk.UseSystemPasswordChar = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMKMoi.Text.Trim() == "")
                {
                    MessageBox.Show(" Mật khẩu không thể rỗng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMKMoi.Text = "";
                    txtConfimMk.Text = "";
                    return;
                }
                else if (!SinhVienController.checkExistSV(txtTaiKhoan.Text, txtMKCu.Text))
                {
                    MessageBox.Show(" Bạn nhập sai mật khẩu cũ hoặc tên đăng nhập không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMKCu.Text = "";
                    txtMKMoi.Text = "";
                    txtConfimMk.Text = "";
                    return;
                }
                else if (txtMKCu.Text == txtMKMoi.Text)
                {
                    MessageBox.Show(" Mật khẩu mới trùng mật khẩu cũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMKCu.Text = "";
                    txtMKMoi.Text = "";
                    txtConfimMk.Text = "";
                    return;
                }
                else if (txtConfimMk.Text != txtMKMoi.Text)
                {
                    MessageBox.Show(" xác nhận mật khẩu mới không trùng khớp với mật khẩu mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfimMk.Text = "";
                    return;
                }
                SinhVien sinhvien1 = new SinhVien();
                sinhvien1.MatKhau = txtMKMoi.Text;
                sinhvien1.MaSV = sinhvien.MaSV;
                sinhvien1.HoTen = sinhvien.HoTen;
                sinhvien1.GioiTinh = sinhvien.GioiTinh;
                sinhvien1.SDT = sinhvien.SDT;
                sinhvien1.Email = sinhvien.Email;
                sinhvien1.LopHoc = sinhvien.LopHoc;
                sinhvien1.Khoa = sinhvien.Khoa;
                sinhvien1.DiaChi = sinhvien.DiaChi;
                sinhvien1.MaDT = sinhvien.MaDT;
                sinhvien1.NgaySinh = sinhvien.NgaySinh;
                SinhVienController.UpdateSinhVien(sinhvien1);
                MessageBox.Show("Đổi mật khẩu Thành Công");
            }
            catch { }
        }
    }
}
