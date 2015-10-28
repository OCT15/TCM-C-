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
    public partial class frmCons_Evento : Form
    {
        string v1;
        int var_x = 1;
        ClasseConexao cc;
        DataSet ds;
        int var;
        public frmCons_Evento()
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

        private void atualizarCampos()
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = string.Format("select * from evento where id_evento = {0}", txtID_Evento.Text);
            ds = cc.executarSQL(sql);
            if (ds == null || ds.Tables[0].Rows.Count < 1)
            {
                txtID_Evento.Text = --var_x + "";
            }
            else
            {
                txtData.Text = ds.Tables[0].Rows[0]["dt_evento"].ToString();
                txtInicio.Text = ds.Tables[0].Rows[0]["hr_inicio"].ToString();
                txtAcrescimo.Text = ds.Tables[0].Rows[0]["acrescimos"].ToString();
            }

        }

        private void frmCons_Evento_Load(object sender, EventArgs e)
        {
            txtID_Evento.Text = var_x + "";
            atualizarCampos();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (var_x <= 1) return;
            txtID_Evento.Text = --var_x + "";
            atualizarCampos();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            txtID_Evento.Text = ++var_x + "";
            atualizarCampos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex, // e > argumentos de evento                     ^
            c = e.ColumnIndex;
            v1 = dataGridView1.Rows[r].Cells[0].Value.ToString();
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = ("select * from evento where id_produto like '" + v1 + "'");
            ds = cc.executarSQL(sql);
            txtID_Evento.Text = ds.Tables[0].Rows[0]["id_produto"].ToString();
            txtData.Text = ds.Tables[0].Rows[0]["dt_evento"].ToString();
            txtInicio.Text = ds.Tables[0].Rows[0]["hr_inicio"].ToString();
            txtAcrescimo.Text = ds.Tables[0].Rows[0]["acrescimos"].ToString();
            var_x = int.Parse(txtID_Evento.Text);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
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
                string sql = ("select * from evento where id_evento like '" + textBox1.Text + "' or dt_evento = '" + textBox1.Text + "'");
                ds = cc.executarSQL(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            var = 1;

            do
            {
                cc = new ClasseConexao();
                ds = new DataSet();
                string sql = ("select dt_evento from evento where id_evento = '" + var + "'");
                ds = cc.executarSQL(sql);
                if (ds.Tables[0].Rows.Count > 0) var++;
                else break;
            }
            while (true);

                frmInser_Evento fIE = new frmInser_Evento(var);
                fIE.Show();
                fIE.Location = new Point(448, 133);
        }
    }
}
