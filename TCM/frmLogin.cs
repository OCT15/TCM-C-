using System;
using System.Windows.Forms;

namespace csharp
{
    public partial class frmLogin : Form
    {
        private ToolStripMenuItem bt;

        public frmLogin(ToolStripMenuItem btnAdm)
        {
            bt = btnAdm;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Caio" && txtPasw.Text == "12345")
            {
                MessageBox.Show("Bem vindo " + txtUser.Text);
                bt.Visible = false;
                this.Close();
            }
            if (txtUser.Text == "adm" && txtPasw.Text == "senhaadm")
            {
                MessageBox.Show("Adm mode enable");
                bt.Visible = true;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblsinal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Um software da OTC - Corporação OsSemTera ");
        }
    }
}