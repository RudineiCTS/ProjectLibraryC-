namespace PMBIBLIO
{
    partial class FrmPesquisaPeri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaPeri));
            this.dgvPeri = new System.Windows.Forms.DataGridView();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.rdbEditora = new System.Windows.Forms.RadioButton();
            this.rdbAutor = new System.Windows.Forms.RadioButton();
            this.rdbMaterial = new System.Windows.Forms.RadioButton();
            this.rdbTitulo = new System.Windows.Forms.RadioButton();
            this.gpbPesquisas = new System.Windows.Forms.GroupBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnDesfiltro = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeri)).BeginInit();
            this.gpbFiltro.SuspendLayout();
            this.gpbPesquisas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPeri
            // 
            this.dgvPeri.AllowUserToAddRows = false;
            this.dgvPeri.AllowUserToDeleteRows = false;
            this.dgvPeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeri.Location = new System.Drawing.Point(12, 164);
            this.dgvPeri.Name = "dgvPeri";
            this.dgvPeri.ReadOnly = true;
            this.dgvPeri.Size = new System.Drawing.Size(776, 287);
            this.dgvPeri.TabIndex = 0;
            this.dgvPeri.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPeri_CellMouseDoubleClick);
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.rdbEditora);
            this.gpbFiltro.Controls.Add(this.rdbAutor);
            this.gpbFiltro.Controls.Add(this.rdbMaterial);
            this.gpbFiltro.Controls.Add(this.rdbTitulo);
            this.gpbFiltro.Location = new System.Drawing.Point(13, 13);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(264, 132);
            this.gpbFiltro.TabIndex = 1;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro";
            // 
            // rdbEditora
            // 
            this.rdbEditora.AutoSize = true;
            this.rdbEditora.Location = new System.Drawing.Point(21, 100);
            this.rdbEditora.Name = "rdbEditora";
            this.rdbEditora.Size = new System.Drawing.Size(58, 17);
            this.rdbEditora.TabIndex = 3;
            this.rdbEditora.TabStop = true;
            this.rdbEditora.Text = "Editora";
            this.rdbEditora.UseVisualStyleBackColor = true;
            this.rdbEditora.CheckedChanged += new System.EventHandler(this.rdbEditora_CheckedChanged);
            // 
            // rdbAutor
            // 
            this.rdbAutor.AutoSize = true;
            this.rdbAutor.Location = new System.Drawing.Point(21, 76);
            this.rdbAutor.Name = "rdbAutor";
            this.rdbAutor.Size = new System.Drawing.Size(50, 17);
            this.rdbAutor.TabIndex = 2;
            this.rdbAutor.TabStop = true;
            this.rdbAutor.Text = "Autor";
            this.rdbAutor.UseVisualStyleBackColor = true;
            this.rdbAutor.CheckedChanged += new System.EventHandler(this.rdbAutor_CheckedChanged);
            // 
            // rdbMaterial
            // 
            this.rdbMaterial.AutoSize = true;
            this.rdbMaterial.Location = new System.Drawing.Point(21, 50);
            this.rdbMaterial.Name = "rdbMaterial";
            this.rdbMaterial.Size = new System.Drawing.Size(62, 17);
            this.rdbMaterial.TabIndex = 1;
            this.rdbMaterial.TabStop = true;
            this.rdbMaterial.Text = "Material";
            this.rdbMaterial.UseVisualStyleBackColor = true;
            this.rdbMaterial.CheckedChanged += new System.EventHandler(this.rdbMaterial_CheckedChanged);
            // 
            // rdbTitulo
            // 
            this.rdbTitulo.AutoSize = true;
            this.rdbTitulo.Location = new System.Drawing.Point(21, 22);
            this.rdbTitulo.Name = "rdbTitulo";
            this.rdbTitulo.Size = new System.Drawing.Size(113, 17);
            this.rdbTitulo.TabIndex = 0;
            this.rdbTitulo.TabStop = true;
            this.rdbTitulo.Text = "Titulo do Periódico";
            this.rdbTitulo.UseVisualStyleBackColor = true;
            this.rdbTitulo.CheckedChanged += new System.EventHandler(this.rdbTitulo_CheckedChanged);
            // 
            // gpbPesquisas
            // 
            this.gpbPesquisas.Controls.Add(this.txtEditora);
            this.gpbPesquisas.Controls.Add(this.txtAutor);
            this.gpbPesquisas.Controls.Add(this.txtMaterial);
            this.gpbPesquisas.Controls.Add(this.txtTitulo);
            this.gpbPesquisas.Controls.Add(this.label4);
            this.gpbPesquisas.Controls.Add(this.label3);
            this.gpbPesquisas.Controls.Add(this.label2);
            this.gpbPesquisas.Controls.Add(this.label1);
            this.gpbPesquisas.Location = new System.Drawing.Point(283, 13);
            this.gpbPesquisas.Name = "gpbPesquisas";
            this.gpbPesquisas.Size = new System.Drawing.Size(333, 132);
            this.gpbPesquisas.TabIndex = 2;
            this.gpbPesquisas.TabStop = false;
            this.gpbPesquisas.Text = "Pesquisar";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(63, 97);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(247, 20);
            this.txtEditora.TabIndex = 7;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(63, 69);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(247, 20);
            this.txtAutor.TabIndex = 6;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(63, 43);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(247, 20);
            this.txtMaterial.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(63, 17);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(247, 20);
            this.txtTitulo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editora :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Material :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo :";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(650, 20);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(109, 47);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Text = "Filtro";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnDesfiltro
            // 
            this.btnDesfiltro.Enabled = false;
            this.btnDesfiltro.Location = new System.Drawing.Point(650, 89);
            this.btnDesfiltro.Name = "btnDesfiltro";
            this.btnDesfiltro.Size = new System.Drawing.Size(109, 47);
            this.btnDesfiltro.TabIndex = 4;
            this.btnDesfiltro.Text = "Apagar Filtro";
            this.btnDesfiltro.UseVisualStyleBackColor = true;
            this.btnDesfiltro.Click += new System.EventHandler(this.btnDesfiltro_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(10, 148);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(347, 13);
            this.lblInformation.TabIndex = 15;
            this.lblInformation.Text = "Clique duas vezes sobre uma linha para selecionar os dados da locação";
            // 
            // FrmPesquisaPeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnDesfiltro);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.gpbPesquisas);
            this.Controls.Add(this.gpbFiltro);
            this.Controls.Add(this.dgvPeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPesquisaPeri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisaPeriódicos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPesquisaPeri_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeri)).EndInit();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.gpbPesquisas.ResumeLayout(false);
            this.gpbPesquisas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.GroupBox gpbPesquisas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbAutor;
        private System.Windows.Forms.RadioButton rdbMaterial;
        private System.Windows.Forms.RadioButton rdbTitulo;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnDesfiltro;
        private System.Windows.Forms.RadioButton rdbEditora;
        public System.Windows.Forms.DataGridView dgvPeri;
        private System.Windows.Forms.Label lblInformation;
    }
}