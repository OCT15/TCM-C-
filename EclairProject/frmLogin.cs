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
    public partial class frmLogin : Form
    {
        string nm_permissao;
        string permissao;
        string nome;
        string id;
        ClasseConexao cc = new ClasseConexao();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string sql = "select * from funcionario where nome='" + txtUser.Text + "' and senha='" + txtPass.Text + "'";
            ds = cc.executarSQL(sql);
            int quantidade = ds.Tables[0].Rows.Count;
            if (quantidade != 0)
            {
                id = ds.Tables[0].Rows[0]["id_permissao"].ToString();
                nome = ds.Tables[0].Rows[0]["nome"].ToString();

                cc = new ClasseConexao();
                ds = new DataSet();
                string sql2 = "select * from permissao where id_permissao='" + id + "'";
                ds = cc.executarSQL(sql2);
                nm_permissao = ds.Tables[0].Rows[0]["nm_permissao"].ToString();
                permissao = ds.Tables[0].Rows[0]["lista_permissoes"].ToString();
                frmMDI fp = new frmMDI(txtUser.Text, nm_permissao, permissao);
                fp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorreto(s). Tente novamente");
                txtUser.Text = "";
                txtPass.Text = "";
            }
        }
        private void btnInv_Click(object sender, EventArgs e)
        {
            txtUser.Text = "Testador";
            txtPass.Text = "1234deoliveira";
        }
    }
}
