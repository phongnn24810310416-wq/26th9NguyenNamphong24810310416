namespace bai4._1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.Button btnXoa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtHienThi = new TextBox();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnBang = new Button();
            btnXoa = new Button();
            SuspendLayout();

            txtHienThi.Font = new Font("Arial", 18F);
            txtHienThi.Location = new Point(20, 20);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.ReadOnly = true;
            txtHienThi.Size = new Size(240, 35);
            txtHienThi.TabIndex = 0;
            txtHienThi.TextAlign = HorizontalAlignment.Right;

            btn0.Location = new Point(20, 230);
            btn0.Name = "btn0";
            btn0.Size = new Size(55, 45);
            btn0.TabIndex = 1;
            btn0.Text = "0";

            btn1.Location = new Point(20, 180);
            btn1.Name = "btn1";
            btn1.Size = new Size(55, 45);
            btn1.TabIndex = 2;
            btn1.Text = "1";

            btn2.Location = new Point(80, 180);
            btn2.Name = "btn2";
            btn2.Size = new Size(55, 45);
            btn2.TabIndex = 3;
            btn2.Text = "2";

            btn3.Location = new Point(140, 180);
            btn3.Name = "btn3";
            btn3.Size = new Size(55, 45);
            btn3.TabIndex = 4;
            btn3.Text = "3";

            btn4.Location = new Point(20, 130);
            btn4.Name = "btn4";
            btn4.Size = new Size(55, 45);
            btn4.TabIndex = 5;
            btn4.Text = "4";

            btn5.Location = new Point(80, 130);
            btn5.Name = "btn5";
            btn5.Size = new Size(55, 45);
            btn5.TabIndex = 6;
            btn5.Text = "5";

            btn6.Location = new Point(140, 130);
            btn6.Name = "btn6";
            btn6.Size = new Size(55, 45);
            btn6.TabIndex = 7;
            btn6.Text = "6";

            btn7.Location = new Point(20, 80);
            btn7.Name = "btn7";
            btn7.Size = new Size(55, 45);
            btn7.TabIndex = 8;
            btn7.Text = "7";

            btn8.Location = new Point(80, 80);
            btn8.Name = "btn8";
            btn8.Size = new Size(55, 45);
            btn8.TabIndex = 9;
            btn8.Text = "8";

            btn9.Location = new Point(140, 80);
            btn9.Name = "btn9";
            btn9.Size = new Size(55, 45);
            btn9.TabIndex = 10;
            btn9.Text = "9";

            btnCong.Location = new Point(205, 230);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(55, 45);
            btnCong.TabIndex = 11;
            btnCong.Text = "+";

            btnTru.Location = new Point(205, 180);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(55, 45);
            btnTru.TabIndex = 12;
            btnTru.Text = "-";

            btnNhan.Location = new Point(205, 130);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(55, 45);
            btnNhan.TabIndex = 13;
            btnNhan.Text = "*";

            btnChia.Location = new Point(205, 80);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(55, 45);
            btnChia.TabIndex = 14;
            btnChia.Text = "/";

            btnBang.Location = new Point(140, 230);
            btnBang.Name = "btnBang";
            btnBang.Size = new Size(55, 45);
            btnBang.TabIndex = 15;
            btnBang.Text = "=";

            btnXoa.Location = new Point(80, 230);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(55, 45);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "C";

            ClientSize = new Size(285, 316);
            Controls.Add(txtHienThi);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnCong);
            Controls.Add(btnTru);
            Controls.Add(btnNhan);
            Controls.Add(btnChia);
            Controls.Add(btnBang);
            Controls.Add(btnXoa);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}