namespace Đồ_án.Views
{
    partial class frmDeTai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeTai));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.check = new System.Windows.Forms.CheckBox();
            this.txtTimTenDT = new System.Windows.Forms.TextBox();
            this.ten = new System.Windows.Forms.Label();
            this.txtTimMaDT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkTienDo4 = new System.Windows.Forms.CheckBox();
            this.checkTienDo2 = new System.Windows.Forms.CheckBox();
            this.checkTienDo3 = new System.Windows.Forms.CheckBox();
            this.checkTienDo1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTienDo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtNhanXet = new System.Windows.Forms.RichTextBox();
            this.txtTimSV = new System.Windows.Forms.TextBox();
            this.lstTimSV = new System.Windows.Forms.ListBox();
            this.lstSV = new System.Windows.Forms.ListBox();
            this.NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.rtMoTa = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbGV = new System.Windows.Forms.ComboBox();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenDT = new System.Windows.Forms.TextBox();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listDeTai = new System.Windows.Forms.ListView();
            this.cMaDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTenDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMoTaDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNgayBD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNgayKT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTienDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMaGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTenGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNhanXet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check);
            this.groupBox3.Controls.Add(this.txtTimTenDT);
            this.groupBox3.Controls.Add(this.ten);
            this.groupBox3.Controls.Add(this.txtTimMaDT);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(17, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1160, 63);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.ForeColor = System.Drawing.Color.Black;
            this.check.Location = new System.Drawing.Point(745, 25);
            this.check.Margin = new System.Windows.Forms.Padding(2);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(280, 22);
            this.check.TabIndex = 33;
            this.check.Text = "Đề tài chưa có sinh viên thực hiện";
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // txtTimTenDT
            // 
            this.txtTimTenDT.Location = new System.Drawing.Point(445, 23);
            this.txtTimTenDT.Name = "txtTimTenDT";
            this.txtTimTenDT.Size = new System.Drawing.Size(133, 23);
            this.txtTimTenDT.TabIndex = 31;
            this.txtTimTenDT.TextChanged += new System.EventHandler(this.txtTimTenDT_TextChanged);
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.ForeColor = System.Drawing.Color.Black;
            this.ten.Location = new System.Drawing.Point(368, 25);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(74, 17);
            this.ten.TabIndex = 30;
            this.ten.Text = "Tên đề tài";
            // 
            // txtTimMaDT
            // 
            this.txtTimMaDT.Location = new System.Drawing.Point(130, 23);
            this.txtTimMaDT.Name = "txtTimMaDT";
            this.txtTimMaDT.Size = new System.Drawing.Size(133, 23);
            this.txtTimMaDT.TabIndex = 29;
            this.txtTimMaDT.TextChanged += new System.EventHandler(this.txtTimMaDT_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(32, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Mã đề tài";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1250, 353);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 35);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1250, 311);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 35);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTienDo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rtNhanXet);
            this.groupBox2.Controls.Add(this.txtTimSV);
            this.groupBox2.Controls.Add(this.lstTimSV);
            this.groupBox2.Controls.Add(this.lstSV);
            this.groupBox2.Controls.Add(this.NgayBatDau);
            this.groupBox2.Controls.Add(this.rtMoTa);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.NgayKetThuc);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbGV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTenDT);
            this.groupBox2.Controls.Add(this.txtMaDT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(17, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 548);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkTienDo4);
            this.panel1.Controls.Add(this.checkTienDo2);
            this.panel1.Controls.Add(this.checkTienDo3);
            this.panel1.Controls.Add(this.checkTienDo1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(96, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 78);
            this.panel1.TabIndex = 74;
            // 
            // checkTienDo4
            // 
            this.checkTienDo4.AutoSize = true;
            this.checkTienDo4.Enabled = false;
            this.checkTienDo4.Location = new System.Drawing.Point(7, 56);
            this.checkTienDo4.Name = "checkTienDo4";
            this.checkTienDo4.Size = new System.Drawing.Size(82, 21);
            this.checkTienDo4.TabIndex = 73;
            this.checkTienDo4.Text = "Tiến độ 4";
            this.checkTienDo4.UseVisualStyleBackColor = true;
            // 
            // checkTienDo2
            // 
            this.checkTienDo2.AutoSize = true;
            this.checkTienDo2.Enabled = false;
            this.checkTienDo2.Location = new System.Drawing.Point(7, 21);
            this.checkTienDo2.Name = "checkTienDo2";
            this.checkTienDo2.Size = new System.Drawing.Size(82, 21);
            this.checkTienDo2.TabIndex = 72;
            this.checkTienDo2.Text = "Tiến độ 2";
            this.checkTienDo2.UseVisualStyleBackColor = true;
            this.checkTienDo2.CheckedChanged += new System.EventHandler(this.checkTienDo2_CheckedChanged);
            // 
            // checkTienDo3
            // 
            this.checkTienDo3.AutoSize = true;
            this.checkTienDo3.Enabled = false;
            this.checkTienDo3.Location = new System.Drawing.Point(7, 39);
            this.checkTienDo3.Name = "checkTienDo3";
            this.checkTienDo3.Size = new System.Drawing.Size(82, 21);
            this.checkTienDo3.TabIndex = 74;
            this.checkTienDo3.Text = "Tiến độ 3";
            this.checkTienDo3.UseVisualStyleBackColor = true;
            this.checkTienDo3.CheckedChanged += new System.EventHandler(this.checkTienDo3_CheckedChanged);
            // 
            // checkTienDo1
            // 
            this.checkTienDo1.AutoSize = true;
            this.checkTienDo1.Location = new System.Drawing.Point(7, 3);
            this.checkTienDo1.Name = "checkTienDo1";
            this.checkTienDo1.Size = new System.Drawing.Size(82, 21);
            this.checkTienDo1.TabIndex = 71;
            this.checkTienDo1.Text = "Tiến độ 1";
            this.checkTienDo1.UseVisualStyleBackColor = true;
            this.checkTienDo1.CheckedChanged += new System.EventHandler(this.checkTienDo1_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Tiến độ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(240, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "%";
            // 
            // txtTienDo
            // 
            this.txtTienDo.Location = new System.Drawing.Point(142, 316);
            this.txtTienDo.Name = "txtTienDo";
            this.txtTienDo.ReadOnly = true;
            this.txtTienDo.Size = new System.Drawing.Size(86, 23);
            this.txtTienDo.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Nhận xét";
            // 
            // rtNhanXet
            // 
            this.rtNhanXet.Location = new System.Drawing.Point(113, 356);
            this.rtNhanXet.Margin = new System.Windows.Forms.Padding(2);
            this.rtNhanXet.Name = "rtNhanXet";
            this.rtNhanXet.Size = new System.Drawing.Size(133, 50);
            this.rtNhanXet.TabIndex = 36;
            this.rtNhanXet.Text = "";
            // 
            // txtTimSV
            // 
            this.txtTimSV.Location = new System.Drawing.Point(159, 427);
            this.txtTimSV.Name = "txtTimSV";
            this.txtTimSV.Size = new System.Drawing.Size(104, 23);
            this.txtTimSV.TabIndex = 35;
            this.txtTimSV.TextChanged += new System.EventHandler(this.txtTimSV_TextChanged);
            // 
            // lstTimSV
            // 
            this.lstTimSV.FormattingEnabled = true;
            this.lstTimSV.ItemHeight = 17;
            this.lstTimSV.Location = new System.Drawing.Point(150, 455);
            this.lstTimSV.Margin = new System.Windows.Forms.Padding(2);
            this.lstTimSV.Name = "lstTimSV";
            this.lstTimSV.Size = new System.Drawing.Size(138, 38);
            this.lstTimSV.TabIndex = 34;
            this.lstTimSV.DoubleClick += new System.EventHandler(this.lstTimSV_DoubleClick);
            // 
            // lstSV
            // 
            this.lstSV.FormattingEnabled = true;
            this.lstSV.ItemHeight = 17;
            this.lstSV.Location = new System.Drawing.Point(0, 455);
            this.lstSV.Margin = new System.Windows.Forms.Padding(2);
            this.lstSV.Name = "lstSV";
            this.lstSV.Size = new System.Drawing.Size(141, 38);
            this.lstSV.TabIndex = 33;
            this.lstSV.DoubleClick += new System.EventHandler(this.lstSV_DoubleClick);
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayBatDau.Location = new System.Drawing.Point(100, 142);
            this.NgayBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Size = new System.Drawing.Size(133, 23);
            this.NgayBatDau.TabIndex = 32;
            this.NgayBatDau.Value = new System.DateTime(2020, 5, 27, 0, 0, 0, 0);
            // 
            // rtMoTa
            // 
            this.rtMoTa.Location = new System.Drawing.Point(102, 94);
            this.rtMoTa.Margin = new System.Windows.Forms.Padding(2);
            this.rtMoTa.Name = "rtMoTa";
            this.rtMoTa.Size = new System.Drawing.Size(133, 38);
            this.rtMoTa.TabIndex = 31;
            this.rtMoTa.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Mô tả đề tài";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayKetThuc.Location = new System.Drawing.Point(100, 180);
            this.NgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Size = new System.Drawing.Size(133, 23);
            this.NgayKetThuc.TabIndex = 27;
            this.NgayKetThuc.Value = new System.DateTime(2020, 5, 27, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Mã sinh viên";
            // 
            // cbGV
            // 
            this.cbGV.DataSource = this.giaoVienBindingSource;
            this.cbGV.DisplayMember = "MaGV";
            this.cbGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbGV.FormattingEnabled = true;
            this.cbGV.Location = new System.Drawing.Point(104, 509);
            this.cbGV.Name = "cbGV";
            this.cbGV.Size = new System.Drawing.Size(133, 25);
            this.cbGV.TabIndex = 4;
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "GiaoVien";
            // 
            // doanLTW_GiaoVien
            // 
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // txtTenDT
            // 
            this.txtTenDT.Location = new System.Drawing.Point(102, 57);
            this.txtTenDT.Name = "txtTenDT";
            this.txtTenDT.Size = new System.Drawing.Size(133, 23);
            this.txtTenDT.TabIndex = 2;
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(102, 23);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.Size = new System.Drawing.Size(133, 23);
            this.txtMaDT.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tên giáo viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tiến độ đề tài chung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tên đề tài";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã đề tài";
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmoi.Image")));
            this.btnThemmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemmoi.Location = new System.Drawing.Point(1250, 230);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(107, 35);
            this.btnThemmoi.TabIndex = 32;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listDeTai);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(310, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 548);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // listDeTai
            // 
            this.listDeTai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cMaDT,
            this.cTenDT,
            this.cMoTaDT,
            this.cNgayBD,
            this.cNgayKT,
            this.cTienDo,
            this.cMaSV,
            this.cMaGV,
            this.cTenGV,
            this.cNhanXet,
            this.cLink});
            this.listDeTai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDeTai.GridLines = true;
            this.listDeTai.HideSelection = false;
            this.listDeTai.Location = new System.Drawing.Point(3, 19);
            this.listDeTai.Margin = new System.Windows.Forms.Padding(2);
            this.listDeTai.Name = "listDeTai";
            this.listDeTai.Size = new System.Drawing.Size(928, 526);
            this.listDeTai.TabIndex = 0;
            this.listDeTai.UseCompatibleStateImageBehavior = false;
            this.listDeTai.View = System.Windows.Forms.View.Details;
            this.listDeTai.Click += new System.EventHandler(this.listDeTai_Click);
            // 
            // cMaDT
            // 
            this.cMaDT.Text = "Mã đề tài";
            this.cMaDT.Width = 129;
            // 
            // cTenDT
            // 
            this.cTenDT.Text = "Tên đề tài";
            this.cTenDT.Width = 130;
            // 
            // cMoTaDT
            // 
            this.cMoTaDT.Text = "Mô tả đề tài";
            this.cMoTaDT.Width = 147;
            // 
            // cNgayBD
            // 
            this.cNgayBD.Text = "Ngày bắt đầu";
            this.cNgayBD.Width = 127;
            // 
            // cNgayKT
            // 
            this.cNgayKT.Text = "Ngày kết thúc";
            this.cNgayKT.Width = 133;
            // 
            // cTienDo
            // 
            this.cTienDo.Text = "Tiến độ";
            this.cTienDo.Width = 102;
            // 
            // cMaSV
            // 
            this.cMaSV.Text = "Mã sinh viên";
            this.cMaSV.Width = 116;
            // 
            // cMaGV
            // 
            this.cMaGV.Text = "Mã giáo viên";
            this.cMaGV.Width = 122;
            // 
            // cTenGV
            // 
            this.cTenGV.Text = "Tên giáo viên";
            this.cTenGV.Width = 121;
            // 
            // cNhanXet
            // 
            this.cNhanXet.Text = "Nhận xét";
            this.cNhanXet.Width = 106;
            // 
            // cLink
            // 
            this.cLink.Text = "Link đề tài";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1250, 271);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 35);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(455, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 40);
            this.label1.TabIndex = 29;
            this.label1.Text = "Chương trình quản lý đề tài";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // giaoVienTableAdapter
            // 
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 719);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDeTai";
            this.Text = "Danh sách đề tài";
            this.Load += new System.EventHandler(this.frmDeTai_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimTenDT;
        private System.Windows.Forms.Label ten;
        private System.Windows.Forms.TextBox txtTimMaDT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker NgayKetThuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenDT;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtMoTa;
        private System.Windows.Forms.DateTimePicker NgayBatDau;
        private System.Windows.Forms.RichTextBox rtNhanXet;
        private System.Windows.Forms.TextBox txtTimSV;
        private System.Windows.Forms.ListBox lstTimSV;
        private System.Windows.Forms.ListBox lstSV;
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.ListView listDeTai;
        private System.Windows.Forms.ColumnHeader cMaDT;
        private System.Windows.Forms.ColumnHeader cTenDT;
        private System.Windows.Forms.ColumnHeader cMoTaDT;
        private System.Windows.Forms.ColumnHeader cNgayBD;
        private System.Windows.Forms.ColumnHeader cNgayKT;
        private System.Windows.Forms.ColumnHeader cTienDo;
        private System.Windows.Forms.ColumnHeader cMaSV;
        private System.Windows.Forms.ColumnHeader cMaGV;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private System.Windows.Forms.ColumnHeader cTenGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTienDo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader cNhanXet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkTienDo4;
        private System.Windows.Forms.CheckBox checkTienDo2;
        private System.Windows.Forms.CheckBox checkTienDo3;
        private System.Windows.Forms.CheckBox checkTienDo1;
        private System.Windows.Forms.ColumnHeader cLink;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}