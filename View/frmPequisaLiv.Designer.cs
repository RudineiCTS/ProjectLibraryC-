namespace PMBIBLIO
{
    partial class frmPesquisaLiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaLiv));
            this.dgvPesquisaLiv = new System.Windows.Forms.DataGridView();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.rdbColecao = new System.Windows.Forms.RadioButton();
            this.rdbEditora = new System.Windows.Forms.RadioButton();
            this.rdbAutor = new System.Windows.Forms.RadioButton();
            this.rdbTitulo = new System.Windows.Forms.RadioButton();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblColecao = new System.Windows.Forms.Label();
            this.txtColecao = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnDesfiltro = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaLiv)).BeginInit();
            this.gpbFiltro.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPesquisaLiv
            // 
            this.dgvPesquisaLiv.AllowUserToAddRows = false;
            this.dgvPesquisaLiv.AllowUserToDeleteRows = false;
            this.dgvPesquisaLiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaLiv.Location = new System.Drawing.Point(12, 152);
            this.dgvPesquisaLiv.Name = "dgvPesquisaLiv";
            this.dgvPesquisaLiv.ReadOnly = true;
            this.dgvPesquisaLiv.Size = new System.Drawing.Size(776, 299);
            this.dgvPesquisaLiv.TabIndex = 0;
            this.dgvPesquisaLiv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPesquisaLiv_CellMouseDoubleClick);
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.rdbColecao);
            this.gpbFiltro.Controls.Add(this.rdbEditora);
            this.gpbFiltro.Controls.Add(this.rdbAutor);
            this.gpbFiltro.Controls.Add(this.rdbTitulo);
            this.gpbFiltro.Location = new System.Drawing.Point(12, 12);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(162, 121);
            this.gpbFiltro.TabIndex = 1;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro";
            // 
            // rdbColecao
            // 
            this.rdbColecao.AutoSize = true;
            this.rdbColecao.Location = new System.Drawing.Point(40, 91);
            this.rdbColecao.Name = "rdbColecao";
            this.rdbColecao.Size = new System.Drawing.Size(64, 17);
            this.rdbColecao.TabIndex = 3;
            this.rdbColecao.TabStop = true;
            this.rdbColecao.Text = "Coleção";
            this.rdbColecao.UseVisualStyleBackColor = true;
            this.rdbColecao.CheckedChanged += new System.EventHandler(this.rdbColecao_CheckedChanged);
            // 
            // rdbEditora
            // 
            this.rdbEditora.AutoSize = true;
            this.rdbEditora.Location = new System.Drawing.Point(40, 65);
            this.rdbEditora.Name = "rdbEditora";
            this.rdbEditora.Size = new System.Drawing.Size(58, 17);
            this.rdbEditora.TabIndex = 2;
            this.rdbEditora.TabStop = true;
            this.rdbEditora.Text = "Editora";
            this.rdbEditora.UseVisualStyleBackColor = true;
            this.rdbEditora.CheckedChanged += new System.EventHandler(this.rdbEditora_CheckedChanged);
            // 
            // rdbAutor
            // 
            this.rdbAutor.AutoSize = true;
            this.rdbAutor.Location = new System.Drawing.Point(40, 41);
            this.rdbAutor.Name = "rdbAutor";
            this.rdbAutor.Size = new System.Drawing.Size(91, 17);
            this.rdbAutor.TabIndex = 1;
            this.rdbAutor.TabStop = true;
            this.rdbAutor.Text = "Autor do Livro";
            this.rdbAutor.UseVisualStyleBackColor = true;
            this.rdbAutor.CheckedChanged += new System.EventHandler(this.rdbAutor_CheckedChanged);
            // 
            // rdbTitulo
            // 
            this.rdbTitulo.AutoSize = true;
            this.rdbTitulo.Location = new System.Drawing.Point(40, 17);
            this.rdbTitulo.Name = "rdbTitulo";
            this.rdbTitulo.Size = new System.Drawing.Size(94, 17);
            this.rdbTitulo.TabIndex = 0;
            this.rdbTitulo.TabStop = true;
            this.rdbTitulo.Text = "Título do Livro";
            this.rdbTitulo.UseVisualStyleBackColor = true;
            this.rdbTitulo.CheckedChanged += new System.EventHandler(this.rdbTitulo_CheckedChanged);
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.lblColecao);
            this.gpbPesquisa.Controls.Add(this.txtColecao);
            this.gpbPesquisa.Controls.Add(this.txtEditora);
            this.gpbPesquisa.Controls.Add(this.txtAutor);
            this.gpbPesquisa.Controls.Add(this.txtTitulo);
            this.gpbPesquisa.Controls.Add(this.lblEditora);
            this.gpbPesquisa.Controls.Add(this.lblAutor);
            this.gpbPesquisa.Controls.Add(this.lblTitulo);
            this.gpbPesquisa.Location = new System.Drawing.Point(214, 12);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(441, 121);
            this.gpbPesquisa.TabIndex = 2;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa";
            // 
            // lblColecao
            // 
            this.lblColecao.AutoSize = true;
            this.lblColecao.Location = new System.Drawing.Point(6, 93);
            this.lblColecao.Name = "lblColecao";
            this.lblColecao.Size = new System.Drawing.Size(49, 13);
            this.lblColecao.TabIndex = 5;
            this.lblColecao.Text = "Coleção:";
            // 
            // txtColecao
            // 
            this.txtColecao.Location = new System.Drawing.Point(60, 90);
            this.txtColecao.Name = "txtColecao";
            this.txtColecao.Size = new System.Drawing.Size(184, 20);
            this.txtColecao.TabIndex = 6;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(60, 64);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(201, 20);
            this.txtEditora.TabIndex = 5;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(60, 40);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(263, 20);
            this.txtAutor.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(60, 16);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(375, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(6, 67);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(43, 13);
            this.lblEditora.TabIndex = 2;
            this.lblEditora.Text = "Editora:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(6, 43);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(6, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(692, 30);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(84, 38);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnDesfiltro
            // 
            this.btnDesfiltro.Location = new System.Drawing.Point(692, 81);
            this.btnDesfiltro.Name = "btnDesfiltro";
            this.btnDesfiltro.Size = new System.Drawing.Size(84, 38);
            this.btnDesfiltro.TabIndex = 4;
            this.btnDesfiltro.Text = "Apagar Filtro";
            this.btnDesfiltro.UseVisualStyleBackColor = true;
            this.btnDesfiltro.Click += new System.EventHandler(this.btnDesfiltro_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(12, 136);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(347, 13);
            this.lblInformation.TabIndex = 14;
            this.lblInformation.Text = "Clique duas vezes sobre uma linha para selecionar os dados da locação";
            // 
            // frmPesquisaLiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnDesfiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.gpbFiltro);
            this.Controls.Add(this.dgvPesquisaLiv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmPesquisaLiv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Livros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cadLivro_FormClosed);
            this.Load += new System.EventHandler(this.frmPesquisaLiv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaLiv)).EndInit();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPesquisaLiv;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnDesfiltro;
        private System.Windows.Forms.RadioButton rdbEditora;
        private System.Windows.Forms.RadioButton rdbAutor;
        private System.Windows.Forms.RadioButton rdbTitulo;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblColecao;
        private System.Windows.Forms.TextBox txtColecao;
        private System.Windows.Forms.RadioButton rdbColecao;
        private System.Windows.Forms.Label lblInformation;
    }
}