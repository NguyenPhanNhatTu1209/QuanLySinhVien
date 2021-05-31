using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Đồ_án.Controllers;
using Đồ_án.Models;
using Đồ_án.Views;
namespace Đồ_án.Views.Sinh_viên
{
    public partial class frmThongTinSinhVien : Form
    {
        public frmThongTinSinhVien(SinhVien sinhvien)
        {
            InitializeComponent();
            lbMaSV.Text = sinhvien.MaSV;
            lbHoTen.Text = sinhvien.HoTen;
            lbKhoa.Text = sinhvien.Khoa;
            lbLophoc.Text = sinhvien.LopHoc;
            lbNgaySinh.Text = sinhvien.NgaySinh.ToString("dd/MM/yyyy");
            lbGioiTinh.Text = sinhvien.GioiTinh;
            lbDiaChi.Text = sinhvien.DiaChi;
            lbSDT.Text = sinhvien.SDT;
            lbEmail.Text = sinhvien.Email;

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void frmThongTinSinhVien_Load(object sender, EventArgs e)
        {
        }
    }
}
