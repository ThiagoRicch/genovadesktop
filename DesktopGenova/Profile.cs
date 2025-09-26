using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DesktopGenova
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            ShowUser();
        }

        private void ShowUser()
        {
            if (!UserSession.IsLoggedIn)
            {
                MessageBox.Show("Você não está logado!");
                this.Hide();
                LoginUsuario login = new LoginUsuario();
                login.Show();
                return;
            }

            lblSaudação.Text = $"Olá, {UserSession.Nome} {UserSession.Sobrenome}!";
            lblEmailUser.Text = $"Você está logado como: {UserSession.Email}";

            TxtNomeUser.Text = UserSession.Nome;
            TxtSobrenomeUser.Text = UserSession.Sobrenome;
            TxtEmailUser.Text = UserSession.Email;
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            string nome = TxtNomeUser.Text.Trim();
            string sobrenome = TxtSobrenomeUser.Text.Trim();
            string email = TxtEmailUser.Text.Trim();

            // --- Validações ---
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Informe o nome.");
                TxtNomeUser.Focus();
                return;
            }

            if (string.IsNullOrEmpty(sobrenome))
            {
                MessageBox.Show("Informe o sobrenome.");
                TxtSobrenomeUser.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Informe o e-mail.");
                TxtEmailUser.Focus();
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Informe um e-mail válido.");
                TxtEmailUser.Focus();
                return;
            }

            // Atualiza sessão
            UserSession.Nome = nome;
            UserSession.Sobrenome = sobrenome;
            UserSession.Email = email;

            // Salva no banco
            AtualizarUsuarioNoBanco();

            MessageBox.Show("Perfil atualizado com sucesso!");
            ShowUser(); // Atualiza labels e textbox
        }

        private void AtualizarUsuarioNoBanco()
        {
            string conexao = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conexao))
            {
                con.Open();
                string query = "UPDATE Usuario SET nome=@nome, sobrenome=@sobrenome, email=@email WHERE id_usuario=@id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", UserSession.Nome);
                    cmd.Parameters.AddWithValue("@sobrenome", UserSession.Sobrenome);
                    cmd.Parameters.AddWithValue("@email", UserSession.Email);
                    cmd.Parameters.AddWithValue("@id", UserSession.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnSairdaConta_Click(object sender, EventArgs e)
        {
            UserSession.Logout();
            MessageBox.Show("Você saiu da sua conta.");
            this.Hide();
            LoginUsuario login = new LoginUsuario();
            login.Show();
        }

        private void btnHistoricoChamados_Click(object sender, EventArgs e)
        {
            HistoricoChamados historico = new HistoricoChamados();
            this.Hide();
            historico.Show();
        }

        private void lblAbrirChamado_Click(object sender, EventArgs e)
        {
            AbrirChamado abrirChamado = new AbrirChamado();
            this.Hide();
            abrirChamado.Show();
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void lblFaleConosco_Click(object sender, EventArgs e)
        {
            FaleConosco faleConosco = new FaleConosco();
            this.Hide();
            faleConosco.Show();
        }
    }
}
