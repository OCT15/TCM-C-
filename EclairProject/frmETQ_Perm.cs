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
        int Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 41 * 4;
        int Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 20 * 12;
        public frmETQ_Perm()
        {
            InitializeComponent();
        } //INITIALIZE
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        } //back frm
        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblRetornar.Visible = true;
        }  //Houver => Visible lbl
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblRetornar.Visible = false;
        }  //Leave => Invisible lbl
        private void btnCons_Estq_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCons_Estq>().Count() > 0)
            {

            }
            else
            {
                frmCons_Estq fAP = new frmCons_Estq();
                fAP.Location = new Point(Height + Height / 40, Width + Width / 80);
                fAP.ShowDialog();
            }
        }  //frm_Cons_Est
        private void btnRelat_Estq_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelat_Estq>().Count() > 0)
            {

            }
            else
            {
                frmRelat_Estq fAP = new frmRelat_Estq();
                fAP.Location = new Point(Height + Height / 40, Width + Width / 80);
                fAP.ShowDialog();
            }
        }  //frm_Relat_Est
        private void btnCompra_Estq_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCompra_Estq>().Count() > 0)
            {

            }
            else
            {
                frmCompra_Estq fAP = new frmCompra_Estq();
                fAP.Location = new Point(Height + Height / 40, Width + Width / 80);
                fAP.ShowDialog();
            }
        }  //frm_Compra_Est
<<<<<<< HEAD

        private void btnCons_Forn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFornecedores>().Count() > 0)
=======
        private void btnCad_Forn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCad_Forn>().Count() > 0)
>>>>>>> origin/master
            {

            }
            else
            {
<<<<<<< HEAD
                frmFornecedores fF = new frmFornecedores();
                fF.Location = new Point(Height + Height / 80, Width + Width / 160);
                fF.ShowDialog();
            }
        }

        private void btnCad_Forn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmInser_Forn>().Count() > 0)
=======
                frmCad_Forn fCF = new frmCad_Forn();
                fCF.Location = new Point(443, 133);
                fCF.ShowDialog();
            }
        }  //frm_Cad_Forn
        private void btnCons_Forn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFornecedores>().Count() > 0)
>>>>>>> origin/master
            {

            }
            else
            {
<<<<<<< HEAD
                frmInser_Forn fCF = new frmInser_Forn();
                fCF.Location = new Point(Height + Height / 40, Width + Width / 80);
                fCF.ShowDialog();
            }
        }

=======
                frmFornecedores fF = new frmFornecedores();
                fF.Location = new Point(500, 220);
                fF.ShowDialog();
            }
        }//frm_Cons_Forn
>>>>>>> origin/master
    }
}   //frmETQ_Perm - Permissão de Estoquista; 5 formulários
