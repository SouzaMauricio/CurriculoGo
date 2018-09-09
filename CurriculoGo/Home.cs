using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurriculoGo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            //Atribui o Nome de Usuario
            lblBemVindo.Text = lblBemVindo.Text + Properties.Settings.Default.NomeUsuario;
            //Verifica se há dados cadastrados
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.NomeCompleto))
            {
                btnCriarEditar.Text = "Editar Currículo";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fechar programa
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Minimizar Janela
            WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo Sair?", "CurriculoGo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Hide();
                Login lg = new Login();
                lg.ShowDialog();
                this.Close();
            }
        }

        private void btnCriarEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CriarEditarCurriculo crr = new CriarEditarCurriculo();
            crr.ShowDialog();
            this.Close();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.NomeCompleto))
            {
                Curriculo crr = new Curriculo(true);
                crr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum currículo cadastrado, crie um agora para visualizar!", "CurrículoGo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
