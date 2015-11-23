#region (Imports)

using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

#endregion (Imports)

namespace EclairProject
{
    public partial class frmCompra_Estq : Form
    {
        #region (Variables)

        private int close = 1, close2 = 0;
        private string nm_repre;
        private int x;
        private string r;
        private ClasseConexao cc;
        private DataSet ds;

        #endregion (Variables)

        public frmCompra_Estq()
        {
            InitializeComponent();
        }

        #region (Methods)

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (close == 1)
                this.Close();
            if (close2 == 1)
            {
                button3.Visible = false;
                dataGridView1.Visible = true;
                richTextBox1.Visible = false;
                richTextBox1.Text = "";
                close = 1;
                close2 = 0;
                dataGridView1.DataSource = "";
                button2.Visible = true;
                textBox1.Text = "";
            }
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblRetornar.Visible = true;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblRetornar.Visible = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = "select Evt.id_cliente as ID, Prod.nm_produto as Nome, Prod.preco as Preço, PraEvt.qtd_produto as Quantidade, Frn.empresa as Empresa, Frn.representante as Representante, Prod.tipo_produto as Tipo, Evt.id_lugar as Lugar, Evt.valor_orcamento as Valor_Total, Evt.dt_evento as Data, Evt.hr_inicio as Inicio from evento AS Evt , pratos_evento AS PraEvt , fornecedor_perecivel AS Frn , produto AS Prod where Evt.id_evento ='" + textBox1.Text + "' AND PraEvt.id_orcamento ='" + textBox1.Text + "' AND Prod.id_produto = PraEvt.id_produto AND Frn.id_produto = PraEvt.id_produto ";
            ds = cc.executarSQL(sql);
            dataGridView1.DataSource = ds.Tables[0];
            x = ds.Tables[0].Rows.Count;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = true;
            cc = new ClasseConexao();
            ds = new DataSet();
            if (dataGridView1.DataSource == "")
                MessageBox.Show("Campo de procura vazio");
            else
            {
                string sql = "select representante from fornecedor_perecivel where empresa = '" + dataGridView1.Rows[0].Cells[4].Value.ToString() + "'";
                ds = cc.executarSQL(sql);
                nm_repre = ds.Tables[0].Rows[0]["representante"].ToString();
                DateTime dtn = DateTime.Now;
                string dtnn = dtn.ToShortDateString();
                r = "                                                                                                               " + dtnn + "\nBom Dia,\nVenho por meio deste requisitar os seguintes produtos:\n\n";
                for (int i = 0; i < x; i++)
                {
                    string y = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string w = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string v = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    string z = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    r += w + " - " + y + " unidades, do fornecedor " + v + "(" + z + ")\n";
                }
                richTextBox1.Text = r;
                dataGridView1.Visible = false;
                richTextBox1.Visible = true;
                close = 0;
                close2 = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Compras_Estoque\\Compra_Estoque " + textBox1.Text + ".pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph(richTextBox1.Text);
            doc.Add(paragraph);
            doc.Close();
            MessageBox.Show("Operação Concluída");
            this.Close();
        }
    }
}

#endregion (Methods)