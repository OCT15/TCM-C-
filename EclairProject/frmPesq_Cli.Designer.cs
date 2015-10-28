namespace EclairProject
{
    partial class frmPesq_Cli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesq_Cli));
            this.btnInserir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblconsulta = new System.Windows.Forms.Label();
            this.lblRetornar = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(503, 97);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(66, 20);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(387, 97);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(66, 20);
            this.btnProcurar.TabIndex = 3;
            this.btnProcurar.Text = "procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // lblconsulta
            // 
            this.lblconsulta.AutoSize = true;
            this.lblconsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsulta.ForeColor = System.Drawing.Color.White;
            this.lblconsulta.Location = new System.Drawing.Point(139, 29);
            this.lblconsulta.Name = "lblconsulta";
            this.lblconsulta.Size = new System.Drawing.Size(247, 35);
            this.lblconsulta.TabIndex = 40;
            this.lblconsulta.Text = "Pesquisa Cliente";
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
            // frmPesq_Cli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 417);
            this.Controls.Add(this.lblRetornar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblconsulta);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnInserir);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPesq_Cli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Teste";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label lblconsulta;
        private System.Windows.Forms.Label lblRetornar;
        private System.Windows.Forms.PictureBox btnBack;
    }
}