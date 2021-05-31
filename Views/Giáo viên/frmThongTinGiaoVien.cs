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
    public partial class frmThongTinGiaoVien : Form
    {
        public frmThongTinGiaoVien(GiaoVien giaovien)
        {
            InitializeComponent();
            lbMaGV.Text = giaovien.MaGV;
            lbHoTen.Text = giaovien.HoTen;
            lbGioiTinh.Text = giaovien.GioiTinh;
            lbSDT.Text = giaovien.SDT;
            lbEmail.Text = giaovien.Email;
            
        }

        private void frmThongTinGiaoVien_Load(object sender, EventArgs e)
        {

        }
    }
}
