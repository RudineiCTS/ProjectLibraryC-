namespace PMBIBLIO
{
    partial class frmPesquisaLocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaLocacao));
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.rdbDevolucao = new System.Windows.Forms.RadioButton();
            this.rdbLocacao = new System.Windows.Forms.RadioButton();
            this.rdbLivro = new System.Windows.Forms.RadioButton();
            this.rdbLeitor = new System.Windows.Forms.RadioButton();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblDevolucao = new System.Windows.Forms.Label();
            this.mskDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.lblLocacao = new System.Windows.Forms.Label();
            this.mskLocacao = new System.Windows.Forms.MaskedTextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnApagarFiltro = new System.Windows.Forms.Button();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.lblInformation = new System.Windows.Forms.Label();
            this.rdbLivrosLocado = new System.Windows.Forms.RadioButton();
            this.rdbPerioLocado = new System.Windows.Forms.RadioButton();
            this.gpbFiltro.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.rdbDevolucao);
            this.gpbFiltro.Controls.Add(this.rdbLocacao);
            this.gpbFiltro.Controls.Add(this.rdbLivro);
            this.gpbFiltro.Controls.Add(this.rdbLeitor);
            this.gpbFiltro.Location = new System.Drawing.Point(12, 36);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(200, 125);
            this.gpbFiltro.TabIndex = 0;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro:";
            // 
            // rdbDevolucao
            // 
            this.rdbDevolucao.AutoSize = true;
            this.rdbDevolucao.Location = new System.Drawing.Point(46, 91);
            this.rdbDevolucao.Name = "rdbDevolucao";
            this.rdbDevolucao.Size = new System.Drawing.Size(118, 17);
            this.rdbDevolucao.TabIndex = 4;
            this.rdbDevolucao.TabStop = true;
            this.rdbDevolucao.Text = "Data de Devolução";
            this.rdbDevolucao.UseVisualStyleBackColor = true;
            this.rdbDevolucao.CheckedChanged += new System.EventHandler(this.rdbDevolucao_CheckedChanged);
            // 
            // rdbLocacao
            // 
            this.rdbLocacao.AutoSize = true;
            this.rdbLocacao.Location = new System.Drawing.Point(46, 68);
            this.rdbLocacao.Name = "rdbLocacao";
            this.rdbLocacao.Size = new System.Drawing.Size(108, 17);
            this.rdbLocacao.TabIndex = 3;
            this.rdbLocacao.TabStop = true;
            this.rdbLocacao.Text = "Data de Locação";
            this.rdbLocacao.UseVisualStyleBackColor = true;
            this.rdbLocacao.CheckedChanged += new System.EventHandler(this.rdbLocacao_CheckedChanged);
            // 
            // rdbLivro
            // 
            this.rdbLivro.AutoSize = true;
            this.rdbLivro.Location = new System.Drawing.Point(46, 45);
            this.rdbLivro.Name = "rdbLivro";
            this.rdbLivro.Size = new System.Drawing.Size(94, 17);
            this.rdbLivro.TabIndex = 2;
            this.rdbLivro.TabStop = true;
            this.rdbLivro.Text = "Título do Livro";
            this.rdbLivro.UseVisualStyleBackColor = true;
            this.rdbLivro.CheckedChanged += new System.EventHandler(this.rdbLivro_CheckedChanged);
            // 
            // rdbLeitor
            // 
            this.rdbLeitor.AutoSize = true;
            this.rdbLeitor.Location = new System.Drawing.Point(46, 22);
            this.rdbLeitor.Name = "rdbLeitor";
            this.rdbLeitor.Size = new System.Drawing.Size(97, 17);
            this.rdbLeitor.TabIndex = 1;
            this.rdbLeitor.TabStop = true;
            this.rdbLeitor.Text = "Nome do Leitor";
            this.rdbLeitor.UseVisualStyleBackColor = true;
            this.rdbLeitor.CheckedChanged += new System.EventHandler(this.rdbLeitor_CheckedChanged);
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.lblDevolucao);
            this.gpbPesquisa.Controls.Add(this.mskDevolucao);
            this.gpbPesquisa.Controls.Add(this.lblLocacao);
            this.gpbPesquisa.Controls.Add(this.mskLocacao);
            this.gpbPesquisa.Controls.Add(this.txtTitulo);
            this.gpbPesquisa.Controls.Add(this.txtNome);
            this.gpbPesquisa.Controls.Add(this.lblTitulo);
            this.gpbPesquisa.Controls.Add(this.lblNome);
            this.gpbPesquisa.Location = new System.Drawing.Point(239, 36);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(393, 125);
            this.gpbPesquisa.TabIndex = 1;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa:";
            // 
            // lblDevolucao
            // 
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.Location = new System.Drawing.Point(6, 99);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Size = new System.Drawing.Size(62, 13);
            this.lblDevolucao.TabIndex = 7;
            this.lblDevolucao.Text = "Devolução:";
            // 
            // mskDevolucao
            // 
            this.mskDevolucao.Location = new System.Drawing.Point(74, 96);
            this.mskDevolucao.Mask = "00/00/0000";
            this.mskDevolucao.Name = "mskDevolucao";
            this.mskDevolucao.Size = new System.Drawing.Size(73, 20);
            this.mskDevolucao.TabIndex = 8;
            // 
            // lblLocacao
            // 
            this.lblLocacao.AutoSize = true;
            this.lblLocacao.Location = new System.Drawing.Point(6, 73);
            this.lblLocacao.Name = "lblLocacao";
            this.lblLocacao.Size = new System.Drawing.Size(52, 13);
            this.lblLocacao.TabIndex = 6;
            this.lblLocacao.Text = "Locação:";
            // 
            // mskLocacao
            // 
            this.mskLocacao.Location = new System.Drawing.Point(74, 70);
            this.mskLocacao.Mask = "00/00/0000";
            this.mskLocacao.Name = "mskLocacao";
            this.mskLocacao.Size = new System.Drawing.Size(73, 20);
            this.mskLocacao.TabIndex = 7;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(50, 44);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(285, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(285, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(6, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Título:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(688, 43);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(84, 40);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnApagarFiltro
            // 
            this.btnApagarFiltro.Location = new System.Drawing.Point(688, 118);
            this.btnApagarFiltro.Name = "btnApagarFiltro";
            this.btnApagarFiltro.Size = new System.Drawing.Size(84, 43);
            this.btnApagarFiltro.TabIndex = 10;
            this.btnApagarFiltro.Text = "Apagar Filtro";
            this.btnApagarFiltro.UseVisualStyleBackColor = true;
            this.btnApagarFiltro.Click += new System.EventHandler(this.btnApagarFiltro_Click);
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(12, 189);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.Size = new System.Drawing.Size(776, 306);
            this.dgvPesquisa.TabIndex = 20;
            this.dgvPesquisa.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPesquisa_CellMouseDoubleClick);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(12, 173);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(347, 13);
            this.lblInformation.TabIndex = 13;
            this.lblInformation.Text = "Clique duas vezes sobre uma linha para selecionar os dados da locação";
            // 
            // rdbLivrosLocado
            // 
            this.rdbLivrosLocado.AutoSize = true;
            this.rdbLivrosLocado.Location = new System.Drawing.Point(15, 12);
            this.rdbLivrosLocado.Name = "rdbLivrosLocado";
            this.rdbLivrosLocado.Size = new System.Drawing.Size(111, 17);
            this.rdbLivrosLocado.TabIndex = 21;
            this.rdbLivrosLocado.TabStop = true;
            this.rdbLivrosLocado.Text = "Alternar para Livro";
            this.rdbLivrosLocado.UseVisualStyleBackColor = true;
            this.rdbLivrosLocado.CheckedChanged += new System.EventHandler(this.rdbLivrosLocado_CheckedChanged);
            // 
            // rdbPerioLocado
            // 
            this.rdbPerioLocado.AutoSize = true;
            this.rdbPerioLocado.Location = new System.Drawing.Point(176, 12);
            this.rdbPerioLocado.Name = "rdbPerioLocado";
            this.rdbPerioLocado.Size = new System.Drawing.Size(131, 17);
            this.rdbPerioLocado.TabIndex = 22;
            this.rdbPerioLocado.TabStop = true;
            this.rdbPerioLocado.Text = "Alternar para periódico";
            this.rdbPerioLocado.UseVisualStyleBackColor = true;
            this.rdbPerioLocado.CheckedChanged += new System.EventHandler(this.rdbPerioLocado_CheckedChanged);
            // 
            // frmPesquisaLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 507);
            this.Controls.Add(this.rdbPerioLocado);
            this.Controls.Add(this.rdbLivrosLocado);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.btnApagarFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.gpbFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPesquisaLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Locação";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPesquisaLocacao_FormClosed);
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.RadioButton rdbLivro;
        private System.Windows.Forms.RadioButton rdbLeitor;
        private System.Windows.Forms.RadioButton rdbDevolucao;
        private System.Windows.Forms.RadioButton rdbLocacao;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnApagarFiltro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDevolucao;
        private System.Windows.Forms.MaskedTextBox mskDevolucao;
        private System.Windows.Forms.Label lblLocacao;
        private System.Windows.Forms.MaskedTextBox mskLocacao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.RadioButton rdbLivrosLocado;
        private System.Windows.Forms.RadioButton rdbPerioLocado;
    }
}