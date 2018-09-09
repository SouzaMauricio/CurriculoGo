using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurriculoGo
{
    public partial class Curriculo : Form
    {
        int opc = 0;
        string aux1, aux2, aux3, aux4, aux5, aux6, aux7;
        System.Drawing.Rectangle resolucao = Screen.PrimaryScreen.Bounds;
        //Inicialização normal
        public Curriculo()
        {
            InitializeComponent();
            Criar();
        }
        //Inicialização pelo visualizar 
        public Curriculo(bool ok)
        {
            InitializeComponent();
            Criar();
            btn_Editar.Text = "Voltar";
        }

        //Cria o currículo com os dados salvos
        private void Criar()
        {
            pnl_Curriculo.Visible = false;
            pnl_Modelos.Visible = true;
            pnl_Exportar.Enabled = false;

            //Preenche o Curriculo
            string filhos;
            if (Properties.Settings.Default.Filhos)
            {
                filhos = "Possui Filhos";
            }
            else
            {
                filhos = "Sem filhos";
            }
            //Dados Pessoais
            lbl_Nome.Text = Properties.Settings.Default.NomeCompleto;
            lbl_nacionalidade.Text = Properties.Settings.Default.Nacionalidade + ", " + Properties.Settings.Default.EstadoCivil + ", " + filhos + " , " + Properties.Settings.Default.Idade + " anos";
            lbl_Endereco.Text = Properties.Settings.Default.Endereco;
            lbl_Cidade.Text = Properties.Settings.Default.Cidade + " - " + Properties.Settings.Default.Uf;
            lbl_Tel.Text = Properties.Settings.Default.Telefone + " - " + Properties.Settings.Default.Celular;
            lbl_Email.Text = Properties.Settings.Default.Email;


            //Objetivo
            lbl_Area.Text = lbl_Area.Text + Properties.Settings.Default.Area;
            lbl_Cargo.Text = lbl_Cargo.Text + Properties.Settings.Default.Objetivo;


            //Formação Academica
            lbl_escolaridade.Text = Properties.Settings.Default.Escolaridade + " - " + Properties.Settings.Default.Escola + " - " + Properties.Settings.Default.StatusEsc;


            //Atividade Extracurricular
            aux1 = Properties.Settings.Default.Curso1;
            aux2 = Properties.Settings.Default.Curso2;
            aux3 = Properties.Settings.Default.Idioma1;
            aux4 = Properties.Settings.Default.Idioma2;

            if (aux1 == "" && aux2 == "" && aux3 == "" && aux4 == "")
            {
                pcb_atv.Visible = false;
                lbl_Atividades.Visible = false;
            }
            if (aux1 != "")
            {
                lbl_Curso1.Text = Properties.Settings.Default.Curso1 + " - " + Properties.Settings.Default.Instituicao1 + " - " + Properties.Settings.Default.Conclusao1;
            }
            else
            {
                lbl_Curso1.Visible = false;
            }
            if (aux2 != "")
            {
                lbl_Curso2.Text = Properties.Settings.Default.Curso2 + " - " + Properties.Settings.Default.Instituicao2 + " - " + Properties.Settings.Default.Conclusao2;
            }
            else
            {
                lbl_Curso2.Visible = false;
            }
            if (aux3 != "")
            {
                lbl_Idioma1.Text = Properties.Settings.Default.Idioma1 + " - " + Properties.Settings.Default.InsIdioma1 + " - " + Properties.Settings.Default.Nivel;
            }
            else
            {
                lbl_Idioma1.Visible = false;
            }
            if (aux4 != "")
            {
                lbl_Idioma2.Text = Properties.Settings.Default.Idioma2 + " - " + Properties.Settings.Default.InstIdioma2 + " - " + Properties.Settings.Default.Nivel2;
            }
            else
            {
                lbl_Idioma2.Visible = false;
            }

            //Experiência Profissional
            aux5 = Properties.Settings.Default.Empresa1;
            aux6 = Properties.Settings.Default.Empresa2;
            aux7 = Properties.Settings.Default.DescricaoCarreira;
            if (aux1 == "" && aux2 == "")
            {
                lbl_Exp.Visible = false;
                pcb_Exp.Visible = false;
                lbl_Descricao.Visible = false;
            }
            if (aux1 != "")
            {

                lbl_Empresa1.Text = Properties.Settings.Default.Empresa1;
                //Verifica se o tempo de atuação esta preenchido corretamente
                if (Properties.Settings.Default.Atuacao1.ToLower() != "atual")
                {
                    try
                    {
                        Convert.ToDouble(Properties.Settings.Default.Atuacao1);
                    }
                    catch
                    {
                        throw new Exception("Tempo de atuação inválido");
                    }
                    lbl_Tempo_Empresa1.Text = lbl_Tempo_Empresa1.Text + Properties.Settings.Default.Atuacao1 + " meses";
                }
                else
                {
                    lbl_Tempo_Empresa1.Text = "Atual";
                }
            }
            else
            {
                lbl_Empresa1.Visible = false;
                lbl_Tempo_Empresa1.Visible = false;
            }

            if (aux2 != "")
            {
                lbl_Empresa2.Text = Properties.Settings.Default.Empresa2;
                //Verifica se o tempo de atuação esta preenchido corretamente
                if (Properties.Settings.Default.Atuacao2.ToLower() != "atual")
                {
                    try
                    {
                        Convert.ToDouble(Properties.Settings.Default.Atuacao2);
                    }
                    catch
                    {
                        throw new Exception("Tempo de atuação inválido");
                    }
                    lbl_Tempo_Empresa2.Text = lbl_Tempo_Empresa2.Text + Properties.Settings.Default.Atuacao2 + " meses";
                }
                else
                {
                    lbl_Tempo_Empresa2.Text = "Atual";
                }
            }
            else
            {
                lbl_Empresa2.Visible = false;
                lbl_Tempo_Empresa2.Visible = false;
            }

            lbl_Descricao.Text = Properties.Settings.Default.DescricaoCarreira;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Modelo1_Click(object sender, EventArgs e)
        {
            opc = 1;
            pnl_Curriculo.Visible = true;
            pnl_Modelos.Visible = false;
            pnl_Exportar.Enabled = true;

            //Dados Pessoais
            lbl_Nome.TextAlign = ContentAlignment.MiddleLeft;
            lbl_nacionalidade.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Endereco.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Cidade.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Tel.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Email.TextAlign = ContentAlignment.MiddleLeft;
            //Objetivo
            lbl_Objetivo.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Area.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Cargo.TextAlign = ContentAlignment.MiddleLeft;
            //Formação Acadêmica
            lbl_formacao.TextAlign = ContentAlignment.MiddleLeft;
            lbl_escolaridade.TextAlign = ContentAlignment.MiddleLeft;
            //Atividades Extracurriculares
            lbl_Atividades.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Curso1.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Curso2.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Idioma1.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Idioma2.TextAlign = ContentAlignment.MiddleLeft;
            //Experiência Profissional
            lbl_Exp.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Empresa1.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Tempo_Empresa1.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Empresa2.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Tempo_Empresa2.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Descricao.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void btn_Modelo2_Click(object sender, EventArgs e)
        {
            opc = 2;
            pnl_Curriculo.Visible = true;
            pnl_Modelos.Visible = false;
            pnl_Exportar.Enabled = true;

            //Dados Pessoais
            lbl_Nome.TextAlign = ContentAlignment.MiddleCenter;
            lbl_nacionalidade.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Endereco.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Cidade.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Tel.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Email.TextAlign = ContentAlignment.MiddleCenter;
            //Objetivo
            lbl_Objetivo.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Area.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Cargo.TextAlign = ContentAlignment.MiddleCenter;
            //Formação Acadêmica
            lbl_formacao.TextAlign = ContentAlignment.MiddleCenter;
            lbl_escolaridade.TextAlign = ContentAlignment.MiddleCenter;
            //Atividades Extracurriculares
            lbl_Atividades.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Curso1.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Curso2.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Idioma1.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Idioma2.TextAlign = ContentAlignment.MiddleCenter;
            //Experiência Profissional
            lbl_Exp.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Empresa1.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Tempo_Empresa1.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Empresa2.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Tempo_Empresa2.TextAlign = ContentAlignment.MiddleCenter; ;
            lbl_Descricao.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btn_Modelo3_Click(object sender, EventArgs e)
        {
            opc = 3;
            pnl_Curriculo.Visible = true;
            pnl_Modelos.Visible = false;
            pnl_Exportar.Enabled = true;

            //Dados Pessoais
            lbl_Nome.TextAlign = ContentAlignment.MiddleCenter;
            lbl_nacionalidade.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Endereco.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Cidade.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Tel.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Email.TextAlign = ContentAlignment.MiddleCenter;
            //Objetivo
            lbl_Objetivo.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Area.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Cargo.TextAlign = ContentAlignment.MiddleLeft;
            //Formação Acadêmica
            lbl_formacao.TextAlign = ContentAlignment.MiddleLeft;
            lbl_escolaridade.TextAlign = ContentAlignment.MiddleLeft;
            //Atividades Extracurriculares
            lbl_Atividades.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Curso1.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Curso2.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Idioma1.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Idioma2.TextAlign = ContentAlignment.MiddleLeft;
            //Experiência Profissional
            lbl_Exp.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Empresa1.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Tempo_Empresa1.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Empresa2.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Tempo_Empresa2.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Descricao.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void btn_Modelos_Click(object sender, EventArgs e)
        {
            pnl_Curriculo.Visible = false;
            pnl_Modelos.Visible = true;
            pnl_Exportar.Enabled = false;
        }

        private void btn_PNG_Click(object sender, EventArgs e)
        {
            Bitmap printscreen = new Bitmap(399, 642);
            Graphics graphics = Graphics.FromImage(printscreen);

            graphics.CopyFromScreen(this.Bounds.X, this.Bounds.Y, -7, -12, this.Bounds.Size);

            SaveFileDialog saveImageDialog = new SaveFileDialog();
            
            saveImageDialog.Title = "Selecionar caminho do Ficheiro:";

            saveImageDialog.FileName = "Currículo";

            saveImageDialog.Filter = "JPG Image|*.jpg|PNG Image|*.png";

            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                printscreen.Save(saveImageDialog.FileName, ImageFormat.Png);
            }
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (opc == 1)
                {
                    using (var doc = new PdfSharp.Pdf.PdfDocument())
                    {

                        var page = doc.AddPage();
                        var grafico = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                        var text_forma = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                        var fontT = new PdfSharp.Drawing.XFont("Arial", 16);
                        var font = new PdfSharp.Drawing.XFont("Arial", 13);

                        //Dados Pessoais
                        text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                        text_forma.DrawString(lbl_Nome.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 40, page.Width, page.Height));
                        text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                        text_forma.DrawString(lbl_nacionalidade.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 70, page.Width, page.Height));
                        text_forma.DrawString(lbl_Endereco.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 85, page.Width, page.Height));
                        text_forma.DrawString(lbl_Cidade.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 100, page.Width, page.Height));
                        text_forma.DrawString(lbl_Tel.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 115, page.Width, page.Height));
                        text_forma.DrawString(lbl_Email.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 130, page.Width, page.Height));

                        //Objetivo
                        text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                        text_forma.DrawString(lbl_Objetivo.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 180, page.Width, page.Height));
                        grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 200, 492, 4);
                        text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                        text_forma.DrawString(lbl_Area.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 220, page.Width, page.Height));
                        text_forma.DrawString(lbl_Cargo.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 235, page.Width, page.Height));

                        //Formação Acadêmica
                        text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                        text_forma.DrawString(lbl_formacao.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 285, page.Width, page.Height));
                        grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 305, 492, 4);
                        text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                        text_forma.DrawString(lbl_escolaridade.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 325, page.Width, page.Height));

                        if (aux1 != "" && aux2 != "" && aux3 != "" && aux4 != "")
                        {
                            //Atividades Extracurriculares
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                            text_forma.DrawString(lbl_Atividades.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 375, page.Width, page.Height));
                            grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 395, 492, 4);
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                            text_forma.DrawString(lbl_Curso1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 415, page.Width, page.Height));
                            text_forma.DrawString(lbl_Curso2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 430, page.Width, page.Height));
                            text_forma.DrawString(lbl_Idioma1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 445, page.Width, page.Height));
                            text_forma.DrawString(lbl_Idioma2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 460, page.Width, page.Height));

                        }
                        else if (aux1 != "" || aux2 != "" || aux3 != "" || aux4 != "")
                        {
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                            text_forma.DrawString(lbl_Atividades.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 375, page.Width, page.Height));
                            grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 395, 492, 4);
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                        }


                        if (aux1 != "")
                        {
                            text_forma.DrawString(lbl_Curso1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 415, page.Width, page.Height));
                        }

                        if (aux2 != "")
                        {
                            text_forma.DrawString(lbl_Curso2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 430, page.Width, page.Height));
                        }

                        if (aux3 != "")
                        {
                            text_forma.DrawString(lbl_Idioma1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 445, page.Width, page.Height));
                        }

                        if (aux4 != "")
                        {
                            text_forma.DrawString(lbl_Idioma2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 460, page.Width, page.Height));
                        }


                        if (aux5 != "" && aux6 != "")
                        {
                            //Experiência Profissional
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                            text_forma.DrawString(lbl_Exp.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 510, page.Width, page.Height));
                            grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 530, 492, 4);
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                            text_forma.DrawString(lbl_Empresa1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 550, page.Width, page.Height));
                            text_forma.DrawString(lbl_Tempo_Empresa1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 565, page.Width, page.Height));
                            text_forma.DrawString(lbl_Empresa2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 580, page.Width, page.Height));
                            text_forma.DrawString(lbl_Tempo_Empresa2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 595, page.Width, page.Height));
                            text_forma.DrawString(lbl_Descricao.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 680, 405, page.Height));
                        }
                        else if (aux5 != "" || aux6 != "")
                        {
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                            text_forma.DrawString(lbl_Exp.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 510, page.Width, page.Height));
                            grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 530, 492, 4);
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                        }
                        if (aux5 != "")
                        {
                            text_forma.DrawString(lbl_Empresa1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 550, page.Width, page.Height));
                            text_forma.DrawString(lbl_Tempo_Empresa1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 565, page.Width, page.Height));
                        }

                        if (aux6 != "")
                        {
                            text_forma.DrawString(lbl_Empresa2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 580, page.Width, page.Height));
                            text_forma.DrawString(lbl_Tempo_Empresa2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 595, page.Width, page.Height));
                        }

                        if (aux7 != "")
                        {
                            text_forma.DrawString(lbl_Descricao.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 680, 405, page.Height));
                        }
                        try
                        {
                            doc.Save("Currículo.pdf");
                            System.Diagnostics.Process.Start("Currículo.pdf");
                        }
                        catch
                        {
                            throw new Exception("Feche o pdf que já esta aberto!");
                        }
                    }
                }
                else if (opc == 2)
                {
                    using (var doc = new PdfSharp.Pdf.PdfDocument())
                    {

                        var page = doc.AddPage();
                        var grafico = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                        var text_forma = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                        var fontT = new PdfSharp.Drawing.XFont("Arial", 16);
                        var font = new PdfSharp.Drawing.XFont("Arial", 13);

                        //Dados Pessoais
                        text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                        text_forma.DrawString(lbl_Nome.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 40, page.Width, page.Height));
                        text_forma.DrawString(lbl_nacionalidade.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 70, page.Width, page.Height));
                        text_forma.DrawString(lbl_Endereco.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 85, page.Width, page.Height));
                        text_forma.DrawString(lbl_Cidade.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 100, page.Width, page.Height));
                        text_forma.DrawString(lbl_Tel.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 115, page.Width, page.Height));
                        text_forma.DrawString(lbl_Email.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 130, page.Width, page.Height));

                        //Objetivo
                        text_forma.DrawString(lbl_Objetivo.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 180, page.Width, page.Height));
                        grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 200, 492, 4);
                        text_forma.DrawString(lbl_Area.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 220, page.Width, page.Height));
                        text_forma.DrawString(lbl_Cargo.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 235, page.Width, page.Height));

                        //Formação Acadêmica
                        text_forma.DrawString(lbl_formacao.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 285, page.Width, page.Height));
                        grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 305, 492, 4);
                        text_forma.DrawString(lbl_escolaridade.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 325, page.Width, page.Height));


                        if (aux1 != "" && aux2 != "" && aux3 != "" && aux4 != "")
                        {
                            //Atividades Extracurriculares
                            text_forma.DrawString(lbl_Atividades.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 375, page.Width, page.Height));
                            grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 395, 492, 4);
                            text_forma.DrawString(lbl_Curso1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 415, page.Width, page.Height));
                            text_forma.DrawString(lbl_Curso2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 430, page.Width, page.Height));
                            text_forma.DrawString(lbl_Idioma1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 445, page.Width, page.Height));
                            text_forma.DrawString(lbl_Idioma2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 460, page.Width, page.Height));

                        }
                        else if (aux1 != "" || aux2 != "" || aux3 != "" || aux4 != "")
                        {
                            text_forma.DrawString(lbl_Atividades.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 375, page.Width, page.Height));
                            grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 395, 492, 4);
                        }


                        if (aux1 != "")
                        {
                            text_forma.DrawString(lbl_Curso1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 415, page.Width, page.Height));
                        }

                        if (aux2 != "")
                        {
                            text_forma.DrawString(lbl_Curso2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 430, page.Width, page.Height));
                        }

                        if (aux3 != "")
                        {
                            text_forma.DrawString(lbl_Idioma1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 445, page.Width, page.Height));
                        }

                        if (aux4 != "")
                        {
                            text_forma.DrawString(lbl_Idioma2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 460, page.Width, page.Height));
                        }


                        if (aux5 != "" && aux6 != "")
                        {
                            //Experiência Profissional
                            text_forma.DrawString(lbl_Exp.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 510, page.Width, page.Height));
                            grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 530, 492, 4);
                            text_forma.DrawString(lbl_Empresa1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 550, page.Width, page.Height));
                            text_forma.DrawString(lbl_Tempo_Empresa1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 565, page.Width, page.Height));
                            text_forma.DrawString(lbl_Empresa2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 580, page.Width, page.Height));
                            text_forma.DrawString(lbl_Tempo_Empresa2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 595, page.Width, page.Height));
                            text_forma.DrawString(lbl_Descricao.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(90, 680, 405, page.Height));
                        }
                        else if (aux5 != "" || aux6 != "")
                        {
                            text_forma.DrawString(lbl_Exp.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 510, page.Width, page.Height));
                            grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 530, 492, 4);
                        }
                        if (aux5 != "")
                        {
                            text_forma.DrawString(lbl_Empresa1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 550, page.Width, page.Height));
                            text_forma.DrawString(lbl_Tempo_Empresa1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 565, page.Width, page.Height));
                        }

                        if (aux6 != "")
                        {
                            text_forma.DrawString(lbl_Empresa2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 580, page.Width, page.Height));
                            text_forma.DrawString(lbl_Tempo_Empresa2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 595, page.Width, page.Height));
                        }

                        if (aux7 != "")
                        {
                            text_forma.DrawString(lbl_Descricao.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(90, 680, 405, page.Height));
                        }
                        try
                        {
                            doc.Save("Currículo.pdf");
                            System.Diagnostics.Process.Start("Currículo.pdf");
                        }
                        catch
                        {
                            throw new Exception("Feche o pdf que já esta aberto!");
                        }
                    }
                }
                else
                {
                    using (var doc = new PdfSharp.Pdf.PdfDocument())
                    {

                        var page = doc.AddPage();
                        var grafico = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                        var text_forma = new PdfSharp.Drawing.Layout.XTextFormatter(grafico);
                        var fontT = new PdfSharp.Drawing.XFont("Arial", 16);
                        var font = new PdfSharp.Drawing.XFont("Arial", 13);

                        //Dados Pessoais
                        text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                        text_forma.DrawString(lbl_Nome.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 40, page.Width, page.Height));
                        text_forma.DrawString(lbl_nacionalidade.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 70, page.Width, page.Height));
                        text_forma.DrawString(lbl_Endereco.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 85, page.Width, page.Height));
                        text_forma.DrawString(lbl_Cidade.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 100, page.Width, page.Height));
                        text_forma.DrawString(lbl_Tel.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 115, page.Width, page.Height));
                        text_forma.DrawString(lbl_Email.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 130, page.Width, page.Height));

                        //Objetivo
                        text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                        text_forma.DrawString(lbl_Objetivo.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 180, page.Width, page.Height));
                        grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 200, 492, 4);
                        text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                        text_forma.DrawString(lbl_Area.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 220, page.Width, page.Height));
                        text_forma.DrawString(lbl_Cargo.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 235, page.Width, page.Height));

                        //Formação Acadêmica
                        text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                        text_forma.DrawString(lbl_formacao.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 285, page.Width, page.Height));
                        grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 305, 492, 4);
                        text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                        text_forma.DrawString(lbl_escolaridade.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 325, page.Width, page.Height));

                        if (aux1 != "" && aux2 != "" && aux3 != "" && aux4 != "")
                        {
                            //Atividades Extracurriculares
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                            text_forma.DrawString(lbl_Atividades.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 375, page.Width, page.Height));
                            grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 395, 492, 4);
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                            text_forma.DrawString(lbl_Curso1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 415, page.Width, page.Height));
                            text_forma.DrawString(lbl_Curso2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 430, page.Width, page.Height));
                            text_forma.DrawString(lbl_Idioma1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 445, page.Width, page.Height));
                            text_forma.DrawString(lbl_Idioma2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 460, page.Width, page.Height));

                        }
                        else if (aux1 != "" || aux2 != "" || aux3 != "" || aux4 != "")
                        {
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                            text_forma.DrawString(lbl_Atividades.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 375, page.Width, page.Height));
                            grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 395, 492, 4);
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                        }


                        if (aux1 != "")
                        {
                            text_forma.DrawString(lbl_Curso1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 415, page.Width, page.Height));
                        }

                        if (aux2 != "")
                        {
                            text_forma.DrawString(lbl_Curso2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 430, page.Width, page.Height));
                        }

                        if (aux3 != "")
                        {
                            text_forma.DrawString(lbl_Idioma1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 445, page.Width, page.Height));
                        }

                        if (aux4 != "")
                        {
                            text_forma.DrawString(lbl_Idioma2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 460, page.Width, page.Height));
                        }


                        if (aux5 != "" && aux6 != "")
                        {
                            //Experiência Profissional
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                            text_forma.DrawString(lbl_Exp.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 510, page.Width, page.Height));
                            grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 530, 492, 4);
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                            text_forma.DrawString(lbl_Empresa1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 550, page.Width, page.Height));
                            text_forma.DrawString(lbl_Tempo_Empresa1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 565, page.Width, page.Height));
                            text_forma.DrawString(lbl_Empresa2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 580, page.Width, page.Height));
                            text_forma.DrawString(lbl_Tempo_Empresa2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 595, page.Width, page.Height));
                            text_forma.DrawString(lbl_Descricao.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 680, 405, page.Height));
                        }
                        else if (aux5 != "" || aux6 != "")
                        {
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
                            text_forma.DrawString(lbl_Exp.Text.ToString(), fontT, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(0, 510, page.Width, page.Height));
                            grafico.DrawRectangle(PdfSharp.Drawing.XPens.LightGray, PdfSharp.Drawing.XBrushes.LightGray, 50, 530, 492, 4);
                            text_forma.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
                        }
                        if (aux5 != "")
                        {
                            text_forma.DrawString(lbl_Empresa1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 550, page.Width, page.Height));
                            text_forma.DrawString(lbl_Tempo_Empresa1.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 565, page.Width, page.Height));
                        }

                        if (aux6 != "")
                        {
                            text_forma.DrawString(lbl_Empresa2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 580, page.Width, page.Height));
                            text_forma.DrawString(lbl_Tempo_Empresa2.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 595, page.Width, page.Height));
                        }

                        if (aux7 != "")
                        {
                            text_forma.DrawString(lbl_Descricao.Text.ToString(), font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 680, 405, page.Height));
                        }
                        try
                        {
                            doc.Save("Currículo.pdf");
                            System.Diagnostics.Process.Start("Currículo.pdf");
                        }
                        catch
                        {
                            throw new Exception("Feche o pdf que já esta aberto!");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "CurriculoGo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
