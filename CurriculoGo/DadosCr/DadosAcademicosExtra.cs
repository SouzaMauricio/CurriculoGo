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
    public partial class DadosAcademicosExtra : UserControl
    {
        public CriarEditarCurriculo cec;
        public DadosAcademicosExtra()
        {
            InitializeComponent();
            //Retornar os dados já salvos
            cbo_Escolaridade.SelectedItem = Properties.Settings.Default.Escolaridade;
            txt_InstituicaoEscolaridade.Text = Properties.Settings.Default.Escola;
            cbo_StatusEscolaridade.SelectedItem = Properties.Settings.Default.StatusEsc;
            txt_Curso1.Text = Properties.Settings.Default.Curso1;
            txt_InstituicaoCurso1.Text = Properties.Settings.Default.Instituicao1;
            cbo_StatusCurso1.SelectedItem = Properties.Settings.Default.Conclusao1;
            txt_Curso2.Text = Properties.Settings.Default.Curso2;
            txt_InstituicaoCurso2.Text = Properties.Settings.Default.Instituicao2;
            cbo_StatusCurso2.SelectedItem = Properties.Settings.Default.Conclusao2;
            txt_Idioma1.Text = Properties.Settings.Default.Idioma1;
            txt_InstituicaoIdioma1.Text = Properties.Settings.Default.InsIdioma1;
            cbo_NivelIdioma1.SelectedItem = Properties.Settings.Default.Nivel;
            txt_Idioma2.Text = Properties.Settings.Default.Idioma2;
            txt_InstituicaoIdioma2.Text = Properties.Settings.Default.InstIdioma2;
            cbo_NivelIdioma2.SelectedItem = Properties.Settings.Default.Nivel2;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            cec.dadosPessoais1.BringToFront();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            //Pega as informações digitadas para validar e salvar
            Properties.Settings.Default.Escolaridade = cbo_Escolaridade.Text.ToString();
            Properties.Settings.Default.Escola = txt_InstituicaoEscolaridade.Text;
            Properties.Settings.Default.StatusEsc = cbo_StatusEscolaridade.Text.ToString();
            Properties.Settings.Default.Curso1 = txt_Curso1.Text;
            Properties.Settings.Default.Instituicao1 = txt_InstituicaoCurso1.Text;
            Properties.Settings.Default.Conclusao1 = cbo_StatusCurso1.Text.ToString();
            Properties.Settings.Default.Curso2 = txt_Curso2.Text;
            Properties.Settings.Default.Instituicao2 = txt_InstituicaoCurso2.Text;
            Properties.Settings.Default.Conclusao2 = cbo_StatusCurso2.Text.ToString();
            Properties.Settings.Default.Idioma1 = txt_Idioma1.Text;
            Properties.Settings.Default.InsIdioma1 = txt_InstituicaoIdioma1.Text;
            Properties.Settings.Default.Nivel = cbo_NivelIdioma1.Text.ToString();
            Properties.Settings.Default.Idioma2 = txt_Idioma2.Text;
            Properties.Settings.Default.InstIdioma2 = txt_InstituicaoIdioma2.Text;
            Properties.Settings.Default.Nivel2 = cbo_NivelIdioma2.Text.ToString();
            Properties.Settings.Default.Save();

            if (cbo_Escolaridade.Text != "" && txt_InstituicaoEscolaridade.Text != "" && cbo_Escolaridade.Text != "")
            {
                cec.dadosProfissionais1.BringToFront();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente", "CurrículoGo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbo_Escolaridade.SelectedIndex = -1;
            txt_InstituicaoEscolaridade.Clear();
            cbo_StatusEscolaridade.SelectedIndex = -1;
            txt_Curso1.Clear();
            txt_InstituicaoCurso1.Clear();
            cbo_StatusCurso1.SelectedIndex = -1;
            txt_Curso2.Clear();
            txt_InstituicaoCurso2.Clear();
            cbo_StatusCurso2.SelectedIndex = -1;
            txt_Idioma1.Clear();
            txt_InstituicaoIdioma1.Clear();
            cbo_NivelIdioma1.SelectedIndex = -1;
            txt_Idioma2.Clear();
            txt_InstituicaoIdioma2.Clear();
            cbo_NivelIdioma2.SelectedIndex = -1;
        }
    }
}
