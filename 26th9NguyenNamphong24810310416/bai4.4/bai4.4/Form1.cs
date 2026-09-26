using System;
using System.IO;
using System.Windows.Forms;

namespace bai4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "File ảnh|*.jpg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = open.FileName;
            }
        }

        private void btnXuatCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "File CSV|*.csv";
            save.FileName = "danhsach.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, "Ma,Ten,Gia");
                MessageBox.Show("Đã tạo file CSV");
            }
        }
    }
}