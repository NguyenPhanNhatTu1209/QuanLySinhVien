using Đồ_án.Controllers;
using Đồ_án.Models;
using Đồ_án.Views.Giáo_viên;
using Đồ_án.Views.Sinh_viên;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            ckGiaoVien.Checked = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ckGiaoVien.Checked == true)
            {
                if (GiaoVienController.checkExistGiaoVien(txtUsername.Text, txtPassword.Text) == false)
                {
                    lblErr.Text = "";
                    lblErr.Text += "!Tài khoản không tồn tại";
                    txtPassword.Clear();
                }
                else
                {
                    this.Hide();

                    GiaoVien giaovien = new GiaoVien();
                    giaovien = GiaoVienController.getExistGV(txtUsername.Text);
                    frmMainGiaoVien formGiaoVien = new frmMainGiaoVien(giaovien);
                    formGiaoVien.Show();
                }

            }
            else if (ckSinhVien.Checked == true)
            {
                if (SinhVienController.checkExistSV(txtUsername.Text, txtPassword.Text) == false)
                {
                    lblErr.Text = "";
                    lblErr.Text += "!Tài khoản không tồn tại";
                    txtPassword.Clear();
                }
                else
                {
                    this.Hide();
                    SinhVien sinhvien = new SinhVien();
                    sinhvien = SinhVienController.getExistSV(txtUsername.Text);
                    frmMainSinhVien formSinhVien = new frmMainSinhVien(sinhvien);
                    formSinhVien.Show();
                }
            } 
            else
            {
                if (LoginController.checkExistLanhDao(txtUsername.Text, txtPassword.Text) == false)
                {
                    lblErr.Text = "";
                    lblErr.Text += "!Tài khoản không tồn tại";
                    txtPassword.Clear();
                }
                else
                {
                    this.Hide();
                    frmMainGUI formLanhDao = new frmMainGUI();
                    formLanhDao.Show();
                }
                
            }                
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void ckSinhVien_Click(object sender, EventArgs e)
        {
            if (ckSinhVien.Checked == true)
            {
                ckGiaoVien.Checked = false;
                ckLanhDao.Checked = false;
            }
            else ckLanhDao.Checked = true;
        }

        private void ckLanhDao_Click(object sender, EventArgs e)
        {
            if (ckLanhDao.Checked == true)
            {
                ckGiaoVien.Checked = false;
                ckSinhVien.Checked = false;
            }
            else ckGiaoVien.Checked = true;
        }

        private void ckGiaoVien_Click(object sender, EventArgs e)
        {
            if (ckGiaoVien.Checked == true)
            {
                ckSinhVien.Checked = false;
                ckLanhDao.Checked = false;
            }
            else ckSinhVien.Checked = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
