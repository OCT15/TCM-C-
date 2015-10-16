using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EclairProject
{
    public partial class frmATD_Perm : Form
    {
        public frmATD_Perm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCons_Cli_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCons_Cli>().Count() > 0)
            {

            }
            else
            {
                frmCons_Cli fCC = new frmCons_Cli();
                fCC.Location = new Point(443, 133);
                fCC.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPesq_Cli>().Count() > 0)
            {

            }
            else
            {
                frmPesq_Cli fPC = new frmPesq_Cli();
                fPC.Location = new Point(443, 133);
                fPC.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblRetornar.Visible = true;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblRetornar.Visible = false;
        }
    }
}
