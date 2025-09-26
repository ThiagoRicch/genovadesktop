using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesktopGenova
{
    public partial class HistoricoChamados : Form
    {
        public HistoricoChamados()
        {
            InitializeComponent();
            // Associa o evento de exclusão
            AmostraDosChamados.UserDeletingRow += AmostraDosChamados_UserDeletingRow;
        }

        private void HistoricoChamados_Load(object sender, EventArgs e)
        {
            CarregarChamados();
        }

        // Método para carregar os chamados do usuário logado
        private void CarregarChamados()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString))
            {
                string query = "SELECT id_chamado, chamado, categoria, prioridade FROM Chamado WHERE id_usuario = @id_usuario";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_usuario", UserSession.Id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                AmostraDosChamados.DataSource = dt;
                
            }
        }

        // Evento para confirmar exclusão
        private void AmostraDosChamados_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Você tem certeza que deseja excluir este chamado?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                int idChamado = Convert.ToInt32(e.Row.Cells["id_chamado"].Value);

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString))
                {
                    conn.Open();
                    string queryDelete = "DELETE FROM Chamado WHERE id_chamado = @id_chamado";
                    using (SqlCommand cmd = new SqlCommand(queryDelete, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_chamado", idChamado);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Chamado excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir chamado: " + ex.Message);
                e.Cancel = true;
            }
        }

        private void btnVoltarProProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Hide();
            profile.Show();
        }

        private void btnSalvarDadosHistorico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados alterados com sucesso!");
            CarregarChamados(); // Recarrega os dados caso algo tenha sido editado
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
    }
}
