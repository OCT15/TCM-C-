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
    public partial class naosei : Form
    {
        int var_x = 1;
        ClasseConexao cc;
        DataSet ds;
        public naosei()
        {
            InitializeComponent();
        }
        private void atualizarCampos()
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = string.Format("select * from cliente where id_funcionario = {0}", txtID_func.Text);
            ds = cc.executarSQL(sql);
            if (ds == null || ds.Tables[0].Rows.Count < 1)
            {
                txtID_func.Text = txtNome.Text = txtSenha.Text =  txtIdade.Text = txtDate_nasc.Text = txtEnd.Text = txtTelefone.Text = txtCel.Text = txtRG.Text = txtCPF.Text = txtCEP.Text = txtMail.Text = "";
            }
            else
            {
                txtID_func.Text = ds.Tables[0].Rows[0]["id_cliente"].ToString();
                txtNome.Text = ds.Tables[0].Rows[0]["nome"].ToString();
                txtSenha.Text = ds.Tables[0].Rows[0]["senha"].ToString();
                txtIdade.Text = ds.Tables[0].Rows[0]["idade"].ToString();
                txtDate_nasc.Text = ds.Tables[0].Rows[0]["dt_nascim"].ToString();
                txtEnd.Text = ds.Tables[0].Rows[0]["endereco"].ToString();
                txtTelefone.Text = ds.Tables[0].Rows[0]["telefone"].ToString();
                txtCel.Text = ds.Tables[0].Rows[0]["celular"].ToString();
                txtRG.Text = ds.Tables[0].Rows[0]["rg"].ToString();
                txtCPF.Text = ds.Tables[0].Rows[0]["cpf"].ToString();
                txtCEP.Text = ds.Tables[0].Rows[0]["cep"].ToString();
                txtMail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            }
        }
        private void btnProximo_Click_1(object sender, EventArgs e)
        {
            txtID_func.Text = ++var_x + "";
            atualizarCampos();
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            if (var_x <= 1) return;
            txtID_func.Text = --var_x + "";
            atualizarCampos();
        }

        private void naosei_Load(object sender, EventArgs e)
        {
            txtID_func.Text = var_x + "";
            atualizarCampos();
        }
      /*  private void btnPesquisar_cli_Click(object sender, EventArgs e)
        {
            frmPesquisar cB = new frmPesquisar();
            cB.ShowDialog();*/
        }
    }
