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
    public partial class cadPeriodicos : Form
    {

        public static cadPeriodicos cSelf;
        public cadPeriodicos(string valid)
        {
           
            InitializeComponent();
            cSelf = this;
            this.Visible = true;
            if (valid != null)
            {
                gpbPeriodico.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                textID.Text = valid;
                btnSalvar.Enabled = false;
              

            }

                // adiciona dados na comboBox -> Assinatura
            cbAssinatura.Items.Add("Mensal");         
            cbAssinatura.Items.Add("Semestral");
            cbAssinatura.Items.Add("Anual");
            cbAssinatura.Items.Add("Nenhuma");


            if (cbAutorP.Items.Count == 0)
            {
                cbAutorP.Enabled = false;
                MessageBox.Show("Não há dados de Autor");
            }
            carregaAutor();

            if (cbEditoraP.Items.Count == 0)
            {
                cbEditoraP.Enabled = false;
                MessageBox.Show("Não há dados de Editora");
            }
            carregarComboEditoraP();

        }
        int codigoAutorP = -666;
        int codigoEditora = -666;
        int codigoMaterial = -666;

        private void limpaTexto()
        {
            foreach (Control ctl in gpbPeriodico.Controls)
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

        private void cadPeriodicos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            clsControl.abreMenu(frmMenu.Self);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            gpbPeriodico.Enabled = true;
            limpaTexto();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaTexto();
        }

        //{carrega dados de  autor
        private void cbAutorP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAutorP.SelectedIndex != -1)
            {
                DataRow rowAutor = null;

                try
                {
                    rowAutor = pegaAutor(cbAutorP.SelectedItem.ToString()).Rows[0];
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Não foi possível pegar os dados do banco. Se o error persistir, contate o administrador.");

                }
                if (rowAutor != null)
                {
                    codigoAutorP = Convert.ToInt32(rowAutor["ID_AUTOR"]);
                }//
            }
        }

        private DataTable pegaAutor(string autor)
        {
            SqlCommand cmd = new SqlCommand();
            clsConexão conexao = new clsConexão();
            cmd.CommandText = "SELECT ID_AUTOR FROM AUTOR WHERE NOME_AUTOR =@autor";
            cmd.Parameters.AddWithValue("@autor", autor);
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
                MessageBox.Show("Não foi possível recuperar os dados da categoria!");
                return null;
            }
            finally
            {
                conexao.desconectar();
            }
        }
        public void carregaAutor()
        {
            cbAutorP.Items.Clear();
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
                    cbAutorP.Items.Add(autor);

                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao tentar se conectar com o Banco de Dados");
            }
            finally
            {
                conexao.desconectar();
            }


        }
        //------------------------}

        private void cadPeriodicos_Load(object sender, EventArgs e)
        {
            
            
        }

        private void cbAquisicao_SelectedIndexChanged(object sender, EventArgs e)
        {
          
             if (cbEditoraP.SelectedIndex != -1)
            {
                DataRow rowEditora = null;
                try
                {
                    rowEditora = pegaEditora(cbEditoraP.SelectedItem.ToString()).Rows[0];
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Não foi possível pegar os dados do banco. Se o error persistir, contate o administrador.");
                }
                if (rowEditora != null)
                {
                    codigoEditora = Convert.ToInt32(rowEditora["ID_EDITORA"]);
                }
            }
            


        }

        private DataTable pegaEditora(object editora)
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
        public void carregarComboEditoraP()
        {
            cbEditoraP.Items.Clear(); // primeiro limpa os itens na combobox
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
                    cbEditoraP.Items.Add(editora); // o valor obtido na string editora vai ser passado como um item na combobox editora
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string identificador = "periodicos";
            this.Visible = false;
            cadTipos cadastraTipo = new cadTipos(identificador);
            cadastraTipo.Visible = true;
        }
     
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clsCadastro cad = new clsCadastro();
            if (txtPeriodico.Text == "")
            {
                MessageBox.Show("Informe o Titulo do periódico");
            }
            else if (cbAssinatura.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma assinatura!");
            }
            else if (cbAutorP.SelectedIndex == -1)
            {
                MessageBox.Show("Informe um autor!");

            }
            else if (cbEditoraP.SelectedIndex == -1)
            {
                MessageBox.Show("Informe uma Editora!");
            }
            else if (txtMaterial.Text == "")
            {
                MessageBox.Show("Informe o material!");
            }
            else
            {
                cad.salvarPeriodico(txtPeriodico.Text, codigoAutorP, codigoEditora, txtMaterial.Text, cbAssinatura.SelectedItem.ToString(), chkEmprestimo.Checked);
                MessageBox.Show(cad.mensagem);
                limpaTexto();
            }

        }

        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisaPeri novapesquisa = new FrmPesquisaPeri();
            this.Visible = false;
            novapesquisa.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clsCadastro cad = new clsCadastro();
            cad.editarPeri(txtPeriodico.Text, txtMaterial.Text, codigoAutorP, cbAssinatura.SelectedItem.ToString(), codigoEditora, chkEmprestimo.Checked, textID.Text);
            MessageBox.Show(cad.mensagem);
            limpaTexto();
            gpbPeriodico.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            clsCadastro cad = new clsCadastro();
            cad.excluirPeri(Convert.ToInt32(textID.Text));
            MessageBox.Show(cad.mensagem);
            limpaTexto();
            gpbPeriodico.Enabled = false;

        }
    }
 }



