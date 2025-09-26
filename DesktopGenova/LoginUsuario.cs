using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DesktopGenova
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            string email = TxtEmail.Text.Trim();
            string senha = TxtSenha.Text.Trim();

            // --- Validações ---
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Informe o e-mail.");
                TxtEmail.Focus();
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Informe um e-mail válido.");
                TxtEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Informe a senha.");
                TxtSenha.Focus();
                return;
            }

            var conexao = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conexao))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Usuario WHERE email=@Email AND senha=@Senha";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Senha", senha); // Futuramente usar hash

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();

                                // Salvar dados na sessão global
                                UserSession.Id = Convert.ToInt32(reader["id_usuario"]);
                                UserSession.Nome = reader["nome"].ToString();
                                UserSession.Sobrenome = reader["sobrenome"].ToString();
                                UserSession.Email = reader["email"].ToString();

                                MessageBox.Show("Login realizado com sucesso!");

                                this.Hide();
                                Home mainForm = new Home();
                                mainForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Email ou senha incorretos. Tente novamente.");
                                TxtSenha.Clear();
                                TxtSenha.Focus();
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao Banco de Dados: " + ex.Message);
                }
            }
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastrarUsuario cadastroForm = new CadastrarUsuario();
            this.Hide();
            cadastroForm.Show();
        }
    }
}
