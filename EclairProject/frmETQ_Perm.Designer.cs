namespace EclairProject
{
    partial class frmETQ_Perm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmETQ_Perm));
            this.btnCons_Estq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRelat_Estq = new System.Windows.Forms.Button();
            this.btnCompra_Estq = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblRetornar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCons_Estq
            // 
            this.btnCons_Estq.Location = new System.Drawing.Point(117, 135);
            this.btnCons_Estq.Name = "btnCons_Estq";
            this.btnCons_Estq.Size = new System.Drawing.Size(60, 60);
            this.btnCons_Estq.TabIndex = 0;
            this.btnCons_Estq.UseVisualStyleBackColor = true;
            this.btnCons_Estq.Click += new System.EventHandler(this.btnCons_Estq_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultar Estoque";
            // 
            // btnRelat_Estq
            // 
            this.btnRelat_Estq.Location = new System.Drawing.Point(278, 135);
            this.btnRelat_Estq.Name = "btnRelat_Estq";
            this.btnRelat_Estq.Size = new System.Drawing.Size(60, 60);
            this.btnRelat_Estq.TabIndex = 2;
            this.btnRelat_Estq.UseVisualStyleBackColor = true;
            this.btnRelat_Estq.Click += new System.EventHandler(this.btnRelat_Estq_Click);
            // 
            // btnCompra_Estq
            // 
            this.btnCompra_Estq.Location = new System.Drawing.Point(434, 135);
            this.btnCompra_Estq.Name = "btnCompra_Estq";
            this.btnCompra_Estq.Size = new System.Drawing.Size(60, 60);
            this.btnCompra_Estq.TabIndex = 3;
            this.btnCompra_Estq.UseVisualStyleBackColor = true;
            this.btnCompra_Estq.Click += new System.EventHandler(this.btnCompra_Estq_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Relatório de Estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Compra de Estoque";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(571, -8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 60);
            this.btnBack.TabIndex = 110;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // lblRetornar
            // 
            this.lblRetornar.AutoSize = true;
            this.lblRetornar.BackColor = System.Drawing.Color.Transparent;
            this.lblRetornar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRetornar.Location = new System.Drawing.Point(521, 41);
            this.lblRetornar.Name = "lblRetornar";
            this.lblRetornar.Size = new System.Drawing.Size(48, 13);
            this.lblRetornar.TabIndex = 111;
            this.lblRetornar.Text = "Retornar";
            this.lblRetornar.Visible = false;
            // 
            // frmETQ_Perm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 417);
            this.Controls.Add(this.lblRetornar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCompra_Estq);
            this.Controls.Add(this.btnRelat_Estq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCons_Estq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmETQ_Perm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmETQ_Perm";
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCons_Estq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRelat_Estq;
        private System.Windows.Forms.Button btnCompra_Estq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblRetornar;
    }
}