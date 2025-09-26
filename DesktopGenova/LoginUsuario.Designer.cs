namespace DesktopGenova
{
    partial class LoginUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUsuario));
            this.lblLogin = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrarLogin = new System.Windows.Forms.Button();
            this.lblPerguntaCadastro = new System.Windows.Forms.Label();
            this.linkCadastrar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(49, 293);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(62, 24);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(53, 368);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(408, 38);
            this.TxtEmail.TabIndex = 1;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(53, 458);
            this.TxtSenha.Multiline = true;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(408, 38);
            this.TxtSenha.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(50, 352);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(50, 442);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(43, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.BackColor = System.Drawing.Color.Green;
            this.btnEntrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarLogin.ForeColor = System.Drawing.Color.White;
            this.btnEntrarLogin.Location = new System.Drawing.Point(197, 547);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(101, 38);
            this.btnEntrarLogin.TabIndex = 5;
            this.btnEntrarLogin.Text = "Entrar";
            this.btnEntrarLogin.UseVisualStyleBackColor = false;
            this.btnEntrarLogin.Click += new System.EventHandler(this.btnEntrarLogin_Click);
            // 
            // lblPerguntaCadastro
            // 
            this.lblPerguntaCadastro.AutoSize = true;
            this.lblPerguntaCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblPerguntaCadastro.Location = new System.Drawing.Point(176, 605);
            this.lblPerguntaCadastro.Name = "lblPerguntaCadastro";
            this.lblPerguntaCadastro.Size = new System.Drawing.Size(83, 13);
            this.lblPerguntaCadastro.TabIndex = 6;
            this.lblPerguntaCadastro.Text = "Não tem conta?\r\n";
            // 
            // linkCadastrar
            // 
            this.linkCadastrar.AutoSize = true;
            this.linkCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.linkCadastrar.Location = new System.Drawing.Point(265, 605);
            this.linkCadastrar.Name = "linkCadastrar";
            this.linkCadastrar.Size = new System.Drawing.Size(52, 13);
            this.linkCadastrar.TabIndex = 7;
            this.linkCadastrar.TabStop = true;
            this.linkCadastrar.Text = "Cadastrar";
            this.linkCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastrar_LinkClicked);
            // 
            // LoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.linkCadastrar);
            this.Controls.Add(this.lblPerguntaCadastro);
            this.Controls.Add(this.btnEntrarLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.lblLogin);
            this.DoubleBuffered = true;
            this.Name = "LoginUsuario";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnEntrarLogin;
        private System.Windows.Forms.Label lblPerguntaCadastro;
        private System.Windows.Forms.LinkLabel linkCadastrar;
    }
}

