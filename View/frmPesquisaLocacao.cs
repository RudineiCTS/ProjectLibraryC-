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
    public partial class frmPesquisaLocacao : Form
    {
        public frmPesquisaLocacao()
        {
            InitializeComponent();
            gpbFiltro.Enabled = false;
            btnApagarFiltro.Enabled = false;

            foreach (Control item in gpbPesquisa.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                    item.Enabled = false;   
                }
                if(item is MaskedTextBox)
                {
                    item.Text = "";
                    item.Enabled = false;
                }

            }
        }

        private void rdbLeitor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLeitor.Checked == true)
            {
                txtTitulo.Enabled = false;
                mskDevolucao.Enabled = false;
                mskLocacao.Enabled = false;
                txtNome.Enabled = true;
            }
            else
            {
                txtNome.Text = "";
            }
        }

        private void rdbLivro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLivro.Checked == true)
            {
                txtNome.Enabled = false;
                mskLocacao.Enabled = false;
                mskDevolucao.Enabled = false;
                txtTitulo.Enabled = true;
            }
            else
            {
                txtTitulo.Text = "";
            }
        }

        private void rdbLocacao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLocacao.Checked == true)
            {
                mskLocacao.Enabled = true;
                txtNome.Enabled = false;
                txtTitulo.Enabled = false;
                mskDevolucao.Enabled = false;
            }
            else
            {
                mskLocacao.Text = "";
            }
        }

        private void rdbDevolucao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDevolucao.Checked == true)
            {
                mskDevolucao.Enabled = true;
                mskLocacao.Enabled = false;
                txtTitulo.Enabled = false;
                txtNome.Enabled = false;
            }
            else
            {
                mskDevolucao.Text = "";
            }
        }

        private void frmPesquisaLocacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            locaLivro locaLivro = locaLivro.self;
            locaLivro.Visible = true;
            this.Dispose();
        }

        private void dataFill()
        {
            clsConexão conexao = new clsConexão();

            try
            {
                SqlDataAdapter dataAdp = new SqlDataAdapter("SELECT LOCACAO.ID_LOCACAO AS 'Código', CLIENTE.NOME AS 'Nome do Cliente', LIVRO.TITULO AS 'Título do Livro',LOCACAO.DATA_INICIAL AS 'Data de Locação',LOCACAO.DATA_ENTREGA AS 'Data de Devolução' FROM LOCACAO INNER JOIN CLIENTE ON CLI_LOCACAO = CLIENTE.ID_CLIENTE INNER JOIN LIVRO ON LOCACAO.LIVR_LOCACAO = LIVRO.ID_LIVRO WHERE LIVR_LOCADO = 1 order by NOME", conexao.conectar());
                DataTable tabelaDados = new DataTable();
                dataAdp.Fill(tabelaDados);
                dgvPesquisa.DataSource = tabelaDados;
            }
            catch (SqlException e)
            {

                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void dgvPesquisa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPesquisa.Rows.Count > 0)
            {
                locaLivro loca = locaLivro.self;
                if (rdbLivrosLocado.Checked)
                {
                    loca.rdbDevolver.Checked = true;
                    loca.gpbLocacao.Enabled = true;
                    loca.rdbLivro.Checked = true;
                    for (int i = 0; i < loca.cmbLeitor.Items.Count; i++)
                    {
                        if (loca.cmbLeitor.Items[i].ToString() == Convert.ToString(dgvPesquisa.CurrentRow.Cells[1].Value))
                        {
                            loca.cmbLeitor.SelectedIndex = i;
                            break;
                        }
                    }
                    for (int i = 0; i < loca.cmbLivro.Items.Count; i++)
                    {
                        if (loca.cmbLivro.Items[i].ToString() == Convert.ToString(dgvPesquisa.CurrentRow.Cells[2].Value))
                        {
                            loca.cmbLivro.SelectedIndex = i;
                            break;
                        }
                    }
                    loca.cmbLeitor.Enabled = false;
                    loca.cmbLivro.Enabled = false;
                    loca.mskLocacao.Text = Convert.ToString(dgvPesquisa.CurrentRow.Cells[3].Value);
                    loca.Visible = true;
                    this.Dispose();
                }
                else if (rdbPerioLocado.Checked)
                {
                    loca.rdbDevolver.Checked = true;
                    loca.gpbLocacao.Enabled = true;
                    loca.rdbPeri.Checked = true;
                    for (int i = 0; i < loca.cmbLeitor.Items.Count; i++)
                    {
                        if (loca.cmbLeitor.Items[i].ToString() == Convert.ToString(dgvPesquisa.CurrentRow.Cells[1].Value))
                        {
                            loca.cmbLeitor.SelectedIndex = i;
                            break;
                        }
                    }
                    for (int i = 0; i < loca.cmbLivro.Items.Count; i++)
                    {
                        if (loca.cmbLivro.Items[i].ToString() == Convert.ToString(dgvPesquisa.CurrentRow.Cells[2].Value))
                        {
                            loca.cmbLivro.SelectedIndex = i;
                            break;
                        }
                    }
                    loca.cmbLeitor.Enabled = false;
                    loca.cmbLivro.Enabled = false;
                    loca.mskLocacao.Text = Convert.ToString(dgvPesquisa.CurrentRow.Cells[3].Value);
                    loca.Visible = true;
                    this.Dispose();
                }

            }
            else
            {
                MessageBox.Show("Nenhum dado cadastrado!");
            }
           
        }

        private void cabecalho()
        {
            dgvPesquisa.Columns[0].Width = 65;
            dgvPesquisa.Columns[1].Width = 210;
            dgvPesquisa.Columns[2].Width = 210;
            dgvPesquisa.Columns[3].Width = 124;
            dgvPesquisa.Columns[4].Width = 124;
        }

        private void btnApagarFiltro_Click(object sender, EventArgs e)
        {
            if (rdbLivrosLocado.Checked)
            {
                dataFill();
                cabecalho();
            }
            else if (rdbPerioLocado.Checked)
            {
                datafillPeri();
                cabecalho();
            }
            clsControl.limparPesquisa(this);
            rdbDevolucao.Checked = false;
            rdbLeitor.Checked = false;
            rdbLivro.Checked = false;
            rdbLocacao.Checked = false;
            btnApagarFiltro.Enabled = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (rdbLeitor.Checked)
            {
                pesquisaLeitor(txtNome.Text);
                btnApagarFiltro.Enabled = true;
            }
            else if (rdbLivro.Checked)
            {
                pesquisaLivro(txtTitulo.Text);
                btnApagarFiltro.Enabled = true;
            }
            else if (rdbLocacao.Checked)
            {
                btnApagarFiltro.Enabled = true;
                DateTime data = Convert.ToDateTime("31/12/6666");

                try
                {
                    data = Convert.ToDateTime(mskLocacao.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Digite uma data válida!");
                }
                if (data.Year != 6666)
                    pesquisaLoca(mskLocacao.Text);
            }
            else if (rdbDevolucao.Checked)
            {
                btnApagarFiltro.Enabled = true;
                DateTime data = Convert.ToDateTime("31/12/6666");

                try
                {
                    data = Convert.ToDateTime(mskDevolucao.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Digite uma data válida!");
                }
                if (data.Year != 6666)
                    pesquisaDevolv(mskDevolucao.Text);
            }
            else
            {
                MessageBox.Show("Primeiro selecione qual o filtro desejado!");
            }
            if (dgvPesquisa.Rows.Count < 1)
            {
                MessageBox.Show("Não foi possível encontrar dados com o filtro utilizado!");
            }
        }

        private void pesquisaLeitor(string nome)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();
            try
            {
                if (rdbLivrosLocado.Checked)
                {
                    sqlB.Append("SELECT LOCACAO.ID_LOCACAO AS 'Código', CLIENTE.NOME AS 'Nome do Cliente', LIVRO.TITULO AS 'Título do Livro',LOCACAO.DATA_INICIAL AS 'Data de Locação',LOCACAO.DATA_ENTREGA AS 'Data de Devolução' FROM LOCACAO INNER JOIN CLIENTE ON CLI_LOCACAO = CLIENTE.ID_CLIENTE INNER JOIN LIVRO ON LOCACAO.LIVR_LOCACAO = LIVRO.ID_LIVRO  WHERE LIVR_LOCADO = 1 AND CLIENTE.NOME LIKE @cliente order by NOME");
                }else if (rdbPerioLocado.Checked)
                {
                    sqlB.Append("SELECT LP.ID_LOCACAO[Código],CLIENTE.NOME[Nome],PERIODICOS.TITULO[Titulo],LP.DATA_INICIAL[Data de locação], LP.DATA_ENTREGA[Data de entrega] FROM LOCA_PERIODICO AS LP INNER JOIN CLIENTE ON CLIENTE.ID_CLIENTE = LP.CLI_LOCACAO INNER JOIN PERIODICOS ON PERIODICOS.ID = LP.PERI_LOCADO WHERE LP.PERIODICO_LC =1 AND CLIENTE.NOME like @cliente order by NOME");
                }
                cmd.Parameters.Add(new SqlParameter("@cliente", nome + '%'));
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPesquisa.DataSource = tabelaDados;
                conexao.desconectar();
            }
            catch (SqlException e)
            {

                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }
        
        private void pesquisaLivro(string nome)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();

            try
            {
                if (rdbLivrosLocado.Checked)
                {
                    sqlB.Append("SELECT LOCACAO.ID_LOCACAO AS 'Código', CLIENTE.NOME AS 'Nome do Cliente', LIVRO.TITULO AS 'Título do Livro',LOCACAO.DATA_INICIAL AS 'Data de Locação',LOCACAO.DATA_ENTREGA AS 'Data de Devolução' FROM LOCACAO INNER JOIN CLIENTE ON CLI_LOCACAO = CLIENTE.ID_CLIENTE INNER JOIN LIVRO ON LOCACAO.LIVR_LOCACAO = LIVRO.ID_LIVRO  WHERE LIVR_LOCADO = 1 AND LIVRO.TITULO LIKE @livro order by NOME");
                }else if (rdbPerioLocado.Checked)
                {
                    sqlB.Append("SELECT LP.ID_LOCACAO[Código],CLIENTE.NOME[Nome],PERIODICOS.TITULO[Titulo],LP.DATA_INICIAL[Data de locação], LP.DATA_ENTREGA[Data de entrega] FROM LOCA_PERIODICO AS LP INNER JOIN CLIENTE ON CLIENTE.ID_CLIENTE = LP.CLI_LOCACAO INNER JOIN PERIODICOS ON PERIODICOS.ID = LP.PERI_LOCADO WHERE LP.PERIODICO_LC =1 AND LIVRO.TITULO LIKE @livro order by NOME");
                }
               
                cmd.Parameters.Add(new SqlParameter("@livro", nome + '%'));
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPesquisa.DataSource = tabelaDados;
                conexao.desconectar();
            }
            catch (SqlException e)
            {

                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void pesquisaLoca(string data)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();

            try
            {
                if (rdbLivrosLocado.Checked)
                {
                    sqlB.Append("SELECT LOCACAO.ID_LOCACAO AS 'Código', CLIENTE.NOME AS 'Nome do Cliente', LIVRO.TITULO AS 'Título do Livro',LOCACAO.DATA_INICIAL AS 'Data de Locação',LOCACAO.DATA_ENTREGA AS 'Data de Devolução' FROM LOCACAO INNER JOIN CLIENTE ON CLI_LOCACAO = CLIENTE.ID_CLIENTE INNER JOIN LIVRO ON LOCACAO.LIVR_LOCACAO = LIVRO.ID_LIVRO  WHERE LIVR_LOCADO = 1 AND LOCACAO.DATA_INICIAL = @data order by NOME");
                }
                else if (rdbPerioLocado.Checked)
                {
                    sqlB.Append("SELECT LP.ID_LOCACAO[Código],CLIENTE.NOME[Nome],PERIODICOS.TITULO[Titulo],LP.DATA_INICIAL[Data de locação], LP.DATA_ENTREGA[Data de entrega] FROM LOCA_PERIODICO AS LP INNER JOIN CLIENTE ON CLIENTE.ID_CLIENTE = LP.CLI_LOCACAO INNER JOIN PERIODICOS ON PERIODICOS.ID = LP.PERI_LOCADO WHERE LP.PERIODICO_LC =1 AND LOCACAO.DATA_INICIAL = @data order by NOME");
                }
                cmd.Parameters.AddWithValue("@data", data);
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPesquisa.DataSource = tabelaDados;
                conexao.desconectar();
            }
            catch (SqlException e)
            {

                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void pesquisaDevolv(string data)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();

            try
            {
                if (rdbLivrosLocado.Checked)
                {
                    sqlB.Append("SELECT LOCACAO.ID_LOCACAO AS 'Código', CLIENTE.NOME AS 'Nome do Cliente', LIVRO.TITULO AS 'Título do Livro',LOCACAO.DATA_INICIAL AS 'Data de Locação',LOCACAO.DATA_ENTREGA AS 'Data de Devolução' FROM LOCACAO INNER JOIN CLIENTE ON CLI_LOCACAO = CLIENTE.ID_CLIENTE INNER JOIN LIVRO ON LOCACAO.LIVR_LOCACAO = LIVRO.ID_LIVRO  WHERE LIVR_LOCADO = 1 AND LOCACAO.DATA_ENTREGA = @data order by NOME");
                }
                else if (rdbLivrosLocado.Checked)
                {
                    sqlB.Append("SELECT LP.ID_LOCACAO[Código],CLIENTE.NOME[Nome],PERIODICOS.TITULO[Titulo],LP.DATA_INICIAL[Data de locação], LP.DATA_ENTREGA[Data de entrega] FROM LOCA_PERIODICO AS LP INNER JOIN CLIENTE ON CLIENTE.ID_CLIENTE = LP.CLI_LOCACAO INNER JOIN PERIODICOS ON PERIODICOS.ID = LP.PERI_LOCADO WHERE LP.PERIODICO_LC =1 AND LOCACAO.DATA_ENTREGA = @data order by NOME");
                }
                cmd.Parameters.AddWithValue("@data", data);
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPesquisa.DataSource = tabelaDados;
                conexao.desconectar();
            }
            catch (SqlException e)
            {

                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void rdbPerioLocado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPerioLocado.Checked)
            {
                datafillPeri();
                cabecalho();
              
                gpbFiltro.Enabled = true;
                
            }
        }
        private void datafillPeri()
        {
            clsConexão conexao = new clsConexão();

            try
            {
                SqlDataAdapter dataAdp = new SqlDataAdapter("SELECT LP.ID_LOCACAO[Código],CLIENTE.NOME[Nome],PERIODICOS.TITULO[Titulo],LP.DATA_INICIAL[Data de locação], LP.DATA_ENTREGA[Data de entrega] FROM LOCA_PERIODICO AS LP INNER JOIN CLIENTE ON CLIENTE.ID_CLIENTE = LP.CLI_LOCACAO INNER JOIN PERIODICOS ON PERIODICOS.ID = LP.PERI_LOCADO WHERE LP.PERIODICO_LC =1", conexao.conectar());
                DataTable tabelaDados = new DataTable();
                dataAdp.Fill(tabelaDados);
                dgvPesquisa.DataSource = tabelaDados;
            }
            catch (SqlException e)
            {

                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void rdbLivrosLocado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLivrosLocado.Checked)
            {
                dataFill();
                cabecalho();
                gpbFiltro.Enabled = true;
               
            }
            
           
        }


        

       
    }

}
