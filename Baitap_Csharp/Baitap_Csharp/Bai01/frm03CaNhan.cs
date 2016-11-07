using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap_Csharp.Bai01
{
    public partial class frm03CaNhan : Form
    {
        public frm03CaNhan()
        {
            InitializeComponent();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            String tt = "Họ Tên: " + tbHoten.Text + "\r" +
                "Ngày sinh: " + tbNgaysinh.Text + "\r" +
                "Sở thích: \r" + tbSothich.Text;
            MessageBox.Show(tt, "Kết quả");
        }

        private void tbHoten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbNgaysinh.Focus();
        }

        private void tbNgaysinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbSothich.Focus();
        }
    }
}
