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
    public partial class frmThemDeTai : Form
    {
        GiaoVien giaovien;
        public frmThemDeTai(GiaoVien giaovien)
        {
            InitializeComponent();
            this.giaovien = giaovien;
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtMaDT.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaDT, "Phai nhap Ma De Tai");
                    return;
                }
                else this.errorProvider1.Clear();
                if (this.txtTenDT.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtTenDT, "Phai nhap Ten De Tai");
                    return;
                }
                else this.errorProvider1.Clear();
                if (rtMoTa.Text == "")
                {
                    this.errorProvider1.SetError(this.rtMoTa, "Phai co mo ta");
                    return;
                }
                else this.errorProvider1.Clear();
                if (NgayBatDau.Value < DateTime.Now)
                {
                    this.errorProvider1.SetError(this.NgayBatDau, "Phai nhap thoi gian bat dau lon hon hoac bang thoi gian hien tai");
                    return;
                }
                else this.errorProvider1.Clear();
                if (NgayKetThuc.Value <= NgayBatDau.Value)
                {
                    this.errorProvider1.SetError(this.NgayKetThuc, "Phai nhap ngay ket thuc lon hon ngay bat dau");
                    return;
                }
                else this.errorProvider1.Clear();

                if (rtNhanXet.Text == "")
                {
                    this.errorProvider1.SetError(this.rtNhanXet, "Phai co nhan xet");
                    return;
                }
                else this.errorProvider1.Clear();

                DeTai detai = new DeTai();
                double soTienDo = 0;
                detai.MaDT = txtMaDT.Text;
                detai.TenDT = txtTenDT.Text;
                detai.MoTaDT = rtMoTa.Text;
                detai.NgayBatDau = NgayBatDau.Value;
                detai.NgayKetThuc = NgayKetThuc.Value;
                detai.MaGV = giaovien.MaGV;
                string displaySV = "";
                for (int i = 0; i < lstSV.Items.Count; i++)
                {
                    displaySV = displaySV + this.lstSV.Items[i] + " ";
                    detai.SinhViens.Add(this.lstSV.Items[i] as SinhVien);
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
                detai.NhanXet = rtNhanXet.Text;
                DeTaiController.ThemDT(detai);
                MessageBox.Show("Thêm đề tài thành công");
            }
            catch
            {
                MessageBox.Show(" Vui lòng không nhập trùng mã đề tài", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimSV_TextChanged(object sender, EventArgs e)
        {
            this.lstTimSV.Items.Clear();
            //Tìm sinh viên trong danh sách các sinh viên
            List<SinhVien> searchsv = SinhVienController.danhsachSV(this.txtTimSV.Text.Trim());
            if (searchsv.Count > 0)
            {
                this.lstTimSV.Visible = true;
            }
            else
            {
                this.lstTimSV.Visible = false;
            }
            for (int i = 0; i < searchsv.Count; i++)
            {
                this.lstTimSV.Items.Add(searchsv[i]);
            }
        }

        private void lstTimSV_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstTimSV.SelectedIndex >= 0)
            {
                int n = lstSV.Items.Count;
                int i;
                for (i = 0; i < n; i++)
                    if (lstSV.Items[i].ToString().Trim() == lstTimSV.Items[lstTimSV.SelectedIndex].ToString().Trim())
                        break;
                if (i == n)
                    this.lstSV.Items.Add(this.lstTimSV.SelectedItem);

            }
        }

        private void lstSV_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstSV.SelectedIndex >= 0)
                this.lstSV.Items.RemoveAt(this.lstSV.SelectedIndex);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
