using System;
using System.Windows.Forms;

namespace bai4._1
{
    public partial class Form1 : Form
    {
        double so1;
        string phepTinh;

        public Form1()
        {
            InitializeComponent();

            btn0.Click += btnNum_Click;
            btn1.Click += btnNum_Click;
            btn2.Click += btnNum_Click;
            btn3.Click += btnNum_Click;
            btn4.Click += btnNum_Click;
            btn5.Click += btnNum_Click;
            btn6.Click += btnNum_Click;
            btn7.Click += btnNum_Click;
            btn8.Click += btnNum_Click;
            btn9.Click += btnNum_Click;

            btnCong.Click += btnPhepTinh_Click;
            btnTru.Click += btnPhepTinh_Click;
            btnNhan.Click += btnPhepTinh_Click;
            btnChia.Click += btnPhepTinh_Click;

            btnBang.Click += btnBang_Click;
            btnXoa.Click += btnXoa_Click;
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtHienThi.Text += btn.Text;
        }

        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtHienThi.Text != "")
            {
                so1 = double.Parse(txtHienThi.Text);
                phepTinh = btn.Text;
                txtHienThi.Clear();
            }
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (txtHienThi.Text == "")
                return;

            double so2 = double.Parse(txtHienThi.Text);
            double ketQua = 0;

            if (phepTinh == "+")
                ketQua = so1 + so2;
            else if (phepTinh == "-")
                ketQua = so1 - so2;
            else if (phepTinh == "*")
                ketQua = so1 * so2;
            else if (phepTinh == "/")
            {
                if (so2 == 0)
                {
                    MessageBox.Show("khong the chia cho 0");
                    return;
                }

                ketQua = so1 / so2;
            }

            txtHienThi.Text = ketQua.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHienThi.Clear();
            so1 = 0;
            phepTinh = "";
        }
    }
}