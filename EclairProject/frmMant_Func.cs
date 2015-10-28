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
    public partial class frmMant_Func : Form
    {
        Persist pr;
        ClasseConexao cc;
        DataSet ds;
        public frmMant_Func()
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja excluir o campo selecionado?", "Aviso", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = string.Format("delete from funcionario where id_funcionario = {0}", txtID_Cli.Text);
                cc = new ClasseConexao();
                cc.executarSQL(sql);
            }
            else
            {
                MessageBox.Show("Operação Cancelada");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtEnd.Enabled = true;
            txtDate_nasc.Enabled = true;
            txtMail.Enabled = true;
            txtTelefone.Enabled = true;
            txtCel.Enabled = true;
            txtPerm.Enabled = true;
            txtCPF.Enabled = true;
            txtRG.Enabled = true;
            txtCEP.Enabled = true;
            btnAlterar2.Visible = true;
            btnExcluir.Enabled = false;
        }

        private void btnAlterar2_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSenha.Text == "" || txtDate_nasc.Text == "" || txtTelefone.Text == "" || txtCel.Text == "" || txtEnd.Text == "" || txtCEP.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("O campo nome está vazio!");
            }
            

            DialogResult res = MessageBox.Show("Deseja alterar o campo selecionado?", "Aviso", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = string.Format("UPDATE funcionario SET nome = '{0}', senha = '{1}', idade = '{2}', dt_nascim = '{3}', endereco = '{4}', telefone = '{5}', celular = '{6}', cep = '{7}', cpf = '{8}', email = '{9}' where id_cliente = {10}",
                    txtNome.Text,
                    txtSenha.Text,
                    txtDate_nasc.Text,
                    txtEnd.Text,
                    txtTelefone.Text,
                    txtCel.Text,
                    txtCEP.Text,
                    txtCPF.Text,
                    txtMail.Text,
                    txtID_Cli.Text);
                cc = new ClasseConexao();
                cc.executarSQL(sql);
            }
            else
            {
                MessageBox.Show("Operação Cancelada");
            }
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtDate_nasc.Enabled = false;
            txtTelefone.Enabled = false;
            txtCel.Enabled = false;
            txtEnd.Enabled = false;
            txtCPF.Enabled = false;
            txtCEP.Enabled = false;
            txtMail.Enabled = false;
            btnAlterar2.Visible = false;
            btnExcluir.Enabled = true;
        }
        }
    }
