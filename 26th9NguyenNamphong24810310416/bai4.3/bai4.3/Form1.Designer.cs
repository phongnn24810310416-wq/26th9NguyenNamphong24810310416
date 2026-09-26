namespace bai4._3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvSanPham;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMa = new Label();
            lblTen = new Label();
            lblGia = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            txtGia = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            dgvSanPham = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();

            lblMa.AutoSize = true;
            lblMa.Location = new Point(25, 25);
            lblMa.Text = "Mã:";

            txtMa.Location = new Point(90, 22);
            txtMa.Size = new Size(180, 27);

            lblTen.AutoSize = true;
            lblTen.Location = new Point(25, 65);
            lblTen.Text = "Tên:";

            txtTen.Location = new Point(90, 62);
            txtTen.Size = new Size(180, 27);

            lblGia.AutoSize = true;
            lblGia.Location = new Point(25, 105);
            lblGia.Text = "Giá:";

            txtGia.Location = new Point(90, 102);
            txtGia.Size = new Size(180, 27);

            btnThem.Location = new Point(300, 22);
            btnThem.Size = new Size(90, 35);
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;

            btnXoa.Location = new Point(300, 65);
            btnXoa.Size = new Size(90, 35);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;

            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.Location = new Point(25, 150);
            dgvSanPham.Size = new Size(550, 250);
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "cotMa",
                HeaderText = "Mã",
                DataPropertyName = "Ma"
            });

            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "cotTen",
                HeaderText = "Tên sản phẩm",
                DataPropertyName = "Ten"
            });

            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "cotGia",
                HeaderText = "Giá",
                DataPropertyName = "Gia"
            });

            ClientSize = new Size(610, 430);
            Controls.Add(lblMa);
            Controls.Add(txtMa);
            Controls.Add(lblTen);
            Controls.Add(txtTen);
            Controls.Add(lblGia);
            Controls.Add(txtGia);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(dgvSanPham);

            Name = "Form1";
            Text = "Quản lý sản phẩm";

            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}