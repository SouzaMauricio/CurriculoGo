using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurriculoGo.DadosCr
{
    public partial class DadosPessoais : UserControl
    {
        public CriarEditarCurriculo cec;
        public DadosPessoais()
        {
            InitializeComponent();
            //Retorna os dados Salvos
            txt_Nome.Text = Properties.Settings.Default.NomeCompleto;
            if (Properties.Settings.Default.Filhos)
            {
                chk_Filhos.Checked = true;
            }
            else
            {
                chk_Filhos.Checked = false;
            }
            cbo_EstadoCivil.SelectedItem = Properties.Settings.Default.EstadoCivil;
            mkt_Data_Nasc.Text = Properties.Settings.Default.Idade;
            txt_Endereco.Text = Properties.Settings.Default.Endereco;
            txt_Cidade.Text = Properties.Settings.Default.Cidade;
            cbo_UF.SelectedItem = Properties.Settings.Default.Uf;
            mkt_Telefone_Fixo.Text = Properties.Settings.Default.Telefone;
            mkt_Celular.Text = Properties.Settings.Default.Celular;
            txt_Naturalidade.Text = Properties.Settings.Default.Naturalidade;
            txt_Nacionalidade.Text = Properties.Settings.Default.Nacionalidade;
            txt_Email.Text = Properties.Settings.Default.Email;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {

            //Chama a proxima tela
            Properties.Settings.Default.NomeCompleto = txt_Nome.Text;
            if (chk_Filhos.Checked)
            {
                Properties.Settings.Default.Filhos = true;
            }
            else
            {
                Properties.Settings.Default.Filhos = false;
            }
            Properties.Settings.Default.EstadoCivil = cbo_EstadoCivil.Text.ToString();
            Properties.Settings.Default.Idade = mkt_Data_Nasc.Text;
            Properties.Settings.Default.Endereco = txt_Endereco.Text;
            Properties.Settings.Default.Cidade = txt_Cidade.Text;
            Properties.Settings.Default.Uf = cbo_UF.Text.ToString();
            Properties.Settings.Default.Telefone = mkt_Telefone_Fixo.Text;
            Properties.Settings.Default.Celular = mkt_Celular.Text;
            Properties.Settings.Default.Naturalidade = txt_Naturalidade.Text;
            Properties.Settings.Default.Nacionalidade = txt_Nacionalidade.Text;
            Properties.Settings.Default.Email = txt_Email.Text;
            Properties.Settings.Default.Save();
            if (txt_Nome.Text != "" && cbo_EstadoCivil.Text != "" && mkt_Data_Nasc.Text != "" && txt_Endereco.Text != "" && txt_Cidade.Text != "" && cbo_UF.Text != "" && mkt_Telefone_Fixo.Text != "" && mkt_Celular.Text != "" && txt_Nacionalidade.Text != "" && txt_Nacionalidade.Text != "" && txt_Email.Text != "")
            {
                cec.dadosAcademicosProfissionais1.BringToFront();
            }
            else
            {
                MessageBox.Show("Preencha todos os dados", "CurrículoGo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt_Nome.Clear();
            chk_Filhos.Checked = false;
            cbo_EstadoCivil.SelectedIndex = -1;
            mkt_Data_Nasc.Clear();
            txt_Endereco.Clear();
            txt_Cidade.Clear();
            cbo_UF.SelectedIndex = -1;
            mkt_Telefone_Fixo.Clear();
            mkt_Celular.Clear();
            txt_Nacionalidade.Clear();
            txt_Naturalidade.Clear();
            txt_Email.Clear();
        }
    }
}
