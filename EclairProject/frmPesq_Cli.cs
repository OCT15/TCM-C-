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


        private void button2_Click(object sender, EventArgs e)
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = ("select * from cliente where id_cliente = " + textBox1.Text + " or nome like '" + textBox1.Text + "' or telefone like '" + textBox1.Text + "' or celular like '" + textBox1.Text + "' or cep like '" + textBox1.Text + "' or cpf like '" + textBox1.Text + "'");
            ds = cc.executarSQL(sql);
            dataGridView1.DataSource = ds.Tables[0];

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
