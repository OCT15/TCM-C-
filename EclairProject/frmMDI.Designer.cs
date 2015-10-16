namespace EclairProject
{
    partial class frmMDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLogOff = new System.Windows.Forms.Label();
            this.lblEstoquista = new System.Windows.Forms.Label();
            this.lblAtendente = new System.Windows.Forms.Label();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.btnDeslogar = new System.Windows.Forms.PictureBox();
            this.btnETQ = new System.Windows.Forms.Button();
            this.btnATD = new System.Windows.Forms.Button();
            this.btnADM = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeslogar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.lblLogOff);
            this.groupBox1.Controls.Add(this.lblEstoquista);
            this.groupBox1.Controls.Add(this.lblAtendente);
            this.groupBox1.Controls.Add(this.lblAdministrador);
            this.groupBox1.Controls.Add(this.btnDeslogar);
            this.groupBox1.Controls.Add(this.btnETQ);
            this.groupBox1.Controls.Add(this.btnATD);
            this.groupBox1.Controls.Add(this.btnADM);
            this.groupBox1.Location = new System.Drawing.Point(-2, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(156, 471);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblLogOff
            // 
            this.lblLogOff.AutoSize = true;
            this.lblLogOff.BackColor = System.Drawing.Color.Transparent;
            this.lblLogOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogOff.Location = new System.Drawing.Point(40, 33);
            this.lblLogOff.Name = "lblLogOff";
            this.lblLogOff.Size = new System.Drawing.Size(39, 13);
            this.lblLogOff.TabIndex = 7;
            this.lblLogOff.Text = "LogOff";
            this.lblLogOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogOff.Visible = false;
            // 
            // lblEstoquista
            // 
            this.lblEstoquista.AutoSize = true;
            this.lblEstoquista.BackColor = System.Drawing.Color.Transparent;
            this.lblEstoquista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstoquista.Location = new System.Drawing.Point(45, 149);
            this.lblEstoquista.Name = "lblEstoquista";
            this.lblEstoquista.Size = new System.Drawing.Size(56, 13);
            this.lblEstoquista.TabIndex = 6;
            this.lblEstoquista.Text = "Estoquista";
            this.lblEstoquista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstoquista.Visible = false;
            // 
            // lblAtendente
            // 
            this.lblAtendente.AutoSize = true;
            this.lblAtendente.BackColor = System.Drawing.Color.Transparent;
            this.lblAtendente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAtendente.Location = new System.Drawing.Point(45, 275);
            this.lblAtendente.Name = "lblAtendente";
            this.lblAtendente.Size = new System.Drawing.Size(56, 13);
            this.lblAtendente.TabIndex = 5;
            this.lblAtendente.Text = "Atendente";
            this.lblAtendente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAtendente.Visible = false;
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.lblAdministrador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdministrador.Location = new System.Drawing.Point(45, 405);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(70, 13);
            this.lblAdministrador.TabIndex = 4;
            this.lblAdministrador.Text = "Administrador";
            this.lblAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdministrador.Visible = false;
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeslogar.BackgroundImage")));
            this.btnDeslogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeslogar.Location = new System.Drawing.Point(2, 11);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(38, 35);
            this.btnDeslogar.TabIndex = 3;
            this.btnDeslogar.TabStop = false;
            this.btnDeslogar.Click += new System.EventHandler(this.pictureBox2_Click);
            this.btnDeslogar.MouseLeave += new System.EventHandler(this.btnDeslogar_MouseLeave);
            this.btnDeslogar.MouseHover += new System.EventHandler(this.btnDeslogar_MouseHover);
            // 
            // btnETQ
            // 
            this.btnETQ.BackColor = System.Drawing.Color.Transparent;
            this.btnETQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnETQ.BackgroundImage")));
            this.btnETQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnETQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnETQ.Location = new System.Drawing.Point(32, 59);
            this.btnETQ.Margin = new System.Windows.Forms.Padding(0);
            this.btnETQ.Name = "btnETQ";
            this.btnETQ.Size = new System.Drawing.Size(90, 90);
            this.btnETQ.TabIndex = 2;
            this.btnETQ.UseVisualStyleBackColor = false;
            this.btnETQ.Click += new System.EventHandler(this.btnETQ_Click);
            this.btnETQ.MouseLeave += new System.EventHandler(this.btnETQ_MouseLeave);
            this.btnETQ.MouseHover += new System.EventHandler(this.btnETQ_MouseHover);
            // 
            // btnATD
            // 
            this.btnATD.Location = new System.Drawing.Point(32, 182);
            this.btnATD.Name = "btnATD";
            this.btnATD.Size = new System.Drawing.Size(90, 90);
            this.btnATD.TabIndex = 1;
            this.btnATD.UseVisualStyleBackColor = true;
            this.btnATD.Click += new System.EventHandler(this.btnATD_Click);
            this.btnATD.MouseLeave += new System.EventHandler(this.btnATD_MouseLeave);
            this.btnATD.MouseHover += new System.EventHandler(this.btnATD_MouseHover);
            // 
            // btnADM
            // 
            this.btnADM.Location = new System.Drawing.Point(32, 312);
            this.btnADM.Name = "btnADM";
            this.btnADM.Size = new System.Drawing.Size(90, 90);
            this.btnADM.TabIndex = 0;
            this.btnADM.UseVisualStyleBackColor = true;
            this.btnADM.Click += new System.EventHandler(this.btnADM_Click);
            this.btnADM.MouseLeave += new System.EventHandler(this.btnADM_MouseLeave);
            this.btnADM.MouseHover += new System.EventHandler(this.btnADM_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.lblCronometro);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblText);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Location = new System.Drawing.Point(-22, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 46);
            this.panel1.TabIndex = 64;
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCronometro.Location = new System.Drawing.Point(26, 20);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(90, 25);
            this.lblCronometro.TabIndex = 3;
            this.lblCronometro.Text = "00:00:00";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(730, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 23);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "label1";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(26, 3);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "label1";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Loki Cola", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(649, 3);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(45, 24);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EclairProject.Properties.Resources.DEFININDO_BACKGROUND_black_and_red_Recovered;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(152, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 417);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeslogar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnATD;
        private System.Windows.Forms.Button btnADM;
        private System.Windows.Forms.Button btnETQ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnDeslogar;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Label lblEstoquista;
        private System.Windows.Forms.Label lblAtendente;
        private System.Windows.Forms.Label lblLogOff;
    }
}