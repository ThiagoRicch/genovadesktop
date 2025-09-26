namespace DesktopGenova
{
    partial class CadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarUsuario));
            this.lblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtSobrenome = new System.Windows.Forms.TextBox();
            this.TxtEmailCadastro = new System.Windows.Forms.TextBox();
            this.TxtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblEmailCadastro = new System.Windows.Forms.Label();
            this.lblSenhaCadastro = new System.Windows.Forms.Label();
            this.btnEntrarLogin = new System.Windows.Forms.Button();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblPerguntaLogin = new System.Windows.Forms.Label();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(71, 329);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(72, 344);
            this.TxtNome.Multiline = true;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(308, 29);
            this.TxtNome.TabIndex = 5;
            // 
            // TxtSobrenome
            // 
            this.TxtSobrenome.Location = new System.Drawing.Point(72, 393);
            this.TxtSobrenome.Multiline = true;
            this.TxtSobrenome.Name = "TxtSobrenome";
            this.TxtSobrenome.Size = new System.Drawing.Size(306, 29);
            this.TxtSobrenome.TabIndex = 6;
            // 
            // TxtEmailCadastro
            // 
            this.TxtEmailCadastro.Location = new System.Drawing.Point(74, 450);
            this.TxtEmailCadastro.Multiline = true;
            this.TxtEmailCadastro.Name = "TxtEmailCadastro";
            this.TxtEmailCadastro.Size = new System.Drawing.Size(306, 29);
            this.TxtEmailCadastro.TabIndex = 7;
            // 
            // TxtSenhaCadastro
            // 
            this.TxtSenhaCadastro.Location = new System.Drawing.Point(72, 502);
            this.TxtSenhaCadastro.Multiline = true;
            this.TxtSenhaCadastro.Name = "TxtSenhaCadastro";
            this.TxtSenhaCadastro.PasswordChar = '*';
            this.TxtSenhaCadastro.Size = new System.Drawing.Size(308, 29);
            this.TxtSenhaCadastro.TabIndex = 8;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(69, 377);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(70, 13);
            this.lblSobrenome.TabIndex = 9;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblEmailCadastro
            // 
            this.lblEmailCadastro.AutoSize = true;
            this.lblEmailCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCadastro.Location = new System.Drawing.Point(71, 434);
            this.lblEmailCadastro.Name = "lblEmailCadastro";
            this.lblEmailCadastro.Size = new System.Drawing.Size(37, 13);
            this.lblEmailCadastro.TabIndex = 10;
            this.lblEmailCadastro.Text = "Email";
            // 
            // lblSenhaCadastro
            // 
            this.lblSenhaCadastro.AutoSize = true;
            this.lblSenhaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaCadastro.Location = new System.Drawing.Point(71, 487);
            this.lblSenhaCadastro.Name = "lblSenhaCadastro";
            this.lblSenhaCadastro.Size = new System.Drawing.Size(43, 13);
            this.lblSenhaCadastro.TabIndex = 11;
            this.lblSenhaCadastro.Text = "Senha";
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.BackColor = System.Drawing.Color.Blue;
            this.btnEntrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarLogin.ForeColor = System.Drawing.Color.White;
            this.btnEntrarLogin.Location = new System.Drawing.Point(179, 557);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(101, 38);
            this.btnEntrarLogin.TabIndex = 12;
            this.btnEntrarLogin.Text = "Cadastrar";
            this.btnEntrarLogin.UseVisualStyleBackColor = false;
            this.btnEntrarLogin.Click += new System.EventHandler(this.btnEntrarLogin_Click);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(70, 255);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(92, 24);
            this.lblCadastro.TabIndex = 14;
            this.lblCadastro.Text = "Cadastro";
            // 
            // lblPerguntaLogin
            // 
            this.lblPerguntaLogin.AutoSize = true;
            this.lblPerguntaLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblPerguntaLogin.Location = new System.Drawing.Point(167, 614);
            this.lblPerguntaLogin.Name = "lblPerguntaLogin";
            this.lblPerguntaLogin.Size = new System.Drawing.Size(74, 13);
            this.lblPerguntaLogin.TabIndex = 15;
            this.lblPerguntaLogin.Text = "Já tem conta?";
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.BackColor = System.Drawing.Color.Transparent;
            this.linkLogin.Location = new System.Drawing.Point(247, 614);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(33, 13);
            this.linkLogin.TabIndex = 16;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Login";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // CadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.lblPerguntaLogin);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.btnEntrarLogin);
            this.Controls.Add(this.lblSenhaCadastro);
            this.Controls.Add(this.lblEmailCadastro);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.TxtSenhaCadastro);
            this.Controls.Add(this.TxtEmailCadastro);
            this.Controls.Add(this.TxtSobrenome);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.lblNome);
            this.DoubleBuffered = true;
            this.Name = "CadastrarUsuario";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtSobrenome;
        private System.Windows.Forms.TextBox TxtEmailCadastro;
        private System.Windows.Forms.TextBox TxtSenhaCadastro;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblEmailCadastro;
        private System.Windows.Forms.Label lblSenhaCadastro;
        private System.Windows.Forms.Button btnEntrarLogin;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblPerguntaLogin;
        private System.Windows.Forms.LinkLabel linkLogin;
    }
}