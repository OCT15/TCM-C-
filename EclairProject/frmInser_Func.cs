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
    public partial class frmInser_Func : Form
    {
        int IDPERM;
        Persist pr;
        ClasseConexao cc;
        DataSet ds;
        int var;
        public frmInser_Func(int id)
        {
            var = id;
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = 
            txtSenha.Text = 
            txtEnd.Text = 
            txtDate_nasc.Text = 
            txtMail.Text = 
            txtTelefone.Text = 
            txtCel.Text = 
            txtPerm.Text = 
            txtCPF.Text = 
            txtRG.Text = 
            txtCEP.Text = "";
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsCpf(txtCPF.Text))
            {
                ptbCPF.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("CPF incorreto");
                ptbCPF.BackColor = Color.Red;
                txtCPF.Text = "";
            }
        }

        private void txtDate_nasc_Leave(object sender, EventArgs e)
        {
            if(ClasseValida.Data(txtDate_nasc.Text))
            {
                ptbData.BackColor = Color.MediumTurquoise;
                DateTime ag;
                DateTime.TryParse(txtDate_nasc.Text, out ag);
                TimeSpan t = DateTime.Now - ag;
            }
            else
            {
                MessageBox.Show("Data incorreta");
                ptbData.BackColor = Color.Red;
                txtCPF.Text = "";
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsEmail(txtMail.Text))
            {
                ptbMail.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("Email incorreto");
                ptbMail.BackColor = Color.Red;
                txtMail.Text = "";
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsTel(txtTelefone.Text))
            {
                ptbTelefone.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("Telefone incorreto");
                ptbTelefone.BackColor = Color.Red;
                txtTelefone.Text = "";
            }
        }

        private void txtCel_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsTel(txtCel.Text))
            {
                ptbCel.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("Telefone incorreto");
                ptbCel.BackColor = Color.Red;
                txtCel.Text = "";
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsCep(txtCEP.Text))
            {
                ptbCEP.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("CEP incorreto");
                ptbCEP.BackColor = Color.Red;
                txtCEP.Text = "";
            }
        }

        private void txtRG_Leave(object sender, EventArgs e)
        {
            if (ClasseValida.IsRG(txtRG.Text))
            {
                ptbRG.BackColor = Color.MediumTurquoise;
            }
            else
            {
                MessageBox.Show("RG incorreto");
                ptbRG.BackColor = Color.Red;
                txtRG.Text = "";
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtPerm.Text == "Estoquista")
            {
                IDPERM = 1;
            }
            if (txtPerm.Text == "Atendente")
            {
                IDPERM = 2;
            }
            if (txtPerm.Text == "Administrador")
            {
                IDPERM = 1;
            }
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = string.Format ("insert into funcionario values({0},{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}', '{11}','{12}')",
                         txtID_Func.Text,
                         IDPERM,
                         txtNome.Text,
                         txtSenha.Text,
                         txtDate_nasc.Text,
                         txtEnd.Text,
                         txtTelefone.Text,
                         txtCel.Text,
                         txtCEP.Text,
                         txtCPF.Text,
                         txtRG.Text,
                         "SP",
                         txtMail.Text);
            cc.executarSQL(sql);
            MessageBox.Show("Operação Concluída");
        }

        private void frmInser_Func_Load(object sender, EventArgs e)
        {
            txtID_Func.Text = var.ToString();
            txtID_Func.Enabled = false;
        }

    }
}