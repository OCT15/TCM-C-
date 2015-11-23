namespace EclairProject
{
    partial class frmInser_Func
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInser_Func));
            this.lblRetornar = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblconsulta = new System.Windows.Forms.Label();
            this.gpbTop1 = new System.Windows.Forms.GroupBox();
            this.txtDate_nasc = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtID_Func = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.ptbData = new System.Windows.Forms.PictureBox();
            this.ptbMail = new System.Windows.Forms.PictureBox();
            this.gpbTop2 = new System.Windows.Forms.GroupBox();
            this.txtPerm = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblPerm = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.ptbCPF = new System.Windows.Forms.PictureBox();
            this.ptbTelefone = new System.Windows.Forms.PictureBox();
            this.ptbCel = new System.Windows.Forms.PictureBox();
            this.ptbRG = new System.Windows.Forms.PictureBox();
            this.ptbCEP = new System.Windows.Forms.PictureBox();
            this.gpbBot = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.gpbTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMail)).BeginInit();
            this.gpbTop2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTelefone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCEP)).BeginInit();
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
            this.lblconsulta.Location = new System.Drawing.Point(173, 33);
            this.lblconsulta.Name = "lblconsulta";
            this.lblconsulta.Size = new System.Drawing.Size(307, 40);
            this.lblconsulta.TabIndex = 116;
            this.lblconsulta.Text = "Inserir Funcionário";
            // 
            // gpbTop1
            // 
            this.gpbTop1.BackColor = System.Drawing.Color.Transparent;
            this.gpbTop1.Controls.Add(this.txtDate_nasc);
            this.gpbTop1.Controls.Add(this.txtMail);
            this.gpbTop1.Controls.Add(this.lblMail);
            this.gpbTop1.Controls.Add(this.txtEnd);
            this.gpbTop1.Controls.Add(this.lblEndereço);
            this.gpbTop1.Controls.Add(this.txtSenha);
            this.gpbTop1.Controls.Add(this.txtID_Func);
            this.gpbTop1.Controls.Add(this.txtNome);
            this.gpbTop1.Controls.Add(this.lblSenha);
            this.gpbTop1.Controls.Add(this.lblNascimento);
            this.gpbTop1.Controls.Add(this.lblNome);
            this.gpbTop1.Controls.Add(this.lblID);
            this.gpbTop1.Controls.Add(this.ptbData);
            this.gpbTop1.Controls.Add(this.ptbMail);
            this.gpbTop1.Location = new System.Drawing.Point(14, 87);
            this.gpbTop1.Name = "gpbTop1";
            this.gpbTop1.Size = new System.Drawing.Size(301, 184);
            this.gpbTop1.TabIndex = 113;
            this.gpbTop1.TabStop = false;
            // 
            // txtDate_nasc
            // 
            this.txtDate_nasc.Location = new System.Drawing.Point(104, 127);
            this.txtDate_nasc.Mask = "00\\.00\\.0000";
            this.txtDate_nasc.Name = "txtDate_nasc";
            this.txtDate_nasc.Size = new System.Drawing.Size(190, 20);
            this.txtDate_nasc.TabIndex = 13;
            this.txtDate_nasc.Leave += new System.EventHandler(this.txtDate_nasc_Leave);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(104, 154);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(190, 20);
            this.txtMail.TabIndex = 14;
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(26, 156);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(57, 19);
            this.lblMail.TabIndex = 99;
            this.lblMail.Text = "E-mail";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(104, 96);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(190, 20);
            this.txtEnd.TabIndex = 12;
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereço.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblEndereço.ForeColor = System.Drawing.Color.White;
            this.lblEndereço.Location = new System.Drawing.Point(14, 95);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(79, 19);
            this.lblEndereço.TabIndex = 97;
            this.lblEndereço.Text = "Endereço";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(104, 68);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(190, 20);
            this.txtSenha.TabIndex = 11;
            // 
            // txtID_Func
            // 
            this.txtID_Func.Enabled = false;
            this.txtID_Func.Location = new System.Drawing.Point(104, 14);
            this.txtID_Func.Name = "txtID_Func";
            this.txtID_Func.Size = new System.Drawing.Size(190, 20);
            this.txtID_Func.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(104, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(190, 20);
            this.txtNome.TabIndex = 10;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(26, 68);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(55, 19);
            this.lblSenha.TabIndex = 66;
            this.lblSenha.Text = "Senha";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblNascimento.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblNascimento.ForeColor = System.Drawing.Color.White;
            this.lblNascimento.Location = new System.Drawing.Point(6, 128);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(90, 19);
            this.lblNascimento.TabIndex = 65;
            this.lblNascimento.Text = "Data_Nasc";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(29, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 19);
            this.lblNome.TabIndex = 64;
            this.lblNome.Text = "Nome";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(43, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 19);
            this.lblID.TabIndex = 63;
            this.lblID.Text = "ID";
            // 
            // ptbData
            // 
            this.ptbData.Location = new System.Drawing.Point(18, 137);
            this.ptbData.Name = "ptbData";
            this.ptbData.Size = new System.Drawing.Size(67, 11);
            this.ptbData.TabIndex = 104;
            this.ptbData.TabStop = false;
            // 
            // ptbMail
            // 
            this.ptbMail.Location = new System.Drawing.Point(28, 167);
            this.ptbMail.Name = "ptbMail";
            this.ptbMail.Size = new System.Drawing.Size(53, 10);
            this.ptbMail.TabIndex = 105;
            this.ptbMail.TabStop = false;
            // 
            // gpbTop2
            // 
            this.gpbTop2.BackColor = System.Drawing.Color.Transparent;
            this.gpbTop2.Controls.Add(this.txtPerm);
            this.gpbTop2.Controls.Add(this.txtTelefone);
            this.gpbTop2.Controls.Add(this.txtCel);
            this.gpbTop2.Controls.Add(this.txtCPF);
            this.gpbTop2.Controls.Add(this.txtRG);
            this.gpbTop2.Controls.Add(this.txtCEP);
            this.gpbTop2.Controls.Add(this.lblRG);
            this.gpbTop2.Controls.Add(this.lblPerm);
            this.gpbTop2.Controls.Add(this.lblTelefone);
            this.gpbTop2.Controls.Add(this.lblCelular);
            this.gpbTop2.Controls.Add(this.lblCEP);
            this.gpbTop2.Controls.Add(this.lblCPF);
            this.gpbTop2.Controls.Add(this.ptbCPF);
            this.gpbTop2.Controls.Add(this.ptbTelefone);
            this.gpbTop2.Controls.Add(this.ptbCel);
            this.gpbTop2.Controls.Add(this.ptbRG);
            this.gpbTop2.Controls.Add(this.ptbCEP);
            this.gpbTop2.Location = new System.Drawing.Point(330, 87);
            this.gpbTop2.Name = "gpbTop2";
            this.gpbTop2.Size = new System.Drawing.Size(277, 184);
            this.gpbTop2.TabIndex = 114;
            this.gpbTop2.TabStop = false;
            // 
            // txtPerm
            // 
            this.txtPerm.FormattingEnabled = true;
            this.txtPerm.Items.AddRange(new object[] {
            "Administrador",
            "Atendente",
            "Estoquista"});
            this.txtPerm.Location = new System.Drawing.Point(90, 68);
            this.txtPerm.Name = "txtPerm";
            this.txtPerm.Size = new System.Drawing.Size(175, 21);
            this.txtPerm.TabIndex = 17;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(90, 14);
            this.txtTelefone.Mask = "(00)0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(175, 20);
            this.txtTelefone.TabIndex = 15;
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(90, 40);
            this.txtCel.Mask = "(00)00000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(175, 20);
            this.txtCel.TabIndex = 16;
            this.txtCel.Leave += new System.EventHandler(this.txtCel_Leave);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(90, 98);
            this.txtCPF.Mask = "000\\.000\\.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(175, 20);
            this.txtCPF.TabIndex = 18;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(90, 127);
            this.txtRG.Mask = "00\\.000\\.000-a";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(175, 20);
            this.txtRG.TabIndex = 19;
            this.txtRG.Leave += new System.EventHandler(this.txtRG_Leave);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(90, 155);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(175, 20);
            this.txtCEP.TabIndex = 101;
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.BackColor = System.Drawing.Color.Transparent;
            this.lblRG.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblRG.ForeColor = System.Drawing.Color.White;
            this.lblRG.Location = new System.Drawing.Point(30, 128);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(32, 19);
            this.lblRG.TabIndex = 98;
            this.lblRG.Text = "RG";
            // 
            // lblPerm
            // 
            this.lblPerm.AutoSize = true;
            this.lblPerm.BackColor = System.Drawing.Color.Transparent;
            this.lblPerm.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblPerm.ForeColor = System.Drawing.Color.White;
            this.lblPerm.Location = new System.Drawing.Point(-2, 68);
            this.lblPerm.Name = "lblPerm";
            this.lblPerm.Size = new System.Drawing.Size(89, 19);
            this.lblPerm.TabIndex = 95;
            this.lblPerm.Text = "Permissão";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(3, 14);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(74, 19);
            this.lblTelefone.TabIndex = 75;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblCelular.ForeColor = System.Drawing.Color.White;
            this.lblCelular.Location = new System.Drawing.Point(9, 41);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(63, 19);
            this.lblCelular.TabIndex = 74;
            this.lblCelular.Text = "Celular";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.BackColor = System.Drawing.Color.Transparent;
            this.lblCEP.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblCEP.ForeColor = System.Drawing.Color.White;
            this.lblCEP.Location = new System.Drawing.Point(24, 155);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(40, 19);
            this.lblCEP.TabIndex = 72;
            this.lblCEP.Text = "CEP";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(24, 99);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(39, 19);
            this.lblCPF.TabIndex = 71;
            this.lblCPF.Text = "CPF";
            // 
            // ptbCPF
            // 
            this.ptbCPF.BackColor = System.Drawing.Color.Transparent;
            this.ptbCPF.Location = new System.Drawing.Point(26, 109);
            this.ptbCPF.Name = "ptbCPF";
            this.ptbCPF.Size = new System.Drawing.Size(37, 10);
            this.ptbCPF.TabIndex = 119;
            this.ptbCPF.TabStop = false;
            // 
            // ptbTelefone
            // 
            this.ptbTelefone.Location = new System.Drawing.Point(2, 24);
            this.ptbTelefone.Name = "ptbTelefone";
            this.ptbTelefone.Size = new System.Drawing.Size(74, 10);
            this.ptbTelefone.TabIndex = 120;
            this.ptbTelefone.TabStop = false;
            // 
            // ptbCel
            // 
            this.ptbCel.Location = new System.Drawing.Point(13, 51);
            this.ptbCel.Name = "ptbCel";
            this.ptbCel.Size = new System.Drawing.Size(56, 10);
            this.ptbCel.TabIndex = 121;
            this.ptbCel.TabStop = false;
            // 
            // ptbRG
            // 
            this.ptbRG.BackColor = System.Drawing.Color.Transparent;
            this.ptbRG.Location = new System.Drawing.Point(30, 138);
            this.ptbRG.Name = "ptbRG";
            this.ptbRG.Size = new System.Drawing.Size(31, 10);
            this.ptbRG.TabIndex = 122;
            this.ptbRG.TabStop = false;
            // 
            // ptbCEP
            // 
            this.ptbCEP.BackColor = System.Drawing.Color.Transparent;
            this.ptbCEP.Location = new System.Drawing.Point(25, 167);
            this.ptbCEP.Name = "ptbCEP";
            this.ptbCEP.Size = new System.Drawing.Size(38, 10);
            this.ptbCEP.TabIndex = 123;
            this.ptbCEP.TabStop = false;
            // 
            // gpbBot
            // 
            this.gpbBot.BackColor = System.Drawing.Color.Transparent;
            this.gpbBot.Controls.Add(this.btnInserir);
            this.gpbBot.Controls.Add(this.btnLimpar);
            this.gpbBot.Location = new System.Drawing.Point(156, 277);
            this.gpbBot.Name = "gpbBot";
            this.gpbBot.Size = new System.Drawing.Size(324, 42);
            this.gpbBot.TabIndex = 117;
            this.gpbBot.TabStop = false;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.White;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Arial Black", 8F);
            this.btnInserir.ForeColor = System.Drawing.Color.Black;
            this.btnInserir.Location = new System.Drawing.Point(27, 13);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 8F);
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(225, 13);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmInser_Func
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 417);
            this.Controls.Add(this.gpbBot);
            this.Controls.Add(this.lblconsulta);
            this.Controls.Add(this.gpbTop1);
            this.Controls.Add(this.gpbTop2);
            this.Controls.Add(this.lblRetornar);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInser_Func";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmInser_Func_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.gpbTop1.ResumeLayout(false);
            this.gpbTop1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMail)).EndInit();
            this.gpbTop2.ResumeLayout(false);
            this.gpbTop2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTelefone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCEP)).EndInit();
            this.gpbBot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRetornar;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblconsulta;
        private System.Windows.Forms.GroupBox gpbTop1;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gpbTop2;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtID_Func;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblPerm;
        private System.Windows.Forms.GroupBox gpbBot;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox txtDate_nasc;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.ComboBox txtPerm;
        private System.Windows.Forms.PictureBox ptbCPF;
        private System.Windows.Forms.PictureBox ptbTelefone;
        private System.Windows.Forms.PictureBox ptbCel;
        private System.Windows.Forms.PictureBox ptbRG;
        private System.Windows.Forms.PictureBox ptbCEP;
        private System.Windows.Forms.PictureBox ptbData;
        private System.Windows.Forms.PictureBox ptbMail;
    }
}