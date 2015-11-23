using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EclairProject
{
    public partial class frmRelat_Estq : Form
    {
        int i = 1;
        ClasseConexao cc;
        DataSet ds;
        List<string[]> estoque = new List<string[]>();

        public frmRelat_Estq()
        {
            InitializeComponent();
        }
        private void btnBack_MouseHover(object sender, EventArgs e)
<<<<<<< HEAD
        {
            lblRetornar.Visible = true;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblRetornar.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRelat_Estq_Load(object sender, EventArgs e)
=======
>>>>>>> origin/master
        {
            string relatorio;
            DateTime dtn = DateTime.Now;
            cc = new ClasseConexao();
            ds = new DataSet();

            string sql = "select * from produto where id_produto = '" + i + "'";
            ds = cc.executarSQL(sql);
            relatorio = "Eclair Corporation\nDia "+dtn+". Os estoques de produtos se encontram nas seguintes condições:\n";
            richTextBox1.Text = relatorio;

            do
            {
                cc = new ClasseConexao();
                ds = new DataSet();
                string sqls = ("select * from produto where id_produto = " + i);
                ds = cc.executarSQL(sqls);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string prodnome = ds.Tables[0].Rows[0]["nm_produto"].ToString();
                    string prodquant = ds.Tables[0].Rows[0]["quantidade"].ToString();
                    estoque.Add(new string[] { prodnome, prodquant });
                    if (int.Parse(prodquant) < 100)
                    {
                        richTextBox1.Text += "-" + prodnome.PadRight(29, ' ') + prodquant + " unidades\n";
                    }else{
                        richTextBox1.Text += prodnome.PadRight(30, ' ') + prodquant + " unidades\n";
                    }
                    i++;
                }
                else break;
            }
            while (true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Estoque/" + timestamp + "estoque.csv", "Data: " + DateTime.Now + "\n", System.Text.Encoding.UTF8);
            foreach (string[] produto in estoque)
            {
                File.AppendAllText("Estoque/" + timestamp + "estoque.csv", produto[0] + ";" + produto[1] + "\n", System.Text.Encoding.UTF8);
            }
            MessageBox.Show("Relatório salvo em \"Estoque/" + timestamp + "estoque.csv\"");
        }

        private string timestamp {
            get {
                DateTime naw = DateTime.Now;
                return string.Format("[{0}.{1}.{2}]"/*[{3}.{4}]"*/,
                    naw.Day.ToString().PadLeft(2, '0'),
                    naw.Month.ToString().PadLeft(2, '0'),
                    naw.Year.ToString().PadLeft(2, '0')//,
                    //naw.Hour.ToString().PadLeft(2, '0'),
                    //naw.Minute.ToString().PadLeft(2, '0')
                    );
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
