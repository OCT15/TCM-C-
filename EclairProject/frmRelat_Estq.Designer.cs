namespace EclairProject
{
    partial class frmRelat_Estq
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelat_Estq));
            this.lblRetornar = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRetornar
            // 
            this.lblRetornar.AutoSize = true;
            this.lblRetornar.BackColor = System.Drawing.Color.Transparent;
            this.lblRetornar.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.lblRetornar.ForeColor = System.Drawing.Color.White;
            this.lblRetornar.Location = new System.Drawing.Point(520, 42);
            this.lblRetornar.Name = "lblRetornar";
            this.lblRetornar.Size = new System.Drawing.Size(59, 15);
            this.lblRetornar.TabIndex = 112;
            this.lblRetornar.Text = "Retornar";
            this.lblRetornar.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(570, -7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 60);
            this.btnBack.TabIndex = 111;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // frmRelat_Estq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 417);
            this.Controls.Add(this.lblRetornar);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelat_Estq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmRelat_Estq";
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRetornar;
        private System.Windows.Forms.PictureBox btnBack;

    }
}