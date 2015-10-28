namespace EclairProject
{
    partial class frmInser_Est
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInser_Est));
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
            this.gpbMid = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.gpbTop1.SuspendLayout();
            this.gpbTop2.SuspendLayout();
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
            this.lblRetornar.TabIndex = 130;
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
            this.btnBack.TabIndex = 129;
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
            this.gpbTop1.Location = new System.Drawing.Point(16, 142);
            this.gpbTop1.Name = "gpbTop1";
            this.gpbTop1.Size = new System.Drawing.Size(294, 83);
            this.gpbTop1.TabIndex = 131;
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
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(15, 46);
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
            this.gpbTop2.Controls.Add(this.txtQuant);
            this.gpbTop2.Controls.Add(this.txtPreço);
            this.gpbTop2.Location = new System.Drawing.Point(323, 142);
            this.gpbTop2.Name = "gpbTop2";
            this.gpbTop2.Size = new System.Drawing.Size(292, 83);
            this.gpbTop2.TabIndex = 132;
            this.gpbTop2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 119;
            this.label2.Text = "Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
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
            // gpbMid
            // 
            this.gpbMid.BackColor = System.Drawing.Color.Transparent;
            this.gpbMid.Controls.Add(this.txtTipo);
            this.gpbMid.Controls.Add(this.label3);
            this.gpbMid.Location = new System.Drawing.Point(143, 231);
            this.gpbMid.Name = "gpbMid";
            this.gpbMid.Size = new System.Drawing.Size(324, 44);
            this.gpbMid.TabIndex = 133;
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 120;
            this.label3.Text = "Tipo";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(194, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 35);
            this.lblTitle.TabIndex = 134;
            this.lblTitle.Text = "Inserir Produto";
            // 
            // frmInser_Est
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(630, 417);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gpbTop1);
            this.Controls.Add(this.gpbTop2);
            this.Controls.Add(this.gpbMid);
            this.Controls.Add(this.lblRetornar);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInser_Est";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmInser_Est";
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.gpbTop1.ResumeLayout(false);
            this.gpbTop1.PerformLayout();
            this.gpbTop2.ResumeLayout(false);
            this.gpbTop2.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpbMid;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
    }
}