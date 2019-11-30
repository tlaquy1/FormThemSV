namespace AppG4
{
    partial class frmThongTinSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinSinhVien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.chkGioiTinh = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTongSoMuc = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgQuaTrinhHocTap = new System.Windows.Forms.DataGridView();
            this.clTuNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDenNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHocO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.linkChonAnhDaiDien = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.picAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.bdsQuaTrinhHocTap = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuaTrinhHocTap)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQuaTrinhHocTap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nơi sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới tính:";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(241, 19);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(277, 20);
            this.txtMaSinhVien.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(241, 45);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(277, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(241, 72);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(103, 20);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(241, 98);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(277, 20);
            this.txtNoiSinh.TabIndex = 3;
            // 
            // chkGioiTinh
            // 
            this.chkGioiTinh.AutoSize = true;
            this.chkGioiTinh.Location = new System.Drawing.Point(241, 125);
            this.chkGioiTinh.Name = "chkGioiTinh";
            this.chkGioiTinh.Size = new System.Drawing.Size(48, 17);
            this.chkGioiTinh.TabIndex = 4;
            this.chkGioiTinh.Text = "Nam";
            this.chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.dtgQuaTrinhHocTap);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(13, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 196);
            this.panel1.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblTongSoMuc});
            this.statusStrip1.Location = new System.Drawing.Point(0, 172);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(503, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel1.Text = "Tổng số mục: ";
            // 
            // lblTongSoMuc
            // 
            this.lblTongSoMuc.Name = "lblTongSoMuc";
            this.lblTongSoMuc.Size = new System.Drawing.Size(13, 17);
            this.lblTongSoMuc.Text = "0";
            // 
            // dtgQuaTrinhHocTap
            // 
            this.dtgQuaTrinhHocTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgQuaTrinhHocTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTuNam,
            this.clDenNam,
            this.clHocO});
            this.dtgQuaTrinhHocTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgQuaTrinhHocTap.Location = new System.Drawing.Point(0, 25);
            this.dtgQuaTrinhHocTap.Name = "dtgQuaTrinhHocTap";
            this.dtgQuaTrinhHocTap.Size = new System.Drawing.Size(503, 169);
            this.dtgQuaTrinhHocTap.TabIndex = 1;
            // 
            // clTuNam
            // 
            this.clTuNam.DataPropertyName = "YearFrom";
            this.clTuNam.HeaderText = "Từ năm";
            this.clTuNam.Name = "clTuNam";
            // 
            // clDenNam
            // 
            this.clDenNam.DataPropertyName = "YearEnd";
            this.clDenNam.HeaderText = "Đến năm";
            this.clDenNam.Name = "clDenNam";
            // 
            // clHocO
            // 
            this.clHocO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHocO.DataPropertyName = "SchoolName";
            this.clHocO.HeaderText = "Học ở";
            this.clHocO.Name = "clHocO";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnXoa,
            this.btnSua,
            this.btnThem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(503, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "Quá trình học tập";
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.Image = global::AppG4.Properties.Resources.delete;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSua.Image = global::AppG4.Properties.Resources.edit;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThem.Image = global::AppG4.Properties.Resources.add;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(57, 22);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // linkChonAnhDaiDien
            // 
            this.linkChonAnhDaiDien.AutoSize = true;
            this.linkChonAnhDaiDien.Location = new System.Drawing.Point(25, 141);
            this.linkChonAnhDaiDien.Name = "linkChonAnhDaiDien";
            this.linkChonAnhDaiDien.Size = new System.Drawing.Size(94, 13);
            this.linkChonAnhDaiDien.TabIndex = 6;
            this.linkChonAnhDaiDien.TabStop = true;
            this.linkChonAnhDaiDien.Text = "Chọn ảnh đại diện";
            this.linkChonAnhDaiDien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkChonAnhDaiDien_LinkClicked);
            // 
            // button1
            // 
            this.button1.Image = global::AppG4.Properties.Resources.back_arrow;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(442, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bỏ qua";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::AppG4.Properties.Resources.database;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(348, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cập nhật";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // picAnhDaiDien
            // 
            this.picAnhDaiDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhDaiDien.Image = global::AppG4.Properties.Resources.avatar;
            this.picAnhDaiDien.Location = new System.Drawing.Point(13, 8);
            this.picAnhDaiDien.Name = "picAnhDaiDien";
            this.picAnhDaiDien.Size = new System.Drawing.Size(123, 130);
            this.picAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhDaiDien.TabIndex = 0;
            this.picAnhDaiDien.TabStop = false;
            this.picAnhDaiDien.DragDrop += new System.Windows.Forms.DragEventHandler(this.PicAnhDaiDien_DragDrop);
            this.picAnhDaiDien.DragEnter += new System.Windows.Forms.DragEventHandler(this.PicAnhDaiDien_DragEnter);
            // 
            // frmThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 402);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkChonAnhDaiDien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkGioiTinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAnhDaiDien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongTinSinhVien";
            this.Text = "Thông tin sinh viên - Tác giả: ndungithue";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuaTrinhHocTap)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQuaTrinhHocTap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnhDaiDien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.CheckBox chkGioiTinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dtgQuaTrinhHocTap;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.LinkLabel linkChonAnhDaiDien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTuNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDenNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHocO;
        private System.Windows.Forms.BindingSource bdsQuaTrinhHocTap;
        private System.Windows.Forms.ToolStripStatusLabel lblTongSoMuc;
    }
}