using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace TCM
{
    public partial class Form1 : Form
    {
        private ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
        private Image logo;
        /// <summary>
        /// Resizes an image
        /// </summary>
        /// <param name="imgToResize">Image to be resized</param>
        /// <param name="size">Size to set the image to</param>
        /// <returns></returns>
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        /// <summary>  
        /// method for changing the opacity of an image  
        /// </summary>  
        /// <param name="image">image to set opacity on</param>  
        /// <param name="opacity">percentage of opacity</param>  
        /// <returns></returns>  
        public Image SetImageOpacity(Image image, double opacity)
        {
            try
            {
                //create a Bitmap the size of the image provided  
                Bitmap bmp = new Bitmap(image.Width, image.Height);

                //create a graphics object from the image  
                using (Graphics gfx = Graphics.FromImage(bmp))
                {

                    //create a color matrix object  
                    ColorMatrix matrix = new ColorMatrix();

                    //set the opacity  
                    matrix.Matrix33 = (float)opacity;

                    //create image attributes  
                    ImageAttributes attributes = new ImageAttributes();

                    //set the color(opacity) of the image  
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    //now draw the image  
                    gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
                return (Image)bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                return null;
            }
        } 

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Timer resizeTimer = new Timer();
            resizeTimer.Interval = 200;
            resizeTimer.Tick += resizeTimer_Tick;
            resizeTimer.Start();
        }

        void resizeTimer_Tick(object sender, EventArgs e)
        {
            resizeBackground();
            ((Timer)sender).Stop();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            
                if ((txtLogin.Text == "Caiovigiani" ||
                    txtLogin.Text == "Guilherme" ||
                    txtLogin.Text == "Elisa" ||
                    txtLogin.Text == "Gustavo" ||
                    txtLogin.Text == "Mari") && txtSenha.Text == "12345") 
                {
                    this.Hide();
                    (new Teste02(this)).Show();
                    MessageBox.Show("Bem vindo " + txtLogin.Text + ".");
                    txtLogin.Text = txtSenha.Text = "";
                }
                else 
                {
                    MessageBox.Show("what");
                }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeBackground();
        }

        private void resizeBackground()
        {
            if (logo == null)
            {
                logo = TCM.Properties.Resources.vetor_valt_boy; // Pega o logo do "Resources"
                logo = SetImageOpacity(logo, 0.50); // Muda a transparência do logo
            }
            logo = resizeImage(logo, new Size(this.Width, this.Height)); // Resizes the image
            this.BackgroundImage = logo; // Sets the logo as the background
        }
    }
}


