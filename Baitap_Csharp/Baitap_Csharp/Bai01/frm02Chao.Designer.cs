namespace Baitap_Csharp.Bai01
{
    partial class frm02Chao
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
            this.lbNhapHoTen = new System.Windows.Forms.Label();
            this.lbXuatHoTen = new System.Windows.Forms.Label();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.txtNhapHoTen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNhapHoTen
            // 
            this.lbNhapHoTen.AutoSize = true;
            this.lbNhapHoTen.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapHoTen.Location = new System.Drawing.Point(17, 53);
            this.lbNhapHoTen.Name = "lbNhapHoTen";
            this.lbNhapHoTen.Size = new System.Drawing.Size(105, 22);
            this.lbNhapHoTen.TabIndex = 0;
            this.lbNhapHoTen.Text = "Nhập họ tên";
            // 
            // lbXuatHoTen
            // 
            this.lbXuatHoTen.AutoSize = true;
            this.lbXuatHoTen.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbXuatHoTen.ForeColor = System.Drawing.Color.Red;
            this.lbXuatHoTen.Location = new System.Drawing.Point(35, 136);
            this.lbXuatHoTen.Name = "lbXuatHoTen";
            this.lbXuatHoTen.Size = new System.Drawing.Size(0, 22);
            this.lbXuatHoTen.TabIndex = 1;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnThucHien.Location = new System.Drawing.Point(140, 186);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(160, 46);
            this.btnThucHien.TabIndex = 2;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // txtNhapHoTen
            // 
            this.txtNhapHoTen.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtNhapHoTen.Location = new System.Drawing.Point(140, 45);
            this.txtNhapHoTen.Name = "txtNhapHoTen";
            this.txtNhapHoTen.Size = new System.Drawing.Size(233, 29);
            this.txtNhapHoTen.TabIndex = 1;
            // 
            // frm02Chao
            // 
            this.AcceptButton = this.btnThucHien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 272);
            this.Controls.Add(this.txtNhapHoTen);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.lbXuatHoTen);
            this.Controls.Add(this.lbNhapHoTen);
            this.Name = "frm02Chao";
            this.Text = "Chào";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapHoTen;
        private System.Windows.Forms.Label lbXuatHoTen;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.TextBox txtNhapHoTen;
    }
}