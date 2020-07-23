using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMBIBLIO
{
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();

            txtPesquisa.Enabled = false;
            mskPCpf.Enabled = false;
            txtCod.Enabled = false;
        }

        private void frmPesquisa_FormClosed(object sender, FormClosedEventArgs e)
        {
            cadCliente clienteNovo = new cadCliente("");
            clienteNovo.Visible = true;
            this.Dispose();
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            dataFill();
            cabecalho();
        }

        private void dataFill()
        {
            clsConexão conexao = new clsConexão();

            try
            {
                // preenchendo tabela com os dados do banco 
                SqlDataAdapter dataAdp = new SqlDataAdapter("SELECT ID_CLIENTE[Código], NOME[Nome], ENDERECO[Endereço], CIDADE[Cidade], FONE[Telefone], CELULAR[Celular],EMAIL[E-mail], CPF_CLIENTE[CPF], RG_CLIENTE[RG], DATA_NASC[Nascimento] FROM CLIENTE", conexao.conectar());
                DataTable tabelaDados = new DataTable();
                dataAdp.Fill(tabelaDados);
                dgvPesquisa.DataSource = tabelaDados;
            }
            catch
            {
                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void rdbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLeitor.Checked == true)
            {
                txtPesquisa.Enabled = false;
                mskPCpf.Enabled = false;
                txtCod.Enabled = true;
                limpaGpb();
            }
        }

        private void cabecalho()
        {
            dgvPesquisa.Columns[0].Width = 45;
            dgvPesquisa.Columns[1].Width = 115;
            dgvPesquisa.Columns[2].Width = 140;
            dgvPesquisa.Columns[3].Width = 75;
            dgvPesquisa.Columns[4].Width = 85;
            dgvPesquisa.Columns[5].Width = 90;
            dgvPesquisa.Columns[6].Width = 140;
            dgvPesquisa.Columns[7].Width = 95;
            dgvPesquisa.Columns[8].Width = 75;
            dgvPesquisa.Columns[9].Width = 80;
        }

        private void pesquisaCod(string cod)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();
            try
            {
                // preenchendo tabela com os dados do banco 
                sqlB.Append("SELECT ID_CLIENTE[Código], NOME[Nome], ENDERECO[Endereço], CIDADE[Cidade], FONE[Telefone], CELULAR[Celular],EMAIL[E-mail], CPF_CLIENTE[CPF], RG_CLIENTE[RG], DATA_NASC[Nascimento] FROM CLIENTE WHERE ID_CLIENTE like @cod ");
                cmd.Parameters.Add(new SqlParameter("@cod", cod +'%'));
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPesquisa.DataSource = tabelaDados;
                conexao.desconectar();
            }
            catch
            {
                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNome.Checked == true)
            {
                txtPesquisa.Enabled = true;
                mskPCpf.Enabled = false;
                txtCod.Enabled = false;
                limpaGpb();
            }
        }

        private void rdbCpf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCpf.Checked == true)
            {
                txtPesquisa.Enabled = false;
                mskPCpf.Enabled = true;
                txtCod.Enabled = false;
                limpaGpb();
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
        
            if(rdbLeitor.Checked == true)
            {
                pesquisaCod(txtCod.Text);
                btnDesfiltro.Enabled = true;
            }
            else if (rdbNome.Checked == true)
            {
                pesquisaNome(txtPesquisa.Text);
                btnDesfiltro.Enabled = true;
            }
            else
            {
                mskPCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cpf = mskPCpf.Text;
                mskPCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                pesquisaCpf(cpf);
                btnDesfiltro.Enabled = true;
            }
        }
        private void limpaGpb()
        {
            foreach (Control ctl2 in gpbPesquisa.Controls)
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
        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void pesquisaNome(string nome)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();

            try
            {
                sqlB.Append ("SELECT ID_CLIENTE[Código], NOME[Nome], ENDERECO[Endereço], CIDADE[Cidade], FONE[Telefone], CELULAR[Celular],EMAIL[E-mail], CPF_CLIENTE[CPF], RG_CLIENTE[RG], DATA_NASC[Nascimento] FROM CLIENTE WHERE NOME like @nome");
                cmd.Parameters.Add(new SqlParameter("@nome", nome + '%'));
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPesquisa.DataSource = tabelaDados;
                conexao.desconectar();
               

            }
            catch(SqlException e)
            {
                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }
        private void pesquisaCpf(string cpf)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();

            try
            {
                sqlB.Append("SELECT ID_CLIENTE[Código], NOME[Nome], ENDERECO[Endereço], CIDADE[Cidade], FONE[Telefone], CELULAR[Celular], EMAIL[E - mail], CPF_CLIENTE[CPF], RG_CLIENTE[RG], DATA_NASC[Nascimento] FROM CLIENTE WHERE CPF_CLIENTE like @cpf");
                cmd.Parameters.Add(new SqlParameter("@cpf", cpf+'%'));
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPesquisa.DataSource = tabelaDados;
                conexao.desconectar();

            }
            catch(SqlException e)
            {
                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPesquisa.Rows.Count > 0)
            {
                string valid = Convert.ToString(dgvPesquisa.CurrentRow.Cells[0].Value);
                cadCliente cad = new cadCliente(valid);
                cad.txtNome.Text = Convert.ToString(dgvPesquisa.CurrentRow.Cells[1].Value);
                string endereco = Convert.ToString(dgvPesquisa.CurrentRow.Cells[2].Value);
                int virgula = endereco.IndexOf(',');
                string rua = endereco.Substring(0, virgula);
                endereco = endereco.Substring(virgula + 1);
                virgula = endereco.IndexOf(',');
                string bairro = endereco.Substring(0, virgula);
                endereco = endereco.Substring(virgula + 1);
                string numero = endereco;
                cad.txtBairro.Text = bairro;
                cad.txtNo.Text = numero;
                cad.txtRua.Text = rua;
                cad.txtCidade.Text = Convert.ToString(dgvPesquisa.CurrentRow.Cells[3].Value);
                cad.mskTel.Text = Convert.ToString(dgvPesquisa.CurrentRow.Cells[4].Value);
                cad.txtEmail.Text = Convert.ToString(dgvPesquisa.CurrentRow.Cells[6].Value);
                cad.mskCPF.Text = Convert.ToString(dgvPesquisa.CurrentRow.Cells[7].Value);
                cad.mskRG.Text = Convert.ToString(dgvPesquisa.CurrentRow.Cells[8].Value);
                cad.mskNascimento.Text = Convert.ToString(dgvPesquisa.CurrentRow.Cells[9].Value);
                this.Visible = false;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Não há nenhum dado cadastrado!");
            }
            //cad.txtBairro.Text = Convert.ToString(dgvPesquisa.CurrentRow.Cells[])
        }

        private void btnDesfiltro_Click(object sender, EventArgs e)
        {
           
            dataFill();
            btnDesfiltro.Enabled = false;
            clsControl.limparPesquisa(this);
        }

      
    }

}
