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
    public partial class locaLivro : Form
    {
        int codigoCli = -666;
        int codigoLiv = -666;

        public static locaLivro self;

        public locaLivro()
        {
            InitializeComponent();
            self = this;
            this.Visible = true;
            gpbLeitor.Enabled = false;
            gpbLivro.Enabled = false;
            btnLocar.Enabled = false;
            btnDevolver.Enabled = false;
        }

        private void rdbDevolver_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDevolver.Checked == true)
            {
                rdbLivro.Checked = false;
                rdbPeri.Checked = false;
                gpbLocacao.Enabled = true;
                cmbLeitor.Enabled = false;
                cmbLivro.Enabled = false;
                mskLocacao.Enabled = false;

                foreach (Control ct1 in gpbLocacao.Controls)
                {
                    if (ct1 is ComboBox)
                    {
                        ct1.Text = string.Empty;

                    }
                    if (ct1 is ComboBox)
                    {
                        ct1.Text = string.Empty;
                    }
                }
                foreach (Control ct2 in gpbLeitor.Controls)
                {
                    if (ct2 is TextBox)
                    {
                        ct2.Text = string.Empty;
                    }
                }
                foreach (Control ct3 in gpbLivro.Controls)
                {
                    if (ct3 is TextBox)
                    {
                        ct3.Text = string.Empty;
                    }
                }
                if (rdbLivro.Checked)
                {
                    carregaleitorlocado();
                    carregaLivrolocado();
                    mskLocacao.Enabled = false;
                    btnLocar.Enabled = false;
                }
                else if (rdbPeri.Checked)
                {
                    carregaleitorlocado();
                    carregaLocadoPeri();

                }

                btnDevolver.Enabled = true;
                DateTime date = DateTime.Now;

                string asString = date.ToString();
                mskLocacao.Text = "";
                mskDevolucao.Text = asString;
            }
            else
            {
                btnDevolver.Enabled = false;
                rdbLivro.Checked = false;
                rdbPeri.Checked = false;
            }
            if(rdbDevolver.Checked == true && cmbLeitor.Items.Count < 1)
            {
                MessageBox.Show("Não há nenhuma locação de livros ou periódicos ");
                limpar();
                
            }
           
           

        }

        private void rdbLocar_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdbLocar.Checked == true)
            {
                rdbLivro.Checked = false;
                rdbPeri.Checked = false;
                gpbLocacao.Enabled = true;
                cmbLeitor.Enabled = false;
                cmbLivro.Enabled = false;

                foreach (Control ct1 in gpbLocacao.Controls)
                {
                    if (ct1 is ComboBox)
                    {
                        ct1.Text = string.Empty;

                    }
                    if (ct1 is ComboBox)
                    {
                        ct1.Text = string.Empty;
                    }
                }
                foreach (Control ct2 in gpbLeitor.Controls)
                {
                    if (ct2 is TextBox)
                    {
                        ct2.Text = string.Empty;
                    }
                }
                foreach (Control ct3 in gpbLivro.Controls)
                {
                    if (ct3 is TextBox)
                    {
                        ct3.Text = string.Empty;
                    }
                }
                //carregaLivro();
                carregaleitor();

                btnDevolver.Enabled = false;
                mskDevolucao.Enabled = true;
                mskLocacao.Enabled = true;
                btnLocar.Enabled = true;

                //fazendo essa linha você vai estar pegando o horário da máquina, o que significa que 
                //se a máquina do usuário estiver com a data errada, ele vai salvar o horário errado
                //recomendável dar um @GETDATE() no SQL e retornar a data
                DateTime date = DateTime.Now;


                string asString = date.ToString();
                mskLocacao.Text = asString;
                mskDevolucao.Text = "";



            }
            else
            {
                btnLocar.Enabled = false;
            }          
             if (rdbLocar.Checked == true &&cmbLeitor.Items.Count < 1)
            {
                MessageBox.Show("Não já cadastros de leitor");
                limpar();
               
            }
            
            
            
        }
        public static DateTime Now
        {
            get;
        }

        private void locaLivro_Load(object sender, EventArgs e)
        {

            carregaleitor();
            carregaLivro();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            gpbLocacaoDevolucao.Enabled = true;
        }

        private void locaLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            clsControl.abreMenu(frmMenu.Self);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaLocacao pesquisaLocacao = new frmPesquisaLocacao();
            pesquisaLocacao.Visible = true;
            this.Visible = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void limpar()
        {
            foreach (Control ct1 in gpbLocacao.Controls)
            {
                if (ct1 is ComboBox)
                {
                    ((ComboBox)ct1).SelectedIndex = -1;
                    ct1.Enabled = false;
                }
                if (ct1 is MaskedTextBox)
                {
                    ct1.Text = string.Empty;
                    ct1.Enabled = false;
                }
            }
            foreach (Control ct2 in gpbLeitor.Controls)
            {
                if (ct2 is TextBox)
                {
                    ct2.Text = string.Empty;
                    ct2.Enabled = false;
                }
                if (ct2 is MaskedTextBox)
                {
                    ct2.Text = string.Empty;
                    ct2.Enabled = false;
                }
            }
            foreach (Control ct3 in gpbLivro.Controls)
            {
                if (ct3 is TextBox)
                {
                    ct3.Text = string.Empty;
                    ct3.Enabled = false;
                }
            }
            gpbLocacaoDevolucao.Enabled = false;
            gpbLocacao.Enabled = false;
            rdbLocar.Checked = false;
            rdbDevolver.Checked = false;
        }
        private DataTable pegaCliente(string valor)
        {
            SqlCommand cmd = new SqlCommand();
            clsConexão conexao = new clsConexão();
            cmd.CommandText = "SELECT ID_CLIENTE, NOME, CPF_CLIENTE, CELULAR,FONE FROM CLIENTE WHERE NOME = @valor";//COLAR AQUI ROLE DO BANCO
            cmd.Parameters.AddWithValue("@valor", valor);
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

                MessageBox.Show("Não foi possível recuperar os dados do cliente!");
                return null;
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void cmbLeitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLeitor.SelectedIndex != -1)
            {
                DataRow rowLeitor = null;

                try
                {
                    rowLeitor = pegaCliente(cmbLeitor.SelectedItem.ToString()).Rows[0];
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Não foi possível pegar os dados do banco. Se o error persistir, contate o administrador.");

                }
                if (rowLeitor != null)
                {
                    codigoCli = Convert.ToInt32(rowLeitor["ID_CLIENTE"]);
                    string leitorcb = Convert.ToString(rowLeitor[1]);
                    txtNome.Text = leitorcb;
                    string cpfcb = Convert.ToString(rowLeitor[2]);
                    mskCPF.Text = cpfcb;
                    string celcb = Convert.ToString(rowLeitor[3]);
                    if (celcb == "")
                    {
                        celcb = Convert.ToString(rowLeitor[4]);
                        mskCel.Text = celcb;
                    }
                    else
                    {
                        mskCel.Text = celcb;
                    }


                    cmbLivro.Text = "";

                }
                if (rdbDevolver.Checked)
                {
                    if(rdbPeri.Checked)
                    {
                        carregaLocadoPeri();
                        cmbLivro.Enabled = true;
                    }
                    else
                    {
                        carregaLivrolocado();
                        cmbLivro.Enabled = true;
                    }
                }


            }

        }
        public void carregaleitor()
        {
            cmbLeitor.Items.Clear();
            clsConexão conexao = new clsConexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT NOME FROM CLIENTE";

            try
            {
                cmd.Connection = conexao.conectar();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string leitor = reader.GetString(0);
                    cmbLeitor.Items.Add(leitor);

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
        public void carregaleitorlocado()
        {
            cmbLeitor.Items.Clear();
            clsConexão conexao = new clsConexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT NOME FROM CLIENTE INNER JOIN LOCACAO ON LOCACAO.CLI_LOCACAO = CLIENTE.ID_CLIENTE WHERE LOCACAO.LIVR_LOCADO = 1 order by NOME desc";

            try
            {
                cmd.Connection = conexao.conectar();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string leitor = reader.GetString(0);
                    cmbLeitor.Items.Add(leitor);
                    //FISCALIZAÇÃO
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
        public void carregaleitorlocadoPeri()
        {
            cmbLeitor.Items.Clear();
            clsConexão conexao = new clsConexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT NOME FROM CLIENTE INNER JOIN LOCA_PERIODICO ON LOCA_PERIODICO.CLI_LOCACAO = CLIENTE.ID_CLIENTE where LOCA_PERIODICO.PERIODICO_LC=1 order by NOME desc";

            try
            {
                cmd.Connection = conexao.conectar();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string leitor = reader.GetString(0);
                    cmbLeitor.Items.Add(leitor);
               
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

        private DataTable pegaLivro(string valor)
        {
            SqlCommand cmd = new SqlCommand();
            clsConexão conexao = new clsConexão();
            cmd.CommandText = "SELECT LIVRO.ID_LIVRO, LIVRO.TITULO[Titulo], AUTOR.NOME_AUTOR[Autor], EDITORA.NOME_EDITORA[Editora] FROM LIVRO INNER JOIN AUTOR ON AUTOR.ID_AUTOR = LIVRO.AUTOR_LIVRO INNER JOIN EDITORA ON EDITORA.ID_EDITORA = LIVRO.EDITORA_LIVRO WHERE TITULO =@valor";
            cmd.Parameters.AddWithValue("@valor", valor);
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

                MessageBox.Show("Não foi possível recuperar os dados do livro!");
                return null;
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void cmbLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbLivro.Checked)
            {
                if (cmbLivro.SelectedIndex != -1)
                {

                    DataRow rowLivro = null;

                    try
                    {
                        rowLivro = pegaLivro(cmbLivro.SelectedItem.ToString()).Rows[0];
                    }
                    catch
                    {

                        MessageBox.Show("Não foi possível pegar os dados do banco. Se o error persistir, contate o administrador.");
                    }
                    if (rowLivro != null)
                    {
                        codigoLiv = Convert.ToInt32(rowLivro[0]);
                        string titcb = Convert.ToString(rowLivro[1]);
                        cmbtitulo.Text = titcb;
                        string autocb = Convert.ToString(rowLivro[2]);
                        cmbauto.Text = autocb;
                        string catg = Convert.ToString(rowLivro[3]);
                        cmbcate.Text = catg;
                        //COPIAR
                    }

                }
                
            }
            else if (rdbPeri.Checked)
            {
                if (cmbLivro.SelectedIndex != -1)
                {

                    DataRow rowPeriodico = null;

                    try
                    {
                        rowPeriodico = pegaPeriodico(cmbLivro.SelectedItem.ToString()).Rows[0];
                    }
                    catch
                    {

                        MessageBox.Show("Não foi possível pegar os dados do banco. Se o error persistir, contate o administrador.");
                    }
                    if (rowPeriodico != null)
                    {
                        codigoLiv = Convert.ToInt32(rowPeriodico[0]);
                        string titcb = Convert.ToString(rowPeriodico[1]);
                        cmbtitulo.Text = titcb;
                        string autocb = Convert.ToString(rowPeriodico[2]);
                        cmbauto.Text = autocb;
                        string catg = Convert.ToString(rowPeriodico[3]);
                        cmbcate.Text = catg;
                        //COPIAR
                    }

                }

            }
            else
            {
                MessageBox.Show("Selecione se quer um livro ou periódico primeiro!");
            }

        }
        private void carregaLivro()
        {
            cmbLivro.Items.Clear();
            clsConexão conexao = new clsConexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM LIVRO WHERE REFERENCIA = 0";

            try
            {
                cmd.Connection = conexao.conectar();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string livro = reader.GetString(1);
                    cmbLivro.Items.Add(livro);

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

        private void carregaLivrolocado()
        {
            cmbLivro.Items.Clear();
            if (cmbLeitor.SelectedIndex != -1)
            {

                clsConexão conexao = new clsConexão();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                cmd.CommandText = "SELECT TITULO FROM LIVRO INNER JOIN LOCACAO ON LOCACAO.LIVR_LOCACAO = LIVRO.ID_LIVRO INNER JOIN CLIENTE ON CLIENTE.ID_CLIENTE = LOCACAO.CLI_LOCACAO WHERE LIVR_LOCADO = 1 AND CLIENTE.NOME = @valor order by TITULO DESC";
                cmd.Parameters.AddWithValue("@valor", cmbLeitor.SelectedItem.ToString());

                try
                {
                    cmd.Connection = conexao.conectar();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string livro = reader.GetString(0);
                        cmbLivro.Items.Add(livro);
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
        }

        private void btnLocar_Click(object sender, EventArgs e)
        {
            if (cmbLivro.Text == "")
            {
                MessageBox.Show("Informe o livro");
            }
            if (cmbauto.Text == "")
            {
                MessageBox.Show("Informe o autor");
            }
            if (mskLocacao.Text == "")
            {
                MessageBox.Show("Informe a data de locação");
            }
            if (mskDevolucao.Text == "")
            {
                MessageBox.Show("Informe a data de entrega");
            }
            else
            {
                DateTime dateloca = Convert.ToDateTime("31/12/6666");
                DateTime datedevo = Convert.ToDateTime("31/12/6666");

                try
                {
                    dateloca = Convert.ToDateTime(mskLocacao.Text);
                    datedevo = Convert.ToDateTime(mskDevolucao.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Digite uma data válida!");
                }
                if (dateloca.Year != 6666 && datedevo.Year != 6666)
                {
                    clsCadastro novalocação = new clsCadastro();
                    if (codigoCli == -666)
                    {
                        MessageBox.Show("Selecione um cliente");
                    }
                    else if (codigoLiv == -666)
                    {
                        MessageBox.Show("Selecione um cliente");
                    }
                    else
                    {
                        if (rdbPeri.Checked)
                        {
                            novalocação.locarPeriodico(codigoCli, codigoLiv, Convert.ToString(dateloca.ToString("yyyy-MM-dd")), Convert.ToString(datedevo.ToString("yyyy-MM-dd")));
                            MessageBox.Show(novalocação.mensagem);
                            limpar();
                            mskDevolucao.Text = "";
                            mskLocacao.Text = "";

                        }
                        else if (rdbLivro.Checked)
                        {
                            novalocação.locar(codigoCli, codigoLiv, Convert.ToString(dateloca.ToString("yyyy-MM-dd")), Convert.ToString(datedevo.ToString("yyyy-MM-dd")));
                            MessageBox.Show(novalocação.mensagem);
                            limpar();
                            mskDevolucao.Text = "";
                            mskLocacao.Text = "";

                        }

                    }


                }
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            clsCadastro novadevolucao = new clsCadastro();
            if (codigoCli == -666)
            {
                MessageBox.Show("Selecione um cliente");
            }
            else if (codigoLiv == -666)
            {
                MessageBox.Show("Selecione um livro");
            }
            else
            {
                string devoData = mskDevolucao.ToString();
                string locaData = mskLocacao.ToString();
                string cpf = mskCPF.ToString();
                string cell = mskCel.ToString();
                if (rdbLivro.Checked)
                {
                    novadevolucao.devolver(codigoCli, codigoLiv);
                }else if (rdbPeri.Checked)
                {
                    novadevolucao.devolverPeri(codigoCli, codigoLiv);
                }
                MessageBox.Show("Devolução feita com sucesso");
                limpar();
            }

        }

        private void rdbLivro_CheckedChanged(object sender, EventArgs e)
        {
            cmbLivro.Items.Clear();
            cmbLeitor.SelectedIndex = -1;
            cmbLeitor.Text = "";
            cmbLivro.SelectedIndex = -1;
            cmbLivro.Text = "";
            if (rdbLivro.Checked)
            {
                if (rdbDevolver.Checked)
                {
                    cmbLeitor.Enabled = true;
                    carregaleitorlocado();
                }
                else
                {
                    cmbLeitor.Enabled = true;
                    carregaleitor();
                    cmbLivro.Enabled = true;
                    carregaLivro();
                }
            }
            else
            {
                cmbLeitor.Enabled = false;
                cmbLivro.Enabled = false;
            }
      
             if (rdbLivro.Checked == true&&cmbLivro.Items.Count < 1)
            {
                MessageBox.Show("Não há livros cadastrados ");
                limpar();
                rdbLivro.Checked = false;
            }
            else if (rdbPeri.Checked == true && cmbLivro.Items.Count < 1)
            {
                MessageBox.Show("Não há cadastros de Periódicos");
                limpar();
                rdbPeri.Checked = false;
                
            }
            
            

        }
        private DataTable pegaPeriodico(string valor)
        {
            SqlCommand cmd = new SqlCommand();
            clsConexão conexao = new clsConexão();
            cmd.CommandText = "SELECT PERIODICOS.ID, PERIODICOS.TITULO[Titulo], AUTOR.NOME_AUTOR[Autor], EDITORA.NOME_EDITORA[Editora] FROM PERIODICOS INNER JOIN AUTOR ON AUTOR.ID_AUTOR = PERIODICOS.AUTOR INNER JOIN EDITORA ON EDITORA.ID_EDITORA = PERIODICOS.EDITORA  WHERE TITULO =@valor";
            cmd.Parameters.AddWithValue("@valor", valor);
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

                MessageBox.Show("Não foi possível recuperar os dados do livro!");
                return null;
            }
            finally
            {
                conexao.desconectar();
            }

        }
        private void carregarPeriodico()
        {
            cmbLivro.Items.Clear();
            clsConexão conexao = new clsConexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "SELECT TITULO FROM PERIODICOS";

            try
            {
                cmd.Connection = conexao.conectar();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string periodico = reader.GetString(0);
                    cmbLivro.Items.Add(periodico);

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
        private void carregaLocadoPeri()
        {
            cmbLivro.Items.Clear();
            if (cmbLeitor.SelectedIndex != -1)
            {

                clsConexão conexao = new clsConexão();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                cmd.CommandText = "SELECT TITULO FROM PERIODICOS INNER JOIN LOCA_PERIODICO ON LOCA_PERIODICO.PERI_LOCADO = PERIODICOS.ID INNER JOIN CLIENTE ON CLIENTE.ID_CLIENTE = LOCA_PERIODICO.CLI_LOCACAO WHERE LOCA_PERIODICO.PERIODICO_LC = 1 AND CLIENTE.NOME = @valor order by TITULO DESC";
                cmd.Parameters.AddWithValue("@valor", cmbLeitor.SelectedItem.ToString());

                try
                {
                    cmd.Connection = conexao.conectar();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string periodico = reader.GetString(0);
                        cmbLivro.Items.Add(periodico);
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
        }

        private void rdbPeri_CheckedChanged(object sender, EventArgs e)
        {
            cmbLeitor.SelectedIndex = -1;
            cmbLeitor.Text = "";
            cmbLivro.SelectedIndex = -1;
            cmbLivro.Text = "";
            cmbLivro.Items.Clear();
            cmbLivro.Enabled = false;
            if (rdbPeri.Checked)
            {
                if (rdbLocar.Checked)
                {
                    carregaleitor();
                    cmbLeitor.Enabled = true;
                    carregarPeriodico();
                    cmbLivro.Enabled = true;
                }
                else
                {
                    carregaleitorlocadoPeri();
                    cmbLeitor.Enabled = true;
                }
            }
            else
            {
                cmbLivro.Enabled = false;
                cmbLeitor.Enabled = false;
            }
            if (rdbLocar.Checked == true && cmbLivro.Items.Count < 1)
            {
                MessageBox.Show("Não há cadastros de Periódicos");
                limpar();
                rdbPeri.Checked = false;
            }

            else if (rdbDevolver.Checked == true && cmbLivro.Items.Count < 1)
            {
                MessageBox.Show("Não há cadastros de Periódicos");
                limpar();
                rdbPeri.Checked = false;


            }
            cmbLivro.Enabled = false;
            rdbPeri.Checked = false;


        }
    }
}

// ajustar na hora de carregar o info usuario 