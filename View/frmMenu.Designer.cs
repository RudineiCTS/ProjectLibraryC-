namespace PMBIBLIO
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPeriodicos = new System.Windows.Forms.Button();
            this.btnLocar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.gpbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMenu
            // 
            this.gpbMenu.BackColor = System.Drawing.Color.White;
            this.gpbMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gpbMenu.BackgroundImage")));
            this.gpbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gpbMenu.Controls.Add(this.lblCreditos);
            this.gpbMenu.Controls.Add(this.button1);
            this.gpbMenu.Controls.Add(this.btnPeriodicos);
            this.gpbMenu.Controls.Add(this.btnLocar);
            this.gpbMenu.Controls.Add(this.btnCadastro);
            this.gpbMenu.Controls.Add(this.btnLivro);
            this.gpbMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbMenu.Location = new System.Drawing.Point(12, 12);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(759, 479);
            this.gpbMenu.TabIndex = 5;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "PMBIBLIO";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(627, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 108);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPeriodicos
            // 
            this.btnPeriodicos.BackColor = System.Drawing.Color.White;
            this.btnPeriodicos.BackgroundImage = global::PMBIBLIO.Properties.Resources.dale2;
            this.btnPeriodicos.Location = new System.Drawing.Point(322, 19);
            this.btnPeriodicos.Name = "btnPeriodicos";
            this.btnPeriodicos.Size = new System.Drawing.Size(126, 108);
            this.btnPeriodicos.TabIndex = 2;
            this.btnPeriodicos.UseVisualStyleBackColor = false;
            this.btnPeriodicos.Click += new System.EventHandler(this.btnPeriodicos_Click);
            // 
            // btnLocar
            // 
            this.btnLocar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocar.BackgroundImage")));
            this.btnLocar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocar.Location = new System.Drawing.Point(474, 19);
            this.btnLocar.Name = "btnLocar";
            this.btnLocar.Size = new System.Drawing.Size(126, 108);
            this.btnLocar.TabIndex = 3;
            this.btnLocar.Text = "\r\n";
            this.btnLocar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLocar.UseVisualStyleBackColor = true;
            this.btnLocar.Click += new System.EventHandler(this.btnLocar_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastro.BackgroundImage")));
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastro.Location = new System.Drawing.Point(6, 19);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(126, 108);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLivro.BackgroundImage")));
            this.btnLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLivro.Location = new System.Drawing.Point(168, 19);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(126, 108);
            this.btnLivro.TabIndex = 1;
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditos.Location = new System.Drawing.Point(1, 465);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(365, 12);
            this.lblCreditos.TabIndex = 6;
            this.lblCreditos.Text = "Desenvolvido por: Rudinei Augusto Costa Ferreira e Otávio Miguel Salvador Gonçalv" +
    "es";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 493);
            this.Controls.Add(this.gpbMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.gpbMenu.ResumeLayout(false);
            this.gpbMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.Button btnLocar;
        private System.Windows.Forms.Button btnPeriodicos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCreditos;
    }
}