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
    public partial class frm02HangHoa : Form
    {
        private string _output;
        public frm02HangHoa()
        {
            InitializeComponent();
        }

        private void btnXuatmessage_Click(object sender, EventArgs e)
        {
            _output = "Tên hàng: " + txtTenhang.Text;
            _output += "\nSố lượng: " + txtSoluong.Text + "\nTổng tiền: " + txtTongtien.Text;
            //_output += "\nThanh toán bằng: " + (cbkTienmat.Checked ? "Tiền mặt" : "Chuyển khoản");
            //_output += "\nVận chuyển bằng: " + (rdiXeoto.Checked ? "Xe ô tô" : (rdiTauhoa.Checked ? "Tàu hỏa" : "Máy bay"));
            if (cbkChuyenkhoan.Checked)
                _output += "\nThanh toán: " + cbkChuyenkhoan.Text;
            else
                _output += "\nThanh toán: " + cbkTienmat.Text;
            if (rdiXeoto.Checked)
                _output += "\nVận chuyển: " + rdiXeoto.Text;
            else if (rdiMaybay.Checked)
                _output += "\nVận chuyển: " + rdiMaybay.Text;
            else if (rdiTauhoa.Checked)
                _output += "\nVận chuyển: " + rdiTauhoa.Text;
            MessageBox.Show(_output, "Kết quả:");
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtTenhang.Clear();
            txtSoluong.Clear();
            txtTongtien.Clear();
            txtXuat.Clear();
            cbkChuyenkhoan.Checked = false;
            cbkTienmat.Checked = false;
            rdiMaybay.Checked = false;
            rdiTauhoa.Checked = false;
            rdiXeoto.Checked = false;
        }

        private void cbkTienmat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkTienmat.Checked)
                cbkChuyenkhoan.Checked = false;
        }

        private void cbkChuyenkhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkChuyenkhoan.Checked)
                cbkTienmat.Checked = false;
        }

        private void btnXuattext_Click(object sender, EventArgs e)
        {
            _output = "Tên hàng\t\t\t Số lượng \t\t\t Tổng tiền\r\n";
            _output += txtTenhang.Text + "\t\t\t" + txtSoluong.Text + "\t\t\t" + txtTongtien.Text;
            _output += "\r\nThanh toán bằng: " + (cbkTienmat.Checked ? "Tiền mặt" : "Chuyển khoản");
            _output += "\r\nVận chuyển bằng: " + (rdiXeoto.Checked ? "Xe ô tô" : (rdiTauhoa.Checked? "Tàu hỏa" : "Máy bay"));
            txtXuat.Text = _output;
        }
    }
}
