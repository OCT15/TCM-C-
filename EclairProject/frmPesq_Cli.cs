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
    public partial class frmPesq_Cli : Form
    {
        Persist pr;
        ClasseConexao cc;
        DataSet ds;
        int var;

        public frmPesq_Cli()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira algo no campo para pesquisar na lista de clientes");
                dataGridView1.DataSource = "";
            }
            else
            {
                cc = new ClasseConexao();
                ds = new DataSet();
                string sql = ("select * from cliente where id_cliente like '" + textBox1.Text + "' or nome = '" + textBox1.Text + "' or senha = '" + textBox1.Text + "' or dt_nascim like '" + textBox1.Text + "' or endereco = '" + textBox1.Text + "' or telefone = '" + textBox1.Text + "' or celular = '" + textBox1.Text + "' or cep = '" + textBox1.Text + "' or cpf_cnpj = '" + textBox1.Text + "' or rg_ie = '" + textBox1.Text + "' or email = '" + textBox1.Text + "'");
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
                string sql = ("select nome from cliente where id_cliente = '" + var + "'");
                ds = cc.executarSQL(sql);
                if (ds.Tables[0].Rows.Count > 0) var++;
                else break;
            }
            while (true);

            frmInser_Cli fIC = new frmInser_Cli(var);
            fIC.Show();
            fIC.Location = new Point(448, 133);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pr = new Persist();
            int r = e.RowIndex, // e > argumentos de evento                     ^
            c = e.ColumnIndex;
            string v1 = dataGridView1.Rows[r].Cells[0].Value.ToString();
            pr.setId(v1);
            frmMant_Cli fT = new frmMant_Cli();
            fT.Show();
            fT.Location = new Point(448, 133);
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





    }
}
