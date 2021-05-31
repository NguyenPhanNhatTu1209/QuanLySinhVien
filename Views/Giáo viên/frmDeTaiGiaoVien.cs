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
    public partial class frmDeTaiGiaoVien : Form
    {
        GiaoVien giaovien;
        public frmDeTaiGiaoVien(GiaoVien giaovien)
        {
            InitializeComponent();
            this.giaovien = giaovien;
            int dem = GiaoVienController.demdetai(this.giaovien.MaGV);
            for (int i = 0; i < dem; i++)
                listDeTai.Items.Add(GiaoVienController.danhsach(this.giaovien.MaGV)[i]);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                frmChiTietDeTai formChiTiet = new frmChiTietDeTai(listDeTai.SelectedItem as DeTai);
                formChiTiet.Show();
            }
            catch
            { }

        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            frmThemDeTai formThemDeTai = new frmThemDeTai(this.giaovien);
            formThemDeTai.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                listDeTai.Items.Clear();
                GiaoVien giaovien1;
                giaovien1 = this.giaovien;
                int dem = GiaoVienController.demdetai(this.giaovien.MaGV);
                for (int i = 0; i < dem; i++)
                    listDeTai.Items.Add(GiaoVienController.danhsach(this.giaovien.MaGV)[i]);
            }
            catch { }
        }
    }
}
