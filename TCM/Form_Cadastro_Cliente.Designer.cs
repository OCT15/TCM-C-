namespace TCM
{
    partial class Form_Cadastro_Cliente
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
            this.lblNome_cliente = new System.Windows.Forms.Label();
            this.lblSobrenome_cliente = new System.Windows.Forms.Label();
            this.lblEmail_cliente = new System.Windows.Forms.Label();
            this.lblDatadenascimento_cliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome_cliente
            // 
            this.lblNome_cliente.AutoSize = true;
            this.lblNome_cliente.Location = new System.Drawing.Point(81, 47);
            this.lblNome_cliente.Name = "lblNome_cliente";
            this.lblNome_cliente.Size = new System.Drawing.Size(38, 13);
            this.lblNome_cliente.TabIndex = 0;
            this.lblNome_cliente.Text = "Nome:";
            // 
            // lblSobrenome_cliente
            // 
            this.lblSobrenome_cliente.AutoSize = true;
            this.lblSobrenome_cliente.Location = new System.Drawing.Point(79, 81);
            this.lblSobrenome_cliente.Name = "lblSobrenome_cliente";
            this.lblSobrenome_cliente.Size = new System.Drawing.Size(64, 13);
            this.lblSobrenome_cliente.TabIndex = 1;
            this.lblSobrenome_cliente.Text = "Sobrenome:";
            // 
            // lblEmail_cliente
            // 
            this.lblEmail_cliente.AutoSize = true;
            this.lblEmail_cliente.Location = new System.Drawing.Point(81, 115);
            this.lblEmail_cliente.Name = "lblEmail_cliente";
            this.lblEmail_cliente.Size = new System.Drawing.Size(35, 13);
            this.lblEmail_cliente.TabIndex = 2;
            this.lblEmail_cliente.Text = "Email:";
            // 
            // lblDatadenascimento_cliente
            // 
            this.lblDatadenascimento_cliente.AutoSize = true;
            this.lblDatadenascimento_cliente.Location = new System.Drawing.Point(81, 149);
            this.lblDatadenascimento_cliente.Name = "lblDatadenascimento_cliente";
            this.lblDatadenascimento_cliente.Size = new System.Drawing.Size(107, 13);
            this.lblDatadenascimento_cliente.TabIndex = 3;
            this.lblDatadenascimento_cliente.Text = "Data de Nascimento:";
            // 
            // Form_Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 388);
            this.Controls.Add(this.lblDatadenascimento_cliente);
            this.Controls.Add(this.lblEmail_cliente);
            this.Controls.Add(this.lblSobrenome_cliente);
            this.Controls.Add(this.lblNome_cliente);
            this.Name = "Form_Cadastro_Cliente";
            this.Text = "Form_Cadastro_Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome_cliente;
        private System.Windows.Forms.Label lblSobrenome_cliente;
        private System.Windows.Forms.Label lblEmail_cliente;
        private System.Windows.Forms.Label lblDatadenascimento_cliente;
    }
}