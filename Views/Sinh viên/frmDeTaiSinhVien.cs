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
using Đồ_án.Controllers;
using Đồ_án.Views;

namespace Đồ_án.Views.Sinh_viên
{
    
    public partial class frmDeTaiSinhVien : Form
    {
        private DeTai detai;
        private int gioketthuc;
        private GiaoVien giaovien;
        private string masinhvien;
        public frmDeTaiSinhVien(SinhVien sinhvien)
        {

            InitializeComponent();

            masinhvien = sinhvien.MaSV;
            this.detai = SinhVienController.danhsach(sinhvien.MaSV);
            TimeSpan Val = DateTime.Parse(detai.NgayKetThuc.ToString()).Subtract(DateTime.Now);
            gioketthuc = Val.Days * 24 + Val.Hours;
            if (gioketthuc < 0)
            {
                prThoiGian.Value = 0;
            }
            else if (gioketthuc > 720)
            {
                prThoiGian.Value = 720;
            }
            else
            {
                prThoiGian.Value = gioketthuc;
            }
            lbConLai.Text = gioketthuc.ToString() + " Giờ";
            lbMaDT.Text = detai.MaDT;
            lbTenDT.Text = detai.TenDT;
            rtxtMoTa.Text = detai.MoTaDT;
            lbNgayBatDau.Text = detai.NgayBatDau.ToString("dd/MM/yyyy");
            lbNgayKetThuc.Text = detai.NgayKetThuc.ToString("dd/MM/yyyy");
            lbTienDo.Text = detai.TienDoDT + "%";
            rtxtNhanXet.Text = detai.NhanXet;
            this.giaovien = GiaoVienController.getExistGV(detai.MaGV);
            lbGiaoVienHuongDan.Text = giaovien.MaGV.ToString() + ": " + giaovien.HoTen.ToString();
            prTienDo.Value = int.Parse(detai.TienDoDT.ToString());
            txtUpLoad.Text = detai.FileDeTai;
            int dem = DeTaiController.demsinhvien(sinhvien.MaDT);
            for (int i = 0; i < dem; i++)
                danhsachsinhvien.Text += DeTaiController.danhsach(sinhvien.MaDT)[i].HoTen.ToString() + "\n";
            

        }

        private void frmDeTaiSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbGiaoVienHuongDan_Click(object sender, EventArgs e)
        {

        }

        private void btUpLoad_Click(object sender, EventArgs e)
        {
            
                DeTai detai1 = new DeTai();
                detai1.MaDT = detai.MaDT;
                detai1.MaGV = detai.MaGV;
                detai1.TenDT = detai.TenDT;
                detai1.MoTaDT = detai.MoTaDT;
                detai1.NgayBatDau = detai.NgayBatDau;
                detai1.NgayKetThuc = detai.NgayKetThuc;
                detai1.NhanXet = detai.NhanXet;
                detai1.TienDoDT = detai.TienDoDT;
                detai1.FileDeTai = txtUpLoad.Text;
                detai1.SinhViens = DeTaiController.danhsach(detai.MaDT);
                DeTaiController.UpdateDeTai(detai1);
                MessageBox.Show("Upload Thành Công");
            
        }
        
        private void txtUpLoad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
