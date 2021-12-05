namespace QLDHS
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHS = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSHS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoiLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNamHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHocKy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHS,
            this.mnuKhoiLop,
            this.mnuMH,
            this.mnuGV,
            this.mnuDiem,
            this.mnuLop,
            this.mnuNamHoc,
            this.mnuHocKy});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuHS
            // 
            this.mnuHS.Name = "mnuHS";
            this.mnuHS.Size = new System.Drawing.Size(210, 30);
            this.mnuHS.Text = "Học sinh";
            this.mnuHS.Click += new System.EventHandler(this.mnuHS_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDSHS});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // mnuDSHS
            // 
            this.mnuDSHS.Name = "mnuDSHS";
            this.mnuDSHS.Size = new System.Drawing.Size(249, 30);
            this.mnuDSHS.Text = "Danh sách học sinh";
            this.mnuDSHS.Click += new System.EventHandler(this.mnuDSHS_Click);
            // 
            // mnuKhoiLop
            // 
            this.mnuKhoiLop.Name = "mnuKhoiLop";
            this.mnuKhoiLop.Size = new System.Drawing.Size(210, 30);
            this.mnuKhoiLop.Text = "Khối lớp";
            this.mnuKhoiLop.Click += new System.EventHandler(this.mnuKhoiLop_Click);
            // 
            // mnuMH
            // 
            this.mnuMH.Name = "mnuMH";
            this.mnuMH.Size = new System.Drawing.Size(210, 30);
            this.mnuMH.Text = "Môn học";
            this.mnuMH.Click += new System.EventHandler(this.mnuMH_Click);
            // 
            // mnuGV
            // 
            this.mnuGV.Name = "mnuGV";
            this.mnuGV.Size = new System.Drawing.Size(210, 30);
            this.mnuGV.Text = "Giáo viên";
            this.mnuGV.Click += new System.EventHandler(this.mnuGV_Click);
            // 
            // mnuDiem
            // 
            this.mnuDiem.Name = "mnuDiem";
            this.mnuDiem.Size = new System.Drawing.Size(210, 30);
            this.mnuDiem.Text = "Điểm";
            this.mnuDiem.Click += new System.EventHandler(this.mnuDiem_Click);
            // 
            // mnuLop
            // 
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Size = new System.Drawing.Size(210, 30);
            this.mnuLop.Text = "Lớp";
            this.mnuLop.Click += new System.EventHandler(this.mnuLop_Click);
            // 
            // mnuNamHoc
            // 
            this.mnuNamHoc.Name = "mnuNamHoc";
            this.mnuNamHoc.Size = new System.Drawing.Size(210, 30);
            this.mnuNamHoc.Text = "Năm Học";
            this.mnuNamHoc.Click += new System.EventHandler(this.mnuNamHoc_Click);
            // 
            // mnuHocKy
            // 
            this.mnuHocKy.Name = "mnuHocKy";
            this.mnuHocKy.Size = new System.Drawing.Size(210, 30);
            this.mnuHocKy.Text = "Học Kỳ";
            this.mnuHocKy.Click += new System.EventHandler(this.mnuHocKy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 438);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHS;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDSHS;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoiLop;
        private System.Windows.Forms.ToolStripMenuItem mnuMH;
        private System.Windows.Forms.ToolStripMenuItem mnuGV;
        private System.Windows.Forms.ToolStripMenuItem mnuDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuNamHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuHocKy;
    }
}

