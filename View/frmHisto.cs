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
    public partial class frmHisto : Form
    {
        public frmHisto()
        {
            InitializeComponent();
            this.Visible = true;
            gpbFiltro.Enabled = false;
            btnApagarFiltro.Enabled = false;
            txtNome.Enabled = false;
          
            foreach (Control ctr in gpbFiltro.Controls)
            {
                if(ctr is RadioButton)
                {
                    ((RadioButton)ctr).Checked = false;
                }
            }
           

        }
        private void fillhistory()
        {
            clsConexão conexao = new clsConexão();

            try
            {
                SqlDataAdapter dataAdp = new SqlDataAdapter("SELECT LOCACAO.ID_LOCACAO AS 'Código', CLIENTE.NOME AS 'Nome do Cliente', LIVRO.TITULO AS 'Título do Livro',LOCACAO.DATA_INICIAL AS 'Data de Locação',LOCACAO.DATA_ENTREGA AS 'Data de Devolução' FROM LOCACAO INNER JOIN CLIENTE ON CLI_LOCACAO = CLIENTE.ID_CLIENTE INNER JOIN LIVRO ON LOCACAO.LIVR_LOCACAO = LIVRO.ID_LIVRO WHERE LIVR_LOCADO = 0 order by DATA_INICIAL", conexao.conectar());
                DataTable tabelaDados = new DataTable();
                dataAdp.Fill(tabelaDados);
                dgvHisto.DataSource = tabelaDados;
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
        private void cabecalho()
        {
            dgvHisto.Columns[0].Width = 65;
            dgvHisto.Columns[1].Width = 210;
            dgvHisto.Columns[2].Width = 210;
            dgvHisto.Columns[3].Width = 124;
            dgvHisto.Columns[4].Width = 124;
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

        
        

        private void btnApagarFiltro_Click(object sender, EventArgs e)
        {
            if (rdbLivrosLocado.Checked)
            {
                fillhistory();
                cabecalho();
            }
            else if (rdbPerioLocado.Checked)
            {
                fillhistoryPeri();
                cabecalho();
            }
            clsControl.limparPesquisa(this);
            rdbLeitor.Checked = false;
            rdbLivro.Checked = false;
            rdbLocacao.Checked = false;
            mskLocacao.Enabled = false;
            mskDevolucao.Enabled = false;
            btnApagarFiltro.Enabled = false;
        }

        private void fillhistoryPeri()
        {
            clsConexão conexao = new clsConexão();

            try
            {
                SqlDataAdapter dataAdp = new SqlDataAdapter("SELECT LP.ID_LOCACAO[Código],CLIENTE.NOME[Nome],PERIODICOS.TITULO[Titulo],LP.DATA_INICIAL[Data de locação], LP.DATA_ENTREGA[Data de entrega] FROM LOCA_PERIODICO AS LP INNER JOIN CLIENTE ON CLIENTE.ID_CLIENTE = LP.CLI_LOCACAO INNER JOIN PERIODICOS ON PERIODICOS.ID = LP.PERI_LOCADO WHERE LP.PERIODICO_LC =0", conexao.conectar());
                DataTable tabelaDados = new DataTable();
                dataAdp.Fill(tabelaDados);
                dgvHisto.DataSource = tabelaDados;
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
            gpbFiltro.Enabled = true;
            fillhistory();
            cabecalho();
        }

        private void rdbPerioLocado_CheckedChanged(object sender, EventArgs e)
        {
            gpbFiltro.Enabled = true;
            fillhistoryPeri();
            cabecalho();
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
                DateTime data2 = Convert.ToDateTime("31/12/6666");

                try
                {
                    data = Convert.ToDateTime(mskLocacao.Text);
                    data2 = Convert.ToDateTime(mskDevolucao.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Digite uma data válida!");
                }
                if (data.Year != 6666 || data2.Year!=6666)
                    pesquisaEntre(mskLocacao.Text, mskDevolucao.Text);
               

            }           
            else
            {
                MessageBox.Show("Primeiro selecione qual o filtro desejado!");
            }
            if (dgvHisto.Rows.Count < 1)
            {
                MessageBox.Show("Não foi possível encontrar dados com o filtro utilizado!");
            }

          
        }

        private void pesquisaEntre(string text1, string text2)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();

            try
            {
                if (rdbLivrosLocado.Checked)
                {
                    sqlB.Append("SELECT LOCACAO.ID_LOCACAO AS 'Código', CLIENTE.NOME AS 'Nome do Cliente', LIVRO.TITULO AS 'Título do Livro',LOCACAO.DATA_INICIAL AS 'Data de Locação',LOCACAO.DATA_ENTREGA AS 'Data de Devolução' FROM LOCACAO INNER JOIN CLIENTE ON CLI_LOCACAO = CLIENTE.ID_CLIENTE INNER JOIN LIVRO ON LOCACAO.LIVR_LOCACAO = LIVRO.ID_LIVRO  WHERE LIVR_LOCADO = 0  AND LOCACAO.DATA_INICIAL BETWEEN @data and @data2  order by NOME");
                }
                else if (rdbLivrosLocado.Checked)
                {
                    sqlB.Append("SELECT LP.ID_LOCACAO[Código], CLIENTE.NOME[Nome], PERIODICOS.TITULO[Titulo], LP.DATA_INICIAL[Data de locação], LP.DATA_ENTREGA[Data de entrega] FROM LOCA_PERIODICO AS LP INNER JOIN CLIENTE ON CLIENTE.ID_CLIENTE = LP.CLI_LOCACAO INNER JOIN PERIODICOS ON PERIODICOS.ID = LP.PERI_LOCADO WHERE LP.PERIODICO_LC = 0 AND LOCACAO.DATA_ENTREGA BETWEEN @data AND @data2 order by NOME");
                }
                cmd.Parameters.AddWithValue("@data", text1);
                cmd.Parameters.AddWithValue("@data2", text2);
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvHisto.DataSource = tabelaDados;
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
        private void pesquisaLivro(string text)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();

            try
            {
                if (rdbLivrosLocado.Checked)
                {
                    sqlB.Append("SELECT LOCACAO.ID_LOCACAO AS 'Código', CLIENTE.NOME AS 'Nome do Cliente', LIVRO.TITULO AS 'Título do Livro',LOCACAO.DATA_INICIAL AS 'Data de Locação',LOCACAO.DATA_ENTREGA AS 'Data de Devolução' FROM LOCACAO INNER JOIN CLIENTE ON CLI_LOCACAO = CLIENTE.ID_CLIENTE INNER JOIN LIVRO ON LOCACAO.LIVR_LOCACAO = LIVRO.ID_LIVRO  WHERE LIVR_LOCADO = 0 AND LIVRO.TITULO LIKE @livro order by NOME");
                }
                else if (rdbPerioLocado.Checked)
                {
                    sqlB.Append("SELECT LP.ID_LOCACAO[Código],CLIENTE.NOME[Nome],PERIODICOS.TITULO[Titulo],LP.DATA_INICIAL[Data de locação], LP.DATA_ENTREGA[Data de entrega] FROM LOCA_PERIODICO AS LP INNER JOIN CLIENTE ON CLIENTE.ID_CLIENTE = LP.CLI_LOCACAO INNER JOIN PERIODICOS ON PERIODICOS.ID = LP.PERI_LOCADO WHERE LP.PERIODICO_LC =0 AND LIVRO.TITULO LIKE @livro order by NOME");
                }

                cmd.Parameters.Add(new SqlParameter("@livro", text + '%'));
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvHisto.DataSource = tabelaDados;
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

        private void pesquisaLeitor(string text)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();
            try
            {
                if (rdbLivrosLocado.Checked)
                {
                    sqlB.Append("SELECT LOCACAO.ID_LOCACAO AS 'Código', CLIENTE.NOME AS 'Nome do Cliente', LIVRO.TITULO AS 'Título do Livro',LOCACAO.DATA_INICIAL AS 'Data de Locação',LOCACAO.DATA_ENTREGA AS 'Data de Devolução' FROM LOCACAO INNER JOIN CLIENTE ON CLI_LOCACAO = CLIENTE.ID_CLIENTE INNER JOIN LIVRO ON LOCACAO.LIVR_LOCACAO = LIVRO.ID_LIVRO  WHERE LIVR_LOCADO = 0 AND CLIENTE.NOME LIKE @cliente order by NOME");
                }
                else if (rdbPerioLocado.Checked)
                {
                    sqlB.Append("SELECT LP.ID_LOCACAO[Código],CLIENTE.NOME[Nome],PERIODICOS.TITULO[Titulo],LP.DATA_INICIAL[Data de locação], LP.DATA_ENTREGA[Data de entrega] FROM LOCA_PERIODICO AS LP INNER JOIN CLIENTE ON CLIENTE.ID_CLIENTE = LP.CLI_LOCACAO INNER JOIN PERIODICOS ON PERIODICOS.ID = LP.PERI_LOCADO WHERE LP.PERIODICO_LC =0 AND CLIENTE.NOME like @cliente order by NOME");
                }
                cmd.Parameters.Add(new SqlParameter("@cliente", text + '%'));
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvHisto.DataSource = tabelaDados;
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

        private void frmHisto_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsControl.abreMenu(frmMenu.Self);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLocacao.Checked == true)
            {
                mskDevolucao.Enabled = true;
                mskLocacao.Enabled = true;
                txtTitulo.Enabled = false;
                txtNome.Enabled = false;
               
                
            }
            else
            {
                mskDevolucao.Text = "";
                mskLocacao.Text = "";
            }
        }

        private void frmHisto_Load(object sender, EventArgs e)
        {
            clsControl.limparPesquisa(this);
        }
    }
}
