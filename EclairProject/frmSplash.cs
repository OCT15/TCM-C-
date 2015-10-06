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
    public partial class frmSplash : Form
    {
        Timer tmAnim2;
        int curLetter;
        string txt = "Carregando Festa!";
        public int Progress
        {
            get
            {
                return this.progressBar1.Value;
            }
            set
            {
                this.progressBar1.Value = value;
            }
        }

        private delegate void ProgressDelegate(int progress);

        private ProgressDelegate del;

        public frmSplash()
        {
            InitializeComponent();
            this.progressBar1.Maximum = 300;
            del = this.UpdateProgressInternal;
        }

        private void UpdateProgressInternal(int progress)
        {
            if (this.Handle == null)
            {
                return;
            }
            this.progressBar1.Value = progress;
        }
        public void UpdateProgress(int progress)
        {
            this.Invoke(del, progress);
        }
        void tmAnim2_Tick(object sender, EventArgs e)
        {
            if (curLetter <= txt.Length)
            {
                textBox1.Text = txt.Substring(0, curLetter);
                curLetter++;
            }
            else
            {
                tmAnim2.Stop();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            tmAnim2 = new Timer();
            tmAnim2.Interval = 220;
            tmAnim2.Tick += tmAnim2_Tick;
            tmAnim2.Start();
        }
    }
}
