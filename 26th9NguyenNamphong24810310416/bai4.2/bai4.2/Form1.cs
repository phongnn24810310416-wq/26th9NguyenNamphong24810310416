using System;
using System.Windows.Forms;

namespace bai4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool loi = false;

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập họ tên");
                loi = true;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Vui lòng nhập email");
                loi = true;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                errorProvider1.SetError(txtSoDienThoai, "Vui lòng nhập số điện thoại");
                loi = true;
            }

            if (cboLop.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboLop, "Vui lòng chọn lớp");
                loi = true;
            }

            if (!loi)
            {
                MessageBox.Show("Đăng ký thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSoDienThoai.Clear();
            cboLop.SelectedIndex = -1;
            errorProvider1.Clear();
        }
    }
}