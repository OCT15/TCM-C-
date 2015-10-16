namespace EclairProject
{
    partial class frmInser_Cli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInser_Cli));
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtID_Cli = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbTop1 = new System.Windows.Forms.GroupBox();
            this.txtDate_nasc = new System.Windows.Forms.MaskedTextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.ptbData = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbTop2 = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.ptbCPF = new System.Windows.Forms.PictureBox();
            this.ptbTelefone = new System.Windows.Forms.PictureBox();
            this.ptbCel = new System.Windows.Forms.PictureBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblconsulta = new System.Windows.Forms.Label();
            this.gpbMid = new System.Windows.Forms.GroupBox();
            this.gpbBot = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblRetornar = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gpbTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbTop2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTelefone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCel)).BeginInit();
            this.gpbBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(104, 76);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(190, 20);
            this.txtSenha.TabIndex = 11;
            // 
            // txtID_Cli
            // 
            this.txtID_Cli.Enabled = false;
            this.txtID_Cli.Location = new System.Drawing.Point(117, 97);
            this.txtID_Cli.Name = "txtID_Cli";
            this.txtID_Cli.Size = new System.Drawing.Size(190, 20);
            this.txtID_Cli.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(117, 127);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(190, 20);
            this.txtNome.TabIndex = 10;
            // 
            // gpbTop1
            // 
            this.gpbTop1.BackColor = System.Drawing.Color.Transparent;
            this.gpbTop1.Controls.Add(this.txtDate_nasc);
            this.gpbTop1.Controls.Add(this.txtSenha);
            this.gpbTop1.Controls.Add(this.txtIdade);
            this.gpbTop1.Controls.Add(this.lblIdade);
            this.gpbTop1.Controls.Add(this.lblSenha);
            this.gpbTop1.Controls.Add(this.lblNascimento);
            this.gpbTop1.Controls.Add(this.lblNome);
            this.gpbTop1.Controls.Add(this.lblID);
            this.gpbTop1.Controls.Add(this.ptbData);
            this.gpbTop1.Controls.Add(this.pictureBox1);
            this.gpbTop1.Location = new System.Drawing.Point(13, 81);
            this.gpbTop1.Name = "gpbTop1";
            this.gpbTop1.Size = new System.Drawing.Size(301, 169);
            this.gpbTop1.TabIndex = 99;
            this.gpbTop1.TabStop = false;
            // 
            // txtDate_nasc
            // 
            this.txtDate_nasc.Location = new System.Drawing.Point(104, 105);
            this.txtDate_nasc.Mask = "00/00/0000";
            this.txtDate_nasc.Name = "txtDate_nasc";
            this.txtDate_nasc.Size = new System.Drawing.Size(190, 20);
            this.txtDate_nasc.TabIndex = 13;
            this.txtDate_nasc.Leave += new System.EventHandler(this.txtDate_nasc_Leave);
            // 
            // txtIdade
            // 
            this.txtIdade.Enabled = false;
            this.txtIdade.Location = new System.Drawing.Point(105, 135);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(190, 20);
            this.txtIdade.TabIndex = 12;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.BackColor = System.Drawing.Color.Transparent;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(31, 133);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(54, 22);
            this.lblIdade.TabIndex = 69;
            this.lblIdade.Text = "Idade";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(26, 74);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(62, 22);
            this.lblSenha.TabIndex = 66;
            this.lblSenha.Text = "Senha";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.ForeColor = System.Drawing.Color.White;
            this.lblNascimento.Location = new System.Drawing.Point(2, 102);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(104, 22);
            this.lblNascimento.TabIndex = 65;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(28, 44);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 22);
            this.lblNome.TabIndex = 64;
            this.lblNome.Text = "Nome";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(44, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 22);
            this.lblID.TabIndex = 63;
            this.lblID.Text = "ID";
            // 
            // ptbData
            // 
            this.ptbData.Location = new System.Drawing.Point(4, 102);
            this.ptbData.Name = "ptbData";
            this.ptbData.Size = new System.Drawing.Size(96, 25);
            this.ptbData.TabIndex = 96;
            this.ptbData.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 25);
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // gpbTop2
            // 
            this.gpbTop2.BackColor = System.Drawing.Color.Transparent;
            this.gpbTop2.Controls.Add(this.txtCPF);
            this.gpbTop2.Controls.Add(this.txtTelefone);
            this.gpbTop2.Controls.Add(this.txtCel);
            this.gpbTop2.Controls.Add(this.txtCEP);
            this.gpbTop2.Controls.Add(this.lblTelefone);
            this.gpbTop2.Controls.Add(this.txtEnd);
            this.gpbTop2.Controls.Add(this.lblEndereço);
            this.gpbTop2.Controls.Add(this.lblCelular);
            this.gpbTop2.Controls.Add(this.lblCEP);
            this.gpbTop2.Controls.Add(this.lblCPF);
            this.gpbTop2.Controls.Add(this.ptbCPF);
            this.gpbTop2.Controls.Add(this.ptbTelefone);
            this.gpbTop2.Controls.Add(this.ptbCel);
            this.gpbTop2.Location = new System.Drawing.Point(329, 81);
            this.gpbTop2.Name = "gpbTop2";
            this.gpbTop2.Size = new System.Drawing.Size(277, 169);
            this.gpbTop2.TabIndex = 100;
            this.gpbTop2.TabStop = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(93, 105);
            this.txtCPF.Mask = "000\\.000\\.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(175, 20);
            this.txtCPF.TabIndex = 17;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(93, 16);
            this.txtTelefone.Mask = "(00)0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(175, 20);
            this.txtTelefone.TabIndex = 14;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(93, 45);
            this.txtCel.Mask = "(00)00000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(175, 20);
            this.txtCel.TabIndex = 15;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(93, 135);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(175, 20);
            this.txtCEP.TabIndex = 18;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(5, 16);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(81, 22);
            this.lblTelefone.TabIndex = 75;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(93, 76);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(175, 20);
            this.txtEnd.TabIndex = 16;
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereço.ForeColor = System.Drawing.Color.White;
            this.lblEndereço.Location = new System.Drawing.Point(2, 76);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(87, 22);
            this.lblEndereço.TabIndex = 70;
            this.lblEndereço.Text = "Endereço";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.White;
            this.lblCelular.Location = new System.Drawing.Point(11, 46);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(67, 22);
            this.lblCelular.TabIndex = 74;
            this.lblCelular.Text = "Celular";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.BackColor = System.Drawing.Color.Transparent;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.Color.White;
            this.lblCEP.Location = new System.Drawing.Point(23, 136);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(47, 22);
            this.lblCEP.TabIndex = 72;
            this.lblCEP.Text = "CEP";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(22, 106);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(46, 22);
            this.lblCPF.TabIndex = 71;
            this.lblCPF.Text = "CPF";
            // 
            // ptbCPF
            // 
            this.ptbCPF.BackColor = System.Drawing.Color.Transparent;
            this.ptbCPF.Location = new System.Drawing.Point(12, 104);
            this.ptbCPF.Name = "ptbCPF";
            this.ptbCPF.Size = new System.Drawing.Size(67, 25);
            this.ptbCPF.TabIndex = 80;
            this.ptbCPF.TabStop = false;
            // 
            // ptbTelefone
            // 
            this.ptbTelefone.Location = new System.Drawing.Point(5, 13);
            this.ptbTelefone.Name = "ptbTelefone";
            this.ptbTelefone.Size = new System.Drawing.Size(80, 25);
            this.ptbTelefone.TabIndex = 81;
            this.ptbTelefone.TabStop = false;
            // 
            // ptbCel
            // 
            this.ptbCel.Location = new System.Drawing.Point(6, 45);
            this.ptbCel.Name = "ptbCel";
            this.ptbCel.Size = new System.Drawing.Size(80, 25);
            this.ptbCel.TabIndex = 82;
            this.ptbCel.TabStop = false;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(118, 264);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(392, 20);
            this.txtMail.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(51, 263);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 22);
            this.lblEmail.TabIndex = 98;
            this.lblEmail.Text = "E-mail";
            // 
            // lblconsulta
            // 
            this.lblconsulta.AutoSize = true;
            this.lblconsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsulta.ForeColor = System.Drawing.Color.White;
            this.lblconsulta.Location = new System.Drawing.Point(168, 26);
            this.lblconsulta.Name = "lblconsulta";
            this.lblconsulta.Size = new System.Drawing.Size(204, 35);
            this.lblconsulta.TabIndex = 97;
            this.lblconsulta.Text = "Inserir Cliente";
            // 
            // gpbMid
            // 
            this.gpbMid.BackColor = System.Drawing.Color.Transparent;
            this.gpbMid.Location = new System.Drawing.Point(43, 249);
            this.gpbMid.Name = "gpbMid";
            this.gpbMid.Size = new System.Drawing.Size(482, 44);
            this.gpbMid.TabIndex = 102;
            this.gpbMid.TabStop = false;
            // 
            // gpbBot
            // 
            this.gpbBot.BackColor = System.Drawing.Color.Transparent;
            this.gpbBot.Controls.Add(this.btnInserir);
            this.gpbBot.Controls.Add(this.btnLimpar);
            this.gpbBot.Location = new System.Drawing.Point(152, 293);
            this.gpbBot.Name = "gpbBot";
            this.gpbBot.Size = new System.Drawing.Size(324, 42);
            this.gpbBot.TabIndex = 103;
            this.gpbBot.TabStop = false;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(27, 13);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(225, 13);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(571, -8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 60);
            this.btnBack.TabIndex = 104;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // lblRetornar
            // 
            this.lblRetornar.AutoSize = true;
            this.lblRetornar.BackColor = System.Drawing.Color.Transparent;
            this.lblRetornar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRetornar.Location = new System.Drawing.Point(521, 41);
            this.lblRetornar.Name = "lblRetornar";
            this.lblRetornar.Size = new System.Drawing.Size(48, 13);
            this.lblRetornar.TabIndex = 105;
            this.lblRetornar.Text = "Retornar";
            this.lblRetornar.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton2.Location = new System.Drawing.Point(383, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 17);
            this.radioButton2.TabIndex = 114;
            this.radioButton2.Text = "Pessoa Jurídica";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(383, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 17);
            this.radioButton1.TabIndex = 113;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pessoa Física";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // frmInser_Cli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EclairProject.Properties.Resources.Logadaview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 417);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblRetornar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gpbBot);
            this.Controls.Add(this.txtID_Cli);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.gpbTop1);
            this.Controls.Add(this.gpbTop2);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblconsulta);
            this.Controls.Add(this.gpbMid);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInser_Cli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmInser_Cli";
            this.Load += new System.EventHandler(this.frmInser_Cli_Load);
            this.Leave += new System.EventHandler(this.frmInser_Cli_Leave);
            this.gpbTop1.ResumeLayout(false);
            this.gpbTop1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbTop2.ResumeLayout(false);
            this.gpbTop2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTelefone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCel)).EndInit();
            this.gpbBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtID_Cli;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gpbTop1;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gpbTop2;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblconsulta;
        private System.Windows.Forms.GroupBox gpbMid;
        private System.Windows.Forms.GroupBox gpbBot;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.MaskedTextBox txtDate_nasc;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.PictureBox ptbCPF;
        private System.Windows.Forms.PictureBox ptbData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbTelefone;
        private System.Windows.Forms.PictureBox ptbCel;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblRetornar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}