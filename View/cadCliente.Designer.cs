namespace PMBIBLIO
{
    partial class cadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadCliente));
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbCadastro = new System.Windows.Forms.GroupBox();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.lblCel = new System.Windows.Forms.Label();
            this.mskNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskRG = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.textPOG = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gpbCadastro.SuspendLayout();
            this.gpbInfo.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // gpbCadastro
            // 
            this.gpbCadastro.Controls.Add(this.gpbInfo);
            this.gpbCadastro.Controls.Add(this.gpbEndereco);
            this.gpbCadastro.Enabled = false;
            this.gpbCadastro.Location = new System.Drawing.Point(12, 12);
            this.gpbCadastro.Name = "gpbCadastro";
            this.gpbCadastro.Size = new System.Drawing.Size(480, 271);
            this.gpbCadastro.TabIndex = 1;
            this.gpbCadastro.TabStop = false;
            this.gpbCadastro.Text = "Cadastro:";
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.lblCel);
            this.gpbInfo.Controls.Add(this.mskNascimento);
            this.gpbInfo.Controls.Add(this.lblNascimento);
            this.gpbInfo.Controls.Add(this.mskCelular);
            this.gpbInfo.Controls.Add(this.lblTel);
            this.gpbInfo.Controls.Add(this.mskTel);
            this.gpbInfo.Controls.Add(this.lblNome);
            this.gpbInfo.Controls.Add(this.txtNome);
            this.gpbInfo.Controls.Add(this.lblEmail);
            this.gpbInfo.Controls.Add(this.lblRG);
            this.gpbInfo.Controls.Add(this.txtEmail);
            this.gpbInfo.Controls.Add(this.mskRG);
            this.gpbInfo.Controls.Add(this.mskCPF);
            this.gpbInfo.Controls.Add(this.lblCPF);
            this.gpbInfo.Location = new System.Drawing.Point(9, 19);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(448, 122);
            this.gpbInfo.TabIndex = 2;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Info. Cliente:";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(8, 97);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(42, 13);
            this.lblCel.TabIndex = 16;
            this.lblCel.Text = "Celular:";
            // 
            // mskNascimento
            // 
            this.mskNascimento.Location = new System.Drawing.Point(363, 65);
            this.mskNascimento.Mask = "00/00/0000";
            this.mskNascimento.Name = "mskNascimento";
            this.mskNascimento.Size = new System.Drawing.Size(71, 20);
            this.mskNascimento.TabIndex = 11;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(292, 68);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(66, 13);
            this.lblNascimento.TabIndex = 12;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(56, 94);
            this.mskCelular.Mask = "(00)00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(78, 20);
            this.mskCelular.TabIndex = 15;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(145, 97);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 14;
            this.lblTel.Text = "Telefone:";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(203, 94);
            this.mskTel.Mask = "(00)0000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(74, 20);
            this.mskTel.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 13);
            this.txtNome.MaxLength = 75;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(386, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 42);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(171, 68);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 10;
            this.lblRG.Text = "RG:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 39);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // mskRG
            // 
            this.mskRG.Location = new System.Drawing.Point(203, 65);
            this.mskRG.Mask = "00,000,000-A";
            this.mskRG.Name = "mskRG";
            this.mskRG.Size = new System.Drawing.Size(74, 20);
            this.mskRG.TabIndex = 9;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(50, 65);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(84, 20);
            this.mskCPF.TabIndex = 7;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(6, 68);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF:";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.textPOG);
            this.gpbEndereco.Controls.Add(this.lblCidade);
            this.gpbEndereco.Controls.Add(this.txtCidade);
            this.gpbEndereco.Controls.Add(this.lblNo);
            this.gpbEndereco.Controls.Add(this.txtNo);
            this.gpbEndereco.Controls.Add(this.lblBairro);
            this.gpbEndereco.Controls.Add(this.txtBairro);
            this.gpbEndereco.Controls.Add(this.lblRua);
            this.gpbEndereco.Controls.Add(this.txtRua);
            this.gpbEndereco.Location = new System.Drawing.Point(9, 147);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(448, 106);
            this.gpbEndereco.TabIndex = 4;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço:";
            // 
            // textPOG
            // 
            this.textPOG.Location = new System.Drawing.Point(396, 81);
            this.textPOG.MaxLength = 75;
            this.textPOG.Name = "textPOG";
            this.textPOG.Size = new System.Drawing.Size(35, 20);
            this.textPOG.TabIndex = 10;
            this.textPOG.Visible = false;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(7, 81);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 9;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(56, 78);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(221, 20);
            this.txtCidade.TabIndex = 8;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(360, 28);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(22, 13);
            this.lblNo.TabIndex = 7;
            this.lblNo.Text = "Nº:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(388, 25);
            this.txtNo.MaxLength = 4;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(48, 20);
            this.txtNo.TabIndex = 6;
            this.txtNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNo_KeyPress);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(7, 55);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 5;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(56, 52);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(221, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(6, 28);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 3;
            this.lblRua.Text = "Rua:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(56, 25);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(295, 20);
            this.txtRua.TabIndex = 2;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 289);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(93, 289);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(174, 289);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(255, 289);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 5;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(336, 289);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(417, 289);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 321);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gpbCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cadCliente_FormClosed);
            this.gpbCadastro.ResumeLayout(false);
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisa;
        public System.Windows.Forms.GroupBox gpbCadastro;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.Label lblRG;
        public System.Windows.Forms.MaskedTextBox mskRG;
        public System.Windows.Forms.Label lblCPF;
        public System.Windows.Forms.MaskedTextBox mskCPF;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.GroupBox gpbEndereco;
        public System.Windows.Forms.TextBox txtNo;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtRua;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.GroupBox gpbInfo;
        public System.Windows.Forms.Label lblCel;
        public System.Windows.Forms.MaskedTextBox mskCelular;
        public System.Windows.Forms.Label lblTel;
        public System.Windows.Forms.MaskedTextBox mskTel;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.Label lblNascimento;
        public System.Windows.Forms.MaskedTextBox mskNascimento;
        public System.Windows.Forms.TextBox textPOG;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExcluir;
    }
}