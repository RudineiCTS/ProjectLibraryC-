namespace PMBIBLIO
{
    partial class locaLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locaLivro));
            this.gpbLocacao = new System.Windows.Forms.GroupBox();
            this.rdbLivro = new System.Windows.Forms.RadioButton();
            this.rdbPeri = new System.Windows.Forms.RadioButton();
            this.mskDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.mskLocacao = new System.Windows.Forms.MaskedTextBox();
            this.lblDevolucao = new System.Windows.Forms.Label();
            this.lblLocacao = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.cmbLivro = new System.Windows.Forms.ComboBox();
            this.cmbLeitor = new System.Windows.Forms.ComboBox();
            this.lblLeitor = new System.Windows.Forms.Label();
            this.gpbLeitor = new System.Windows.Forms.GroupBox();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbLivro = new System.Windows.Forms.GroupBox();
            this.cmbcate = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbauto = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.cmbtitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLocar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gpbLocacaoDevolucao = new System.Windows.Forms.GroupBox();
            this.rdbDevolver = new System.Windows.Forms.RadioButton();
            this.rdbLocar = new System.Windows.Forms.RadioButton();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gpbLocacao.SuspendLayout();
            this.gpbLeitor.SuspendLayout();
            this.gpbLivro.SuspendLayout();
            this.gpbLocacaoDevolucao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLocacao
            // 
            this.gpbLocacao.Controls.Add(this.rdbLivro);
            this.gpbLocacao.Controls.Add(this.rdbPeri);
            this.gpbLocacao.Controls.Add(this.mskDevolucao);
            this.gpbLocacao.Controls.Add(this.mskLocacao);
            this.gpbLocacao.Controls.Add(this.lblDevolucao);
            this.gpbLocacao.Controls.Add(this.lblLocacao);
            this.gpbLocacao.Controls.Add(this.lblLivro);
            this.gpbLocacao.Controls.Add(this.cmbLivro);
            this.gpbLocacao.Controls.Add(this.cmbLeitor);
            this.gpbLocacao.Controls.Add(this.lblLeitor);
            this.gpbLocacao.Enabled = false;
            this.gpbLocacao.Location = new System.Drawing.Point(12, 67);
            this.gpbLocacao.Name = "gpbLocacao";
            this.gpbLocacao.Size = new System.Drawing.Size(529, 107);
            this.gpbLocacao.TabIndex = 0;
            this.gpbLocacao.TabStop = false;
            this.gpbLocacao.Text = "Locação de Livro";
            // 
            // rdbLivro
            // 
            this.rdbLivro.AutoSize = true;
            this.rdbLivro.Location = new System.Drawing.Point(422, 46);
            this.rdbLivro.Name = "rdbLivro";
            this.rdbLivro.Size = new System.Drawing.Size(48, 17);
            this.rdbLivro.TabIndex = 8;
            this.rdbLivro.TabStop = true;
            this.rdbLivro.Text = "Livro";
            this.rdbLivro.UseVisualStyleBackColor = true;
            this.rdbLivro.CheckedChanged += new System.EventHandler(this.rdbLivro_CheckedChanged);
            // 
            // rdbPeri
            // 
            this.rdbPeri.AutoSize = true;
            this.rdbPeri.Location = new System.Drawing.Point(347, 46);
            this.rdbPeri.Name = "rdbPeri";
            this.rdbPeri.Size = new System.Drawing.Size(69, 17);
            this.rdbPeri.TabIndex = 7;
            this.rdbPeri.TabStop = true;
            this.rdbPeri.Text = "Periódico";
            this.rdbPeri.UseVisualStyleBackColor = true;
            this.rdbPeri.CheckedChanged += new System.EventHandler(this.rdbPeri_CheckedChanged);
            // 
            // mskDevolucao
            // 
            this.mskDevolucao.Location = new System.Drawing.Point(326, 74);
            this.mskDevolucao.Mask = "00/00/0000";
            this.mskDevolucao.Name = "mskDevolucao";
            this.mskDevolucao.Size = new System.Drawing.Size(73, 20);
            this.mskDevolucao.TabIndex = 6;
            // 
            // mskLocacao
            // 
            this.mskLocacao.Location = new System.Drawing.Point(108, 74);
            this.mskLocacao.Mask = "00/00/0000";
            this.mskLocacao.Name = "mskLocacao";
            this.mskLocacao.Size = new System.Drawing.Size(73, 20);
            this.mskLocacao.TabIndex = 5;
            // 
            // lblDevolucao
            // 
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.Location = new System.Drawing.Point(243, 77);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Size = new System.Drawing.Size(62, 13);
            this.lblDevolucao.TabIndex = 6;
            this.lblDevolucao.Text = "Devolução:";
            // 
            // lblLocacao
            // 
            this.lblLocacao.AutoSize = true;
            this.lblLocacao.Location = new System.Drawing.Point(23, 77);
            this.lblLocacao.Name = "lblLocacao";
            this.lblLocacao.Size = new System.Drawing.Size(52, 13);
            this.lblLocacao.TabIndex = 4;
            this.lblLocacao.Text = "Locação:";
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Location = new System.Drawing.Point(20, 48);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(82, 13);
            this.lblLivro.TabIndex = 3;
            this.lblLivro.Text = "Livro/Periódico:";
            // 
            // cmbLivro
            // 
            this.cmbLivro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLivro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLivro.FormattingEnabled = true;
            this.cmbLivro.Location = new System.Drawing.Point(108, 45);
            this.cmbLivro.Name = "cmbLivro";
            this.cmbLivro.Size = new System.Drawing.Size(233, 21);
            this.cmbLivro.TabIndex = 4;
            this.cmbLivro.SelectedIndexChanged += new System.EventHandler(this.cmbLivro_SelectedIndexChanged);
            // 
            // cmbLeitor
            // 
            this.cmbLeitor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLeitor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLeitor.FormattingEnabled = true;
            this.cmbLeitor.Location = new System.Drawing.Point(108, 18);
            this.cmbLeitor.Name = "cmbLeitor";
            this.cmbLeitor.Size = new System.Drawing.Size(233, 21);
            this.cmbLeitor.TabIndex = 3;
            this.cmbLeitor.SelectedIndexChanged += new System.EventHandler(this.cmbLeitor_SelectedIndexChanged);
            // 
            // lblLeitor
            // 
            this.lblLeitor.AutoSize = true;
            this.lblLeitor.Location = new System.Drawing.Point(20, 21);
            this.lblLeitor.Name = "lblLeitor";
            this.lblLeitor.Size = new System.Drawing.Size(36, 13);
            this.lblLeitor.TabIndex = 0;
            this.lblLeitor.Text = "Leitor:";
            // 
            // gpbLeitor
            // 
            this.gpbLeitor.Controls.Add(this.mskCel);
            this.gpbLeitor.Controls.Add(this.lblCelular);
            this.gpbLeitor.Controls.Add(this.mskCPF);
            this.gpbLeitor.Controls.Add(this.lblCPF);
            this.gpbLeitor.Controls.Add(this.txtNome);
            this.gpbLeitor.Controls.Add(this.lblNome);
            this.gpbLeitor.Enabled = false;
            this.gpbLeitor.Location = new System.Drawing.Point(12, 180);
            this.gpbLeitor.Name = "gpbLeitor";
            this.gpbLeitor.Size = new System.Drawing.Size(257, 100);
            this.gpbLeitor.TabIndex = 1;
            this.gpbLeitor.TabStop = false;
            this.gpbLeitor.Text = "Info. Leitor:";
            // 
            // mskCel
            // 
            this.mskCel.Location = new System.Drawing.Point(45, 66);
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(100, 20);
            this.mskCel.TabIndex = 22;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(7, 69);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(28, 13);
            this.lblCelular.TabIndex = 5;
            this.lblCelular.Text = "Cel.:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(45, 39);
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 21;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(6, 42);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(45, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(167, 20);
            this.txtNome.TabIndex = 20;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // gpbLivro
            // 
            this.gpbLivro.Controls.Add(this.cmbcate);
            this.gpbLivro.Controls.Add(this.lblCategoria);
            this.gpbLivro.Controls.Add(this.cmbauto);
            this.gpbLivro.Controls.Add(this.lblAutor);
            this.gpbLivro.Controls.Add(this.cmbtitulo);
            this.gpbLivro.Controls.Add(this.lblTitulo);
            this.gpbLivro.Enabled = false;
            this.gpbLivro.Location = new System.Drawing.Point(275, 180);
            this.gpbLivro.Name = "gpbLivro";
            this.gpbLivro.Size = new System.Drawing.Size(266, 100);
            this.gpbLivro.TabIndex = 2;
            this.gpbLivro.TabStop = false;
            this.gpbLivro.Text = "Info. Livro:";
            // 
            // cmbcate
            // 
            this.cmbcate.Location = new System.Drawing.Point(47, 66);
            this.cmbcate.Name = "cmbcate";
            this.cmbcate.Size = new System.Drawing.Size(165, 20);
            this.cmbcate.TabIndex = 26;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(3, 69);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(46, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Editora :";
            // 
            // cmbauto
            // 
            this.cmbauto.Location = new System.Drawing.Point(47, 39);
            this.cmbauto.Name = "cmbauto";
            this.cmbauto.Size = new System.Drawing.Size(165, 20);
            this.cmbauto.TabIndex = 25;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(6, 42);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor:";
            // 
            // cmbtitulo
            // 
            this.cmbtitulo.Location = new System.Drawing.Point(47, 13);
            this.cmbtitulo.Name = "cmbtitulo";
            this.cmbtitulo.Size = new System.Drawing.Size(165, 20);
            this.cmbtitulo.TabIndex = 23;
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
            // btnLocar
            // 
            this.btnLocar.Location = new System.Drawing.Point(255, 286);
            this.btnLocar.Name = "btnLocar";
            this.btnLocar.Size = new System.Drawing.Size(75, 23);
            this.btnLocar.TabIndex = 9;
            this.btnLocar.Text = "Locar";
            this.btnLocar.UseVisualStyleBackColor = true;
            this.btnLocar.Click += new System.EventHandler(this.btnLocar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(93, 286);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 286);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(174, 286);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gpbLocacaoDevolucao
            // 
            this.gpbLocacaoDevolucao.Controls.Add(this.rdbDevolver);
            this.gpbLocacaoDevolucao.Controls.Add(this.rdbLocar);
            this.gpbLocacaoDevolucao.Enabled = false;
            this.gpbLocacaoDevolucao.Location = new System.Drawing.Point(165, 12);
            this.gpbLocacaoDevolucao.Name = "gpbLocacaoDevolucao";
            this.gpbLocacaoDevolucao.Size = new System.Drawing.Size(151, 44);
            this.gpbLocacaoDevolucao.TabIndex = 7;
            this.gpbLocacaoDevolucao.TabStop = false;
            // 
            // rdbDevolver
            // 
            this.rdbDevolver.AutoSize = true;
            this.rdbDevolver.Location = new System.Drawing.Point(77, 19);
            this.rdbDevolver.Name = "rdbDevolver";
            this.rdbDevolver.Size = new System.Drawing.Size(68, 17);
            this.rdbDevolver.TabIndex = 2;
            this.rdbDevolver.TabStop = true;
            this.rdbDevolver.Text = "Devolver";
            this.rdbDevolver.UseVisualStyleBackColor = true;
            this.rdbDevolver.CheckedChanged += new System.EventHandler(this.rdbDevolver_CheckedChanged);
            // 
            // rdbLocar
            // 
            this.rdbLocar.AutoSize = true;
            this.rdbLocar.Location = new System.Drawing.Point(6, 19);
            this.rdbLocar.Name = "rdbLocar";
            this.rdbLocar.Size = new System.Drawing.Size(52, 17);
            this.rdbLocar.TabIndex = 2;
            this.rdbLocar.TabStop = true;
            this.rdbLocar.Text = "Locar";
            this.rdbLocar.UseVisualStyleBackColor = true;
            this.rdbLocar.CheckedChanged += new System.EventHandler(this.rdbLocar_CheckedChanged);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(336, 286);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 10;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // locaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 315);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.gpbLocacaoDevolucao);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLocar);
            this.Controls.Add(this.gpbLivro);
            this.Controls.Add(this.gpbLeitor);
            this.Controls.Add(this.gpbLocacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "locaLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação de Livro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.locaLivro_FormClosed);
            this.Load += new System.EventHandler(this.locaLivro_Load);
            this.gpbLocacao.ResumeLayout(false);
            this.gpbLocacao.PerformLayout();
            this.gpbLeitor.ResumeLayout(false);
            this.gpbLeitor.PerformLayout();
            this.gpbLivro.ResumeLayout(false);
            this.gpbLivro.PerformLayout();
            this.gpbLocacaoDevolucao.ResumeLayout(false);
            this.gpbLocacaoDevolucao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.Label lblLeitor;
        private System.Windows.Forms.Label lblDevolucao;
        private System.Windows.Forms.Label lblLocacao;
        private System.Windows.Forms.GroupBox gpbLeitor;
        private System.Windows.Forms.MaskedTextBox mskCel;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbLivro;
        private System.Windows.Forms.TextBox cmbcate;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox cmbauto;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox cmbtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLocar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton rdbLocar;
        private System.Windows.Forms.Button btnDevolver;
        public System.Windows.Forms.ComboBox cmbLivro;
        public System.Windows.Forms.ComboBox cmbLeitor;
        public System.Windows.Forms.MaskedTextBox mskDevolucao;
        public System.Windows.Forms.MaskedTextBox mskLocacao;
        public System.Windows.Forms.MaskedTextBox mskCPF;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.RadioButton rdbDevolver;
        public System.Windows.Forms.GroupBox gpbLocacao;
        public System.Windows.Forms.GroupBox gpbLocacaoDevolucao;
        public System.Windows.Forms.RadioButton rdbPeri;
        public System.Windows.Forms.RadioButton rdbLivro;
    }
}