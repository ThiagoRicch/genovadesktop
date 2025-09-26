namespace DesktopGenova
{
    partial class AbrirChamado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbrirChamado));
            this.TxtChamado = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblAbrirChamado = new System.Windows.Forms.Label();
            this.lblFaleConosco = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.ComboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.CheckBoxNãoUrgente = new System.Windows.Forms.CheckBox();
            this.CheckBoxPoucoUrgente = new System.Windows.Forms.CheckBox();
            this.CheckBoxUrgente = new System.Windows.Forms.CheckBox();
            this.btnEnviarChamado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtChamado
            // 
            this.TxtChamado.BackColor = System.Drawing.Color.White;
            this.TxtChamado.Location = new System.Drawing.Point(499, 256);
            this.TxtChamado.Multiline = true;
            this.TxtChamado.Name = "TxtChamado";
            this.TxtChamado.Size = new System.Drawing.Size(410, 47);
            this.TxtChamado.TabIndex = 0;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(458, 34);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(57, 21);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Início";
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            // 
            // lblAbrirChamado
            // 
            this.lblAbrirChamado.AutoSize = true;
            this.lblAbrirChamado.BackColor = System.Drawing.Color.Transparent;
            this.lblAbrirChamado.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrirChamado.ForeColor = System.Drawing.Color.White;
            this.lblAbrirChamado.Location = new System.Drawing.Point(697, 34);
            this.lblAbrirChamado.Name = "lblAbrirChamado";
            this.lblAbrirChamado.Size = new System.Drawing.Size(128, 21);
            this.lblAbrirChamado.TabIndex = 2;
            this.lblAbrirChamado.Text = "Abrir Chamado";
            this.lblAbrirChamado.Click += new System.EventHandler(this.lblAbrirChamado_Click);
            // 
            // lblFaleConosco
            // 
            this.lblFaleConosco.AutoSize = true;
            this.lblFaleConosco.BackColor = System.Drawing.Color.Transparent;
            this.lblFaleConosco.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaleConosco.ForeColor = System.Drawing.Color.White;
            this.lblFaleConosco.Location = new System.Drawing.Point(959, 34);
            this.lblFaleConosco.Name = "lblFaleConosco";
            this.lblFaleConosco.Size = new System.Drawing.Size(112, 21);
            this.lblFaleConosco.TabIndex = 3;
            this.lblFaleConosco.Text = "Fale Conosco";
            this.lblFaleConosco.Click += new System.EventHandler(this.lblFaleConosco_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.Location = new System.Drawing.Point(1144, 23);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(100, 50);
            this.btnProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProfile.TabIndex = 4;
            this.btnProfile.TabStop = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(496, 240);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Chamado";
            // 
            // ComboBoxCategoria
            // 
            this.ComboBoxCategoria.FormattingEnabled = true;
            this.ComboBoxCategoria.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Rede/Internet",
            "Acesso/Usuário",
            "Segurança da Informação",
            "Infraestrutura",
            "Outros"});
            this.ComboBoxCategoria.Location = new System.Drawing.Point(499, 331);
            this.ComboBoxCategoria.Name = "ComboBoxCategoria";
            this.ComboBoxCategoria.Size = new System.Drawing.Size(410, 21);
            this.ComboBoxCategoria.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(496, 315);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(61, 13);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria";
            // 
            // CheckBoxNãoUrgente
            // 
            this.CheckBoxNãoUrgente.AutoSize = true;
            this.CheckBoxNãoUrgente.BackColor = System.Drawing.Color.Blue;
            this.CheckBoxNãoUrgente.ForeColor = System.Drawing.Color.White;
            this.CheckBoxNãoUrgente.Location = new System.Drawing.Point(452, 408);
            this.CheckBoxNãoUrgente.Name = "CheckBoxNãoUrgente";
            this.CheckBoxNãoUrgente.Size = new System.Drawing.Size(87, 17);
            this.CheckBoxNãoUrgente.TabIndex = 8;
            this.CheckBoxNãoUrgente.Text = "Não Urgente";
            this.CheckBoxNãoUrgente.UseVisualStyleBackColor = false;
            // 
            // CheckBoxPoucoUrgente
            // 
            this.CheckBoxPoucoUrgente.AutoSize = true;
            this.CheckBoxPoucoUrgente.BackColor = System.Drawing.Color.Orange;
            this.CheckBoxPoucoUrgente.Location = new System.Drawing.Point(653, 408);
            this.CheckBoxPoucoUrgente.Name = "CheckBoxPoucoUrgente";
            this.CheckBoxPoucoUrgente.Size = new System.Drawing.Size(98, 17);
            this.CheckBoxPoucoUrgente.TabIndex = 9;
            this.CheckBoxPoucoUrgente.Text = "Pouco Urgente";
            this.CheckBoxPoucoUrgente.UseVisualStyleBackColor = false;
            // 
            // CheckBoxUrgente
            // 
            this.CheckBoxUrgente.AutoSize = true;
            this.CheckBoxUrgente.BackColor = System.Drawing.Color.Red;
            this.CheckBoxUrgente.ForeColor = System.Drawing.Color.White;
            this.CheckBoxUrgente.Location = new System.Drawing.Point(886, 408);
            this.CheckBoxUrgente.Name = "CheckBoxUrgente";
            this.CheckBoxUrgente.Size = new System.Drawing.Size(64, 17);
            this.CheckBoxUrgente.TabIndex = 10;
            this.CheckBoxUrgente.Text = "Urgente";
            this.CheckBoxUrgente.UseVisualStyleBackColor = false;
            // 
            // btnEnviarChamado
            // 
            this.btnEnviarChamado.BackColor = System.Drawing.Color.Green;
            this.btnEnviarChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarChamado.ForeColor = System.Drawing.Color.White;
            this.btnEnviarChamado.Location = new System.Drawing.Point(650, 523);
            this.btnEnviarChamado.Name = "btnEnviarChamado";
            this.btnEnviarChamado.Size = new System.Drawing.Size(101, 38);
            this.btnEnviarChamado.TabIndex = 11;
            this.btnEnviarChamado.Text = "Enviar";
            this.btnEnviarChamado.UseVisualStyleBackColor = false;
            this.btnEnviarChamado.Click += new System.EventHandler(this.btnEnviarChamado_Click);
            // 
            // AbrirChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnEnviarChamado);
            this.Controls.Add(this.CheckBoxUrgente);
            this.Controls.Add(this.CheckBoxPoucoUrgente);
            this.Controls.Add(this.CheckBoxNãoUrgente);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.ComboBoxCategoria);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblFaleConosco);
            this.Controls.Add(this.lblAbrirChamado);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.TxtChamado);
            this.DoubleBuffered = true;
            this.Name = "AbrirChamado";
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtChamado;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblAbrirChamado;
        private System.Windows.Forms.Label lblFaleConosco;
        private System.Windows.Forms.PictureBox btnProfile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox ComboBoxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.CheckBox CheckBoxNãoUrgente;
        private System.Windows.Forms.CheckBox CheckBoxPoucoUrgente;
        private System.Windows.Forms.CheckBox CheckBoxUrgente;
        private System.Windows.Forms.Button btnEnviarChamado;
    }
}