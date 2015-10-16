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
    public partial class acentu : Form
    {
        public acentu()
        {
            InitializeComponent();
        }

        public void fingequesoufoda()
        {
            string comAcentos = "àâêôûãõáéíóúçüÀÂÊÔÛÃÕÁÉÍÓÚÇÜ'";
            string semAcentos = "aaeouaoaeioucuAAEOUAOAEIOUCU ";
            string texto;
            int i, a, b;

            for (i = 0; i <= this.Controls.Count - 1; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    if ((this.Controls[i] as TextBox).Text != String.Empty)
                    {
                        texto = (this.Controls[i] as TextBox).Text;
                        for (a = 0; a <= (texto.Length) - 1; a++)
                        {
                            for (b = 0; b <= (comAcentos.Length) - 1; b++)
                            {
                                if (texto[a] == comAcentos[b])
                                    texto = texto.Replace(comAcentos[b], semAcentos[b]);
                            }
                        }
                        (this.Controls[i] as TextBox).Text = texto;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fingequesoufoda();
        }
    }
}
