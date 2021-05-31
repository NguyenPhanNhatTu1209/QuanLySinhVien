namespace Đồ_án.Views.Giáo_viên
{
    partial class frmThemDeTai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemDeTai));
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenDT = new System.Windows.Forms.TextBox();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkTienDo4 = new System.Windows.Forms.CheckBox();
            this.checkTienDo2 = new System.Windows.Forms.CheckBox();
            this.checkTienDo3 = new System.Windows.Forms.CheckBox();
            this.checkTienDo1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThemmoi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmoi.Image")));
            this.btnThemmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemmoi.Location = new System.Drawing.Point(80, 77);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(167, 78);
            this.btnThemmoi.TabIndex = 40;
            this.btnThemmoi.Text = "Lưu";
            this.btnThemmoi.UseVisualStyleBackColor = false;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(472, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 43);
            this.label1.TabIndex = 39;
            this.label1.Text = "Thêm đề tài";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label6);
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
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTenDT);
            this.groupBox2.Controls.Add(this.txtMaDT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(377, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 521);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(195, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "%";
            // 
            // txtTienDo
            // 
            this.txtTienDo.Location = new System.Drawing.Point(104, 314);
            this.txtTienDo.Name = "txtTienDo";
            this.txtTienDo.Size = new System.Drawing.Size(86, 23);
            this.txtTienDo.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Nhận xét";
            // 
            // rtNhanXet
            // 
            this.rtNhanXet.Location = new System.Drawing.Point(104, 345);
            this.rtNhanXet.Margin = new System.Windows.Forms.Padding(2);
            this.rtNhanXet.Name = "rtNhanXet";
            this.rtNhanXet.Size = new System.Drawing.Size(133, 50);
            this.rtNhanXet.TabIndex = 36;
            this.rtNhanXet.Text = "";
            // 
            // txtTimSV
            // 
            this.txtTimSV.Location = new System.Drawing.Point(131, 399);
            this.txtTimSV.Name = "txtTimSV";
            this.txtTimSV.Size = new System.Drawing.Size(168, 23);
            this.txtTimSV.TabIndex = 35;
            this.txtTimSV.TextChanged += new System.EventHandler(this.txtTimSV_TextChanged);
            // 
            // lstTimSV
            // 
            this.lstTimSV.FormattingEnabled = true;
            this.lstTimSV.ItemHeight = 17;
            this.lstTimSV.Location = new System.Drawing.Point(185, 475);
            this.lstTimSV.Margin = new System.Windows.Forms.Padding(2);
            this.lstTimSV.Name = "lstTimSV";
            this.lstTimSV.Size = new System.Drawing.Size(174, 38);
            this.lstTimSV.TabIndex = 34;
            this.lstTimSV.DoubleClick += new System.EventHandler(this.lstTimSV_DoubleClick);
            // 
            // lstSV
            // 
            this.lstSV.FormattingEnabled = true;
            this.lstSV.ItemHeight = 17;
            this.lstSV.Location = new System.Drawing.Point(1, 475);
            this.lstSV.Margin = new System.Windows.Forms.Padding(2);
            this.lstSV.Name = "lstSV";
            this.lstSV.Size = new System.Drawing.Size(171, 38);
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
            this.label10.Location = new System.Drawing.Point(9, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Mã sinh viên";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tiến độ đề tài";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkTienDo4);
            this.panel1.Controls.Add(this.checkTienDo2);
            this.panel1.Controls.Add(this.checkTienDo3);
            this.panel1.Controls.Add(this.checkTienDo1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(103, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 78);
            this.panel1.TabIndex = 74;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "Tiến độ";
            // 
            // frmThemDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(924, 607);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThemDeTai";
            this.Text = "frmThemDeTai";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTienDo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtNhanXet;
        private System.Windows.Forms.TextBox txtTimSV;
        private System.Windows.Forms.ListBox lstTimSV;
        private System.Windows.Forms.ListBox lstSV;
        private System.Windows.Forms.DateTimePicker NgayBatDau;
        private System.Windows.Forms.RichTextBox rtMoTa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker NgayKetThuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenDT;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkTienDo4;
        private System.Windows.Forms.CheckBox checkTienDo2;
        private System.Windows.Forms.CheckBox checkTienDo3;
        private System.Windows.Forms.CheckBox checkTienDo1;
        private System.Windows.Forms.Label label6;
    }
}