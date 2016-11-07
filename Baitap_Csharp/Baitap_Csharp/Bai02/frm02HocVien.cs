using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap_Csharp.Bai02
{
    public partial class frm02HocVien : Form
    {
        public frm02HocVien()
        {
            InitializeComponent();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (tbHoten.Text == "")
                MessageBox.Show("Bạn chưa điền họ tên !");
            else
                MessageBox.Show("Đã cập nhật thành công !");
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            tbHoten.Clear();
            dtpNgayghidanh.ResetText();
            rdoNam.Checked = true;
            cboDocsach.Checked = false;
            cboDulich.Checked = false;
            cboNghenhac.Checked = false;
            cboXemphim.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
