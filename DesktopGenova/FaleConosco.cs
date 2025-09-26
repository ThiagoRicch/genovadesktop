using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopGenova
{
    public partial class FaleConosco : Form
    {
        public FaleConosco()
        {
            InitializeComponent();
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void lblAbrirChamado_Click(object sender, EventArgs e)
        {
            AbrirChamado abrirChamado = new AbrirChamado();
            this.Hide();
            abrirChamado.Show();
        }

        private void lblFaleConosco_Click(object sender, EventArgs e)
        {
            FaleConosco faleConosco = new FaleConosco();
            this.Hide();
            faleConosco.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Hide();
            profile.Show();
        }

        private void LinkWhats_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string numero = "5511914500045"; 
            string mensagem = Uri.EscapeDataString("Olá! Preciso de Ajuda!.");
            string url = $"https://wa.me/{numero}?text={mensagem}";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }

        private void LinkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = "iagenova2025@gmail.com";
            string assunto = "Suporte";
            string corpo = "Olá, Preciso de Ajuda!";

            // Escapa caracteres especiais para o mailto
            string mailto = $"mailto:{email}?subject={Uri.EscapeDataString(assunto)}&body={Uri.EscapeDataString(corpo)}";

            Process.Start(new ProcessStartInfo { FileName = mailto, UseShellExecute = true });
        }
    }
}
