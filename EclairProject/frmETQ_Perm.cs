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
    public partial class frmETQ_Perm : Form
    {
        public frmETQ_Perm()
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

        private void btnCons_Estq_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCons_Estq>().Count() > 0)
            {

            }
            else
            {
                frmCons_Estq fAP = new frmCons_Estq();
                fAP.Location = new Point(443, 133);
                fAP.ShowDialog();
            }
        }

        private void btnRelat_Estq_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelat_Estq>().Count() > 0)
            {

            }
            else
            {
                frmRelat_Estq fAP = new frmRelat_Estq();
                fAP.Location = new Point(443, 133);
                fAP.ShowDialog();
            }
        }

        private void btnCompra_Estq_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCompra_Estq>().Count() > 0)
            {

            }
            else
            {
                frmCompra_Estq fAP = new frmCompra_Estq();
                fAP.Location = new Point(443, 133);
                fAP.ShowDialog();
            }
        }
    }
}
