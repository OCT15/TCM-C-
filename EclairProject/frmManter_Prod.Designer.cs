namespace EclairProject
{
    partial class frmManter_Prod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManter_Prod));
            this.lblRetornar = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.gpbTop1 = new System.Windows.Forms.GroupBox();
            this.txtID_Produto = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gpbTop2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtPreço = new System.Windows.Forms.TextBox();
            this.gpbBot = new System.Windows.Forms.GroupBox();
            this.btnAlterar2 = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gpbMid = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblconsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.gpbTop1.SuspendLayout();
            this.gpbTop2.SuspendLayout();
            this.gpbBot.SuspendLayout();
            this.gpbMid.SuspendLayout();
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
            this.lblRetornar.TabIndex = 114;
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
            this.btnBack.TabIndex = 113;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // gpbTop1
            // 
            this.gpbTop1.BackColor = System.Drawing.Color.Transparent;
            this.gpbTop1.Controls.Add(this.txtID_Produto);
            this.gpbTop1.Controls.Add(this.txtNome);
            this.gpbTop1.Controls.Add(this.lblNome);
            this.gpbTop1.Controls.Add(this.lblID);
            this.gpbTop1.Location = new System.Drawing.Point(16, 118);
            this.gpbTop1.Name = "gpbTop1";
            this.gpbTop1.Size = new System.Drawing.Size(294, 83);
            this.gpbTop1.TabIndex = 124;
            this.gpbTop1.TabStop = false;
            // 
            // txtID_Produto
            // 
            this.txtID_Produto.Enabled = false;
            this.txtID_Produto.Location = new System.Drawing.Point(87, 16);
            this.txtID_Produto.Name = "txtID_Produto";
            this.txtID_Produto.Size = new System.Drawing.Size(190, 20);
            this.txtID_Produto.TabIndex = 115;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(87, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(190, 20);
            this.txtNome.TabIndex = 114;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Arial Black", 11F);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(15, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 22);
            this.lblNome.TabIndex = 64;
            this.lblNome.Text = "Nome";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Arial Black", 11F);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(31, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 22);
            this.lblID.TabIndex = 63;
            this.lblID.Text = "ID";
            // 
            // gpbTop2
            // 
            this.gpbTop2.BackColor = System.Drawing.Color.Transparent;
            this.gpbTop2.Controls.Add(this.label2);
            this.gpbTop2.Controls.Add(this.label1);
            this.gpbTop2.Controls.Add(this.txtQuant);
            this.gpbTop2.Controls.Add(this.txtPreço);
            this.gpbTop2.Location = new System.Drawing.Point(323, 118);
            this.gpbTop2.Name = "gpbTop2";
            this.gpbTop2.Size = new System.Drawing.Size(292, 83);
            this.gpbTop2.TabIndex = 125;
            this.gpbTop2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 119;
            this.label2.Text = "Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 118;
            this.label1.Text = "Preço";
            // 
            // txtQuant
            // 
            this.txtQuant.Enabled = false;
            this.txtQuant.Location = new System.Drawing.Point(114, 48);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(163, 20);
            this.txtQuant.TabIndex = 117;
            // 
            // txtPreço
            // 
            this.txtPreço.Enabled = false;
            this.txtPreço.Location = new System.Drawing.Point(114, 16);
            this.txtPreço.Name = "txtPreço";
            this.txtPreço.Size = new System.Drawing.Size(163, 20);
            this.txtPreço.TabIndex = 116;
            // 
            // gpbBot
            // 
            this.gpbBot.BackColor = System.Drawing.Color.Transparent;
            this.gpbBot.Controls.Add(this.btnAlterar2);
            this.gpbBot.Controls.Add(this.btnAlterar);
            this.gpbBot.Location = new System.Drawing.Point(235, 257);
            this.gpbBot.Name = "gpbBot";
            this.gpbBot.Size = new System.Drawing.Size(157, 42);
            this.gpbBot.TabIndex = 126;
            this.gpbBot.TabStop = false;
            // 
            // btnAlterar2
            // 
            this.btnAlterar2.BackColor = System.Drawing.Color.White;
            this.btnAlterar2.FlatAppearance.BorderSize = 0;
            this.btnAlterar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar2.Font = new System.Drawing.Font("Arial Black", 8F);
            this.btnAlterar2.Location = new System.Drawing.Point(42, 13);
            this.btnAlterar2.Name = "btnAlterar2";
            this.btnAlterar2.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar2.TabIndex = 54;
            this.btnAlterar2.Text = "Alterar!";
            this.btnAlterar2.UseVisualStyleBackColor = false;
            this.btnAlterar2.Visible = false;
            this.btnAlterar2.Click += new System.EventHandler(this.btnAlterar2_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Arial Black", 8F);
            this.btnAlterar.Location = new System.Drawing.Point(42, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 52;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gpbMid
            // 
            this.gpbMid.BackColor = System.Drawing.Color.Transparent;
            this.gpbMid.Controls.Add(this.txtTipo);
            this.gpbMid.Controls.Add(this.label3);
            this.gpbMid.Location = new System.Drawing.Point(143, 207);
            this.gpbMid.Name = "gpbMid";
            this.gpbMid.Size = new System.Drawing.Size(324, 44);
            this.gpbMid.TabIndex = 127;
            this.gpbMid.TabStop = false;
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(120, 14);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(190, 20);
            this.txtTipo.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 120;
            this.label3.Text = "Tipo";
            // 
            // lblconsulta
            // 
            this.lblconsulta.AutoSize = true;
            this.lblconsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblconsulta.Font = new System.Drawing.Font("Arial Black", 19F);
            this.lblconsulta.ForeColor = System.Drawing.Color.White;
            this.lblconsulta.Location = new System.Drawing.Point(209, 42);
            this.lblconsulta.Name = "lblconsulta";
            this.lblconsulta.Size = new System.Drawing.Size(236, 37);
            this.lblconsulta.TabIndex = 55;
            this.lblconsulta.Text = "Alterar Produto";
            // 
            // frmManter_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 417);
            this.Controls.Add(this.lblconsulta);
            this.Controls.Add(this.gpbTop1);
            this.Controls.Add(this.gpbTop2);
            this.Controls.Add(this.gpbBot);
            this.Controls.Add(this.gpbMid);
            this.Controls.Add(this.lblRetornar);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManter_Prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmEdit_Prod";
            this.Load += new System.EventHandler(this.frmEdit_Prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.gpbTop1.ResumeLayout(false);
            this.gpbTop1.PerformLayout();
            this.gpbTop2.ResumeLayout(false);
            this.gpbTop2.PerformLayout();
            this.gpbBot.ResumeLayout(false);
            this.gpbMid.ResumeLayout(false);
            this.gpbMid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRetornar;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.GroupBox gpbTop1;
        private System.Windows.Forms.TextBox txtID_Produto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gpbTop2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtPreço;
        private System.Windows.Forms.GroupBox gpbBot;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox gpbMid;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlterar2;
        private System.Windows.Forms.Label lblconsulta;
    }
}