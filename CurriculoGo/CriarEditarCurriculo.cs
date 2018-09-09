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
    public partial class CriarEditarCurriculo : Form
    {
        public CriarEditarCurriculo()
        {
            InitializeComponent();
            //Atribuir esta tela nos controles
            dadosPessoais1.cec = this;
            dadosAcademicosProfissionais1.cec = this;
            dadosProfissionais1.cec = this;
            //Coloca os dados pessoais em primeiro
            dadosPessoais1.BringToFront();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fechar a Aplicação
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Minimizar a Janela
            WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo voltar a Home?", "CurriculoGo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Hide();
                Home hm = new Home();
                hm.ShowDialog();
                this.Close();
            }
        }
    }
}
