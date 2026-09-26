namespace bai4._5
{
    partial class FormRegister
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Text = "Tên đăng nhập:";

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(140, 37);
            this.txtUsername.Size = new System.Drawing.Size(180, 20);

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Text = "Mật khẩu:";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(140, 77);
            this.txtPassword.Size = new System.Drawing.Size(180, 20);
            this.txtPassword.UseSystemPasswordChar = true;

            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(140, 120);
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.Text = "Đăng ký";

            // FormRegister
            this.ClientSize = new System.Drawing.Size(380, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnRegister);
            this.Name = "FormRegister";
            this.Text = "Form đăng ký";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}