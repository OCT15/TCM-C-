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
    public partial class frmInser_Cli : Form
    {
        ClasseConexao cc;
        DataSet ds;
        int id;
        public frmInser_Cli(int var)
        {
            InitializeComponent();

          id = var;


        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo nome está vazio!");
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("O campo senha está vazio!");
            }
            if (txtIdade.Text == "")
            {
                MessageBox.Show("O campo idade está vazio!");
            }
            if (txtDate_nasc.Text == "")
            {
                MessageBox.Show("O campo nascimento está vazio!");
            }
            if (txtTelefone.Text == "")
            {
                MessageBox.Show("O campo telefone está vazio!");
            }
            if (txtCel.Text == "")
            {
                MessageBox.Show("O campo celular está vazio!");
            }
            if (txtEnd.Text == "")
            {
                MessageBox.Show("O campo endereço está vazio!");
            }
            if (txtCPF.Text == "")
            {
                MessageBox.Show("O campo CPF está vazio!");
            }
            if (txtCEP.Text == "")
            {
                MessageBox.Show("O campo CEP está vazio!");
            }
            if (txtMail.Text == "")
            {
                MessageBox.Show("O campo email está vazio!");
            }
            DialogResult res = MessageBox.Show("Deseja inserir os campos selecionados?", "Aviso", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = string.Format("insert into cliente values ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                    txtID_Cli.Text,
                    txtNome.Text,
                    txtSenha.Text,
                    txtDate_nasc.Text,
                    txtEnd.Text,
                    txtTelefone.Text,
                    txtCel.Text,
                    txtCEP.Text,
                    txtCPF.Text,
                    txtMail.Text);
                cc = new ClasseConexao();
                cc.executarSQL(sql);
            }
            else
            {
                MessageBox.Show("Operação Cancelada");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = 
            txtSenha.Text = 
            txtEnd.Text = 
            txtDate_nasc.Text =
            txtEnd.Text = txtTelefone.Text = 
            txtCel.Text = 
            txtCPF.Text = 
            txtCEP.Text = 
            txtIdade.Text = 
            txtMail.Text = "";
        }

        private void frmInser_Cli_Load(object sender, EventArgs e)
        {
            txtID_Cli.Text = id.ToString();
            txtID_Cli.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsCpf(txtCPF.Text))
            {
                ptbCPF.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("CPF inválido");
                ptbCPF.BackColor = Color.Red;
                txtCPF.Text = "";
            }
        }

        private void txtDate_nasc_Leave(object sender, EventArgs e)
        {
            if(ClasseValida.Data(txtDate_nasc.Text))
            {
                ptbData.BackColor = Color.Green;
                DateTime ag;
                DateTime.TryParse(txtDate_nasc.Text, out ag);
                TimeSpan t = DateTime.Now - ag;
                txtIdade.Text = Math.Floor(t.Days / 365d) + "";
            }
            else
            {
                MessageBox.Show("Data inválida");
                ptbData.BackColor = Color.Red;
                txtCPF.Text = "";
            }
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            lblRetornar.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            lblRetornar.Visible = false;
        }

        private void frmInser_Cli_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            lblCPF.Text = "CPF";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            lblCPF.Text = "CNPJ";
        }

    }
}
