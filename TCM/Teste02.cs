using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM
{
    public partial class Teste02 : Form
    {
        private Form1 mastah;
        public Teste02(Form1 m)
        {
            mastah = m;
            InitializeComponent();
        }

        private void Teste02_Closing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form Closing");
            mastah.Show();
        }
    }
}
