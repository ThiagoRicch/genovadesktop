using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DesktopGenova
{
    public partial class AbrirChamado : Form
    {
        public AbrirChamado()
        {
            InitializeComponent();
        }

        private void btnEnviarChamado_Click(object sender, EventArgs e)
        {
            string chamado = TxtChamado.Text.Trim();
            string categoria = ComboBoxCategoria.SelectedItem?.ToString();

            bool naoUrgente = CheckBoxNãoUrgente.Checked;
            bool poucoUrgente = CheckBoxPoucoUrgente.Checked;
            bool urgente = CheckBoxUrgente.Checked;

            // --- Validações ---
            if (string.IsNullOrEmpty(chamado))
            {
                MessageBox.Show("Informe a descrição do chamado.");
                TxtChamado.Focus();
                return;
            }

            if (string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Selecione uma categoria para o chamado.");
                ComboBoxCategoria.Focus();
                return;
            }

            if (!naoUrgente && !poucoUrgente && !urgente)
            {
                MessageBox.Show("Selecione pelo menos uma prioridade.");
                return;
            }

            // Monta a string de prioridade
            string prioridade = "";
            if (naoUrgente) prioridade += "Não Urgente; ";
            if (poucoUrgente) prioridade += "Pouco Urgente; ";
            if (urgente) prioridade += "Urgente; ";
            prioridade = prioridade.TrimEnd(' ', ';'); // Remove o último ;

            string conexao = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Chamado (id_usuario, chamado, categoria, prioridade) " +
                                   "VALUES (@id_usuario, @chamado, @categoria, @prioridade)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_usuario", UserSession.Id);
                        cmd.Parameters.AddWithValue("@chamado", chamado);
                        cmd.Parameters.AddWithValue("@categoria", categoria);
                        cmd.Parameters.AddWithValue("@prioridade", prioridade);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Chamado enviado com sucesso!");

                        // Limpa campos após envio
                        TxtChamado.Clear();
                        ComboBoxCategoria.SelectedIndex = -1;
                        CheckBoxNãoUrgente.Checked = false;
                        CheckBoxPoucoUrgente.Checked = false;
                        CheckBoxUrgente.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar chamado: " + ex.Message);
                }
            }
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
    }
}
