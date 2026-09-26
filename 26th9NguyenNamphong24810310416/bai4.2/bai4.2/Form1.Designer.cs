namespace bai4._2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblHoTen = new Label();
            lblEmail = new Label();
            lblSoDienThoai = new Label();
            lblLop = new Label();

            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            txtSoDienThoai = new TextBox();

            cboLop = new ComboBox();

            btnSubmit = new Button();
            btnXoa = new Button();

            errorProvider1 = new ErrorProvider(components);

            SuspendLayout();

            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(30, 30);
            lblHoTen.Text = "Họ tên:";

            txtHoTen.Location = new Point(130, 27);
            txtHoTen.Size = new Size(220, 27);

            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 75);
            lblEmail.Text = "Email:";

            txtEmail.Location = new Point(130, 72);
            txtEmail.Size = new Size(220, 27);

            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(30, 120);
            lblSoDienThoai.Text = "Số điện thoại:";

            txtSoDienThoai.Location = new Point(130, 117);
            txtSoDienThoai.Size = new Size(220, 27);

            lblLop.AutoSize = true;
            lblLop.Location = new Point(30, 165);
            lblLop.Text = "Lớp:";

            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.Items.AddRange(new object[]
            {
                "Lớp 1",
                "Lớp 2",
                "Lớp 3"
            });
            cboLop.Location = new Point(130, 162);
            cboLop.Size = new Size(220, 28);

            btnSubmit.Location = new Point(130, 215);
            btnSubmit.Size = new Size(100, 35);
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;

            btnXoa.Location = new Point(250, 215);
            btnXoa.Size = new Size(100, 35);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;

            errorProvider1.ContainerControl = this;

            ClientSize = new Size(400, 280);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblSoDienThoai);
            Controls.Add(txtSoDienThoai);
            Controls.Add(lblLop);
            Controls.Add(cboLop);
            Controls.Add(btnSubmit);
            Controls.Add(btnXoa);

            Name = "Form1";
            Text = "Đăng ký học viên";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}