namespace EclairProject
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblEclair = new System.Windows.Forms.Label();
            this.ptbUser = new System.Windows.Forms.PictureBox();
            this.ptbPass = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPass)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(336, 160);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(212, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(336, 243);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(212, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // btnLogar
            // 
            this.btnLogar.FlatAppearance.BorderSize = 0;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Arial Black", 8F);
            this.btnLogar.Location = new System.Drawing.Point(243, 376);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 3;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Black", 8F);
            this.btnSair.Location = new System.Drawing.Point(514, 376);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblEclair
            // 
            this.lblEclair.AutoSize = true;
            this.lblEclair.BackColor = System.Drawing.Color.Transparent;
            this.lblEclair.Font = new System.Drawing.Font("Loki Cola", 50F);
            this.lblEclair.ForeColor = System.Drawing.Color.White;
            this.lblEclair.Location = new System.Drawing.Point(339, 63);
            this.lblEclair.Name = "lblEclair";
            this.lblEclair.Size = new System.Drawing.Size(167, 79);
            this.lblEclair.TabIndex = 7;
            this.lblEclair.Text = "Eclair";
            // 
            // ptbUser
            // 
            this.ptbUser.BackColor = System.Drawing.Color.Transparent;
            this.ptbUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbUser.BackgroundImage")));
            this.ptbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbUser.Location = new System.Drawing.Point(213, 119);
            this.ptbUser.Name = "ptbUser";
            this.ptbUser.Size = new System.Drawing.Size(117, 94);
            this.ptbUser.TabIndex = 10;
            this.ptbUser.TabStop = false;
            // 
            // ptbPass
            // 
            this.ptbPass.BackColor = System.Drawing.Color.Transparent;
            this.ptbPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbPass.BackgroundImage")));
            this.ptbPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbPass.Location = new System.Drawing.Point(220, 219);
            this.ptbPass.Name = "ptbPass";
            this.ptbPass.Size = new System.Drawing.Size(105, 80);
            this.ptbPass.TabIndex = 11;
            this.ptbPass.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.lblUser.ForeColor = System.Drawing.Color.Snow;
            this.lblUser.Location = new System.Drawing.Point(414, 144);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 15);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "Usuário";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Arial Black", 8.25F);
            this.lblPass.ForeColor = System.Drawing.Color.Snow;
            this.lblPass.Location = new System.Drawing.Point(416, 227);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(43, 15);
            this.lblPass.TabIndex = 13;
            this.lblPass.Text = "Senha";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.ptbPass);
            this.Controls.Add(this.ptbUser);
            this.Controls.Add(this.lblEclair);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblEclair;
        private System.Windows.Forms.PictureBox ptbUser;
        private System.Windows.Forms.PictureBox ptbPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
    }
}

