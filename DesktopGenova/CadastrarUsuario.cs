using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DesktopGenova
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            string nome = TxtNome.Text.Trim();
            string sobrenome = TxtSobrenome.Text.Trim();
            string email = TxtEmailCadastro.Text.Trim();
            string senha = TxtSenhaCadastro.Text;

            // --- Validações ---
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Informe o nome.");
                TxtNome.Focus();
                return;
            }

            if (string.IsNullOrEmpty(sobrenome))
            {
                MessageBox.Show("Informe o sobrenome.");
                TxtSobrenome.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Informe o e-mail.");
                TxtEmailCadastro.Focus();
                return;
            }

            // Validação de e-mail
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Informe um e-mail válido.");
                TxtEmailCadastro.Focus();
                return;
            }

            if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Informe a senha.");
                TxtSenhaCadastro.Focus();
                return;
            }

            if (senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.");
                TxtSenhaCadastro.Focus();
                return;
            }

            // --- Inserção no banco ---
            var conexao = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    // Verifica se o e-mail já existe
                    string verificaEmail = "SELECT COUNT(*) FROM Usuario WHERE email = @Email";
                    using (SqlCommand cmdVerifica = new SqlCommand(verificaEmail, conn))
                    {
                        cmdVerifica.Parameters.AddWithValue("@Email", email);
                        int count = (int)cmdVerifica.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este e-mail já está cadastrado.");
                            TxtEmailCadastro.Focus();
                            return;
                        }
                    }

                    string query = "INSERT INTO Usuario (nome, sobrenome, email, senha) VALUES (@Nome, @Sobrenome, @Email, @Senha)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Sobrenome", sobrenome);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Senha", senha); // Ideal: usar hash em produção

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!");
                            this.Hide();
                            LoginUsuario loginForm = new LoginUsuario();
                            loginForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Falha no cadastro. Tente novamente.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginUsuario loginForm = new LoginUsuario();
            this.Hide();
            loginForm.Show();
        }
    }
}
