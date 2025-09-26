using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopGenova
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {
            Home home = new Home();
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
