using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EclairProject
{
    public partial class frmMDI : Form
    {
        int seg = 0, min = 0, hr = 0;
        private string nm_permissao;
        private string nome;
        private string id_permissao;
        private frmSplash frmSplash;
        private bool done = false;
        public frmMDI(string name, string nmpermissao, string permissao)
        {
            InitializeComponent();

            btnADM.Enabled = permissao.Contains("adm");
            btnATD.Enabled = permissao.Contains("atd");
            btnETQ.Enabled = permissao.Contains("etq");

            nome = name;
            nm_permissao = nmpermissao;
            id_permissao = permissao;
            

            this.Load += new EventHandler(HandleFormLoad);
            this.frmSplash = new frmSplash();
        }
        private void HandleFormLoad(object sender, EventArgs e)
        {
            this.Hide();
            Thread thread = new Thread(new ThreadStart(this.ShowSplashScreen));
            thread.Start();
            ClasseSplash worker = new ClasseSplash();
            worker.ProgressChanged += (o, ex) =>
            {
                this.frmSplash.UpdateProgress(ex.Progress);
            };
            worker.HardWorkDone += (o, ex) =>
                {
                    done = true;
                    this.Show();
                };
            worker.DoHardWork();
        }
        private void ShowSplashScreen()
        {
            frmSplash.Show();
            while (!done)
            {
                Application.DoEvents();
            }
            frmSplash.Close();
            this.frmSplash.Dispose();
        }
        private void frmMDI_Load(object sender, EventArgs e)
        {
            if (id_permissao == "2")
            {
                btnADM.Enabled = false;
            }
            if (id_permissao == "1")
            {
                btnADM.Enabled = false;
                btnATD.Enabled = false;
            }
            var data = DateTime.Now;
            int horas = data.Hour;
            if (horas >= 0 && horas < 12)
            {
                lblHora.Text = "Bom Dia\nEclairCorp™";
            }
            if (horas >= 12 && horas < 18)
            {
                lblHora.Text = "Boa Tarde\nEclairCorp™";
            }
            if (horas >= 18 && horas <=23)
            {
                lblHora.Text = "Boa Noite\nEclairCorp™";
            }

            lblText.Text = "Nível de Acesso: "+nm_permissao+"";
            lblNome.Text = nome;

            timer1.Enabled = true;
        }

        private void btnADM_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmADM_Perm>().Count() > 0)
            {

            }
            else
            {
                frmADM_Perm fDM = new frmADM_Perm();
                fDM.Location = new Point(443, 133);
                fDM.ShowDialog();
            }
        }

        private void btnATD_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmATD_Perm>().Count() > 0)
            {

            }
            else
            {
                frmATD_Perm fAP = new frmATD_Perm();
                fAP.Location = new Point(443, 133);
                fAP.ShowDialog();
            }
        }

        private void btnETQ_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmETQ_Perm>().Count() > 0)
            {

            }
            else
            {
                frmETQ_Perm fEP = new frmETQ_Perm();
                fEP.Location = new Point(443, 133);
                fEP.ShowDialog(); 
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }
            else if (min == 60)
            {
                hr++;
                min = 0;
            }

            lblCronometro.Text = hr.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');

        }

        private void btnADM_MouseHover(object sender, EventArgs e)
        {
            lblAdministrador.Visible = true;
        }

        private void btnADM_MouseLeave(object sender, EventArgs e)
        {
            lblAdministrador.Visible = false;
        }

        private void btnATD_MouseHover(object sender, EventArgs e)
        {
            lblAtendente.Visible = true;
        }

        private void btnATD_MouseLeave(object sender, EventArgs e)
        {
            lblAtendente.Visible = false;
        }

        private void btnETQ_MouseHover(object sender, EventArgs e)
        {
            lblEstoquista.Visible = true;
        }

        private void btnETQ_MouseLeave(object sender, EventArgs e)
        {
            lblEstoquista.Visible = false;
        }
        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeslogar_MouseLeave(object sender, EventArgs e)
        {
            lblLogOff.Visible = false;
        }

        private void btnDeslogar_MouseHover(object sender, EventArgs e)
        {
            lblLogOff.Visible = true;
        }

    }
}

