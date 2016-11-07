namespace Baitap_Csharp.Bai01
{
    partial class frm03CaNhan
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
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbSoThich = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.tbSothich = new System.Windows.Forms.TextBox();
            this.tbNgaysinh = new System.Windows.Forms.TextBox();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(48, 34);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(91, 23);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ và tên";
            // 
            // lbSoThich
            // 
            this.lbSoThich.AutoSize = true;
            this.lbSoThich.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoThich.Location = new System.Drawing.Point(48, 114);
            this.lbSoThich.Name = "lbSoThich";
            this.lbSoThich.Size = new System.Drawing.Size(79, 23);
            this.lbSoThich.TabIndex = 1;
            this.lbSoThich.Text = "Sở thích";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(48, 75);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(92, 23);
            this.lbNgaySinh.TabIndex = 2;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // tbHoten
            // 
            this.tbHoten.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.tbHoten.Location = new System.Drawing.Point(162, 31);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(265, 30);
            this.tbHoten.TabIndex = 1;
            this.tbHoten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbHoten_KeyDown);
            // 
            // tbSothich
            // 
            this.tbSothich.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.tbSothich.Location = new System.Drawing.Point(162, 116);
            this.tbSothich.Multiline = true;
            this.tbSothich.Name = "tbSothich";
            this.tbSothich.Size = new System.Drawing.Size(265, 110);
            this.tbSothich.TabIndex = 3;
            // 
            // tbNgaysinh
            // 
            this.tbNgaysinh.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.tbNgaysinh.Location = new System.Drawing.Point(162, 72);
            this.tbNgaysinh.Name = "tbNgaysinh";
            this.tbNgaysinh.Size = new System.Drawing.Size(265, 30);
            this.tbNgaysinh.TabIndex = 2;
            this.tbNgaysinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNgaysinh_KeyDown);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btnXacnhan.Location = new System.Drawing.Point(177, 264);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(214, 45);
            this.btnXacnhan.TabIndex = 4;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // frm03CaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 342);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.tbNgaysinh);
            this.Controls.Add(this.tbSothich);
            this.Controls.Add(this.tbHoten);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbSoThich);
            this.Controls.Add(this.lbHoTen);
            this.Name = "frm03CaNhan";
            this.Text = "Thông tin cá nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbSoThich;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.TextBox tbSothich;
        private System.Windows.Forms.TextBox tbNgaysinh;
        private System.Windows.Forms.Button btnXacnhan;
    }
}