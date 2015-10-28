namespace EclairProject
{
    partial class frmCons_Evento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCons_Evento));
            this.lblRetornar = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.gpbTop1 = new System.Windows.Forms.GroupBox();
            this.txtID_Evento = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gpbTop2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAcrescimo = new System.Windows.Forms.TextBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gpbBot = new System.Windows.Forms.GroupBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.gpbTop1.SuspendLayout();
            this.gpbTop2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbBot.SuspendLayout();
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
            // gpbTop1
            // 
            this.gpbTop1.BackColor = System.Drawing.Color.Transparent;
            this.gpbTop1.Controls.Add(this.txtID_Evento);
            this.gpbTop1.Controls.Add(this.txtData);
            this.gpbTop1.Controls.Add(this.lblNome);
            this.gpbTop1.Controls.Add(this.lblID);
            this.gpbTop1.Location = new System.Drawing.Point(19, 197);
            this.gpbTop1.Name = "gpbTop1";
            this.gpbTop1.Size = new System.Drawing.Size(294, 83);
            this.gpbTop1.TabIndex = 122;
            this.gpbTop1.TabStop = false;
            // 
            // txtID_Evento
            // 
            this.txtID_Evento.Enabled = false;
            this.txtID_Evento.Location = new System.Drawing.Point(87, 16);
            this.txtID_Evento.Name = "txtID_Evento";
            this.txtID_Evento.Size = new System.Drawing.Size(190, 20);
            this.txtID_Evento.TabIndex = 115;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(87, 48);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(190, 20);
            this.txtData.TabIndex = 114;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(19, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 22);
            this.lblNome.TabIndex = 64;
            this.lblNome.Text = "Data";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(31, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 22);
            this.lblID.TabIndex = 63;
            this.lblID.Text = "ID";
            // 
            // gpbTop2
            // 
            this.gpbTop2.BackColor = System.Drawing.Color.Transparent;
            this.gpbTop2.Controls.Add(this.label2);
            this.gpbTop2.Controls.Add(this.label1);
            this.gpbTop2.Controls.Add(this.txtAcrescimo);
            this.gpbTop2.Controls.Add(this.txtInicio);
            this.gpbTop2.Location = new System.Drawing.Point(326, 197);
            this.gpbTop2.Name = "gpbTop2";
            this.gpbTop2.Size = new System.Drawing.Size(292, 83);
            this.gpbTop2.TabIndex = 123;
            this.gpbTop2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 119;
            this.label2.Text = "Acrescimo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 118;
            this.label1.Text = "Inicio";
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.Enabled = false;
            this.txtAcrescimo.Location = new System.Drawing.Point(114, 48);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.Size = new System.Drawing.Size(163, 20);
            this.txtAcrescimo.TabIndex = 117;
            // 
            // txtInicio
            // 
            this.txtInicio.Enabled = false;
            this.txtInicio.Location = new System.Drawing.Point(114, 16);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(163, 20);
            this.txtInicio.TabIndex = 116;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(363, 79);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(66, 20);
            this.btnProcurar.TabIndex = 130;
            this.btnProcurar.Text = "procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(479, 79);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(66, 20);
            this.btnInserir.TabIndex = 129;
            this.btnInserir.Text = "inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 128;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 76);
            this.dataGridView1.TabIndex = 127;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(174, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 35);
            this.lblTitle.TabIndex = 131;
            this.lblTitle.Text = "Consulta Eventos";
            // 
            // gpbBot
            // 
            this.gpbBot.BackColor = System.Drawing.Color.Transparent;
            this.gpbBot.Controls.Add(this.btnAnterior);
            this.gpbBot.Controls.Add(this.btnProximo);
            this.gpbBot.Location = new System.Drawing.Point(199, 286);
            this.gpbBot.Name = "gpbBot";
            this.gpbBot.Size = new System.Drawing.Size(240, 42);
            this.gpbBot.TabIndex = 132;
            this.gpbBot.TabStop = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(27, 13);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 52;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(140, 13);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 53;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // frmCons_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 417);
            this.Controls.Add(this.gpbBot);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.gpbTop1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.gpbTop2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRetornar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCons_Evento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCons_Evento";
            this.Load += new System.EventHandler(this.frmCons_Evento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.gpbTop1.ResumeLayout(false);
            this.gpbTop1.PerformLayout();
            this.gpbTop2.ResumeLayout(false);
            this.gpbTop2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbBot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRetornar;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.GroupBox gpbTop1;
        private System.Windows.Forms.TextBox txtID_Evento;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gpbTop2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAcrescimo;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gpbBot;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
    }
}