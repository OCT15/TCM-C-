using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EclairProject
{
    public partial class frmATD_Perm : Form
    {
        private int Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 41 * 4;
        private int Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 20 * 12;

        public frmATD_Perm()
        {
            InitializeComponent();
        } // INITIALIZE
<<<<<<< HEAD

=======
>>>>>>> origin/master
        private void btnCons_Cli_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCons_Cli>().Count() > 0)
            {
            }
            else
            {
                frmCons_Cli fCC = new frmCons_Cli();
                fCC.Location = new Point(Height + Height / 40, Width + Width / 80);
                fCC.ShowDialog();
            }
        } //frmCons_Cli
<<<<<<< HEAD

=======
>>>>>>> origin/master
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }  //back form
<<<<<<< HEAD

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblRetornar.Visible = true;
        } // Hover => Visible lbl

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblRetornar.Visible = false;
        }  // Leave => Invisible lbl

        private void btnCadas_Evento_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadas_Evento>().Count() > 0)
=======
        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblRetornar.Visible = true;
        } // Hover => Visible lbl
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblRetornar.Visible = false;
        }  // Leave => Invisible lbl
        private void btnCadas_Evento_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadas_Evento>().Count() > 0)
            {

            }
            else
            {
                frmCadas_Evento fCE = new frmCadas_Evento();
                fCE.Location = new Point(443, 133);
                fCE.ShowDialog();
            }
        }  //frmCadas_Evento
        private void btnCons_Evento_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCons_Evento>().Count() > 0)
>>>>>>> origin/master
            {
            }
            else
            {
                frmCadas_Evento fCE = new frmCadas_Evento();
                fCE.Location = new Point(Height + Height / 40, Width + Width / 80);
                fCE.ShowDialog();
            }
        }  //frmCadas_Evento

        private void btnCons_Evento_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCons_Evento>().Count() > 0)
            {
            }
            else
            {
<<<<<<< HEAD
                frmCons_Evento fCEE = new frmCons_Evento();
                fCEE.Location = new Point(Height + Height / 40, Width + Width / 80);
                fCEE.ShowDialog();
            }
        }  //frmCons_EVento

        private void btnGerar_C_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmGerar_C>().Count() > 0)
            {
            }
            else
            {
                frmGerar_C fGC = new frmGerar_C();
                fGC.Location = new Point(Height + Height / 40, Width + Width / 80);
                fGC.ShowDialog();
            }
        }  //frmGerar_C

        private void btnGerar_O_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmGerar_O>().Count() > 0)
            {
            }
            else
            {
                frmGerar_O fGO = new frmGerar_O();
                fGO.Location = new Point(Height + Height / 40, Width + Width / 80);
                fGO.ShowDialog();
            }
        }  //frmGerar_O

        private void btnCons_Calen_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCons_Calen>().Count() > 0)
            {
            }
            else
            {
                frmCons_Calen fCC = new frmCons_Calen();
                fCC.Location = new Point(Height + Height / 40, Width + Width / 80);
                fCC.ShowDialog();
            }
        } //frmCons_Calen

        private void btnPesq_Cli_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPesq_Cli>().Count() > 0)
            {
=======
                frmCons_Evento fCEE= new frmCons_Evento();
                fCEE.Location = new Point(443, 133);
                fCEE.ShowDialog();
            }
        }  //frmCons_EVento
        private void btnGerar_C_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmGerar_C>().Count() > 0)
            {

            }
            else
            {
                frmGerar_C fGC = new frmGerar_C();
                fGC.Location = new Point(443, 133);
                fGC.ShowDialog();
            }
        }  //frmGerar_C
        private void btnGerar_O_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmGerar_O>().Count() > 0)
            {

            }
            else
            {
                frmGerar_O fGO = new frmGerar_O();
                fGO.Location = new Point(443, 133);
                fGO.ShowDialog();
            }
        }  //frmGerar_O
        private void btnCons_Calen_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCons_Calen>().Count() > 0)
            {

            }
            else
            {
                frmCons_Calen fCC = new frmCons_Calen();
                fCC.Location = new Point(443, 133);
                fCC.ShowDialog();
            }
        } //frmCons_Calen
        private void btnPesq_Cli_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPesq_Cli>().Count() > 0)
            {

>>>>>>> origin/master
            }
            else
            {
                frmPesq_Cli fPC = new frmPesq_Cli();
<<<<<<< HEAD
                fPC.Location = new Point(Height + Height / 40, Width + Width / 80);
                fPC.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAprov_Orç>().Count() > 0)
            {
            }
            else
            {
                frmAprov_Orç fAO = new frmAprov_Orç();
                fAO.Location = new Point(Height + Height / 40, Width + Width / 80);
                fAO.ShowDialog();
            }
        }  //frmPesq_Cli
    }
}  //frmATD_Perm - Permissao Atendente; 7 Formulários;;
=======
                fPC.Location = new Point(443, 133);
                fPC.ShowDialog();
            }
        }  //frmPesq_Cli
    }
}  //frmATD_Perm - Permissao Atendente; 7 Formulários;;
>>>>>>> origin/master
