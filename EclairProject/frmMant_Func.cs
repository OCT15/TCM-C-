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
        int IDPERM;
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
                string sql = string.Format("delete from funcionario where id_funcionario = {0}", txtID_Func.Text);
                cc = new ClasseConexao();
                cc.executarSQL(sql);
                MessageBox.Show("Operação Concluída!");
                this.Close();
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
            txtCEP.Enabled = true;
            btnAlterar2.Visible = true;
            btnExcluir.Enabled = false;
        }

        private void btnAlterar2_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSenha.Text == "" || txtDate_nasc.Text == "" || txtTelefone.Text == "" || txtCel.Text == "" || txtEnd.Text == "" || txtCEP.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Campos vazios detectados");
            }
            else
            {
                DialogResult res = MessageBox.Show("Deseja alterar o campo selecionado?", "Aviso", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if (txtPerm.Text == "Estoquista")
                    {
                        IDPERM = 3;
                    }
                    if (txtPerm.Text == "Atendente")
                    {
                        IDPERM = 2;
                    }
                    if (txtPerm.Text == "Administrador")
                    {
                        IDPERM = 1;
                    }
                    string sql = string.Format("UPDATE funcionario SET nome = '{0}', senha = '{1}', dt_nascim = '{2}', endereco = '{3}', telefone = '{4}', celular = '{5}', cep = '{6}', email = '{7}', id_permissao = {9} where id_funcionario = {8}",
                        txtNome.Text,
                        txtSenha.Text,
                        txtDate_nasc.Text,
                        txtEnd.Text,
                        txtTelefone.Text,
                        txtCel.Text,
                        txtCEP.Text,
                        txtMail.Text,
                        txtID_Func.Text,
                        IDPERM);
                    cc = new ClasseConexao();
                    cc.executarSQL(sql);
                    MessageBox.Show("Operação Concluída!");
                }
                else
                {
                    MessageBox.Show("Operação Cancelada");
                }
                txtPerm.Enabled = false;
                txtNome.Enabled = false;
                txtSenha.Enabled = false;
                txtDate_nasc.Enabled = false;
                txtTelefone.Enabled = false;
                txtCel.Enabled = false;
                txtEnd.Enabled = false;
                txtCEP.Enabled = false;
                txtMail.Enabled = false;
                btnAlterar2.Visible = false;
                btnExcluir.Enabled = true;
            }
        }

        private void frmMant_Func_Load(object sender, EventArgs e)
        {
            pr = new Persist();
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = ("select * from funcionario where id_funcionario like '" + pr.getId() + "'");
            ds = cc.executarSQL(sql);
            if (ds == null || ds.Tables[0].Rows.Count < 1)
            {
                txtPerm.Text = txtNome.Text = txtSenha.Text = txtDate_nasc.Text = txtEnd.Text = txtTelefone.Text = txtCel.Text = txtCEP.Text = txtMail.Text = txtCPF.Text = txtRG.Text = "";
            }
            else
            {
                txtID_Func.Text = ds.Tables[0].Rows[0]["id_funcionario"].ToString();
                txtPerm.Text = ds.Tables[0].Rows[0]["id_permissao"].ToString();
                txtNome.Text = ds.Tables[0].Rows[0]["nome"].ToString();
                txtSenha.Text = ds.Tables[0].Rows[0]["senha"].ToString();
                txtDate_nasc.Text = ds.Tables[0].Rows[0]["dt_nascim"].ToString();
                txtEnd.Text = ds.Tables[0].Rows[0]["endereco"].ToString();
                txtTelefone.Text = ds.Tables[0].Rows[0]["telefone"].ToString();
                txtCel.Text = ds.Tables[0].Rows[0]["celular"].ToString();
                txtCEP.Text = ds.Tables[0].Rows[0]["cep"].ToString();
                txtCPF.Text = ds.Tables[0].Rows[0]["cpf"].ToString();
                txtRG.Text = ds.Tables[0].Rows[0]["rg"].ToString();
                txtMail.Text = ds.Tables[0].Rows[0]["email"].ToString();

                DateTime ag;
                DateTime.TryParse(ds.Tables[0].Rows[0]["dt_nascim"].ToString(), out ag);
                TimeSpan t = DateTime.Now - ag;

                txtDate_nasc.Text = ag.ToShortDateString();
            }
        }
    }
}