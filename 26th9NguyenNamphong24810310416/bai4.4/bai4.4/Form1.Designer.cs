namespace bai4._4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnXuatCsv;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnChonAnh = new Button();
            btnXuatCsv = new Button();

            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();

            pictureBox1.Location = new Point(30, 30);
            pictureBox1.Size = new Size(300, 250);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;

            btnChonAnh.Location = new Point(30, 300);
            btnChonAnh.Size = new Size(120, 40);
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.Click += btnChonAnh_Click;

            btnXuatCsv.Location = new Point(170, 300);
            btnXuatCsv.Size = new Size(120, 40);
            btnXuatCsv.Text = "Xuất CSV";
            btnXuatCsv.Click += btnXuatCsv_Click;

            ClientSize = new Size(360, 370);
            Controls.Add(pictureBox1);
            Controls.Add(btnChonAnh);
            Controls.Add(btnXuatCsv);

            Text = "Nạp ảnh và xuất CSV";

            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
        }
    }
}