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
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
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

        private void btnForn_Per_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmForn_Per>().Count() > 0)
            {

            }
            else
            {
                frmForn_Per fFP = new frmForn_Per();
                fFP.Location = new Point(443, 133);
                fFP.ShowDialog();
                this.Close();
            }
        }

        private void btnForn_Cons_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmForn_Cons>().Count() > 0)
            {

            }
            else
            {
                frmForn_Cons fFC = new frmForn_Cons();
                fFC.Location = new Point(443, 133);
                fFC.ShowDialog();
                this.Close();
            }
        }
    }
}
