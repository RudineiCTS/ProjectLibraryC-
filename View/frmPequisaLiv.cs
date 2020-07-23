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
    public partial class frmPesquisaLiv : Form
    {
        public frmPesquisaLiv()
        {
            InitializeComponent();
            txtAutor.Enabled = false;
            txtColecao.Enabled = false;
            txtEditora.Enabled = false;
            txtTitulo.Enabled = false;
        }

        private void btnDesfiltro_Click(object sender, EventArgs e)
        {
            dataFill();
            clsControl.limparPesquisa(this);
        }

        private void dataFill()
        {
            clsConexão conexao = new clsConexão();

            try
            {
                // preenchendo tabela com os dados do banco 
                SqlDataAdapter dataAdp = new SqlDataAdapter("SELECT L.ID_LIVRO[Código], L.TITULO[Titulo], L.ISBN, L.CDU, L.REFERENCIA[Referencia], A.NOME_AUTOR[Autor], A.PHA, E.NOME_EDITORA[Editora], C.NOME_CATEGORIA[Categoria], G.NOME[Gênero], CO.NOME_COLECAO[Coleção], L.VOLUME[Volume], L.N_PAGINAS[N° páginas], L.N_EXEMPLARES[N° exemplares] FROM LIVRO AS L  INNER JOIN AUTOR AS A ON L.AUTOR_LIVRO = A.ID_AUTOR INNER JOIN GENERO AS G ON L.GENERO_LIVRO = G.ID_GENERO INNER JOIN CATEGORIA AS C ON L.CATEG_LIVRO = C.ID_CATEGORIA INNER JOIN EDITORA AS E ON    L.EDITORA_LIVRO = E.ID_EDITORA INNER JOIN COLECAO AS CO ON L.COLECAO_LIVRO = CO.ID_COLECAO", conexao.conectar());
                DataTable tabelaDados = new DataTable();
                dataAdp.Fill(tabelaDados);
                dgvPesquisaLiv.DataSource = tabelaDados;

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


        private void cadLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            cadLivro cadLivro = cadLivro.cadSelf;
            cadLivro.Visible = true;
            this.Dispose();

        }



        private void frmPesquisaLiv_Load(object sender, EventArgs e)
        {
            dataFill();
            cabecalho();

        }

        private void cabecalho()
        {
            dgvPesquisaLiv.Columns[0].Width = 45;
            dgvPesquisaLiv.Columns[1].Width = 140;
            dgvPesquisaLiv.Columns[2].Width = 140;
            dgvPesquisaLiv.Columns[3].Width = 100;
            dgvPesquisaLiv.Columns[4].Width = 72;
            dgvPesquisaLiv.Columns[5].Width = 80;
            dgvPesquisaLiv.Columns[11].Width = 60;
            dgvPesquisaLiv.Columns[13].Width = 82;
        }

        private void pesquisaTitulo(string titulo)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();
            try
            {
                // preenchendo tabela com os dados do banco 
                sqlB.Append("SELECT L.ID_LIVRO[Código], L.TITULO[Titulo], L.ISBN, L.REFERENCIA[Referencia], A.NOME_AUTOR[Autor], E.NOME_EDITORA[Editora], C.NOME_CATEGORIA[Categoria], G.NOME[Gênero],CO.NOME_COLECAO[Coleção] FROM LIVRO AS L  INNER JOIN AUTOR AS A ON L.AUTOR_LIVRO = A.ID_AUTOR INNER JOIN GENERO AS G ON L.GENERO_LIVRO = G.ID_GENERO INNER JOIN CATEGORIA AS C ON L.CATEG_LIVRO = C.ID_CATEGORIA INNER JOIN EDITORA AS E ON    L.EDITORA_LIVRO = E.ID_EDITORA INNER JOIN COLECAO AS CO ON L.COLECAO_LIVRO = CO.ID_COLECAO WHERE L.TITULO like @titulo");
                cmd.Parameters.Add(new SqlParameter("@titulo", titulo + '%'));
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPesquisaLiv.DataSource = tabelaDados;
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


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (rdbTitulo.Checked == true)
            {
                pesquisaTitulo(txtTitulo.Text);
                btnDesfiltro.Enabled = true;
            }
            else if (rdbEditora.Checked == true)
            {
                pesquisaEditora(txtEditora.Text);
                btnDesfiltro.Enabled = true;
            }
            else if(rdbAutor.Checked == true)
            {
                pesquisaAutor(txtAutor.Text);
                btnDesfiltro.Enabled = true;
            }
            else if(rdbColecao.Checked == true)
            {
                pesquisaColecao(txtColecao.Text);
                btnDesfiltro.Enabled = true;
            }
        }

        private void pesquisaEditora(string editora)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();

            try
            {
                sqlB.Append("SELECT L.ID_LIVRO[Código], L.TITULO[Titulo], L.ISBN, L.REFERENCIA[Referencia], A.NOME_AUTOR[Autor], E.NOME_EDITORA[Editora], C.NOME_CATEGORIA[Categoria], G.NOME[Gênero],CO.NOME_COLECAO[Coleção] FROM LIVRO AS L  INNER JOIN AUTOR AS A ON L.AUTOR_LIVRO = A.ID_AUTOR INNER JOIN GENERO AS G ON L.GENERO_LIVRO = G.ID_GENERO INNER JOIN CATEGORIA AS C ON L.CATEG_LIVRO = C.ID_CATEGORIA INNER JOIN EDITORA AS E ON    L.EDITORA_LIVRO = E.ID_EDITORA INNER JOIN COLECAO AS CO ON L.COLECAO_LIVRO = CO.ID_COLECAO WHERE E.NOME_EDITORA like @editora");
                cmd.Parameters.Add(new SqlParameter("@editora", editora + '%'));
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPesquisaLiv.DataSource = tabelaDados;
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
        private void pesquisaAutor(string autor)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();

            try
            {
                sqlB.Append("SELECT L.ID_LIVRO[Código], L.TITULO[Titulo], L.ISBN, L.REFERENCIA[Referencia], A.NOME_AUTOR[Autor], E.NOME_EDITORA[Editora], C.NOME_CATEGORIA[Categoria], G.NOME[Gênero],CO.NOME_COLECAO[Coleção] FROM LIVRO AS L  INNER JOIN AUTOR AS A ON L.AUTOR_LIVRO = A.ID_AUTOR INNER JOIN GENERO AS G ON L.GENERO_LIVRO = G.ID_GENERO INNER JOIN CATEGORIA AS C ON L.CATEG_LIVRO = C.ID_CATEGORIA INNER JOIN EDITORA AS E ON    L.EDITORA_LIVRO = E.ID_EDITORA INNER JOIN COLECAO AS CO ON L.COLECAO_LIVRO = CO.ID_COLECAO WHERE A.NOME_AUTOR like @autor");
                cmd.Parameters.Add(new SqlParameter("@autor", autor + '%'));
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPesquisaLiv.DataSource = tabelaDados;
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
        private void pesquisaColecao(string colecao)
        {
            clsConexão conexao = new clsConexão();
            DataTable tabelaDados = new DataTable();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();

            try
            {
                sqlB.Append("SELECT L.ID_LIVRO[Código], L.TITULO[Titulo], L.ISBN, L.REFERENCIA[Referencia], A.NOME_AUTOR[Autor], E.NOME_EDITORA[Editora], C.NOME_CATEGORIA[Categoria], G.NOME[Gênero],CO.NOME_COLECAO[Coleção] FROM LIVRO AS L  INNER JOIN AUTOR AS A ON L.AUTOR_LIVRO = A.ID_AUTOR INNER JOIN GENERO AS G ON L.GENERO_LIVRO = G.ID_GENERO INNER JOIN CATEGORIA AS C ON L.CATEG_LIVRO = C.ID_CATEGORIA INNER JOIN EDITORA AS E ON    L.EDITORA_LIVRO = E.ID_EDITORA INNER JOIN COLECAO AS CO ON L.COLECAO_LIVRO = CO.ID_COLECAO WHERE CO.NOME_COLECAO like @colecao");
                cmd.Parameters.Add(new SqlParameter("@colecao", colecao + '%'));
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPesquisaLiv.DataSource = tabelaDados;
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

        private void rdbTitulo_CheckedChanged(object sender, EventArgs e)
        {
            txtTitulo.Enabled = true;
            txtEditora.Enabled = false;
            txtColecao.Enabled = false;
            txtAutor.Enabled = false;
            txtAutor.Text = "";
            txtColecao.Text = "";
            txtEditora.Text = "";
            txtTitulo.Text = "";

        }

        private void rdbAutor_CheckedChanged(object sender, EventArgs e)
        {
            txtAutor.Enabled = true;
            txtTitulo.Enabled = false;
            txtEditora.Enabled = false;
            txtColecao.Enabled = false;
            txtAutor.Text = "";
            txtColecao.Text = "";
            txtEditora.Text = "";
            txtTitulo.Text = "";
        }

        private void rdbEditora_CheckedChanged(object sender, EventArgs e)
        {
            txtEditora.Enabled = true;
            txtAutor.Enabled = false;
            txtTitulo.Enabled = false;
            txtColecao.Enabled = false;
            txtAutor.Text = "";
            txtColecao.Text = "";
            txtEditora.Text = "";
            txtTitulo.Text = "";
        }

        private void rdbColecao_CheckedChanged(object sender, EventArgs e)
        {
            txtColecao.Enabled = true;
            txtAutor.Enabled = false;
            txtTitulo.Enabled = false;
            txtEditora.Enabled = false;
            txtAutor.Text = "";
            txtColecao.Text = "";
            txtEditora.Text = "";
            txtTitulo.Text = "";
        }

        private void dgvPesquisaLiv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPesquisaLiv.Rows.Count < 1)
            {
                MessageBox.Show("Não há cadastro de livros aqui!");
             }
            //L.ID_LIVRO[Código], L.TITULO[Titulo], L.ISBN, L.CDU, L.REFERENCIA[Referencia], A.NOME_AUTOR[Autor],
            //A.PHA, E.NOME_EDITORA[Editora], C.NOME_CATEGORIA[Categoria], G.NOME[Gênero], CO.NOME_COLECAO[Coleção],
            //L.VOLUME[Volume], L.N_PAGINAS[N° páginas], L.N_EXEMPLARES[N° exemplares] 
            else
            {
                string valid = Convert.ToString(dgvPesquisaLiv.CurrentRow.Cells[0].Value);
                cadLivro livroNovo = new cadLivro(valid);
                livroNovo.txtTitulo.Text = Convert.ToString(dgvPesquisaLiv.CurrentRow.Cells[1].Value);
                livroNovo.txtISBN.Text = Convert.ToString(dgvPesquisaLiv.CurrentRow.Cells[2].Value);
                livroNovo.txtCDU.Text = Convert.ToString(dgvPesquisaLiv.CurrentRow.Cells[3].Value);
                livroNovo.chkReferencia.Checked = Convert.ToBoolean(dgvPesquisaLiv.CurrentRow.Cells[4].Value);
                livroNovo.cbAutor.Text = Convert.ToString(dgvPesquisaLiv.CurrentRow.Cells[5].Value);
                livroNovo.txtpha.Text = Convert.ToString(dgvPesquisaLiv.CurrentRow.Cells[6]);
                livroNovo.cbEditora.Text = Convert.ToString(dgvPesquisaLiv.CurrentRow.Cells[7].Value);
                livroNovo.cbCategoria.Text = Convert.ToString(dgvPesquisaLiv.CurrentRow.Cells[8].Value);
                livroNovo.cbGenero.Text = Convert.ToString(dgvPesquisaLiv.CurrentRow.Cells[9].Value);
                livroNovo.cbColecao.Text = Convert.ToString(dgvPesquisaLiv.CurrentRow.Cells[10].Value);
                livroNovo.txtVolume.Text = Convert.ToString(dgvPesquisaLiv.CurrentRow.Cells[11].Value);
                livroNovo.txtPaginas.Text = Convert.ToString(dgvPesquisaLiv.CurrentRow.Cells[12].Value);
                livroNovo.txtExemplares.Text = Convert.ToString(dgvPesquisaLiv.CurrentRow.Cells[13].Value);
                this.Visible = false;
                this.Dispose();
            }
        }
        }
}

/*
 * -fazer os ajustes nas colunas do form de  pesquisa--- ok
 * -programar o desfiltro --- ok
 * -tirar coluna tempo de empréstimo --- ok
 * -começar o form de locação
 * 
 * 
 */
