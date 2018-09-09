namespace CurriculoGo
{
    partial class CriarEditarCurriculo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarEditarCurriculo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dadosPessoais1 = new CurriculoGo.DadosCr.DadosPessoais();
            this.dadosProfissionais1 = new CurriculoGo.DadosCr.DadosProfissionais();
            this.dadosAcademicosProfissionais1 = new CurriculoGo.DadosCr.DadosAcademicosExtra();
            this.panel1.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.dadosPessoais1);
            this.pnlDados.Controls.Add(this.dadosProfissionais1);
            this.pnlDados.Controls.Add(this.dadosAcademicosProfissionais1);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDados.Location = new System.Drawing.Point(0, 40);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(800, 500);
            this.pnlDados.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(0, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(40, 40);
            this.btnSair.TabIndex = 8;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(720, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(760, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 40);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dadosPessoais1
            // 
            this.dadosPessoais1.BackColor = System.Drawing.SystemColors.Menu;
            this.dadosPessoais1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dadosPessoais1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadosPessoais1.Location = new System.Drawing.Point(0, 0);
            this.dadosPessoais1.Margin = new System.Windows.Forms.Padding(5);
            this.dadosPessoais1.Name = "dadosPessoais1";
            this.dadosPessoais1.Size = new System.Drawing.Size(800, 500);
            this.dadosPessoais1.TabIndex = 0;
            // 
            // dadosProfissionais1
            // 
            this.dadosProfissionais1.BackColor = System.Drawing.SystemColors.Menu;
            this.dadosProfissionais1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dadosProfissionais1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadosProfissionais1.Location = new System.Drawing.Point(0, 0);
            this.dadosProfissionais1.Margin = new System.Windows.Forms.Padding(4);
            this.dadosProfissionais1.Name = "dadosProfissionais1";
            this.dadosProfissionais1.Size = new System.Drawing.Size(800, 500);
            this.dadosProfissionais1.TabIndex = 2;
            // 
            // dadosAcademicosProfissionais1
            // 
            this.dadosAcademicosProfissionais1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dadosAcademicosProfissionais1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadosAcademicosProfissionais1.Location = new System.Drawing.Point(0, 0);
            this.dadosAcademicosProfissionais1.Margin = new System.Windows.Forms.Padding(4);
            this.dadosAcademicosProfissionais1.Name = "dadosAcademicosProfissionais1";
            this.dadosAcademicosProfissionais1.Size = new System.Drawing.Size(800, 500);
            this.dadosAcademicosProfissionais1.TabIndex = 1;
            // 
            // CriarEditarCurriculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CriarEditarCurriculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriarEditarCurriculo";
            this.panel1.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlDados;
        public DadosCr.DadosPessoais dadosPessoais1;
        public DadosCr.DadosAcademicosExtra dadosAcademicosProfissionais1;
        public DadosCr.DadosProfissionais dadosProfissionais1;
    }
}