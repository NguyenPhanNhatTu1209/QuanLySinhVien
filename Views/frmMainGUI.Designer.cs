namespace Đồ_án.Views
{
    partial class frmMainGUI
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.mGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mDeTai = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFunction,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(843, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mFunction
            // 
            this.mFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mGiaoVien,
            this.mSinhVien,
            this.mDeTai});
            this.mFunction.Name = "mFunction";
            this.mFunction.Size = new System.Drawing.Size(93, 24);
            this.mFunction.Text = "&Chức năng";
            // 
            // mGiaoVien
            // 
            this.mGiaoVien.Name = "mGiaoVien";
            this.mGiaoVien.Size = new System.Drawing.Size(207, 26);
            this.mGiaoVien.Text = "Quản lý giáo viên";
            this.mGiaoVien.Click += new System.EventHandler(this.mGiaoVien_Click);
            // 
            // mSinhVien
            // 
            this.mSinhVien.Name = "mSinhVien";
            this.mSinhVien.Size = new System.Drawing.Size(207, 26);
            this.mSinhVien.Text = "Quản lý sinh viên";
            this.mSinhVien.Click += new System.EventHandler(this.mSinhVien_Click);
            // 
            // mDeTai
            // 
            this.mDeTai.Name = "mDeTai";
            this.mDeTai.Size = new System.Drawing.Size(207, 26);
            this.mDeTai.Text = "Quản lý đề tài";
            this.mDeTai.Click += new System.EventHandler(this.mDeTai_Click);
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 28);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(843, 25);
            this.tabMain.TabIndex = 2;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // frmMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMainGUI";
            this.Text = "frmMainGUI";
            this.Load += new System.EventHandler(this.frmMainGUI_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMainGUI_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mFunction;
        private System.Windows.Forms.ToolStripMenuItem mGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem mSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mDeTai;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}



