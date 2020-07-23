namespace PMBIBLIO
{
    partial class frmHisto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHisto));
            this.rdbPerioLocado = new System.Windows.Forms.RadioButton();
            this.rdbLivrosLocado = new System.Windows.Forms.RadioButton();
            this.dgvHisto = new System.Windows.Forms.DataGridView();
            this.btnApagarFiltro = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblDevolucao = new System.Windows.Forms.Label();
            this.mskDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.lblLocacao = new System.Windows.Forms.Label();
            this.mskLocacao = new System.Windows.Forms.MaskedTextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.rdbLocacao = new System.Windows.Forms.RadioButton();
            this.rdbLivro = new System.Windows.Forms.RadioButton();
            this.rdbLeitor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisto)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            this.gpbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbPerioLocado
            // 
            this.rdbPerioLocado.AutoSize = true;
            this.rdbPerioLocado.Location = new System.Drawing.Point(176, 5);
            this.rdbPerioLocado.Name = "rdbPerioLocado";
            this.rdbPerioLocado.Size = new System.Drawing.Size(131, 17);
            this.rdbPerioLocado.TabIndex = 30;
            this.rdbPerioLocado.TabStop = true;
            this.rdbPerioLocado.Text = "Alternar para periódico";
            this.rdbPerioLocado.UseVisualStyleBackColor = true;
            this.rdbPerioLocado.CheckedChanged += new System.EventHandler(this.rdbPerioLocado_CheckedChanged);
            // 
            // rdbLivrosLocado
            // 
            this.rdbLivrosLocado.AutoSize = true;
            this.rdbLivrosLocado.Location = new System.Drawing.Point(15, 5);
            this.rdbLivrosLocado.Name = "rdbLivrosLocado";
            this.rdbLivrosLocado.Size = new System.Drawing.Size(111, 17);
            this.rdbLivrosLocado.TabIndex = 29;
            this.rdbLivrosLocado.TabStop = true;
            this.rdbLivrosLocado.Text = "Alternar para Livro";
            this.rdbLivrosLocado.UseVisualStyleBackColor = true;
            this.rdbLivrosLocado.CheckedChanged += new System.EventHandler(this.rdbLivrosLocado_CheckedChanged);
            // 
            // dgvHisto
            // 
            this.dgvHisto.AllowUserToAddRows = false;
            this.dgvHisto.AllowUserToDeleteRows = false;
            this.dgvHisto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHisto.Location = new System.Drawing.Point(12, 182);
            this.dgvHisto.Name = "dgvHisto";
            this.dgvHisto.ReadOnly = true;
            this.dgvHisto.Size = new System.Drawing.Size(776, 306);
            this.dgvHisto.TabIndex = 28;
            // 
            // btnApagarFiltro
            // 
            this.btnApagarFiltro.Location = new System.Drawing.Point(688, 111);
            this.btnApagarFiltro.Name = "btnApagarFiltro";
            this.btnApagarFiltro.Size = new System.Drawing.Size(84, 43);
            this.btnApagarFiltro.TabIndex = 26;
            this.btnApagarFiltro.Text = "Apagar Filtro";
            this.btnApagarFiltro.UseVisualStyleBackColor = true;
            this.btnApagarFiltro.Click += new System.EventHandler(this.btnApagarFiltro_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(688, 36);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(84, 40);
            this.btnFiltrar.TabIndex = 25;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
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
            this.gpbPesquisa.Location = new System.Drawing.Point(239, 29);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(393, 138);
            this.gpbPesquisa.TabIndex = 24;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa:";
            // 
            // lblDevolucao
            // 
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.Location = new System.Drawing.Point(6, 112);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Size = new System.Drawing.Size(58, 13);
            this.lblDevolucao.TabIndex = 7;
            this.lblDevolucao.Text = "Data Final:";
            // 
            // mskDevolucao
            // 
            this.mskDevolucao.Location = new System.Drawing.Point(70, 109);
            this.mskDevolucao.Mask = "00/00/0000";
            this.mskDevolucao.Name = "mskDevolucao";
            this.mskDevolucao.Size = new System.Drawing.Size(73, 20);
            this.mskDevolucao.TabIndex = 8;
            // 
            // lblLocacao
            // 
            this.lblLocacao.AutoSize = true;
            this.lblLocacao.Location = new System.Drawing.Point(5, 82);
            this.lblLocacao.Name = "lblLocacao";
            this.lblLocacao.Size = new System.Drawing.Size(63, 13);
            this.lblLocacao.TabIndex = 6;
            this.lblLocacao.Text = "Data Inicial:";
            // 
            // mskLocacao
            // 
            this.mskLocacao.Location = new System.Drawing.Point(74, 82);
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
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.rdbLocacao);
            this.gpbFiltro.Controls.Add(this.rdbLivro);
            this.gpbFiltro.Controls.Add(this.rdbLeitor);
            this.gpbFiltro.Location = new System.Drawing.Point(12, 29);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(200, 102);
            this.gpbFiltro.TabIndex = 23;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro:";
            // 
            // rdbLocacao
            // 
            this.rdbLocacao.AutoSize = true;
            this.rdbLocacao.Location = new System.Drawing.Point(29, 69);
            this.rdbLocacao.Name = "rdbLocacao";
            this.rdbLocacao.Size = new System.Drawing.Size(48, 17);
            this.rdbLocacao.TabIndex = 5;
            this.rdbLocacao.TabStop = true;
            this.rdbLocacao.Text = "Data";
            this.rdbLocacao.UseVisualStyleBackColor = true;
            this.rdbLocacao.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbLivro
            // 
            this.rdbLivro.AutoSize = true;
            this.rdbLivro.Location = new System.Drawing.Point(29, 46);
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
            this.rdbLeitor.Location = new System.Drawing.Point(29, 23);
            this.rdbLeitor.Name = "rdbLeitor";
            this.rdbLeitor.Size = new System.Drawing.Size(97, 17);
            this.rdbLeitor.TabIndex = 1;
            this.rdbLeitor.TabStop = true;
            this.rdbLeitor.Text = "Nome do Leitor";
            this.rdbLeitor.UseVisualStyleBackColor = true;
            this.rdbLeitor.CheckedChanged += new System.EventHandler(this.rdbLeitor_CheckedChanged);
            // 
            // frmHisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 496);
            this.Controls.Add(this.rdbPerioLocado);
            this.Controls.Add(this.rdbLivrosLocado);
            this.Controls.Add(this.dgvHisto);
            this.Controls.Add(this.btnApagarFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.gpbFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHisto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHisto_FormClosed);
            this.Load += new System.EventHandler(this.frmHisto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisto)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbPerioLocado;
        private System.Windows.Forms.RadioButton rdbLivrosLocado;
        private System.Windows.Forms.DataGridView dgvHisto;
        private System.Windows.Forms.Button btnApagarFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Label lblDevolucao;
        private System.Windows.Forms.MaskedTextBox mskDevolucao;
        private System.Windows.Forms.Label lblLocacao;
        private System.Windows.Forms.MaskedTextBox mskLocacao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.RadioButton rdbLivro;
        private System.Windows.Forms.RadioButton rdbLeitor;
        private System.Windows.Forms.RadioButton rdbLocacao;
    }
}