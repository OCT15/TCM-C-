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
    public partial class testeAnimation : Form
    {
        Timer tmAnim, tmAnim2;
        int curFrames, curLetter;
        bool goinBak = false;
        string txt = "Lorem ipsum dolor sit amet et martes alumnis";

        public testeAnimation()
        {
            InitializeComponent();
        }

        private void testeAnimation_Load(object sender, EventArgs e)
        {
            // 623 frames no total
            // Usando 60 fps para ficar *suave*
            tmAnim = new Timer();
            tmAnim.Interval = 1000 / 60;
            tmAnim.Tick += tmAnim_Tick;
            tmAnim.Start();

            tmAnim2 = new Timer();
            tmAnim2.Interval = 100;
            tmAnim2.Tick += tmAnim2_Tick;
            tmAnim2.Start();
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

        void tmAnim_Tick(object sender, EventArgs e)
        {
            label2.Text = goinBak ? "Yes" : "Nein";
            label4.Text = curFrames + "";
            if (curFrames <= 623 && !goinBak)
            {
                button1.Location = new Point(curFrames + 13, 13);
                curFrames += 3;
                if (curFrames >= 623) goinBak = true;
            }
            else if (curFrames >= 13 && goinBak)
            {
                button1.Location = new Point(curFrames + 13, 13);
                curFrames -= 3;
                if (curFrames <= 13) goinBak = false;
            }
            else
            {
                tmAnim.Stop();
            }
            
        }
    }
}
