namespace EclairProject
{
    partial class frmMant_Func
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMant_Func));
            this.lblRetornar = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblconsulta = new System.Windows.Forms.Label();
            this.gpbTop1 = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtID_Func = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDate_nasc = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gpbTop2 = new System.Windows.Forms.GroupBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblPerm = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.gpbBot = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar2 = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtPerm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.gpbTop1.SuspendLayout();
            this.gpbTop2.SuspendLayout();
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
            // lblconsulta
            // 
            this.lblconsulta.AutoSize = true;
            this.lblconsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblconsulta.Font = new System.Drawing.Font("Arial Black", 21F);
            this.lblconsulta.ForeColor = System.Drawing.Color.White;
            this.lblconsulta.Location = new System.Drawing.Point(152, 32);
            this.lblconsulta.Name = "lblconsulta";
            this.lblconsulta.Size = new System.Drawing.Size(315, 40);
            this.lblconsulta.TabIndex = 116;
            this.lblconsulta.Text = "Manter Funcionário";
            // 
            // gpbTop1
            // 
            this.gpbTop1.BackColor = System.Drawing.Color.Transparent;
            this.gpbTop1.Controls.Add(this.txtMail);
            this.gpbTop1.Controls.Add(this.lblMail);
            this.gpbTop1.Controls.Add(this.txtEnd);
            this.gpbTop1.Controls.Add(this.lblEndereço);
            this.gpbTop1.Controls.Add(this.txtSenha);
            this.gpbTop1.Controls.Add(this.txtID_Func);
            this.gpbTop1.Controls.Add(this.txtNome);
            this.gpbTop1.Controls.Add(this.txtDate_nasc);
            this.gpbTop1.Controls.Add(this.lblSenha);
            this.gpbTop1.Controls.Add(this.lblNascimento);
            this.gpbTop1.Controls.Add(this.lblNome);
            this.gpbTop1.Controls.Add(this.lblID);
            this.gpbTop1.Location = new System.Drawing.Point(14, 87);
            this.gpbTop1.Name = "gpbTop1";
            this.gpbTop1.Size = new System.Drawing.Size(301, 184);
            this.gpbTop1.TabIndex = 113;
            this.gpbTop1.TabStop = false;
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(104, 154);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(190, 20);
            this.txtMail.TabIndex = 98;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Arial Black", 11F);
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(24, 153);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(61, 22);
            this.lblMail.TabIndex = 99;
            this.lblMail.Text = "E-mail";
            // 
            // txtEnd
            // 
            this.txtEnd.Enabled = false;
            this.txtEnd.Location = new System.Drawing.Point(104, 96);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(190, 20);
            this.txtEnd.TabIndex = 96;
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereço.Font = new System.Drawing.Font("Arial Black", 11F);
            this.lblEndereço.ForeColor = System.Drawing.Color.White;
            this.lblEndereço.Location = new System.Drawing.Point(12, 96);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(88, 22);
            this.lblEndereço.TabIndex = 97;
            this.lblEndereço.Text = "Endereço";
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(104, 68);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(190, 20);
            this.txtSenha.TabIndex = 95;
            // 
            // txtID_Func
            // 
            this.txtID_Func.Enabled = false;
            this.txtID_Func.Location = new System.Drawing.Point(104, 14);
            this.txtID_Func.Name = "txtID_Func";
            this.txtID_Func.Size = new System.Drawing.Size(190, 20);
            this.txtID_Func.TabIndex = 94;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(104, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(190, 20);
            this.txtNome.TabIndex = 93;
            // 
            // txtDate_nasc
            // 
            this.txtDate_nasc.Enabled = false;
            this.txtDate_nasc.Location = new System.Drawing.Point(105, 125);
            this.txtDate_nasc.Name = "txtDate_nasc";
            this.txtDate_nasc.Size = new System.Drawing.Size(189, 20);
            this.txtDate_nasc.TabIndex = 72;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Arial Black", 11F);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(24, 65);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(61, 22);
            this.lblSenha.TabIndex = 66;
            this.lblSenha.Text = "Senha";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblNascimento.Font = new System.Drawing.Font("Arial Black", 11F);
            this.lblNascimento.ForeColor = System.Drawing.Color.White;
            this.lblNascimento.Location = new System.Drawing.Point(4, 125);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(99, 22);
            this.lblNascimento.TabIndex = 65;
            this.lblNascimento.Text = "Data_Nasc";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Arial Black", 11F);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(27, 38);
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
            this.lblID.Location = new System.Drawing.Point(41, 11);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 22);
            this.lblID.TabIndex = 63;
            this.lblID.Text = "ID";
            // 
            // gpbTop2
            // 
            this.gpbTop2.BackColor = System.Drawing.Color.Transparent;
            this.gpbTop2.Controls.Add(this.txtPerm);
            this.gpbTop2.Controls.Add(this.lblRG);
            this.gpbTop2.Controls.Add(this.txtRG);
            this.gpbTop2.Controls.Add(this.lblPerm);
            this.gpbTop2.Controls.Add(this.txtTelefone);
            this.gpbTop2.Controls.Add(this.lblTelefone);
            this.gpbTop2.Controls.Add(this.lblCelular);
            this.gpbTop2.Controls.Add(this.lblCEP);
            this.gpbTop2.Controls.Add(this.lblCPF);
            this.gpbTop2.Controls.Add(this.txtCEP);
            this.gpbTop2.Controls.Add(this.txtCPF);
            this.gpbTop2.Controls.Add(this.txtCel);
            this.gpbTop2.Location = new System.Drawing.Point(330, 87);
            this.gpbTop2.Name = "gpbTop2";
            this.gpbTop2.Size = new System.Drawing.Size(277, 184);
            this.gpbTop2.TabIndex = 114;
            this.gpbTop2.TabStop = false;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.BackColor = System.Drawing.Color.Transparent;
            this.lblRG.Font = new System.Drawing.Font("Arial Black", 11F);
            this.lblRG.ForeColor = System.Drawing.Color.White;
            this.lblRG.Location = new System.Drawing.Point(30, 125);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(35, 22);
            this.lblRG.TabIndex = 98;
            this.lblRG.Text = "RG";
            // 
            // txtRG
            // 
            this.txtRG.Enabled = false;
            this.txtRG.Location = new System.Drawing.Point(90, 127);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(175, 20);
            this.txtRG.TabIndex = 97;
            // 
            // lblPerm
            // 
            this.lblPerm.AutoSize = true;
            this.lblPerm.BackColor = System.Drawing.Color.Transparent;
            this.lblPerm.Font = new System.Drawing.Font("Arial Black", 11F);
            this.lblPerm.ForeColor = System.Drawing.Color.White;
            this.lblPerm.Location = new System.Drawing.Point(-2, 65);
            this.lblPerm.Name = "lblPerm";
            this.lblPerm.Size = new System.Drawing.Size(96, 22);
            this.lblPerm.TabIndex = 95;
            this.lblPerm.Text = "Permissão";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(90, 13);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(175, 20);
            this.txtTelefone.TabIndex = 94;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Arial Black", 11F);
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(3, 11);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(82, 22);
            this.lblTelefone.TabIndex = 75;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular.Font = new System.Drawing.Font("Arial Black", 11F);
            this.lblCelular.ForeColor = System.Drawing.Color.White;
            this.lblCelular.Location = new System.Drawing.Point(9, 38);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(69, 22);
            this.lblCelular.TabIndex = 74;
            this.lblCelular.Text = "Celular";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.BackColor = System.Drawing.Color.Transparent;
            this.lblCEP.Font = new System.Drawing.Font("Arial Black", 11F);
            this.lblCEP.ForeColor = System.Drawing.Color.White;
            this.lblCEP.Location = new System.Drawing.Point(24, 152);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(44, 22);
            this.lblCEP.TabIndex = 72;
            this.lblCEP.Text = "CEP";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Arial Black", 11F);
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(24, 96);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(43, 22);
            this.lblCPF.TabIndex = 71;
            this.lblCPF.Text = "CPF";
            // 
            // txtCEP
            // 
            this.txtCEP.Enabled = false;
            this.txtCEP.Location = new System.Drawing.Point(90, 155);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(175, 20);
            this.txtCEP.TabIndex = 38;
            // 
            // txtCPF
            // 
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(90, 96);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(175, 20);
            this.txtCPF.TabIndex = 37;
            // 
            // txtCel
            // 
            this.txtCel.Enabled = false;
            this.txtCel.Location = new System.Drawing.Point(90, 41);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(175, 20);
            this.txtCel.TabIndex = 35;
            // 
            // gpbBot
            // 
            this.gpbBot.BackColor = System.Drawing.Color.Transparent;
            this.gpbBot.Controls.Add(this.btnExcluir);
            this.gpbBot.Controls.Add(this.btnAlterar2);
            this.gpbBot.Controls.Add(this.btnAlterar);
            this.gpbBot.Location = new System.Drawing.Point(159, 280);
            this.gpbBot.Name = "gpbBot";
            this.gpbBot.Size = new System.Drawing.Size(324, 42);
            this.gpbBot.TabIndex = 115;
            this.gpbBot.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Arial Black", 8F);
            this.btnExcluir.Location = new System.Drawing.Point(204, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 102;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar2
            // 
            this.btnAlterar2.BackColor = System.Drawing.Color.White;
            this.btnAlterar2.FlatAppearance.BorderSize = 0;
            this.btnAlterar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar2.Font = new System.Drawing.Font("Arial Black", 8F);
            this.btnAlterar2.Location = new System.Drawing.Point(50, 13);
            this.btnAlterar2.Name = "btnAlterar2";
            this.btnAlterar2.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar2.TabIndex = 103;
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
            this.btnAlterar.Location = new System.Drawing.Point(50, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 101;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtPerm
            // 
            this.txtPerm.Enabled = false;
            this.txtPerm.FormattingEnabled = true;
            this.txtPerm.Items.AddRange(new object[] {
            "Administrador",
            "Atendente",
            "Estoquista"});
            this.txtPerm.Location = new System.Drawing.Point(90, 68);
            this.txtPerm.Name = "txtPerm";
            this.txtPerm.Size = new System.Drawing.Size(175, 21);
            this.txtPerm.TabIndex = 99;
            // 
            // frmMant_Func
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
            this.Controls.Add(this.lblRetornar);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMant_Func";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmMant_Func_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.gpbTop1.ResumeLayout(false);
            this.gpbTop1.PerformLayout();
            this.gpbTop2.ResumeLayout(false);
            this.gpbTop2.PerformLayout();
            this.gpbBot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRetornar;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblconsulta;
        private System.Windows.Forms.GroupBox gpbTop1;
        private System.Windows.Forms.TextBox txtDate_nasc;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gpbTop2;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.GroupBox gpbBot;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar2;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtID_Func;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblPerm;
        private System.Windows.Forms.ComboBox txtPerm;
    }
}