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
<<<<<<< HEAD

    public partial class frmFornecedores : Form
    {
        int Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 41 * 4;
        int Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 20 * 12;
=======
    public partial class frmFornecedores : Form
    {
>>>>>>> origin/master
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
<<<<<<< HEAD
            if (Application.OpenForms.OfType<frmCons_Forn_Perc>().Count() > 0)
=======
            if (Application.OpenForms.OfType<frmForn_Per>().Count() > 0)
>>>>>>> origin/master
            {

            }
            else
            {
<<<<<<< HEAD
                frmCons_Forn_Perc fFP = new frmCons_Forn_Perc();
                fFP.Location = new Point(Height + Height / 40, Width + Width / 80);
=======
                frmForn_Per fFP = new frmForn_Per();
                fFP.Location = new Point(443, 133);
>>>>>>> origin/master
                fFP.ShowDialog();
                this.Close();
            }
        }

        private void btnForn_Cons_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (Application.OpenForms.OfType<frmCons_Forn_Cons>().Count() > 0)
=======
            if (Application.OpenForms.OfType<frmForn_Cons>().Count() > 0)
>>>>>>> origin/master
            {

            }
            else
            {
<<<<<<< HEAD
                frmCons_Forn_Cons fFC = new frmCons_Forn_Cons();
                fFC.Location = new Point(Height + Height / 40, Width + Width / 80);
=======
                frmForn_Cons fFC = new frmForn_Cons();
                fFC.Location = new Point(443, 133);
>>>>>>> origin/master
                fFC.ShowDialog();
                this.Close();
            }
        }
    }
}
