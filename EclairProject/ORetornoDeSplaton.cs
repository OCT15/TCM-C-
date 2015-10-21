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
    public partial class ORetornoDeSplaton : Form
    {
        StreamWriter x;
        public ORetornoDeSplaton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ORetornodoRetornodeSplaton.ReplacePdfForm();
        }

        /*public void ORetornoDeSplaton_Load(object sender, EventArgs e)
        {
            string CaminhoNome = "D:\\OIII\\arq01.txt";
            x = File.CreateText(CaminhoNome);

            x.WriteLine("Recibo de Pagamanto");

            x.WriteLine();
            x.WriteLine();

            x.WriteLine("Recebi do Sr: Nome do Pagador");
            x.WriteLine("a quantia de VALOR DO RECIBO (VALOR POR EXTENSO),");
            x.WriteLine("referente ao DESCRIÇÃO DO QUE FOI PAGO... ");
            x.WriteLine("CIDADE, DATA");
            x.WriteLine();
            x.WriteLine();
            x.WriteLine("__________________________________________________");
            x.WriteLine("Nome do pagador");
            x.WriteLine("CPF do pagador: CPF");
            x.WriteLine();

            x.Close();
        }*/

     /*   private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(x);
        } */

    }
}
