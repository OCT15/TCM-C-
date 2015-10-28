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
    public partial class frmCons_Func : Form
    {
        int var_x = 1;
        string var_permi;
        ClasseConexao cc;
        DataSet ds;
        public frmCons_Func()
        {
            InitializeComponent();
        }
        private void atualizarCampos()
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = string.Format("select * from funcionario where id_funcionario = {0}", txtID_Func.Text);
            ds = cc.executarSQL(sql);
            if (ds == null || ds.Tables[0].Rows.Count < 1)
            {
                txtNome.Text = txtPass.Text = txtEndereco.Text = txtDate_Nasc.Text = txtMail.Text = txtTel.Text = txtCel.Text = txtPerm.Text = txtCPF.Text = txtRG.Text = txtCEP.Text = "";
            }
            else
            {
                var_permi = ds.Tables[0].Rows[0]["id_permissao"].ToString();
                txtNome.Text = ds.Tables[0].Rows[0]["nome"].ToString();
                txtPass.Text = ds.Tables[0].Rows[0]["senha"].ToString();
                txtEndereco.Text = ds.Tables[0].Rows[0]["endereco"].ToString();
                txtDate_Nasc.Text = ds.Tables[0].Rows[0]["dt_nascim"].ToString();
                txtMail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                txtTel.Text = ds.Tables[0].Rows[0]["telefone"].ToString();
                txtCel.Text = ds.Tables[0].Rows[0]["celular"].ToString();
                txtCPF.Text = ds.Tables[0].Rows[0]["cpf"].ToString();
                txtRG.Text = ds.Tables[0].Rows[0]["rg"].ToString();
                txtCEP.Text = ds.Tables[0].Rows[0]["cep"].ToString();
///////////////////////////////////////////////////////////////////////////////////////////// Separação de Tabelas Funcionário / Permissão
                cc = new ClasseConexao();
                ds = new DataSet();
                string sql2 = string.Format("select * from permissao where id_permissao = {0}", var_permi);
                ds = cc.executarSQL(sql2);
                txtPerm.Text = ds.Tables[0].Rows[0]["nm_permissao"].ToString();
            }

        }
        private void frmCons_Func_Load(object sender, EventArgs e)
        {
            txtID_Func.Text = var_x + "";
            atualizarCampos();
        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            txtID_Func.Text = ++var_x + "";
            atualizarCampos();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (var_x <= 1) return;
            txtID_Func.Text = --var_x + "";
            atualizarCampos();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
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
    }
}