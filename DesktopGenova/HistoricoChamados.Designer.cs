namespace DesktopGenova
{
    partial class HistoricoChamados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricoChamados));
            this.lblFaleConosco = new System.Windows.Forms.Label();
            this.lblAbrirChamado = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.AmostraDosChamados = new System.Windows.Forms.DataGridView();
            this.btnVoltarProProfile = new System.Windows.Forms.Button();
            this.btnSalvarDadosHistorico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AmostraDosChamados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFaleConosco
            // 
            this.lblFaleConosco.AutoSize = true;
            this.lblFaleConosco.BackColor = System.Drawing.Color.Transparent;
            this.lblFaleConosco.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaleConosco.Location = new System.Drawing.Point(1004, 43);
            this.lblFaleConosco.Name = "lblFaleConosco";
            this.lblFaleConosco.Size = new System.Drawing.Size(112, 21);
            this.lblFaleConosco.TabIndex = 5;
            this.lblFaleConosco.Text = "Fale Conosco";
            this.lblFaleConosco.Click += new System.EventHandler(this.lblFaleConosco_Click);
            // 
            // lblAbrirChamado
            // 
            this.lblAbrirChamado.AutoSize = true;
            this.lblAbrirChamado.BackColor = System.Drawing.Color.Transparent;
            this.lblAbrirChamado.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrirChamado.Location = new System.Drawing.Point(707, 43);
            this.lblAbrirChamado.Name = "lblAbrirChamado";
            this.lblAbrirChamado.Size = new System.Drawing.Size(128, 21);
            this.lblAbrirChamado.TabIndex = 4;
            this.lblAbrirChamado.Text = "Abrir Chamado";
            this.lblAbrirChamado.Click += new System.EventHandler(this.lblAbrirChamado_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(450, 43);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(57, 21);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Início";
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            // 
            // AmostraDosChamados
            // 
            this.AmostraDosChamados.AllowUserToAddRows = false;
            this.AmostraDosChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AmostraDosChamados.Location = new System.Drawing.Point(329, 143);
            this.AmostraDosChamados.Name = "AmostraDosChamados";
            this.AmostraDosChamados.Size = new System.Drawing.Size(550, 405);
            this.AmostraDosChamados.TabIndex = 6;
            // 
            // btnVoltarProProfile
            // 
            this.btnVoltarProProfile.BackColor = System.Drawing.Color.Gray;
            this.btnVoltarProProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarProProfile.ForeColor = System.Drawing.Color.White;
            this.btnVoltarProProfile.Location = new System.Drawing.Point(454, 613);
            this.btnVoltarProProfile.Name = "btnVoltarProProfile";
            this.btnVoltarProProfile.Size = new System.Drawing.Size(101, 38);
            this.btnVoltarProProfile.TabIndex = 12;
            this.btnVoltarProProfile.Text = "Voltar";
            this.btnVoltarProProfile.UseVisualStyleBackColor = false;
            this.btnVoltarProProfile.Click += new System.EventHandler(this.btnVoltarProProfile_Click);
            // 
            // btnSalvarDadosHistorico
            // 
            this.btnSalvarDadosHistorico.BackColor = System.Drawing.Color.Turquoise;
            this.btnSalvarDadosHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarDadosHistorico.ForeColor = System.Drawing.Color.White;
            this.btnSalvarDadosHistorico.Location = new System.Drawing.Point(632, 613);
            this.btnSalvarDadosHistorico.Name = "btnSalvarDadosHistorico";
            this.btnSalvarDadosHistorico.Size = new System.Drawing.Size(101, 38);
            this.btnSalvarDadosHistorico.TabIndex = 13;
            this.btnSalvarDadosHistorico.Text = "Salvar";
            this.btnSalvarDadosHistorico.UseVisualStyleBackColor = false;
            this.btnSalvarDadosHistorico.Click += new System.EventHandler(this.btnSalvarDadosHistorico_Click);
            // 
            // HistoricoChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnSalvarDadosHistorico);
            this.Controls.Add(this.btnVoltarProProfile);
            this.Controls.Add(this.AmostraDosChamados);
            this.Controls.Add(this.lblFaleConosco);
            this.Controls.Add(this.lblAbrirChamado);
            this.Controls.Add(this.lblInicio);
            this.DoubleBuffered = true;
            this.Name = "HistoricoChamados";
            this.Text = "HistoricoChamados";
            this.Load += new System.EventHandler(this.HistoricoChamados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AmostraDosChamados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFaleConosco;
        private System.Windows.Forms.Label lblAbrirChamado;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DataGridView AmostraDosChamados;
        private System.Windows.Forms.Button btnVoltarProProfile;
        private System.Windows.Forms.Button btnSalvarDadosHistorico;
    }
}