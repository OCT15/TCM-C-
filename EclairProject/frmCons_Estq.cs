#region (Imports)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace EclairProject
{
    public partial class frmCons_Estq : Form
    {
<<<<<<< HEAD
        #region (Variables)
        Persist PR;
=======
>>>>>>> origin/master
        string v1;
        int var_x = 1;
        ClasseConexao cc;
        DataSet ds;
        int var;
        #endregion
        public frmCons_Estq()
        {
            InitializeComponent();
        }
        #region (Methods)
        private void atualizarCampos()
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = string.Format("select * from produto where id_produto = {0}", txtID_Produto.Text);
            ds = cc.executarSQL(sql);
            if (ds == null || ds.Tables[0].Rows.Count < 1)
            {
                txtID_Produto.Text = --var_x + "";
            }
            else
            {
                txtNome.Text = ds.Tables[0].Rows[0]["nm_produto"].ToString();
                txtPreço.Text = ds.Tables[0].Rows[0]["preco"].ToString();
                txtPreço.Text = txtPreço.Text.Replace(",", ".");
                txtQuant.Text = ds.Tables[0].Rows[0]["quantidade"].ToString();
                txtTipo.Text = ds.Tables[0].Rows[0]["tipo_produto"].ToString();
            }

        }
        private void frmCons_Estq_Load(object sender, EventArgs e)
<<<<<<< HEAD
        {
            txtID_Produto.Text = var_x + "";
            atualizarCampos();
            textBox1.Text = "Pesquisa de Produtos...";
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (var_x <= 1) return;
            txtID_Produto.Text = --var_x + "";
            atualizarCampos();
        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            txtID_Produto.Text = ++var_x + "";
            atualizarCampos();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira algo no campo para pesquisar na tabela de Produtos");
                dataGridView1.DataSource = "";
            }
            else
            {
                cc = new ClasseConexao();
                ds = new DataSet();
                string sql = ("select Prod.id_produto as ID, Prod.nm_produto as Nome, Prod.preco as Preço, Prod.quantidade as Quantidade, Prod.tipo_produto as Tipo from produto as Prod where Prod.id_produto like '" + textBox1.Text + "' or nm_produto = '" + textBox1.Text + "' or preco like '" + textBox1.Text + "' or quantidade like '" + textBox1.Text + "' or tipo_produto = '" + textBox1.Text + "'");
                ds = cc.executarSQL(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
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
        private void btnInserir_Click(object sender, EventArgs e)
=======
>>>>>>> origin/master
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            var = 1;

            do
            {
                cc = new ClasseConexao();
                ds = new DataSet();
                string sql = ("select nm_produto from produto where id_produto = " + var + "");
                ds = cc.executarSQL(sql);
                if (ds.Tables[0].Rows.Count > 0) var++;
                else break;
            }
            while (true);

            frmInser_Est fIE = new frmInser_Est(var);
            fIE.Location = new Point(448, 133);
            fIE.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmManter_Prod>().Count() > 0)
            {

            }
            else
            {
                PR = new Persist();
                PR.setId(var_x.ToString());
                frmManter_Prod fEP = new frmManter_Prod();
                fEP.Location = new Point(Height + Height / 40, Width + Width / 80);
                fEP.ShowDialog();
                this.Close();
            }
        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex, // e > argumentos de evento                     ^
            c = e.ColumnIndex;
            if (r >= 0)
            {
                v1 = dataGridView1.Rows[r].Cells[0].Value.ToString();
                cc = new ClasseConexao();
                ds = new DataSet();
                string sql = ("select * from produto where id_produto like '" + v1 + "'");
                ds = cc.executarSQL(sql);
                txtID_Produto.Text = ds.Tables[0].Rows[0]["id_produto"].ToString();
                txtNome.Text = ds.Tables[0].Rows[0]["nm_produto"].ToString();
                txtPreço.Text = ds.Tables[0].Rows[0]["preco"].ToString();
                txtQuant.Text = ds.Tables[0].Rows[0]["quantidade"].ToString();
                txtTipo.Text = ds.Tables[0].Rows[0]["tipo_produto"].ToString();
                var_x = int.Parse(txtID_Produto.Text);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.button2_Click(sender, e);
            }
        }
<<<<<<< HEAD
=======

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex, // e > argumentos de evento                     ^
            c = e.ColumnIndex;
            v1 = dataGridView1.Rows[r].Cells[0].Value.ToString();
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = ("select * from produto where id_produto like '" + v1 + "'");
            ds = cc.executarSQL(sql);
            txtID_Produto.Text = ds.Tables[0].Rows[0]["id_produto"].ToString();
            txtNome.Text = ds.Tables[0].Rows[0]["nm_produto"].ToString();
            txtPreço.Text = ds.Tables[0].Rows[0]["preço"].ToString();
            txtQuant.Text = ds.Tables[0].Rows[0]["quantidade"].ToString();
            txtTipo.Text = ds.Tables[0].Rows[0]["tipo_produto"].ToString();
            var_x = int.Parse(txtID_Produto.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira algo no campo para pesquisar na tabela de Produtos");
                dataGridView1.DataSource = "";
            }
            else
            {
                cc = new ClasseConexao();
                ds = new DataSet();
                string sql = ("select * from produto where id_produto like '" + textBox1.Text + "' or nm_produto = '" + textBox1.Text + "' or preço like '" + textBox1.Text + "' or quantidade like '" + textBox1.Text + "' or tipo_produto = '" + textBox1.Text + "'");
                ds = cc.executarSQL(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmInser_Est>().Count() > 0)
            {

            }
            else
            {
                frmInser_Est fIE = new frmInser_Est();
                fIE.Location = new Point(443, 133);
                fIE.ShowDialog();
            }
        }

>>>>>>> origin/master
    }
}
        #endregion
