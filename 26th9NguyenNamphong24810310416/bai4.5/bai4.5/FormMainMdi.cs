using System;
using System.Windows.Forms;

namespace bai4._5
{
    public partial class FormMainMdi : Form
    {
        public FormMainMdi()
        {
            InitializeComponent();
        }

        private void menuRegister_Click(object sender, EventArgs e)
        {
            FormRegister child = new FormRegister();
            child.MdiParent = this;
            child.Show();
        }
    }
}