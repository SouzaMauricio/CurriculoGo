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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //Retoma o Ultimo Nome de Usuario que Entrou
            txtUsuario.Text = Properties.Settings.Default.NomeUsuario;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Minimiza a janela 
            WindowState = FormWindowState.Minimized;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    //Salva no sistema o nome do usuario para recuperar nas proximas telas se sessoes
                    Properties.Settings.Default.NomeUsuario = txtUsuario.Text;
                    Properties.Settings.Default.Save();
                    //Abre a Home
                    this.Hide();
                    Home hm = new Home();
                    hm.ShowDialog();
                    this.Close();
                }
                else
                {
                    //Cria a Exception para exibir na label de erro
                     throw new Exception("Preencha o Nome de Usuário");
                }
            }
            catch(Exception ex)
            {
                lblErro.Text = ex.Message;
            }
        }
    }
}
