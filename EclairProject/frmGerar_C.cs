<<<<<<< HEAD
﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> origin/master
using System.Windows.Forms;

namespace EclairProject
{
    public partial class frmGerar_C : Form
    {
<<<<<<< HEAD
        ClasseConexao cc;
        DataSet ds;
=======
>>>>>>> origin/master
        public frmGerar_C()
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

<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
        {
            cc = new ClasseConexao();
            ds = new DataSet();
            string sql = "select dt_evento from evento where id_evento = '" + textBox1.Text + "'";
            ds = cc.executarSQL(sql);
            if (ds == null || ds.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("O ID do evento selecionado está incorreto");
            }
            else
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Contratos\\Contrato "+textBox1.Text+".pdf", FileMode.Create));
                doc.Open();

                //System.Drawing.Image Eclair = System.Drawing.Image.FromHbitmap(EclairProject.Properties.Resources.Eclair.GetHbitmap());
                //iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(Eclair, System.Drawing.Imaging.ImageFormat.Png);
                //System.Drawing.Image Eclair2 = System.Drawing.Image.FromHbitmap(EclairProject.Properties.Resources.Eclair2.GetHbitmap());
                //iTextSharp.text.Image PNG2 = iTextSharp.text.Image.GetInstance(Eclair2, System.Drawing.Imaging.ImageFormat.Png);
                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("Eclair.png");
                iTextSharp.text.Image PNG2 = iTextSharp.text.Image.GetInstance("Eclair2.png");
                PNG.ScalePercent(16f);   //Redimencionamento em porcentagem
                PNG2.ScalePercent(26f);
                PNG.SetAbsolutePosition(400f, 640f);
                PNG2.SetAbsolutePosition(90f, 680f);
                doc.Add(PNG);
                doc.Add(PNG2);
                Paragraph paragraph = new Paragraph(richTextBox1.Text);
                doc.Add(paragraph);
                doc.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string fileText = File.ReadAllText("./Contrato.doc");
            richTextBox1.Text = fileText;
            richTextBox1.Visible = true;
            //richTextBox1.Text = System.Text.Encoding.UTF8.GetString(EclairProject.Properties.Resources.Contrato_doc);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
=======
>>>>>>> origin/master
    }
}
