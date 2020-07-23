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
    public partial class cadLivro : Form
    {

        public static cadLivro cadSelf;
        public cadLivro(string valid)
        {
            InitializeComponent();
            this.Visible = true;
            cadSelf = this;
            
            if(valid != null)
            {
                gpbInfoLivro.Enabled = true;
                btnEditL.Enabled = true;
                btnExcluir.Enabled = true;
                POGlivro.Text = valid;
            }
            carregarComboEditora();
            if (cbEditora.Items.Count == 0)
            {
                cbEditora.Enabled = false;
                MessageBox.Show("Não há dados de editora!");
            }
            carregarComboCategoria();
            if (cbCategoria.Items.Count == 0)
            {
                cbCategoria.Enabled = false;
                MessageBox.Show("Não há dados de categoria!");
            }
            carregarComboGenero();
            if (cbGenero.Items.Count == 0)
            {
                cbGenero.Enabled = false;
                MessageBox.Show("Não há dados de coleção!");
            }
            carregaAutor();
            if (cbAutor.Items.Count == 0)
            {
                cbAutor.Enabled = false;
                MessageBox.Show("Não há dados de autor!");
            }
            carregarColecao();
            if (cbColecao.Items.Count == 0)
            {
                cbColecao.Enabled = false;
                MessageBox.Show("Não há dados de coleção!");
            }

        }

        int codigoEditora = -666;
        int codigoGenero = -666;
        int codigoCategoria = -666;
        int codigoAutor = -666;
        int codigoColecao = -666;

 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReferencia.Checked == true)
            {
          //      txtTempo.Enabled = false;
         //       txtTempo.Text = "";
            }
            else
            {
          //      txtTempo.Enabled = true;
            }
        }

        private void btnPesquisaLivro_Click(object sender, EventArgs e)
        {
            frmPesquisaLiv pesquisaLiv = new frmPesquisaLiv();
            pesquisaLiv.Visible = true;
            this.Visible = false;
            
        }

        private void btnNovoLivro_Click(object sender, EventArgs e)
        {
            gpbInfoLivro.Enabled = true;
            limpaTexto();

        }

        private void btnLimparLivro_Click(object sender, EventArgs e)
        {
            limpaTexto();

            cbCategoria.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            cbEditora.SelectedIndex = -1;
            cbAutor.SelectedIndex = -1;
            cbColecao.SelectedIndex = -1;
            // cbAutor nao esta limpando
        }


        private void limpaTexto()
        {
            foreach (Control ctl in gpbInfoLivro.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
                else if (ctl is CheckBox)
                {
                    ((CheckBox)ctl).Checked = false;
                }
                else if (ctl is ComboBox)
                {
                    ((ComboBox)ctl).SelectedIndex = -1;

                }
            }
        }

        private void btnSalvarLivro_Click(object sender, EventArgs e)
        {
            if(txtTitulo.Text == "")
            {
                MessageBox.Show("Digite o Titulo do Livro");
            }
            else if(cbAutor.Text == "")
            {
                MessageBox.Show("Digite o Autor do Livro");
            }
           else if(cbEditora.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a Editora");
            }
            else if(txtISBN.Text == "")
            {
                MessageBox.Show("Selecione o ISBN do Livro");
            }
              else if (cbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione Gênero do Livro");
            }
            else if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a Categoria do Livro");
            }
            else if(txtPaginas.Text == "")
            {
                MessageBox.Show("Digite um numero de páginas");
            }
            else if(txtExemplares.Text == "")
            {
                MessageBox.Show("Digite a quantidade de exemplares");
            }
            else if(txtCDU.Text == "")
            {
                MessageBox.Show("Digite o CDU do livro");
            }
            
            else
            {
                clsCadastro novoLivro = new clsCadastro();

                novoLivro.salvarLivro(txtTitulo.Text, codigoAutor, txtISBN.Text,chkReferencia.Checked,codigoCategoria,codigoEditora,codigoGenero,codigoColecao,txtCDU.Text,txtExemplares.Text,txtPaginas.Text,txtVolume.Text);
                MessageBox.Show(novoLivro.mensagem);
                limpaTexto();
            }
        }
        private void cadLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsControl.abreMenu(frmMenu.Self);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string identificador = "livro";
            this.Visible = false;
            cadTipos cadastraTipo = new cadTipos(identificador);
            cadastraTipo.Visible = true;
        }
        //aqui recarrega a combobox adicionando os novos valores adicionados
        public void carregarComboEditora()
        {
            cbEditora.Items.Clear(); // primeiro limpa os itens na combobox
            clsConexão conexao = new clsConexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader; // reader é uma variavel para ler os comandos que serão executados 

            cmd.CommandText = "SELECT NOME_EDITORA FROM EDITORA"; // utiliza o comando SELECT  no banco para recarregar

            try
            {
                cmd.Connection = conexao.conectar(); // faz conexao com o banco 
                reader = cmd.ExecuteReader(); //a variavel reader recebe o comando e executa ele 
                while (reader.Read())
                {
                    string editora = reader.GetString(0); //enquanto estiver lendo a string editora irá pegar como resultado o resultado obtido na reader
                    cbEditora.Items.Add(editora); // o valor obtido na string editora vai ser passado como um item na combobox editora
                }
                conexao.desconectar();
            }
            catch
            {
                MessageBox.Show("Erro ao tentar se conectar com o Banco de Dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }
        public void carregarComboGenero()
        {
            cbGenero.Items.Clear();
            clsConexão conexao = new clsConexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT NOME FROM GENERO";

            try
            {
                cmd.Connection = conexao.conectar();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string genero = reader.GetString(0);
                    cbGenero.Items.Add(genero);
                }
                conexao.desconectar();
            }
            catch
            {
                MessageBox.Show("Erro ao tentar se conectar com o Banco de Dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }
        public void carregarComboCategoria()
        {
            cbCategoria.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            clsConexão conexao = new clsConexão();
            SqlDataReader reader;

            cmd.CommandText = "SELECT NOME_CATEGORIA FROM CATEGORIA";

            try
            {
                cmd.Connection = conexao.conectar();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string categoria = reader.GetString(0);
                    cbCategoria.Items.Add(categoria);
                }
                conexao.desconectar();
            }
            catch
            {
                MessageBox.Show("Erro ao tentar se conectar com o Banco de Dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void cadLivro_Load(object sender, EventArgs e)
        {
            carregarComboEditora();            
            carregarComboCategoria();          
            carregarComboGenero();           
            carregaAutor();          
            carregarColecao();
          
        }

        private DataTable pegaEditora(string editora)
        {
            SqlCommand cmd = new SqlCommand();
            clsConexão conexao = new clsConexão(); 
            cmd.CommandText = "SELECT ID_EDITORA FROM EDITORA WHERE NOME_EDITORA = @editora";
            cmd.Parameters.AddWithValue("@editora", editora);
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = conexao.conectar();
                dt.Load(cmd.ExecuteReader());
                conexao.desconectar();
                return dt;
            }
            catch
            {
                MessageBox.Show("Não foi possível recuperar os dados da Editora!");
                return null;
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void cbEditora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEditora.SelectedIndex != -1)
            {
                DataRow rowEditora = null;
                try
                {
                    rowEditora = pegaEditora(cbEditora.SelectedItem.ToString()).Rows[0];
                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("Não foi possível pegar os dados do banco. Se o error persistir, contate o administrador.");
                }
                if (rowEditora != null)
                {
                    codigoEditora = Convert.ToInt32(rowEditora["ID_EDITORA"]);
                }
            }
        }

        private DataTable pegaGenero(string genero)
        {
            SqlCommand cmd = new SqlCommand();
            clsConexão conexao = new clsConexão();
            cmd.CommandText = "SELECT ID_GENERO FROM GENERO WHERE NOME = @genero";
            cmd.Parameters.AddWithValue("@genero", genero);
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = conexao.conectar();
                dt.Load(cmd.ExecuteReader());
                conexao.desconectar();
                return dt;
            }
            catch
            {
                MessageBox.Show("Não foi possível recuperar os dados da Editora!");
                return null;
            }
            finally
            {
                conexao.desconectar();
            }
        }
  
        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbGenero.SelectedIndex != -1)
            {
                DataRow rowGenero = null;

                try
                {
                    rowGenero = pegaGenero(cbGenero.SelectedItem.ToString()).Rows[0];
                }catch(NullReferenceException)
                {
                    MessageBox.Show("Não foi possível pegar os dados do banco. Se o error persistir, contate o administrador.");
                }
                if(rowGenero != null)
                {
                    codigoGenero = Convert.ToInt32(rowGenero["ID_GENERO"]);
                }
            }
            //fazer o pega categoria

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCategoria.SelectedIndex != -1)
            {
                DataRow rowCategoria = null;

                try
                {
                    rowCategoria = pegaCategoria(cbCategoria.SelectedItem.ToString()).Rows[0];
                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("Não foi possível pegar os dados do banco. Se o error persistir, contate o administrador.");
                }
                if(rowCategoria != null)
                {
                    codigoCategoria = Convert.ToInt32(rowCategoria["ID_CATEGORIA"]);
                }
            }
        }

        private DataTable pegaCategoria(string categoria)
        {
            SqlCommand cmd = new SqlCommand();
            clsConexão conexao = new clsConexão();
            cmd.CommandText = "SELECT ID_CATEGORIA FROM CATEGORIA WHERE NOME_CATEGORIA =@categoria";
            cmd.Parameters.AddWithValue("@categoria", categoria);
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = conexao.conectar();
                dt.Load(cmd.ExecuteReader());
                conexao.desconectar();
                return dt;
            }
            catch(SqlException e)
            {
                MessageBox.Show("Não foi possível recuperar os dados da categoria!");
                return null;
            }
            finally
            {
                conexao.desconectar();
            }
        }
        private DataTable pegaAutor(string autor)
        {
            SqlCommand cmd = new SqlCommand();
            clsConexão conexao = new clsConexão();
            cmd.CommandText = "SELECT ID_AUTOR,PHA FROM AUTOR WHERE NOME_AUTOR =@autor";
            cmd.Parameters.AddWithValue("@autor", autor);
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = conexao.conectar();
                dt.Load(cmd.ExecuteReader());
                conexao.desconectar();
                return dt;
            }catch(SqlException e)
            {
                MessageBox.Show("Não foi possível recuperar os dados da categoria!");
                return null;
            }
            finally
            {
                conexao.desconectar();
            }
        }
//
        private void cbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbAutor.SelectedIndex != -1)
            {
                DataRow rowAutor = null;

                try
                {
                    rowAutor = pegaAutor(cbAutor.SelectedItem.ToString()).Rows[0];
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Não foi possível pegar os dados do banco. Se o error persistir, contate o administrador.");
                    
                }
                if( rowAutor != null)
                {
                    codigoAutor = Convert.ToInt32(rowAutor["ID_AUTOR"]);
                    string pha = Convert.ToString(rowAutor[1]);
                    txtpha.Text = pha;
                }//
            }

        }
        public void carregaAutor()
        {
            cbAutor.Items.Clear();
            clsConexão conexao = new clsConexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT NOME_AUTOR FROM AUTOR";

            try
            {
                cmd.Connection = conexao.conectar();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string autor = reader.GetString(0);
                    cbAutor.Items.Add(autor);

                }
            }
            catch(SqlException e)
            {
                MessageBox.Show("Erro ao tentar se conectar com o Banco de Dados");
            }
            finally
            {
                conexao.desconectar();
            }


        }

        /// vai carregar a combo box
        public void carregarColecao()
        {
            cbColecao.Items.Clear();
            clsConexão conexao = new clsConexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT NOME_COLECAO FROM COLECAO";

            try
            {
                cmd.Connection = conexao.conectar();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string colecao = reader.GetString(0);
                    cbColecao.Items.Add(colecao);
                }
                
            }catch(SqlException e)
            {
                MessageBox.Show("Erro ao tentar se conectar com o Banco de Dados");
            }
            finally
            {
                conexao.desconectar();
            }

        }

        private void cbColecao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbColecao.SelectedIndex != -1)
            //if(cbAutor.SelectedIndex != -1)
            {
                DataRow rowColecao = null;

                try
                {
                    rowColecao = pegaColecao(cbColecao.SelectedItem.ToString()).Rows[0];
                    // rowAutor = pegaAutor(cbAutor.SelectedItem.ToString()).Rows[0];
                }
                catch
                {
                    MessageBox.Show("Não foi possível pegar os dados do banco. Se o error persistir, contate o administrador.");
                }
                if (rowColecao != null)
                {
                    codigoColecao = Convert.ToInt32(rowColecao["ID_COLECAO"]);
                    //codigoAutor = Convert.ToInt32(rowAutor["ID_AUTOR"]);
                }

            }
        }
        //pega os dados e coloca na combo box colecao

        private DataTable pegaColecao(string colecao)
        {
            SqlCommand cmd = new SqlCommand();
            clsConexão conexao = new clsConexão();
            cmd.CommandText = "SELECT ID_COLECAO FROM COLECAO WHERE NOME_COLECAO =@colecao";
            cmd.Parameters.AddWithValue("@colecao", colecao);
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = conexao.conectar();
                dt.Load(cmd.ExecuteReader());
                conexao.desconectar();
                return dt;

            }
            catch (SqlException e)
            {

                MessageBox.Show("Não foi possível recuperar os dados da coleção!");
                return null;
            }
            finally
            {
                conexao.desconectar();
            }


        }

        private void btnEditL_Click(object sender, EventArgs e)
        {
           
            clsCadastro cad = new clsCadastro();
            cad.editarLivro(txtTitulo.Text, codigoAutor, txtISBN.Text, codigoEditora, codigoCategoria, codigoGenero, codigoColecao,chkReferencia.Checked, POGlivro.Text,txtVolume.Text,txtPaginas.Text,txtExemplares.Text,txtCDU.Text);
            MessageBox.Show(cad.mensagem);
            limpaTexto();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            clsCadastro cad = new clsCadastro();
            if (POGlivro.Text == "")
            {
                MessageBox.Show("Primeiro selecione um cliente para excluir!");
            }
            else
            {
                cad.excluir_livro(Convert.ToInt32(POGlivro.Text));
                MessageBox.Show(cad.mensagem);
                limpaTexto();
                gpbInfoLivro.Enabled = false;
                btnNovoLivro.Enabled = true;
            }
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtExemplares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}

       
          
