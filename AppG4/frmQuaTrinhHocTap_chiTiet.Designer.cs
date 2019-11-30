namespace AppG4
{
    partial class frmQuaTrinhHocTap_chiTiet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numTuNam = new System.Windows.Forms.NumericUpDown();
            this.numToiNam = new System.Windows.Forms.NumericUpDown();
            this.txtHocO = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTuNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToiNam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tới Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Học ở";
            // 
            // numTuNam
            // 
            this.numTuNam.Location = new System.Drawing.Point(66, 9);
            this.numTuNam.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numTuNam.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numTuNam.Name = "numTuNam";
            this.numTuNam.Size = new System.Drawing.Size(118, 20);
            this.numTuNam.TabIndex = 1;
            this.numTuNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numToiNam
            // 
            this.numToiNam.Location = new System.Drawing.Point(66, 43);
            this.numToiNam.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numToiNam.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numToiNam.Name = "numToiNam";
            this.numToiNam.Size = new System.Drawing.Size(118, 20);
            this.numToiNam.TabIndex = 1;
            this.numToiNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // txtHocO
            // 
            this.txtHocO.Location = new System.Drawing.Point(66, 78);
            this.txtHocO.Multiline = true;
            this.txtHocO.Name = "txtHocO";
            this.txtHocO.Size = new System.Drawing.Size(252, 81);
            this.txtHocO.TabIndex = 2;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(185, 175);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(89, 37);
            this.btnDongY.TabIndex = 3;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.BtnDongY_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoQua.Location = new System.Drawing.Point(280, 175);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(85, 37);
            this.btnBoQua.TabIndex = 3;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // frmQuaTrinhHocTap_chiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBoQua;
            this.ClientSize = new System.Drawing.Size(367, 211);
            this.ControlBox = false;
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtHocO);
            this.Controls.Add(this.numToiNam);
            this.Controls.Add(this.numTuNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQuaTrinhHocTap_chiTiet";
            this.Text = "Thêm mới hoặc chỉnh sửa QTHT";
            ((System.ComponentModel.ISupportInitialize)(this.numTuNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToiNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTuNam;
        private System.Windows.Forms.NumericUpDown numToiNam;
        private System.Windows.Forms.TextBox txtHocO;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
    }
}