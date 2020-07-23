using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMBIBLIO
{
    public partial class frmMenu : Form 
    {
        public static frmMenu Self;

        public frmMenu()
        {
            InitializeComponent();
            Self = this;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            cadCliente novoCliente = new cadCliente("");
            this.Visible = false;
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cadLivro novoLivro = new cadLivro(null);
            
        }

        private void btnLocar_Click(object sender, EventArgs e)
        {
            locaLivro locaLivro = new locaLivro();
            this.Visible = false;
        }

        private void btnPeriodicos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cadPeriodicos novoPeriodico = new cadPeriodicos(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHisto hostorico = new frmHisto();
            this.Visible = false;
        }
    }
}