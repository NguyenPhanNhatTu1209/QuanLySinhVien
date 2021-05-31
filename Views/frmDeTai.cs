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
    public partial class frmDeTai : Form
    {
        public frmDeTai()
        {
            InitializeComponent();
            this.listDeTai.Items.Clear();
            displayDeTai();
           
        }
        private void displayDeTai()
        {
            string displaysinhvien = "";
            List<DeTai> lstdt = DeTaiController.danhsachDT();
            foreach (DeTai detai in lstdt)
            {
                displaysinhvien = "";
                foreach (SinhVien u in detai.SinhViens)
                {
                    displaysinhvien = displaysinhvien + u + ", ";
                }
                ListViewItem dt = new ListViewItem(detai.MaDT);
                dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TenDT));
                dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MoTaDT));
                dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayBatDau.ToString("dd/MM/yyyy")));
                dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayKetThuc.ToString("dd/MM/yyyy")));                
                dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TienDoDT.ToString()));
                dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, displaysinhvien));
                dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MaGV));
                dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, GiaoVienController.getExistGV(detai.MaGV).HoTen));
                dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NhanXet));
                dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.FileDeTai));

                this.listDeTai.Items.Add(dt);
            }



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
                if (NgayBatDau.Value <= DateTime.Now)
                {
                    this.errorProvider1.SetError(this.NgayBatDau, "Phai nhap thoi gian bat dau lon hon thoi gian hien tai");
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
                    this.errorProvider1.SetError(this.rtNhanXet, "Phai co nhan xet" );
                    return;
                }
                else this.errorProvider1.Clear();
                if (cbGV.Text == "")
                {
                    this.errorProvider1.SetError(this.rtNhanXet, "Phai co Giao Vien");
                    return;
                }
                else this.errorProvider1.Clear();
                DeTai detai = new DeTai();
                detai.MaDT = txtMaDT.Text;
                double soTienDo = 0;
                detai.TenDT = txtTenDT.Text;
                detai.MoTaDT = rtMoTa.Text;
                detai.NgayBatDau = NgayBatDau.Value;
                detai.NgayKetThuc = NgayKetThuc.Value;
                detai.MaGV = cbGV.Text;
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
                listDeTai.Items.Clear();
                displayDeTai();
            }
            catch
            {
                MessageBox.Show("Vui lòng không nhập trùng mã đề tài", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void listDeTai_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtMaDT.Text = this.listDeTai.SelectedItems[0].SubItems[0].Text.Trim();
                this.txtTenDT.Text = this.listDeTai.SelectedItems[0].SubItems[1].Text.Trim();
                this.rtMoTa.Text = this.listDeTai.SelectedItems[0].SubItems[2].Text.Trim();
                this.NgayBatDau.Value = DateTime.Parse(this.listDeTai.SelectedItems[0].SubItems[3].Text.Trim());
                this.NgayKetThuc.Value = DateTime.Parse(this.listDeTai.SelectedItems[0].SubItems[4].Text.Trim());
                this.txtTienDo.Text = this.listDeTai.SelectedItems[0].SubItems[5].Text.Trim();
                //hiển thị lại trên listsinhvien
                lstSV.Items.Clear();
                if (DeTaiController.checkExistDeTai(listDeTai.SelectedItems[0].SubItems[0].Text))
                {

                    int dem = DeTaiController.demsinhvien(listDeTai.SelectedItems[0].SubItems[0].Text.Trim());
                    for (int i = 0; i < dem; i++)
                        lstSV.Items.Add(DeTaiController.danhsach(listDeTai.SelectedItems[0].SubItems[0].Text.Trim())[i]);
                }

                this.cbGV.Text = this.listDeTai.SelectedItems[0].SubItems[7].Text.Trim();
                this.rtNhanXet.Text = this.listDeTai.SelectedItems[0].SubItems[9].Text.Trim();
                checkTienDo1.Checked = false;
                checkTienDo2.Checked = false;
                checkTienDo3.Checked = false;
                checkTienDo4.Checked = false;
                if (int.Parse(txtTienDo.Text) == 25)
                {
                    checkTienDo1.Checked = true;
                }
                else if (int.Parse(txtTienDo.Text) == 50)
                {
                    checkTienDo1.Checked = true;
                    checkTienDo2.Checked = true;

                }
                else if (int.Parse(txtTienDo.Text) == 75)
                {
                    checkTienDo1.Checked = true;
                    checkTienDo2.Checked = true;
                    checkTienDo3.Checked = true;
                }
                else if (int.Parse(txtTienDo.Text) == 100)
                {
                    checkTienDo1.Checked = true;
                    checkTienDo2.Checked = true;
                    checkTienDo3.Checked = true;
                    checkTienDo4.Checked = true;
                }

            }
            catch { }
        }

        private void frmDeTai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doanLTW_GiaoVien.GiaoVien' table. You can move, or remove it, as needed.

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
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
                if (cbGV.Text == "")
                {
                    this.errorProvider1.SetError(this.rtNhanXet, "Phai co Giao Vien");
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
                detai.MaGV = cbGV.Text;
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
                if (DeTaiController.checkExistDeTai(detai.MaDT))
                {
                    DeTaiController.UpdateDeTai(detai);
                }
                else
                {
                    MessageBox.Show("Vui lòng không sửa Mã đề tài", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                listDeTai.Items.Clear();
                displayDeTai();
            }

            catch
            {
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DeTai detai = DeTaiController.getExistDT(listDeTai.SelectedItems[0].SubItems[0].Text.Trim());
                this.listDeTai.SelectedItems[0].Remove();
                DeTaiController.DeleteDeTai(detai);

            }
            catch { }
        }

        private void txtTimMaDT_TextChanged(object sender, EventArgs e)
        {
            if (check.Checked == true)
            {
                listDeTai.Items.Clear();
                string displaysinhvien = "";
                List<DeTai> lstdt = DeTaiController.TimKiemDeTaiKhiCoCheck(txtTimMaDT.Text, txtTimTenDT.Text);
                foreach (DeTai detai in lstdt)
                {
                    displaysinhvien = "";
                    foreach (SinhVien u in detai.SinhViens)
                    {
                        displaysinhvien = displaysinhvien + u + ", ";
                    }
                    ListViewItem dt = new ListViewItem(detai.MaDT);
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TenDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MoTaDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayBatDau.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayKetThuc.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TienDoDT.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, displaysinhvien));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MaGV));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MaGV));

                    this.listDeTai.Items.Add(dt);
                }
            }
            else
            {
                listDeTai.Items.Clear();
                string displaysinhvien = "";
                List<DeTai> lstdt = DeTaiController.TimKiemDeTaiKhiKhongCheck(txtTimMaDT.Text, txtTimTenDT.Text);
                foreach (DeTai detai in lstdt)
                {
                    displaysinhvien = "";
                    foreach (SinhVien u in detai.SinhViens)
                    {
                        displaysinhvien = displaysinhvien + u + ", ";
                    }
                    ListViewItem dt = new ListViewItem(detai.MaDT);
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TenDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MoTaDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayBatDau.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayKetThuc.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TienDoDT.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, displaysinhvien));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MaGV));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, GiaoVienController.getExistGV(detai.MaGV).HoTen));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NhanXet));
                    this.listDeTai.Items.Add(dt);
                }
            }
        }

        private void txtTimTenDT_TextChanged(object sender, EventArgs e)
        {
             if (check.Checked == true)
            {
                listDeTai.Items.Clear();
                string displaysinhvien = "";
                List<DeTai> lstdt = DeTaiController.TimKiemDeTaiKhiCoCheck(txtTimMaDT.Text, txtTimTenDT.Text);
                foreach (DeTai detai in lstdt)
                {
                    displaysinhvien = "";
                    foreach (SinhVien u in detai.SinhViens)
                    {
                        displaysinhvien = displaysinhvien + u + ", ";
                    }
                    ListViewItem dt = new ListViewItem(detai.MaDT);
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TenDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MoTaDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayBatDau.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayKetThuc.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TienDoDT.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, displaysinhvien));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MaGV));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, GiaoVienController.getExistGV(detai.MaGV).HoTen));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NhanXet));
                    this.listDeTai.Items.Add(dt);
                }
            }
            else
            {
                listDeTai.Items.Clear();
                string displaysinhvien = "";
                List<DeTai> lstdt = DeTaiController.TimKiemDeTaiKhiKhongCheck(txtTimMaDT.Text, txtTimTenDT.Text);
                foreach (DeTai detai in lstdt)
                {
                    displaysinhvien = "";
                    foreach (SinhVien u in detai.SinhViens)
                    {
                        displaysinhvien = displaysinhvien + u + ", ";
                    }
                    ListViewItem dt = new ListViewItem(detai.MaDT);
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TenDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MoTaDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayBatDau.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayKetThuc.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TienDoDT.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, displaysinhvien));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MaGV));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, GiaoVienController.getExistGV(detai.MaGV).HoTen));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NhanXet));
                    this.listDeTai.Items.Add(dt);
                }
            }
           
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if(check.Checked==true && txtTimMaDT.Text=="" && txtTimTenDT.Text=="" )
            {
                listDeTai.Items.Clear();
                string displaysinhvien = "";
                List<DeTai> lstdt = DeTaiController.danhsachDTKhongCoSinhVien();
                foreach (DeTai detai in lstdt)
                {
                    displaysinhvien = "";
                    foreach (SinhVien u in detai.SinhViens)
                    {
                        displaysinhvien = displaysinhvien + u + ", ";
                    }
                    ListViewItem dt = new ListViewItem(detai.MaDT);
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TenDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MoTaDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayBatDau.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayKetThuc.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TienDoDT.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, displaysinhvien));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MaGV));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, GiaoVienController.getExistGV(detai.MaGV).HoTen));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NhanXet));
                    this.listDeTai.Items.Add(dt);
                }
            }
            if (check.Checked == false && txtTimMaDT.Text == "" && txtTimTenDT.Text == "")
            {
                listDeTai.Items.Clear();
                string displaysinhvien = "";
                List<DeTai> lstdt = DeTaiController.danhsachDT();
                foreach (DeTai detai in lstdt)
                {
                    displaysinhvien = "";
                    foreach (SinhVien u in detai.SinhViens)
                    {
                        displaysinhvien = displaysinhvien + u + ", ";
                    }
                    ListViewItem dt = new ListViewItem(detai.MaDT);
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TenDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MoTaDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayBatDau.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayKetThuc.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TienDoDT.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, displaysinhvien));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MaGV));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, GiaoVienController.getExistGV(detai.MaGV).HoTen));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NhanXet));
                    this.listDeTai.Items.Add(dt);
                }
            }
            if (check.Checked == true && (txtTimMaDT.Text != "" || txtTimTenDT.Text != ""))
            {
                listDeTai.Items.Clear();
                string displaysinhvien = "";
                List<DeTai> lstdt = DeTaiController.TimKiemDeTaiKhiCoCheck(txtTimMaDT.Text, txtTimTenDT.Text);
                foreach (DeTai detai in lstdt)
                {
                    displaysinhvien = "";
                    foreach (SinhVien u in detai.SinhViens)
                    {
                        displaysinhvien = displaysinhvien + u + ", ";
                    }
                    ListViewItem dt = new ListViewItem(detai.MaDT);
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TenDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MoTaDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayBatDau.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayKetThuc.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TienDoDT.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, displaysinhvien));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MaGV));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, GiaoVienController.getExistGV(detai.MaGV).HoTen));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NhanXet));
                    this.listDeTai.Items.Add(dt);
                }
            }
            if (check.Checked == false && (txtTimMaDT.Text != "" || txtTimTenDT.Text != ""))
            {
                listDeTai.Items.Clear();
                string displaysinhvien = "";
                List<DeTai> lstdt = DeTaiController.TimKiemDeTaiKhiKhongCheck(txtTimMaDT.Text, txtTimTenDT.Text);
                foreach (DeTai detai in lstdt)
                {
                    displaysinhvien = "";
                    foreach (SinhVien u in detai.SinhViens)
                    {
                        displaysinhvien = displaysinhvien + u + ", ";
                    }
                    ListViewItem dt = new ListViewItem(detai.MaDT);
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TenDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MoTaDT));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayBatDau.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NgayKetThuc.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.TienDoDT.ToString()));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, displaysinhvien));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.MaGV));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, GiaoVienController.getExistGV(detai.MaGV).HoTen));
                    dt.SubItems.Add(new ListViewItem.ListViewSubItem(dt, detai.NhanXet));
                    this.listDeTai.Items.Add(dt);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
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
