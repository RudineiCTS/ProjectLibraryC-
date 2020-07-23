namespace PMBIBLIO
{
    partial class cadPeriodicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadPeriodicos));
            this.gpbPeriodico = new System.Windows.Forms.GroupBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAutor = new System.Windows.Forms.Label();
            this.cbAutorP = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cbEditoraP = new System.Windows.Forms.ComboBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.cbAssinatura = new System.Windows.Forms.ComboBox();
            this.lblAssinatura = new System.Windows.Forms.Label();
            this.txtPeriodico = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.chkEmprestimo = new System.Windows.Forms.CheckBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gpbPeriodico.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPeriodico
            // 
            this.gpbPeriodico.BackColor = System.Drawing.SystemColors.Control;
            this.gpbPeriodico.Controls.Add(this.textID);
            this.gpbPeriodico.Controls.Add(this.txtMaterial);
            this.gpbPeriodico.Controls.Add(this.btnAdd);
            this.gpbPeriodico.Controls.Add(this.lblAutor);
            this.gpbPeriodico.Controls.Add(this.cbAutorP);
            this.gpbPeriodico.Controls.Add(this.lblMaterial);
            this.gpbPeriodico.Controls.Add(this.cbEditoraP);
            this.gpbPeriodico.Controls.Add(this.lblEditora);
            this.gpbPeriodico.Controls.Add(this.cbAssinatura);
            this.gpbPeriodico.Controls.Add(this.lblAssinatura);
            this.gpbPeriodico.Controls.Add(this.txtPeriodico);
            this.gpbPeriodico.Controls.Add(this.lblTitulo);
            this.gpbPeriodico.Controls.Add(this.chkEmprestimo);
            this.gpbPeriodico.Enabled = false;
            this.gpbPeriodico.Location = new System.Drawing.Point(12, 12);
            this.gpbPeriodico.Name = "gpbPeriodico";
            this.gpbPeriodico.Size = new System.Drawing.Size(492, 182);
            this.gpbPeriodico.TabIndex = 0;
            this.gpbPeriodico.TabStop = false;
            this.gpbPeriodico.Text = "Info. Periódicos:";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(386, 73);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(84, 20);
            this.textID.TabIndex = 18;
            this.textID.Visible = false;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(69, 48);
            this.txtMaterial.MaxLength = 80;
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(188, 20);
            this.txtMaterial.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "**";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(4, 129);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(38, 13);
            this.lblAutor.TabIndex = 15;
            this.lblAutor.Text = "Autor :";
            // 
            // cbAutorP
            // 
            this.cbAutorP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutorP.FormattingEnabled = true;
            this.cbAutorP.Location = new System.Drawing.Point(69, 126);
            this.cbAutorP.Name = "cbAutorP";
            this.cbAutorP.Size = new System.Drawing.Size(145, 21);
            this.cbAutorP.TabIndex = 5;
            this.cbAutorP.SelectedIndexChanged += new System.EventHandler(this.cbAutorP_SelectedIndexChanged);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(4, 48);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(47, 13);
            this.lblMaterial.TabIndex = 12;
            this.lblMaterial.Text = "Material:";
            // 
            // cbEditoraP
            // 
            this.cbEditoraP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditoraP.FormattingEnabled = true;
            this.cbEditoraP.Location = new System.Drawing.Point(69, 72);
            this.cbEditoraP.Name = "cbEditoraP";
            this.cbEditoraP.Size = new System.Drawing.Size(145, 21);
            this.cbEditoraP.TabIndex = 3;
            this.cbEditoraP.SelectedIndexChanged += new System.EventHandler(this.cbAquisicao_SelectedIndexChanged);
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(4, 75);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(46, 13);
            this.lblEditora.TabIndex = 10;
            this.lblEditora.Text = "Editora :";
            // 
            // cbAssinatura
            // 
            this.cbAssinatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssinatura.FormattingEnabled = true;
            this.cbAssinatura.Location = new System.Drawing.Point(69, 99);
            this.cbAssinatura.Name = "cbAssinatura";
            this.cbAssinatura.Size = new System.Drawing.Size(145, 21);
            this.cbAssinatura.TabIndex = 4;
            // 
            // lblAssinatura
            // 
            this.lblAssinatura.AutoSize = true;
            this.lblAssinatura.Location = new System.Drawing.Point(4, 102);
            this.lblAssinatura.Name = "lblAssinatura";
            this.lblAssinatura.Size = new System.Drawing.Size(59, 13);
            this.lblAssinatura.TabIndex = 4;
            this.lblAssinatura.Text = "Assinatura:";
            // 
            // txtPeriodico
            // 
            this.txtPeriodico.Location = new System.Drawing.Point(69, 19);
            this.txtPeriodico.MaxLength = 80;
            this.txtPeriodico.Name = "txtPeriodico";
            this.txtPeriodico.Size = new System.Drawing.Size(293, 20);
            this.txtPeriodico.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(4, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título:";
            // 
            // chkEmprestimo
            // 
            this.chkEmprestimo.AutoSize = true;
            this.chkEmprestimo.Location = new System.Drawing.Point(390, 21);
            this.chkEmprestimo.Name = "chkEmprestimo";
            this.chkEmprestimo.Size = new System.Drawing.Size(80, 17);
            this.chkEmprestimo.TabIndex = 0;
            this.chkEmprestimo.Text = "Empréstimo";
            this.chkEmprestimo.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 200);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(93, 200);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(174, 200);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(255, 200);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(336, 200);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(417, 200);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cadPeriodicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(519, 234);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gpbPeriodico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadPeriodicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Periódicos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cadPeriodicos_FormClosed);
            this.Load += new System.EventHandler(this.cadPeriodicos_Load);
            this.gpbPeriodico.ResumeLayout(false);
            this.gpbPeriodico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPeriodico;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAssinatura;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtPeriodico;
        public System.Windows.Forms.ComboBox cbAssinatura;
        public System.Windows.Forms.ComboBox cbEditoraP;
        public System.Windows.Forms.ComboBox cbAutorP;
        public System.Windows.Forms.TextBox txtMaterial;
        public System.Windows.Forms.TextBox textID;
        public System.Windows.Forms.CheckBox chkEmprestimo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
    }
}