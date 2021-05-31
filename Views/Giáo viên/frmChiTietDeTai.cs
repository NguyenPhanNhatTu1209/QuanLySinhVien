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
    public partial class frmChiTietDeTai : Form
    {
        private int gioketthuc;
        DeTai detai1;
        public frmChiTietDeTai(DeTai detai)
        {
            try
            {
                InitializeComponent();
                this.detai1 = detai;
                timer1.Start();
                TimeSpan Val = DateTime.Parse(detai.NgayKetThuc.ToString()).Subtract(DateTime.Now);
                gioketthuc = Val.Days * 24 + Val.Hours;
                lbConLai.Text = gioketthuc.ToString() + " Giờ";
                lbMaDT.Text = detai.MaDT;
                txtTenDT.Text = detai.TenDT;
                txtMoTa.Text = detai.MoTaDT;
                NgayBatDau.Value = detai.NgayBatDau;
                NgayKetThuc.Value = detai.NgayKetThuc;
                txtTienDo.Text = detai.TienDoDT.ToString();
                rtxtNhanXet.Text = detai.NhanXet;
                txtUpLoad.Text = detai.FileDeTai;
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

                if (detai.TienDoDT == 25)
                {
                    checkTienDo1.Checked = true;
                }
                else if (detai.TienDoDT == 50)
                {
                    checkTienDo1.Checked = true;
                    checkTienDo2.Checked = true;

                }
                else if (detai.TienDoDT == 75)
                {
                    checkTienDo1.Checked = true;
                    checkTienDo2.Checked = true;
                    checkTienDo3.Checked = true;
                }
                else if (detai.TienDoDT == 100)
                {
                    checkTienDo1.Checked = true;
                    checkTienDo2.Checked = true;
                    checkTienDo3.Checked = true;
                    checkTienDo4.Checked = true;
                }
                prTienDo.Value = int.Parse(detai.TienDoDT.ToString());
                lbGiaoVienHuongDan.Text = detai.GiaoVien.MaGV.ToString() + ": " + detai.GiaoVien.HoTen.ToString();
                int dem = DeTaiController.demsinhvien(detai.MaDT);
                for (int i = 0; i < dem; i++)
                    listSinhVien.Items.Add(DeTaiController.danhsach(detai.MaDT)[i]);

            }
            catch
            {

            }

        }

        private void frmChiTietDeTai_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.listSearchSinhVien.Items.Clear();
            //Tìm sinh viên trong danh sách các sinh viên
            List<SinhVien> searchsv = SinhVienController.danhsachSV(this.txtSearch.Text.Trim());
            if (searchsv.Count > 0)
            {
                this.listSearchSinhVien.Visible = true;
            }
            else
            {
                this.listSearchSinhVien.Visible = false;
            }
            for (int i = 0; i < searchsv.Count; i++)
            {
                this.listSearchSinhVien.Items.Add(searchsv[i]);
            }
        }

        private void listSearchSinhVien_DoubleClick(object sender, EventArgs e)
        {
            if (this.listSearchSinhVien.SelectedIndex >= 0)
            {
                int n = listSinhVien.Items.Count;
                int i;
                for (i = 0; i < n; i++)
                    if (listSinhVien.Items[i].ToString().Trim() == listSearchSinhVien.Items[listSearchSinhVien.SelectedIndex].ToString().Trim())
                        break;
                if (i == n)
                    this.listSinhVien.Items.Add(this.listSearchSinhVien.SelectedItem);

            }
        }

        private void listSinhVien_DoubleClick(object sender, EventArgs e)
        {
            if (this.listSinhVien.SelectedIndex >= 0)
                this.listSinhVien.Items.RemoveAt(this.listSinhVien.SelectedIndex);
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            try
            {

                

                if (this.txtTenDT.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtTenDT, "Phai nhap Ten De Tai");
                    return;
                }
                else this.errorProvider1.Clear();
                if (txtMoTa.Text == "")
                {
                    this.errorProvider1.SetError(this.txtMoTa, "Phai co mo ta");
                    return;
                }
                else this.errorProvider1.Clear();
                
                if (NgayKetThuc.Value <= NgayBatDau.Value)
                {
                    this.errorProvider1.SetError(this.NgayKetThuc, "Phai nhap ngay ket thuc lon hon ngay bat dau");
                    return;
                }
                else this.errorProvider1.Clear();

                if (rtxtNhanXet.Text == "")
                {
                    this.errorProvider1.SetError(this.rtxtNhanXet, "Phai co nhan xet");
                    return;
                }
                else this.errorProvider1.Clear();
                
                double soTienDo = 0;
                DeTai detai = new DeTai();
                detai.MaDT = lbMaDT.Text;
                detai.TenDT = txtTenDT.Text;
                detai.MoTaDT = txtMoTa.Text;
                detai.NgayBatDau = NgayBatDau.Value;
                detai.NgayKetThuc = NgayKetThuc.Value;
                detai.FileDeTai = txtUpLoad.Text;
                detai.MaGV = detai1.MaGV;

                string displaySV = "";
                for (int i = 0; i < listSinhVien.Items.Count; i++)
                {
                    displaySV = displaySV + this.listSinhVien.Items[i] + " ";
                    detai.SinhViens.Add(this.listSinhVien.Items[i] as SinhVien);
                }

                if (checkTienDo1.Checked == true)
                {

                    soTienDo = soTienDo + 25;

                }
                if (checkTienDo2.Checked == true && checkTienDo1.Checked == true)
                {
                    soTienDo = 50;
                }
                if (checkTienDo3.Checked == true && checkTienDo2.Checked == true && checkTienDo1.Checked == true)
                {
                    soTienDo = 75;
                }
                if (checkTienDo4.Checked == true && checkTienDo2.Checked == true && checkTienDo1.Checked == true)
                {
                    soTienDo = 100;
                }

                detai.TienDoDT = soTienDo;
                txtTienDo.Text = soTienDo.ToString();
                detai.NhanXet = rtxtNhanXet.Text;
                DeTaiController.UpdateDeTai(detai);
                MessageBox.Show("Lưu Thành Công");

            }
            catch { }

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                TimeSpan Val = NgayKetThuc.Value.Subtract(DateTime.Now);
                gioketthuc = Val.Days * 24 + Val.Hours;
                lbConLai.Text = gioketthuc.ToString() + " Giờ";
                prThoiGian.Value = gioketthuc;
                prTienDo.Value = int.Parse(txtTienDo.Text);
            }
            catch { }
        }

        private void frmChiTietDeTai_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkTienDo1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTienDo1.Checked == true)
                checkTienDo2.Enabled = true;
            else
            {
                checkTienDo2.Checked = false;
                checkTienDo2.Enabled = false;
            }                
        }

        private void checkTienDo2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTienDo2.Checked == true)
                checkTienDo3.Enabled = true;
            else
            {
                checkTienDo3.Checked = false;
                checkTienDo3.Enabled = false;
            }
        }

        private void checkTienDo3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTienDo3.Checked == true)
                checkTienDo4.Enabled = true;
            else
            {
                checkTienDo4.Checked = false;
                checkTienDo4.Enabled = false;
            }
        }
    }
}
