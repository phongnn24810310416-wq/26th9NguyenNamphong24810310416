using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace bai4._3
{
    public partial class Form1 : Form
    {
        BindingList<ProductModel> danhSach = new BindingList<ProductModel>();

        public Form1()
        {
            InitializeComponent();

            dgvSanPham.DataSource = danhSach;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
                return;
            }

            double gia;

            if (!double.TryParse(txtGia.Text, out gia))
            {
                MessageBox.Show("Giá phải là số");
                return;
            }

            ProductModel sp = new ProductModel();
            sp.Ma = txtMa.Text;
            sp.Ten = txtTen.Text;
            sp.Gia = gia;

            danhSach.Add(sp);

            txtMa.Clear();
            txtTen.Clear();
            txtGia.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow != null)
            {
                danhSach.RemoveAt(dgvSanPham.CurrentRow.Index);
            }
        }
    }
}