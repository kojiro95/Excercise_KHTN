namespace Baitap_Csharp.Bai02
{
    partial class frm02HocVien
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
            this.ptbHinhAnh = new System.Windows.Forms.PictureBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.dtpNgayghidanh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboDocsach = new System.Windows.Forms.CheckBox();
            this.cboXemphim = new System.Windows.Forms.CheckBox();
            this.cboNghenhac = new System.Windows.Forms.CheckBox();
            this.cboDulich = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhAnh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbHinhAnh
            // 
            this.ptbHinhAnh.Image = global::Baitap_Csharp.Properties.Resources.Koala;
            this.ptbHinhAnh.Location = new System.Drawing.Point(12, 29);
            this.ptbHinhAnh.Name = "ptbHinhAnh";
            this.ptbHinhAnh.Size = new System.Drawing.Size(179, 321);
            this.ptbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHinhAnh.TabIndex = 0;
            this.ptbHinhAnh.TabStop = false;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbHoTen.Location = new System.Drawing.Point(228, 30);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(72, 17);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ và tên";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbGioiTinh.Location = new System.Drawing.Point(228, 130);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(64, 17);
            this.lbGioiTinh.TabIndex = 2;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(228, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày ghi danh";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCapnhat.Location = new System.Drawing.Point(264, 323);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(98, 28);
            this.btnCapnhat.TabIndex = 5;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnThemmoi.Location = new System.Drawing.Point(425, 323);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(98, 28);
            this.btnThemmoi.TabIndex = 6;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(586, 323);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 28);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Đóng Form";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tbHoten
            // 
            this.tbHoten.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoten.Location = new System.Drawing.Point(337, 22);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(266, 25);
            this.tbHoten.TabIndex = 1;
            // 
            // dtpNgayghidanh
            // 
            this.dtpNgayghidanh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayghidanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpNgayghidanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayghidanh.Location = new System.Drawing.Point(337, 72);
            this.dtpNgayghidanh.Name = "dtpNgayghidanh";
            this.dtpNgayghidanh.Size = new System.Drawing.Size(118, 25);
            this.dtpNgayghidanh.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNu);
            this.groupBox1.Controls.Add(this.rdoNam);
            this.groupBox1.Location = new System.Drawing.Point(337, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 49);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.rdoNam.Location = new System.Drawing.Point(28, 15);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(56, 21);
            this.rdoNam.TabIndex = 3;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.rdoNu.Location = new System.Drawing.Point(134, 15);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(46, 21);
            this.rdoNu.TabIndex = 4;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboDulich);
            this.groupBox2.Controls.Add(this.cboNghenhac);
            this.groupBox2.Controls.Add(this.cboXemphim);
            this.groupBox2.Controls.Add(this.cboDocsach);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(233, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 105);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đọc sách";
            // 
            // cboDocsach
            // 
            this.cboDocsach.AutoSize = true;
            this.cboDocsach.Location = new System.Drawing.Point(14, 50);
            this.cboDocsach.Name = "cboDocsach";
            this.cboDocsach.Size = new System.Drawing.Size(86, 21);
            this.cboDocsach.TabIndex = 0;
            this.cboDocsach.Text = "Đọc sách";
            this.cboDocsach.UseVisualStyleBackColor = true;
            // 
            // cboXemphim
            // 
            this.cboXemphim.AutoSize = true;
            this.cboXemphim.Location = new System.Drawing.Point(132, 50);
            this.cboXemphim.Name = "cboXemphim";
            this.cboXemphim.Size = new System.Drawing.Size(93, 21);
            this.cboXemphim.TabIndex = 1;
            this.cboXemphim.Text = "Xem phim";
            this.cboXemphim.UseVisualStyleBackColor = true;
            // 
            // cboNghenhac
            // 
            this.cboNghenhac.AutoSize = true;
            this.cboNghenhac.Location = new System.Drawing.Point(250, 50);
            this.cboNghenhac.Name = "cboNghenhac";
            this.cboNghenhac.Size = new System.Drawing.Size(96, 21);
            this.cboNghenhac.TabIndex = 2;
            this.cboNghenhac.Text = "Nghe nhạc";
            this.cboNghenhac.UseVisualStyleBackColor = true;
            // 
            // cboDulich
            // 
            this.cboDulich.AutoSize = true;
            this.cboDulich.Location = new System.Drawing.Point(368, 50);
            this.cboDulich.Name = "cboDulich";
            this.cboDulich.Size = new System.Drawing.Size(73, 21);
            this.cboDulich.TabIndex = 3;
            this.cboDulich.Text = "Du lịch";
            this.cboDulich.UseVisualStyleBackColor = true;
            // 
            // frm02HocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpNgayghidanh);
            this.Controls.Add(this.tbHoten);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.ptbHinhAnh);
            this.Name = "frm02HocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin học viên";
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhAnh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbHinhAnh;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.DateTimePicker dtpNgayghidanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cboDulich;
        private System.Windows.Forms.CheckBox cboNghenhac;
        private System.Windows.Forms.CheckBox cboXemphim;
        private System.Windows.Forms.CheckBox cboDocsach;
    }
}