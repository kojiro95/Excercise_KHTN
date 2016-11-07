namespace Baitap_Csharp.Bai02
{
    partial class frm02HangHoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblTenhang = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbkChuyenkhoan = new System.Windows.Forms.CheckBox();
            this.cbkTienmat = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdiMaybay = new System.Windows.Forms.RadioButton();
            this.rdiTauhoa = new System.Windows.Forms.RadioButton();
            this.rdiXeoto = new System.Windows.Forms.RadioButton();
            this.btnXuattext = new System.Windows.Forms.Button();
            this.btnXuatmessage = new System.Windows.Forms.Button();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.txtXuat = new System.Windows.Forms.TextBox();
            this.lblThongtinhangxuat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTongtien);
            this.groupBox1.Controls.Add(this.lblSoluong);
            this.groupBox1.Controls.Add(this.lblTenhang);
            this.groupBox1.Controls.Add(this.txtTongtien);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.txtTenhang);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(18, 121);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(71, 17);
            this.lblTongtien.TabIndex = 5;
            this.lblTongtien.Text = "Tổng tiền";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(18, 81);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(65, 17);
            this.lblSoluong.TabIndex = 4;
            this.lblSoluong.Text = "Số lượng";
            // 
            // lblTenhang
            // 
            this.lblTenhang.AutoSize = true;
            this.lblTenhang.Location = new System.Drawing.Point(18, 41);
            this.lblTenhang.Name = "lblTenhang";
            this.lblTenhang.Size = new System.Drawing.Size(69, 17);
            this.lblTenhang.TabIndex = 3;
            this.lblTenhang.Text = "Tên hàng";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(112, 113);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(183, 25);
            this.txtTongtien.TabIndex = 3;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(112, 73);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(183, 25);
            this.txtSoluong.TabIndex = 2;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(112, 33);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(183, 25);
            this.txtTenhang.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbkChuyenkhoan);
            this.groupBox2.Controls.Add(this.cbkTienmat);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(387, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh toán";
            // 
            // cbkChuyenkhoan
            // 
            this.cbkChuyenkhoan.AutoSize = true;
            this.cbkChuyenkhoan.Location = new System.Drawing.Point(217, 44);
            this.cbkChuyenkhoan.Name = "cbkChuyenkhoan";
            this.cbkChuyenkhoan.Size = new System.Drawing.Size(121, 21);
            this.cbkChuyenkhoan.TabIndex = 5;
            this.cbkChuyenkhoan.Text = "Chuyển khoản";
            this.cbkChuyenkhoan.UseVisualStyleBackColor = true;
            this.cbkChuyenkhoan.CheckedChanged += new System.EventHandler(this.cbkChuyenkhoan_CheckedChanged);
            // 
            // cbkTienmat
            // 
            this.cbkTienmat.AutoSize = true;
            this.cbkTienmat.Location = new System.Drawing.Point(50, 44);
            this.cbkTienmat.Name = "cbkTienmat";
            this.cbkTienmat.Size = new System.Drawing.Size(85, 21);
            this.cbkTienmat.TabIndex = 4;
            this.cbkTienmat.Text = "Tiền mặt";
            this.cbkTienmat.UseVisualStyleBackColor = true;
            this.cbkTienmat.CheckedChanged += new System.EventHandler(this.cbkTienmat_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdiMaybay);
            this.groupBox3.Controls.Add(this.rdiTauhoa);
            this.groupBox3.Controls.Add(this.rdiXeoto);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(387, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vận chuyển";
            // 
            // rdiMaybay
            // 
            this.rdiMaybay.AutoSize = true;
            this.rdiMaybay.Location = new System.Drawing.Point(265, 32);
            this.rdiMaybay.Name = "rdiMaybay";
            this.rdiMaybay.Size = new System.Drawing.Size(81, 21);
            this.rdiMaybay.TabIndex = 8;
            this.rdiMaybay.TabStop = true;
            this.rdiMaybay.Text = "Máy bay";
            this.rdiMaybay.UseVisualStyleBackColor = true;
            // 
            // rdiTauhoa
            // 
            this.rdiTauhoa.AutoSize = true;
            this.rdiTauhoa.Location = new System.Drawing.Point(144, 32);
            this.rdiTauhoa.Name = "rdiTauhoa";
            this.rdiTauhoa.Size = new System.Drawing.Size(78, 21);
            this.rdiTauhoa.TabIndex = 7;
            this.rdiTauhoa.TabStop = true;
            this.rdiTauhoa.Text = "Tàu hỏa";
            this.rdiTauhoa.UseVisualStyleBackColor = true;
            // 
            // rdiXeoto
            // 
            this.rdiXeoto.AutoSize = true;
            this.rdiXeoto.Location = new System.Drawing.Point(23, 32);
            this.rdiXeoto.Name = "rdiXeoto";
            this.rdiXeoto.Size = new System.Drawing.Size(73, 21);
            this.rdiXeoto.TabIndex = 6;
            this.rdiXeoto.TabStop = true;
            this.rdiXeoto.Text = "Xe ô tô";
            this.rdiXeoto.UseVisualStyleBackColor = true;
            // 
            // btnXuattext
            // 
            this.btnXuattext.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnXuattext.Location = new System.Drawing.Point(53, 235);
            this.btnXuattext.Name = "btnXuattext";
            this.btnXuattext.Size = new System.Drawing.Size(188, 45);
            this.btnXuattext.TabIndex = 3;
            this.btnXuattext.Text = "Xuất ra TextBox";
            this.btnXuattext.UseVisualStyleBackColor = true;
            this.btnXuattext.Click += new System.EventHandler(this.btnXuattext_Click);
            // 
            // btnXuatmessage
            // 
            this.btnXuatmessage.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnXuatmessage.Location = new System.Drawing.Point(307, 235);
            this.btnXuatmessage.Name = "btnXuatmessage";
            this.btnXuatmessage.Size = new System.Drawing.Size(188, 45);
            this.btnXuatmessage.TabIndex = 4;
            this.btnXuatmessage.Text = "Xuất ra MessageBox";
            this.btnXuatmessage.UseVisualStyleBackColor = true;
            this.btnXuatmessage.Click += new System.EventHandler(this.btnXuatmessage_Click);
            // 
            // btnLamlai
            // 
            this.btnLamlai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLamlai.Location = new System.Drawing.Point(561, 235);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(188, 45);
            this.btnLamlai.TabIndex = 5;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // txtXuat
            // 
            this.txtXuat.Enabled = false;
            this.txtXuat.Location = new System.Drawing.Point(28, 305);
            this.txtXuat.Multiline = true;
            this.txtXuat.Name = "txtXuat";
            this.txtXuat.Size = new System.Drawing.Size(742, 72);
            this.txtXuat.TabIndex = 6;
            // 
            // lblThongtinhangxuat
            // 
            this.lblThongtinhangxuat.AutoSize = true;
            this.lblThongtinhangxuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblThongtinhangxuat.Location = new System.Drawing.Point(25, 285);
            this.lblThongtinhangxuat.Name = "lblThongtinhangxuat";
            this.lblThongtinhangxuat.Size = new System.Drawing.Size(138, 17);
            this.lblThongtinhangxuat.TabIndex = 7;
            this.lblThongtinhangxuat.Text = "Thông tin hàng xuất";
            // 
            // frm02HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 389);
            this.Controls.Add(this.lblThongtinhangxuat);
            this.Controls.Add(this.txtXuat);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.btnXuatmessage);
            this.Controls.Add(this.btnXuattext);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm02HangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hóa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbkChuyenkhoan;
        private System.Windows.Forms.CheckBox cbkTienmat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdiMaybay;
        private System.Windows.Forms.RadioButton rdiTauhoa;
        private System.Windows.Forms.RadioButton rdiXeoto;
        private System.Windows.Forms.Button btnXuattext;
        private System.Windows.Forms.Button btnXuatmessage;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.TextBox txtXuat;
        private System.Windows.Forms.Label lblThongtinhangxuat;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblTenhang;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtTenhang;
    }
}