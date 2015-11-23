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
    public partial class frmManter_Prod : Form
    {
        Persist PR;
        ClasseConexao cc;
        DataSet ds;
        public frmManter_Prod()
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

        private void frmEdit_Prod_Load(object sender, EventArgs e)
        {
            PR = new Persist();
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = ("select * from produto where id_produto like '" + PR.getId()+"'");
            ds = cc.executarSQL(sql);
            if (ds == null || ds.Tables[0].Rows.Count < 1)
            {
                txtNome.Text = txtPreço.Text = txtQuant.Text = txtTipo.Text = "";
            }
            else
            {
                txtID_Produto.Text = ds.Tables[0].Rows[0]["id_produto"].ToString();
                txtNome.Text = ds.Tables[0].Rows[0]["nm_produto"].ToString();
                txtPreço.Text = ds.Tables[0].Rows[0]["preco"].ToString();
                txtPreço.Text = txtPreço.Text.Replace(",", ".");
                txtQuant.Text = ds.Tables[0].Rows[0]["quantidade"].ToString();
                txtTipo.Text = ds.Tables[0].Rows[0]["tipo_produto"].ToString();
            }
        }

        //private void btnExcluir_Click(object sender, EventArgs e)
        //{
            /*DialogResult res = MessageBox.Show("Deseja excluir o campo selecionado?", "Aviso", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = string.Format("delete from produto where id_produto = {0}, txtID_Produto.Text");
                cc = new ClasseConexao();
                cc.executarSQL(sql);
            }
            else
            {
                MessageBox.Show("Operação Cancelada");
            }*/
        //}

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtPreço.Enabled = true;
            txtQuant.Enabled = true;
            txtTipo.Enabled = true;
            btnAlterar2.Visible = true;
            //btnExcluir.Enabled = false;
        }

        private void btnAlterar2_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtPreço.Text == "" || txtQuant.Text == "" || txtTipo.Text == "")
            {
                MessageBox.Show("Campos vazios detectados");
            }
            else
            {
                if (txtTipo.Text == "perecivel" || txtTipo.Text == "consumivel")
                {
                    DialogResult res = MessageBox.Show("Deseja alterar o campo selecionado?", "Aviso", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        txtPreço.Text = txtPreço.Text.Replace(",", ".");
                        string sql = string.Format("UPDATE produto SET nm_produto = '{0}', preco = '{1}', quantidade = '{2}', tipo_produto = '{3}' where id_produto = {4}",
                            txtNome.Text,
                            txtPreço.Text,
                            txtQuant.Text,
                            txtTipo.Text,
                            txtID_Produto.Text);
                        cc = new ClasseConexao();
                        cc.executarSQL(sql);
                        MessageBox.Show("Operação concluída!");
                    }
                    else
                    {
                        MessageBox.Show("Operação Cancelada");
                    }
                    txtNome.Enabled = false;
                    txtPreço.Enabled = false;
                    txtQuant.Enabled = false;
                    txtTipo.Enabled = false;
                    btnAlterar2.Visible = false;
                    //btnExcluir.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Tipo de produto inexistente");
                    txtTipo.Text = "";
                }
            }
        }
    }
}
