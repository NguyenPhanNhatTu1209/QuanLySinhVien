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

namespace Đồ_án.Views.Giáo_viên
{
    public partial class frmDoiMatKhauGV : Form
    {
        GiaoVien giaovien;
        public frmDoiMatKhauGV(GiaoVien giaovien)
        {
            InitializeComponent();
            this.giaovien = giaovien;
            txtTaiKhoan.Text = this.giaovien.MaGV;
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
                else if (!GiaoVienController.checkExistGiaoVien(txtTaiKhoan.Text, txtMKCu.Text))
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
                GiaoVien giaovien1 = new GiaoVien();
                giaovien1.MatKhau = txtMKMoi.Text;
                giaovien1.MaGV = giaovien.MaGV;
                giaovien1.HoTen = giaovien.HoTen;
                giaovien1.GioiTinh = giaovien.GioiTinh;
                giaovien1.SDT = giaovien.SDT;
                giaovien1.Email = giaovien.Email;
                giaovien1.DeTais = GiaoVienController.danhsach(giaovien.MaGV);
                GiaoVienController.UpdateGiaoVien(giaovien1);
                MessageBox.Show("Đổi mật khẩu Thành Công");
            }
            catch { }
            
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
    }
}
