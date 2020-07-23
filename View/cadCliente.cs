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
    public partial class cadCliente : Form
    {
        public cadCliente(string valid)
        {
            InitializeComponent();
            this.Visible = true;
            if (valid == "")
            {
                btnEdit.Enabled = false;
                btnExcluir.Enabled = false;

            }
            else
            {
                textPOG.Text = valid;
                gpbCadastro.Enabled = true;
                btnEdit.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            gpbCadastro.Enabled = true;
            btnEdit.Enabled = false;
            btnExcluir.Enabled = false;
            limpaTexto();
        }

        private void limpaTexto()
        {
            foreach (Control ctl in gpbCadastro.Controls)
            {
                if (ctl is GroupBox)
                {
                    foreach (Control ctl2 in ctl.Controls)
                    {
                        if (ctl2 is TextBox)
                        {
                            ctl2.Text = string.Empty;
                        }
                        if (ctl2 is MaskedTextBox)
                        {
                            ctl2.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaTexto();
        }

        private void cadCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsControl.abreMenu(frmMenu.Self);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPesquisa pesquisa = new frmPesquisa();
            pesquisa.Visible = true;
            this.Dispose();

        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //criando variavel somente com caracters para validação de cpf
            mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = mskCPF.Text;
            mskCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            //criando variavel somente com caracters para validação de rg
            mskRG.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string rg = mskRG.Text;
            mskRG.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            //criando variavel somente com caracters para validação de celular
            mskCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string celular = mskCelular.Text;
            mskCelular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            // criando variavel somente com caracters para validaçõa de fone
            mskTel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string telefone = mskTel.Text;
            mskTel.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            bool flagTel = false;
            bool flagCel = false;
            if (celular != "" || celular.Length >= 11)
                flagCel = true;
            if (telefone != "" || telefone.Length >= 10)
                flagTel = true;
            // validação de todos os campos 
            if (txtNome.Text == "")
                MessageBox.Show("Digite um nome");
            else if (txtEmail.Text == "")
                MessageBox.Show("Digite um email válido!");
            else if (cpf == "" || cpf.Length < 11)
                MessageBox.Show("Digite um CPF válido!");
            else if (rg == "" || rg.Length < 9)
                MessageBox.Show("Digite um rg válido");
            else if (flagCel || flagTel)
            {
                if (txtRua.Text == "")
                    MessageBox.Show("Preencha todos os campos do grupo endereço");
                else if (txtCidade.Text == "")
                    MessageBox.Show("Preencha todos os campos do grupo endereço");
                else if (txtBairro.Text == "")
                    MessageBox.Show("Preencha todos os campos do grupo endereço");
                else if (txtNo.Text == "")
                    MessageBox.Show("Preencha todos os campos do grupo endereço");
                else
                {
                    DateTime nascimento = Convert.ToDateTime("31/12/6666");
                    try
                    {
                        nascimento = Convert.ToDateTime(mskNascimento.Text);
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Digite uma data de nascimento válida!");
                    }
                    if (nascimento.Year != 6666)
                    {
                        clsCadastro cad = new clsCadastro();
                        cad.salvarCliente(txtNome.Text, txtRua.Text + ", " + txtBairro.Text + ", " + txtNo.Text, txtCidade.Text,
                        mskTel.Text, mskCelular.Text, txtEmail.Text, mskCPF.Text, mskRG.Text, Convert.ToString(nascimento.ToString("yyyy-MM-dd")));
                        MessageBox.Show(cad.mensagem);
                        limpaTexto();
                        gpbCadastro.Enabled = false;
                        btnNovo.Enabled = true;
                    }
                }
            }
            else
                MessageBox.Show("Digite um numero de celular/telefone válido");

        }


        private void txtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int valor = Convert.ToInt32(textPOG.Text);
            DateTime nascimento = Convert.ToDateTime("31/12/6666");
            try
            {
                nascimento = Convert.ToDateTime(mskNascimento.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Digite uma data de nascimento válida!");
            }
            if (nascimento.Year != 6666)
            {
                clsCadastro cad = new clsCadastro();
                cad.editar(valor, txtNome.Text, txtRua.Text + ", " + txtBairro.Text + ", " + txtNo.Text, txtCidade.Text,
                mskTel.Text, mskCelular.Text, txtEmail.Text, mskCPF.Text, mskRG.Text, Convert.ToString(nascimento.ToString("yyyy-MM-dd")));
                MessageBox.Show(cad.mensagem);
                limpaTexto();
                gpbCadastro.Enabled = false;
                btnNovo.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (textPOG.Text == "")
            {
                MessageBox.Show("Primeiro selecione um cliente para excluir!");
            }
            else
            {
                clsCadastro cad = new clsCadastro();
                cad.excluir(Convert.ToInt32(textPOG.Text));
                MessageBox.Show(cad.mensagem);
                limpaTexto();
                gpbCadastro.Enabled = false;
                btnNovo.Enabled = true;
            }

        }
    }
}

