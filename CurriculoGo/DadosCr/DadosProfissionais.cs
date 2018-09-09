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
    public partial class DadosProfissionais : UserControl
    {
        public CriarEditarCurriculo cec;
        public DadosProfissionais()
        {
            InitializeComponent();
            //Retorna os dados salvos
            txt_Empresa1.Text = Properties.Settings.Default.Empresa1;
            txt_TempoEmpresa1.Text = Properties.Settings.Default.Atuacao1;
            txt_Empresa2.Text = Properties.Settings.Default.Empresa2;
            txt_TempoEmpresa2.Text = Properties.Settings.Default.Atuacao2;
            txt_DescricaoCarreira.Text = Properties.Settings.Default.DescricaoCarreira;
            txt_CargoPretendido.Text = Properties.Settings.Default.Objetivo;
            txt_AreaDeAtuacao.Text = Properties.Settings.Default.Area;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            cec.dadosAcademicosProfissionais1.BringToFront();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Empresa1 = txt_Empresa1.Text;
                Properties.Settings.Default.Atuacao1 = txt_TempoEmpresa1.Text;
                Properties.Settings.Default.Empresa2 = txt_Empresa2.Text;
                Properties.Settings.Default.Atuacao2 = txt_TempoEmpresa2.Text;
                Properties.Settings.Default.DescricaoCarreira = txt_DescricaoCarreira.Text;
                Properties.Settings.Default.Objetivo = txt_CargoPretendido.Text;
                Properties.Settings.Default.Area = txt_AreaDeAtuacao.Text;
                Properties.Settings.Default.Save();

                if (txt_AreaDeAtuacao.Text != "" && txt_CargoPretendido.Text != "")
                {
                    Curriculo crr = new Curriculo();
                    crr.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente", "CurrículoGo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "CurrículoGo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt_Empresa1.Clear();
            txt_TempoEmpresa1.Clear();
            txt_Empresa2.Clear();
            txt_TempoEmpresa2.Clear();
            txt_DescricaoCarreira.Clear();
            txt_AreaDeAtuacao.Clear();
            txt_CargoPretendido.Clear();
        }
    }
}
