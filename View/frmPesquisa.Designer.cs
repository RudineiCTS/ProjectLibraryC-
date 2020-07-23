namespace PMBIBLIO
{
    partial class frmPesquisa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisa));
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.rdbLeitor = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCpf = new System.Windows.Forms.RadioButton();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mskPCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnDesfiltro = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.gpbFiltro.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(12, 126);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.Size = new System.Drawing.Size(776, 248);
            this.dgvPesquisa.TabIndex = 2;
            this.dgvPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisa_CellDoubleClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(55, 43);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(276, 20);
            this.txtPesquisa.TabIndex = 4;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(650, 15);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(85, 30);
            this.btnFiltro.TabIndex = 5;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // rdbLeitor
            // 
            this.rdbLeitor.AutoSize = true;
            this.rdbLeitor.Location = new System.Drawing.Point(57, 20);
            this.rdbLeitor.Name = "rdbLeitor";
            this.rdbLeitor.Size = new System.Drawing.Size(102, 17);
            this.rdbLeitor.TabIndex = 6;
            this.rdbLeitor.TabStop = true;
            this.rdbLeitor.Text = "Código do Leitor";
            this.rdbLeitor.UseVisualStyleBackColor = true;
            this.rdbLeitor.CheckedChanged += new System.EventHandler(this.rdbCliente_CheckedChanged);
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(57, 43);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(97, 17);
            this.rdbNome.TabIndex = 7;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome do Leitor";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // rdbCpf
            // 
            this.rdbCpf.AutoSize = true;
            this.rdbCpf.Location = new System.Drawing.Point(57, 66);
            this.rdbCpf.Name = "rdbCpf";
            this.rdbCpf.Size = new System.Drawing.Size(89, 17);
            this.rdbCpf.TabIndex = 8;
            this.rdbCpf.TabStop = true;
            this.rdbCpf.Text = "CPF do Leitor";
            this.rdbCpf.UseVisualStyleBackColor = true;
            this.rdbCpf.CheckedChanged += new System.EventHandler(this.rdbCpf_CheckedChanged);
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.rdbNome);
            this.gpbFiltro.Controls.Add(this.rdbCpf);
            this.gpbFiltro.Controls.Add(this.rdbLeitor);
            this.gpbFiltro.Location = new System.Drawing.Point(12, 2);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(239, 95);
            this.gpbFiltro.TabIndex = 9;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro";
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.lblCPF);
            this.gpbPesquisa.Controls.Add(this.mskPCpf);
            this.gpbPesquisa.Controls.Add(this.lblCódigo);
            this.gpbPesquisa.Controls.Add(this.txtCod);
            this.gpbPesquisa.Controls.Add(this.lblNome);
            this.gpbPesquisa.Controls.Add(this.txtPesquisa);
            this.gpbPesquisa.Location = new System.Drawing.Point(268, 2);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(345, 95);
            this.gpbPesquisa.TabIndex = 10;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(6, 68);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 9;
            this.lblCPF.Text = "CPF:";
            // 
            // mskPCpf
            // 
            this.mskPCpf.Location = new System.Drawing.Point(55, 65);
            this.mskPCpf.Mask = "000,000,000-00";
            this.mskPCpf.Name = "mskPCpf";
            this.mskPCpf.Size = new System.Drawing.Size(84, 20);
            this.mskPCpf.TabIndex = 8;
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Location = new System.Drawing.Point(6, 22);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(43, 13);
            this.lblCódigo.TabIndex = 7;
            this.lblCódigo.Text = "Código:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(55, 19);
            this.txtCod.MaxLength = 5;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(54, 20);
            this.txtCod.TabIndex = 6;
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // btnDesfiltro
            // 
            this.btnDesfiltro.Enabled = false;
            this.btnDesfiltro.Location = new System.Drawing.Point(650, 61);
            this.btnDesfiltro.Name = "btnDesfiltro";
            this.btnDesfiltro.Size = new System.Drawing.Size(85, 31);
            this.btnDesfiltro.TabIndex = 11;
            this.btnDesfiltro.Text = "Apagar Filtro";
            this.btnDesfiltro.UseVisualStyleBackColor = true;
            this.btnDesfiltro.Click += new System.EventHandler(this.btnDesfiltro_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(13, 110);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(291, 13);
            this.lblInformation.TabIndex = 12;
            this.lblInformation.Text = "Clique duas vezes sobre uma linha para selecionar o cliente ";
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnDesfiltro);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.gpbFiltro);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.dgvPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Leitores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPesquisa_FormClosed);
            this.Load += new System.EventHandler(this.frmPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.RadioButton rdbLeitor;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCpf;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mskPCpf;
        private System.Windows.Forms.Button btnDesfiltro;
        private System.Windows.Forms.Label lblInformation;
    }
}