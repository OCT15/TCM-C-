using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EclairProject
{
    public partial class frmADM_Perm : Form
    {
        private int Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 41 * 4;
        private int Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 20 * 12;

        public frmADM_Perm()
        {
            InitializeComponent();
        } //INITIALIZE

        private void btnCons_Func_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCons_Func>().Count() > 0)
            {
            }
            else
            {
                frmCons_Func fCF = new frmCons_Func();
                fCF.Location = new Point(Height + Height / 40, Width + Width / 80);
                fCF.ShowDialog();
            }
        } //frmCons_Func

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        } //back form

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblRetornar.Visible = true;
        }  // Hover => Visible lbl

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblRetornar.Visible = false;
        }  // Leave => Invisible lbl

        private void btnManter_Func_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPesq_Func>().Count() > 0)
            {
            }
            else
            {
                frmPesq_Func fPF = new frmPesq_Func();
                fPF.Location = new Point(Height + Height / 40, Width + Width / 80);
                fPF.ShowDialog();
            }
        } //frmManter_Func

        private void btnGerar_NF_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmGerar_NF>().Count() > 0)
            {
            }
            else
            {
                frmGerar_NF fGNF = new frmGerar_NF();
                fGNF.Location = new Point(443, 133);
                fGNF.ShowDialog();
            }
        } //frmGerar_NF

        private void btnGerar_FC_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmGerar_FC>().Count() > 0)
            {
            }
            else
            {
                frmGerar_FC fGFC = new frmGerar_FC();
                fGFC.Location = new Point(443, 133);
                fGFC.ShowDialog();
            }
        } //frmGerar_FC

        private void btnCons_FC_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCons_FxC>().Count() > 0)
            {
            }
            else
            {
                frmCons_FxC fCFC = new frmCons_FxC();
                fCFC.Location = new Point(443, 133);
                fCFC.ShowDialog();
            }
        } //frmCons_FC

        private void btnGerar_B_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmGerar_B>().Count() > 0)
            {
            }
            else
            {
                frmGerar_B fGB = new frmGerar_B();
                fGB.Location = new Point(443, 133);
                fGB.ShowDialog();
            }
        } //frmGerar_B
    }
} //frmADM_Perm - Permissão do Admnistrador; 6 Formulários;;