namespace PMBIBLIO
{
    partial class cadLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadLivro));
            this.btnPesquisaLivro = new System.Windows.Forms.Button();
            this.gpbInfoLivro = new System.Windows.Forms.GroupBox();
            this.txtpha = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExemplares = new System.Windows.Forms.TextBox();
            this.lblpha = new System.Windows.Forms.Label();
            this.txtCDU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.POGlivro = new System.Windows.Forms.TextBox();
            this.cbColecao = new System.Windows.Forms.ComboBox();
            this.lblColecao = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.lblTipos = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbEditora = new System.Windows.Forms.ComboBox();
            this.chkReferencia = new System.Windows.Forms.CheckBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalvarLivro = new System.Windows.Forms.Button();
            this.btnNovoLivro = new System.Windows.Forms.Button();
            this.btnLimparLivro = new System.Windows.Forms.Button();
            this.btnEditL = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gpbInfoLivro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisaLivro
            // 
            this.btnPesquisaLivro.Location = new System.Drawing.Point(231, 373);
            this.btnPesquisaLivro.Name = "btnPesquisaLivro";
            this.btnPesquisaLivro.Size = new System.Drawing.Size(67, 24);
            this.btnPesquisaLivro.TabIndex = 6;
            this.btnPesquisaLivro.Text = "Pesquisar";
            this.btnPesquisaLivro.UseVisualStyleBackColor = true;
            this.btnPesquisaLivro.Click += new System.EventHandler(this.btnPesquisaLivro_Click);
            // 
            // gpbInfoLivro
            // 
            this.gpbInfoLivro.Controls.Add(this.txtpha);
            this.gpbInfoLivro.Controls.Add(this.txtVolume);
            this.gpbInfoLivro.Controls.Add(this.label5);
            this.gpbInfoLivro.Controls.Add(this.txtPaginas);
            this.gpbInfoLivro.Controls.Add(this.label4);
            this.gpbInfoLivro.Controls.Add(this.label3);
            this.gpbInfoLivro.Controls.Add(this.txtExemplares);
            this.gpbInfoLivro.Controls.Add(this.lblpha);
            this.gpbInfoLivro.Controls.Add(this.txtCDU);
            this.gpbInfoLivro.Controls.Add(this.label1);
            this.gpbInfoLivro.Controls.Add(this.POGlivro);
            this.gpbInfoLivro.Controls.Add(this.cbColecao);
            this.gpbInfoLivro.Controls.Add(this.lblColecao);
            this.gpbInfoLivro.Controls.Add(this.lblGen);
            this.gpbInfoLivro.Controls.Add(this.cbAutor);
            this.gpbInfoLivro.Controls.Add(this.lblTipos);
            this.gpbInfoLivro.Controls.Add(this.btnEditar);
            this.gpbInfoLivro.Controls.Add(this.cbCategoria);
            this.gpbInfoLivro.Controls.Add(this.cbGenero);
            this.gpbInfoLivro.Controls.Add(this.cbEditora);
            this.gpbInfoLivro.Controls.Add(this.chkReferencia);
            this.gpbInfoLivro.Controls.Add(this.lblISBN);
            this.gpbInfoLivro.Controls.Add(this.txtISBN);
            this.gpbInfoLivro.Controls.Add(this.lblCategoria);
            this.gpbInfoLivro.Controls.Add(this.lblEditora);
            this.gpbInfoLivro.Controls.Add(this.lblAutor);
            this.gpbInfoLivro.Controls.Add(this.txtTitulo);
            this.gpbInfoLivro.Controls.Add(this.lblTitulo);
            this.gpbInfoLivro.Enabled = false;
            this.gpbInfoLivro.Location = new System.Drawing.Point(12, 12);
            this.gpbInfoLivro.Name = "gpbInfoLivro";
            this.gpbInfoLivro.Size = new System.Drawing.Size(517, 355);
            this.gpbInfoLivro.TabIndex = 5;
            this.gpbInfoLivro.TabStop = false;
            this.gpbInfoLivro.Text = "Info. Livro:";
            // 
            // txtpha
            // 
            this.txtpha.Enabled = false;
            this.txtpha.Location = new System.Drawing.Point(44, 127);
            this.txtpha.MaxLength = 5;
            this.txtpha.Name = "txtpha";
            this.txtpha.Size = new System.Drawing.Size(83, 20);
            this.txtpha.TabIndex = 38;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(57, 206);
            this.txtVolume.MaxLength = 5;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(83, 20);
            this.txtVolume.TabIndex = 37;
            this.txtVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolume_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Volume:";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(272, 180);
            this.txtPaginas.MaxLength = 5;
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(83, 20);
            this.txtPaginas.TabIndex = 35;
            this.txtPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaginas_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "N° de páginas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "N° exemplares:";
            // 
            // txtExemplares
            // 
            this.txtExemplares.Location = new System.Drawing.Point(87, 180);
            this.txtExemplares.MaxLength = 5;
            this.txtExemplares.Name = "txtExemplares";
            this.txtExemplares.Size = new System.Drawing.Size(83, 20);
            this.txtExemplares.TabIndex = 32;
            this.txtExemplares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExemplares_KeyPress);
            // 
            // lblpha
            // 
            this.lblpha.AutoSize = true;
            this.lblpha.Location = new System.Drawing.Point(6, 130);
            this.lblpha.Name = "lblpha";
            this.lblpha.Size = new System.Drawing.Size(32, 13);
            this.lblpha.TabIndex = 30;
            this.lblpha.Text = "PHA:";
            // 
            // txtCDU
            // 
            this.txtCDU.Location = new System.Drawing.Point(44, 74);
            this.txtCDU.MaxLength = 15;
            this.txtCDU.Name = "txtCDU";
            this.txtCDU.Size = new System.Drawing.Size(183, 20);
            this.txtCDU.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "CDU:";
            // 
            // POGlivro
            // 
            this.POGlivro.Enabled = false;
            this.POGlivro.Location = new System.Drawing.Point(12, 335);
            this.POGlivro.Name = "POGlivro";
            this.POGlivro.Size = new System.Drawing.Size(38, 20);
            this.POGlivro.TabIndex = 26;
            this.POGlivro.Visible = false;
            // 
            // cbColecao
            // 
            this.cbColecao.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbColecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColecao.FormattingEnabled = true;
            this.cbColecao.Location = new System.Drawing.Point(61, 259);
            this.cbColecao.Name = "cbColecao";
            this.cbColecao.Size = new System.Drawing.Size(161, 21);
            this.cbColecao.TabIndex = 25;
            this.cbColecao.SelectedIndexChanged += new System.EventHandler(this.cbColecao_SelectedIndexChanged);
            // 
            // lblColecao
            // 
            this.lblColecao.AutoSize = true;
            this.lblColecao.Location = new System.Drawing.Point(6, 262);
            this.lblColecao.Name = "lblColecao";
            this.lblColecao.Size = new System.Drawing.Size(49, 13);
            this.lblColecao.TabIndex = 24;
            this.lblColecao.Text = "Coleção:";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(247, 235);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(48, 13);
            this.lblGen.TabIndex = 23;
            this.lblGen.Text = "Gênero: ";
            // 
            // cbAutor
            // 
            this.cbAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(44, 100);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(263, 21);
            this.cbAutor.TabIndex = 22;
            this.cbAutor.SelectedIndexChanged += new System.EventHandler(this.cbAutor_SelectedIndexChanged);
            // 
            // lblTipos
            // 
            this.lblTipos.AutoSize = true;
            this.lblTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipos.Location = new System.Drawing.Point(8, 298);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(88, 13);
            this.lblTipos.TabIndex = 10;
            this.lblTipos.Text = "Adicionar Dados:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(102, 292);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(67, 24);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "**";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(61, 232);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(159, 21);
            this.cbCategoria.TabIndex = 19;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(301, 232);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(161, 21);
            this.cbGenero.TabIndex = 18;
            this.cbGenero.SelectedIndexChanged += new System.EventHandler(this.cbGenero_SelectedIndexChanged);
            // 
            // cbEditora
            // 
            this.cbEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(57, 153);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(263, 21);
            this.cbEditora.TabIndex = 17;
            this.cbEditora.SelectedIndexChanged += new System.EventHandler(this.cbEditora_SelectedIndexChanged);
            // 
            // chkReferencia
            // 
            this.chkReferencia.AutoSize = true;
            this.chkReferencia.Location = new System.Drawing.Point(388, 42);
            this.chkReferencia.Name = "chkReferencia";
            this.chkReferencia.Size = new System.Drawing.Size(78, 17);
            this.chkReferencia.TabIndex = 10;
            this.chkReferencia.Text = "Referência";
            this.chkReferencia.UseVisualStyleBackColor = true;
            this.chkReferencia.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(3, 48);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 4;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(44, 45);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(263, 20);
            this.txtISBN.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(3, 235);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(5, 156);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(46, 13);
            this.lblEditora.TabIndex = 9;
            this.lblEditora.Text = "Editora: ";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(6, 103);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(44, 13);
            this.txtTitulo.MaxLength = 100;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(357, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(3, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // btnSalvarLivro
            // 
            this.btnSalvarLivro.Location = new System.Drawing.Point(158, 373);
            this.btnSalvarLivro.Name = "btnSalvarLivro";
            this.btnSalvarLivro.Size = new System.Drawing.Size(67, 24);
            this.btnSalvarLivro.TabIndex = 7;
            this.btnSalvarLivro.Text = "Salvar";
            this.btnSalvarLivro.UseVisualStyleBackColor = true;
            this.btnSalvarLivro.Click += new System.EventHandler(this.btnSalvarLivro_Click);
            // 
            // btnNovoLivro
            // 
            this.btnNovoLivro.Location = new System.Drawing.Point(12, 373);
            this.btnNovoLivro.Name = "btnNovoLivro";
            this.btnNovoLivro.Size = new System.Drawing.Size(67, 24);
            this.btnNovoLivro.TabIndex = 9;
            this.btnNovoLivro.Text = "Novo";
            this.btnNovoLivro.UseVisualStyleBackColor = true;
            this.btnNovoLivro.Click += new System.EventHandler(this.btnNovoLivro_Click);
            // 
            // btnLimparLivro
            // 
            this.btnLimparLivro.Location = new System.Drawing.Point(85, 373);
            this.btnLimparLivro.Name = "btnLimparLivro";
            this.btnLimparLivro.Size = new System.Drawing.Size(67, 24);
            this.btnLimparLivro.TabIndex = 8;
            this.btnLimparLivro.Text = "Limpar";
            this.btnLimparLivro.UseVisualStyleBackColor = true;
            this.btnLimparLivro.Click += new System.EventHandler(this.btnLimparLivro_Click);
            // 
            // btnEditL
            // 
            this.btnEditL.Enabled = false;
            this.btnEditL.Location = new System.Drawing.Point(320, 373);
            this.btnEditL.Name = "btnEditL";
            this.btnEditL.Size = new System.Drawing.Size(75, 23);
            this.btnEditL.TabIndex = 10;
            this.btnEditL.Text = "Editar";
            this.btnEditL.UseVisualStyleBackColor = true;
            this.btnEditL.Click += new System.EventHandler(this.btnEditL_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(401, 373);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cadLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 409);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditL);
            this.Controls.Add(this.btnPesquisaLivro);
            this.Controls.Add(this.gpbInfoLivro);
            this.Controls.Add(this.btnSalvarLivro);
            this.Controls.Add(this.btnNovoLivro);
            this.Controls.Add(this.btnLimparLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "cadLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cadLivro_FormClosed);
            this.Load += new System.EventHandler(this.cadLivro_Load);
            this.gpbInfoLivro.ResumeLayout(false);
            this.gpbInfoLivro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisaLivro;
        private System.Windows.Forms.GroupBox gpbInfoLivro;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalvarLivro;
        private System.Windows.Forms.Button btnNovoLivro;
        private System.Windows.Forms.Button btnLimparLivro;
        private System.Windows.Forms.Label lblTipos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblColecao;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Button btnEditL;
        private System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.TextBox txtISBN;
        public System.Windows.Forms.TextBox txtTitulo;
        public System.Windows.Forms.ComboBox cbCategoria;
        public System.Windows.Forms.ComboBox cbGenero;
        public System.Windows.Forms.ComboBox cbEditora;
        public System.Windows.Forms.ComboBox cbAutor;
        public System.Windows.Forms.ComboBox cbColecao;
        public System.Windows.Forms.CheckBox chkReferencia;
        public System.Windows.Forms.TextBox POGlivro;
        private System.Windows.Forms.Label lblpha;
        public System.Windows.Forms.TextBox txtCDU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtExemplares;
        public System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPaginas;
        public System.Windows.Forms.TextBox txtpha;
    }
}