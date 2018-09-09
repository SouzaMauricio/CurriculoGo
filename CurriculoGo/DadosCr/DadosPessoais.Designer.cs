namespace CurriculoGo.DadosCr
{
    partial class DadosPessoais
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.mkt_Telefone_Fixo = new System.Windows.Forms.MaskedTextBox();
            this.mkt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.mkt_Data_Nasc = new System.Windows.Forms.MaskedTextBox();
            this.cbo_UF = new System.Windows.Forms.ComboBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_UF = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.chk_Filhos = new System.Windows.Forms.CheckBox();
            this.lbl_DataNasc = new System.Windows.Forms.Label();
            this.lbl_EstadoCivil = new System.Windows.Forms.Label();
            this.lbl_TelefoneFixo = new System.Windows.Forms.Label();
            this.lbl_Naturalidade = new System.Windows.Forms.Label();
            this.lbl_Celular = new System.Windows.Forms.Label();
            this.lbl_Nacionalidade = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.cbo_EstadoCivil = new System.Windows.Forms.ComboBox();
            this.txt_Nacionalidade = new System.Windows.Forms.TextBox();
            this.txt_Naturalidade = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dados Pessoais";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(84, 104);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(635, 25);
            this.txt_Nome.TabIndex = 90;
            // 
            // mkt_Telefone_Fixo
            // 
            this.mkt_Telefone_Fixo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkt_Telefone_Fixo.Location = new System.Drawing.Point(84, 300);
            this.mkt_Telefone_Fixo.Mask = "00 0000 0000";
            this.mkt_Telefone_Fixo.Name = "mkt_Telefone_Fixo";
            this.mkt_Telefone_Fixo.Size = new System.Drawing.Size(282, 25);
            this.mkt_Telefone_Fixo.TabIndex = 98;
            this.mkt_Telefone_Fixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mkt_Celular
            // 
            this.mkt_Celular.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkt_Celular.Location = new System.Drawing.Point(84, 346);
            this.mkt_Celular.Mask = "00 00000 9999";
            this.mkt_Celular.Name = "mkt_Celular";
            this.mkt_Celular.Size = new System.Drawing.Size(282, 25);
            this.mkt_Celular.TabIndex = 99;
            this.mkt_Celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mkt_Data_Nasc
            // 
            this.mkt_Data_Nasc.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkt_Data_Nasc.Location = new System.Drawing.Point(507, 151);
            this.mkt_Data_Nasc.Mask = "000";
            this.mkt_Data_Nasc.Name = "mkt_Data_Nasc";
            this.mkt_Data_Nasc.Size = new System.Drawing.Size(212, 25);
            this.mkt_Data_Nasc.TabIndex = 94;
            this.mkt_Data_Nasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_UF
            // 
            this.cbo_UF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_UF.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_UF.FormattingEnabled = true;
            this.cbo_UF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbo_UF.Location = new System.Drawing.Point(437, 255);
            this.cbo_UF.Name = "cbo_UF";
            this.cbo_UF.Size = new System.Drawing.Size(121, 28);
            this.cbo_UF.TabIndex = 97;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(81, 376);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(57, 20);
            this.lbl_Email.TabIndex = 114;
            this.lbl_Email.Text = "*E-mail";
            this.lbl_Email.UseMnemonic = false;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(84, 396);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(635, 25);
            this.txt_Email.TabIndex = 102;
            // 
            // lbl_UF
            // 
            this.lbl_UF.AutoSize = true;
            this.lbl_UF.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UF.Location = new System.Drawing.Point(434, 235);
            this.lbl_UF.Name = "lbl_UF";
            this.lbl_UF.Size = new System.Drawing.Size(33, 20);
            this.lbl_UF.TabIndex = 113;
            this.lbl_UF.Text = "*UF";
            this.lbl_UF.UseMnemonic = false;
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cidade.Location = new System.Drawing.Point(81, 235);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(70, 20);
            this.lbl_Cidade.TabIndex = 112;
            this.lbl_Cidade.Text = "*Cidade";
            this.lbl_Cidade.UseMnemonic = false;
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cidade.Location = new System.Drawing.Point(84, 255);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(282, 25);
            this.txt_Cidade.TabIndex = 96;
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Endereco.Location = new System.Drawing.Point(81, 183);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(273, 20);
            this.lbl_Endereco.TabIndex = 111;
            this.lbl_Endereco.Text = "*Endereço (Rua/Av, Nº, Bairro, CEP):";
            this.lbl_Endereco.UseMnemonic = false;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Endereco.Location = new System.Drawing.Point(84, 203);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(635, 25);
            this.txt_Endereco.TabIndex = 95;
            // 
            // chk_Filhos
            // 
            this.chk_Filhos.AutoSize = true;
            this.chk_Filhos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Filhos.Location = new System.Drawing.Point(85, 151);
            this.chk_Filhos.Name = "chk_Filhos";
            this.chk_Filhos.Size = new System.Drawing.Size(122, 24);
            this.chk_Filhos.TabIndex = 92;
            this.chk_Filhos.Text = "Possui Filhos?";
            this.chk_Filhos.UseVisualStyleBackColor = true;
            // 
            // lbl_DataNasc
            // 
            this.lbl_DataNasc.AutoSize = true;
            this.lbl_DataNasc.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataNasc.Location = new System.Drawing.Point(504, 132);
            this.lbl_DataNasc.Name = "lbl_DataNasc";
            this.lbl_DataNasc.Size = new System.Drawing.Size(60, 20);
            this.lbl_DataNasc.TabIndex = 110;
            this.lbl_DataNasc.Text = "*Idade";
            this.lbl_DataNasc.UseMnemonic = false;
            // 
            // lbl_EstadoCivil
            // 
            this.lbl_EstadoCivil.AutoSize = true;
            this.lbl_EstadoCivil.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EstadoCivil.Location = new System.Drawing.Point(301, 129);
            this.lbl_EstadoCivil.Name = "lbl_EstadoCivil";
            this.lbl_EstadoCivil.Size = new System.Drawing.Size(99, 20);
            this.lbl_EstadoCivil.TabIndex = 108;
            this.lbl_EstadoCivil.Text = "*Estado Cívil";
            this.lbl_EstadoCivil.UseMnemonic = false;
            // 
            // lbl_TelefoneFixo
            // 
            this.lbl_TelefoneFixo.AutoSize = true;
            this.lbl_TelefoneFixo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TelefoneFixo.Location = new System.Drawing.Point(81, 280);
            this.lbl_TelefoneFixo.Name = "lbl_TelefoneFixo";
            this.lbl_TelefoneFixo.Size = new System.Drawing.Size(108, 20);
            this.lbl_TelefoneFixo.TabIndex = 107;
            this.lbl_TelefoneFixo.Text = "*Telefone Fixo";
            this.lbl_TelefoneFixo.UseMnemonic = false;
            // 
            // lbl_Naturalidade
            // 
            this.lbl_Naturalidade.AutoSize = true;
            this.lbl_Naturalidade.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Naturalidade.Location = new System.Drawing.Point(434, 325);
            this.lbl_Naturalidade.Name = "lbl_Naturalidade";
            this.lbl_Naturalidade.Size = new System.Drawing.Size(92, 20);
            this.lbl_Naturalidade.TabIndex = 106;
            this.lbl_Naturalidade.Text = "*Natural de";
            this.lbl_Naturalidade.UseMnemonic = false;
            // 
            // lbl_Celular
            // 
            this.lbl_Celular.AutoSize = true;
            this.lbl_Celular.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Celular.Location = new System.Drawing.Point(81, 324);
            this.lbl_Celular.Name = "lbl_Celular";
            this.lbl_Celular.Size = new System.Drawing.Size(67, 20);
            this.lbl_Celular.TabIndex = 105;
            this.lbl_Celular.Text = "*Celular";
            this.lbl_Celular.UseMnemonic = false;
            // 
            // lbl_Nacionalidade
            // 
            this.lbl_Nacionalidade.AutoSize = true;
            this.lbl_Nacionalidade.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nacionalidade.Location = new System.Drawing.Point(434, 280);
            this.lbl_Nacionalidade.Name = "lbl_Nacionalidade";
            this.lbl_Nacionalidade.Size = new System.Drawing.Size(124, 20);
            this.lbl_Nacionalidade.TabIndex = 104;
            this.lbl_Nacionalidade.Text = "*Nacionalidade";
            this.lbl_Nacionalidade.UseMnemonic = false;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(81, 84);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(136, 20);
            this.lbl_Nome.TabIndex = 103;
            this.lbl_Nome.Text = "*Nome Completo";
            this.lbl_Nome.UseMnemonic = false;
            // 
            // cbo_EstadoCivil
            // 
            this.cbo_EstadoCivil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_EstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_EstadoCivil.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_EstadoCivil.FormattingEnabled = true;
            this.cbo_EstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Viuvo"});
            this.cbo_EstadoCivil.Location = new System.Drawing.Point(304, 149);
            this.cbo_EstadoCivil.Name = "cbo_EstadoCivil";
            this.cbo_EstadoCivil.Size = new System.Drawing.Size(121, 28);
            this.cbo_EstadoCivil.TabIndex = 93;
            // 
            // txt_Nacionalidade
            // 
            this.txt_Nacionalidade.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nacionalidade.Location = new System.Drawing.Point(437, 300);
            this.txt_Nacionalidade.Name = "txt_Nacionalidade";
            this.txt_Nacionalidade.Size = new System.Drawing.Size(282, 25);
            this.txt_Nacionalidade.TabIndex = 100;
            // 
            // txt_Naturalidade
            // 
            this.txt_Naturalidade.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Naturalidade.Location = new System.Drawing.Point(437, 346);
            this.txt_Naturalidade.Name = "txt_Naturalidade";
            this.txt_Naturalidade.Size = new System.Drawing.Size(282, 25);
            this.txt_Naturalidade.TabIndex = 101;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLimpar.Location = new System.Drawing.Point(82, 442);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(207, 46);
            this.btnLimpar.TabIndex = 116;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnProximo.Location = new System.Drawing.Point(512, 442);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(207, 46);
            this.btnProximo.TabIndex = 115;
            this.btnProximo.Text = "Prosseguir";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CurriculoGo.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(375, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DadosPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.mkt_Telefone_Fixo);
            this.Controls.Add(this.mkt_Celular);
            this.Controls.Add(this.mkt_Data_Nasc);
            this.Controls.Add(this.cbo_UF);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_UF);
            this.Controls.Add(this.lbl_Cidade);
            this.Controls.Add(this.txt_Cidade);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.chk_Filhos);
            this.Controls.Add(this.lbl_DataNasc);
            this.Controls.Add(this.lbl_EstadoCivil);
            this.Controls.Add(this.lbl_TelefoneFixo);
            this.Controls.Add(this.lbl_Naturalidade);
            this.Controls.Add(this.lbl_Celular);
            this.Controls.Add(this.lbl_Nacionalidade);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.cbo_EstadoCivil);
            this.Controls.Add(this.txt_Nacionalidade);
            this.Controls.Add(this.txt_Naturalidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DadosPessoais";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Nome;
        public System.Windows.Forms.MaskedTextBox mkt_Telefone_Fixo;
        public System.Windows.Forms.MaskedTextBox mkt_Celular;
        public System.Windows.Forms.MaskedTextBox mkt_Data_Nasc;
        public System.Windows.Forms.ComboBox cbo_UF;
        public System.Windows.Forms.Label lbl_Email;
        public System.Windows.Forms.TextBox txt_Email;
        public System.Windows.Forms.Label lbl_UF;
        public System.Windows.Forms.Label lbl_Cidade;
        public System.Windows.Forms.TextBox txt_Cidade;
        public System.Windows.Forms.Label lbl_Endereco;
        public System.Windows.Forms.TextBox txt_Endereco;
        public System.Windows.Forms.CheckBox chk_Filhos;
        public System.Windows.Forms.Label lbl_DataNasc;
        public System.Windows.Forms.Label lbl_EstadoCivil;
        public System.Windows.Forms.Label lbl_TelefoneFixo;
        public System.Windows.Forms.Label lbl_Naturalidade;
        public System.Windows.Forms.Label lbl_Celular;
        public System.Windows.Forms.Label lbl_Nacionalidade;
        public System.Windows.Forms.Label lbl_Nome;
        public System.Windows.Forms.ComboBox cbo_EstadoCivil;
        public System.Windows.Forms.TextBox txt_Nacionalidade;
        public System.Windows.Forms.TextBox txt_Naturalidade;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnProximo;
    }
}
