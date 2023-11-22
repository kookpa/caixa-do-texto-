namespace blocodetexto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.btnLer = new System.Windows.Forms.Button();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.rbTelefone = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.lbNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNome = new System.Windows.Forms.ComboBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbRespTelefone = new System.Windows.Forms.Label();
            this.lbRespEmail = new System.Windows.Forms.Label();
            this.lbResNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(29, 166);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 46);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(43, 25);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(156, 20);
            this.txbInput.TabIndex = 1;
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(142, 168);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(80, 44);
            this.btnLer.TabIndex = 2;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(43, 76);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(156, 20);
            this.txbTelefone.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(40, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(40, 60);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Telefone";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(43, 128);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(156, 20);
            this.txbEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(40, 112);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // rbTelefone
            // 
            this.rbTelefone.AutoSize = true;
            this.rbTelefone.Location = new System.Drawing.Point(230, 25);
            this.rbTelefone.Name = "rbTelefone";
            this.rbTelefone.Size = new System.Drawing.Size(67, 17);
            this.rbTelefone.TabIndex = 8;
            this.rbTelefone.TabStop = true;
            this.rbTelefone.Text = "Telefone";
            this.rbTelefone.UseVisualStyleBackColor = true;
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Location = new System.Drawing.Point(230, 60);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(50, 17);
            this.rbEmail.TabIndex = 9;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "Email";
            this.rbEmail.UseVisualStyleBackColor = true;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(240, 149);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 10;
            this.lbNome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome Contato";
            // 
            // cbxNome
            // 
            this.cbxNome.FormattingEnabled = true;
            this.cbxNome.Location = new System.Drawing.Point(231, 112);
            this.cbxNome.Name = "cbxNome";
            this.cbxNome.Size = new System.Drawing.Size(83, 21);
            this.cbxNome.TabIndex = 12;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(240, 183);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 13;
            this.lbEmail.Text = "Email:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(237, 208);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(52, 13);
            this.lbTelefone.TabIndex = 14;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbRespTelefone
            // 
            this.lbRespTelefone.AutoSize = true;
            this.lbRespTelefone.Location = new System.Drawing.Point(295, 208);
            this.lbRespTelefone.Name = "lbRespTelefone";
            this.lbRespTelefone.Size = new System.Drawing.Size(97, 13);
            this.lbRespTelefone.TabIndex = 15;
            this.lbRespTelefone.Text = "Resposta Telefone";
            // 
            // lbRespEmail
            // 
            this.lbRespEmail.AutoSize = true;
            this.lbRespEmail.Location = new System.Drawing.Point(285, 183);
            this.lbRespEmail.Name = "lbRespEmail";
            this.lbRespEmail.Size = new System.Drawing.Size(80, 13);
            this.lbRespEmail.TabIndex = 16;
            this.lbRespEmail.Text = "Resposta Email";
            // 
            // lbResNome
            // 
            this.lbResNome.AutoSize = true;
            this.lbResNome.Location = new System.Drawing.Point(284, 149);
            this.lbResNome.Name = "lbResNome";
            this.lbResNome.Size = new System.Drawing.Size(81, 13);
            this.lbResNome.TabIndex = 17;
            this.lbResNome.Text = "Resposta nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.lbResNome);
            this.Controls.Add(this.lbRespEmail);
            this.Controls.Add(this.lbRespTelefone);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.cbxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.rbEmail);
            this.Controls.Add(this.rbTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.RadioButton rbTelefone;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNome;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbRespTelefone;
        private System.Windows.Forms.Label lbRespEmail;
        private System.Windows.Forms.Label lbResNome;
    }
}

