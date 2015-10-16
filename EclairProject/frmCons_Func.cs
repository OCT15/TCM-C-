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
                txtNome.Text = txtSenha.Text = txtIdade.Text = txtDate_nasc.Text = txtEnd.Text = txtTelefone.Text = txtCel.Text = txtCPF.Text = txtCEP.Text = txtMail.Text = txtNM_Permissao.Text = "";
            }
            else
            {
                var_permi = ds.Tables[0].Rows[0]["id_permissao"].ToString();
                txtNome.Text = ds.Tables[0].Rows[0]["nome"].ToString();
                txtSenha.Text = ds.Tables[0].Rows[0]["senha"].ToString();
                txtIdade.Text = ds.Tables[0].Rows[0]["idade"].ToString();
                txtDate_nasc.Text = ds.Tables[0].Rows[0]["dt_nascim"].ToString();
                txtEnd.Text = ds.Tables[0].Rows[0]["endereco"].ToString();
                txtTelefone.Text = ds.Tables[0].Rows[0]["telefone"].ToString();
                txtCel.Text = ds.Tables[0].Rows[0]["celular"].ToString();
                txtCPF.Text = ds.Tables[0].Rows[0]["cpf"].ToString();
                txtCEP.Text = ds.Tables[0].Rows[0]["cep"].ToString();
                txtMail.Text = ds.Tables[0].Rows[0]["email"].ToString();

                cc = new ClasseConexao();
                ds = new DataSet();
                string sql2 = string.Format("select * from permissao where id_permissao = {0}", var_permi);
                //MessageBox.Show(sql2);
                ds = cc.executarSQL(sql2);
                txtNM_Permissao.Text = ds.Tables[0].Rows[0]["nm_permissao"].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmPesq_Func fPF = new frmPesq_Func();
            fPF.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}