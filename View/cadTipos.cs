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
    public partial class cadTipos : Form
    {
        public cadTipos(string identificador)
        {

            InitializeComponent();
            txtEditora.Enabled = false;
            txtCategoria.Enabled = false;
            txtGenero.Enabled = false;
            txtAutor.Enabled = false;
            txtColecao.Enabled = false;
            Box1.Text = identificador;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text != "")
            {
                salvarTipo(txtCategoria.Text, "CATEGORIA", txtPha.Text);

            }
            else if (txtEditora.Text != "")
            {
                salvarTipo(txtEditora.Text, "EDITORA", txtPha.Text);
            }
            else if (txtGenero.Text != "")
            {
                salvarTipo(txtGenero.Text, "GENERO", txtPha.Text);
            }
            else if (txtAutor.Text != "")
            {
                salvarTipo(txtAutor.Text, "AUTOR",txtPha.Text);
            }
            else if (txtColecao.Text != "")
            {
                salvarTipo(txtColecao.Text, "COLECAO", txtPha.Text);
            }
           foreach(Control ctr in gpbAdicionar.Controls) 
            {
                if(ctr is TextBox)
                {
                    ctr.Enabled = false; 
                }
            }
            limpaTexto();
        }

        private void salvarTipo(string text, string tipo,string text2)
        {
            clsConexão conexão = new clsConexão();
            SqlCommand cmd = new SqlCommand();
            string menssagem;
            // tipo é uma identificação para o metodo saber qual "if" ele deve entrar
            // text é o texto escrito dentro da textBox, e esse texto sera inserido no banco nas devida tabelas
            if (tipo == "CATEGORIA")
            {
                cmd.CommandText = "INSERT INTO CATEGORIA (NOME_CATEGORIA) VALUES (@categoria)";
                cmd.Parameters.AddWithValue("@categoria", text);
            }
            else if (tipo == "EDITORA")
            {
                cmd.CommandText = " INSERT INTO EDITORA (NOME_EDITORA) VALUES (@editora)";
                cmd.Parameters.AddWithValue("@editora", text);
            }
            else if (tipo == "GENERO")
            {
                cmd.CommandText = "INSERT INTO GENERO (NOME) VALUES (@genero)";
                cmd.Parameters.AddWithValue("@genero", text);

            }
            else if (tipo == "AUTOR")
            {
                cmd.CommandText = "INSERT INTO AUTOR (NOME_AUTOR,PHA) VALUES (@autor,@pha)";
                cmd.Parameters.AddWithValue("@autor", text);
                cmd.Parameters.AddWithValue("pha", text2);
            }
            else if (tipo == "COLECAO")
            {
                cmd.CommandText = "INSERT INTO COLECAO (NOME_COLECAO) VALUES (@colecao)";
                cmd.Parameters.AddWithValue("@colecao", text);
            }
            else if (tipo == "PERIODICO")
            {
                cmd.CommandText = "INSERT INTO PERIODICOS (MATERIAL) VALUES (@material)";
                cmd.Parameters.AddWithValue("@material", text);

            }
            try
            {
                cmd.Connection = conexão.conectar();
                cmd.ExecuteNonQuery();
                conexão.desconectar();
                MessageBox.Show("Cadastrado com Sucesso");

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao tentar se conectar com o Banco de Dados");

            }
            finally
            {
                conexão.desconectar();
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            gpbAdicionar.Enabled = true;
            limpaTexto();
            txtEditora.Enabled = false;
            txtCategoria.Enabled = false;
            txtGenero.Enabled = false;
            txtAutor.Enabled = false;
            txtColecao.Enabled = false;
            txtPha.Enabled = false;

        }

        private void rdbEditora_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEditora.Checked == true)
            {
                txtEditora.Enabled = true;
                txtAutor.Enabled = false;
                txtCategoria.Enabled = false;
                txtGenero.Enabled = false;
                txtColecao.Enabled = false;
                txtPha.Enabled = false;

                txtColecao.Text = "";
                txtAutor.Text = "";
                txtCategoria.Text = "";
                txtEditora.Text = "";
                txtPha.Text = "";
                txtGenero.Text = "";
                btnAdd.Enabled = true;
            }
        }

        private void rdbCategorai_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCategorai.Checked == true)
            {
                txtCategoria.Enabled = true;
                txtEditora.Enabled = false;
                txtAutor.Enabled = false;
                txtGenero.Enabled = false;
                txtColecao.Enabled = false;
                txtPha.Enabled = false;

                txtColecao.Text = "";
                txtAutor.Text = "";
                txtCategoria.Text = "";
                txtEditora.Text = "";
                txtPha.Text = "";
                txtGenero.Text = "";
                btnAdd.Enabled = true;
            }
        }

        private void rdbGenero_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGenero.Checked == true)
            {
                txtGenero.Enabled = true;
                txtEditora.Enabled = false;
                txtCategoria.Enabled = false;
                txtAutor.Enabled = false;
                txtColecao.Enabled = false;
                txtPha.Enabled = false;

                txtColecao.Text = "";
                txtCategoria.Text = "";
                txtEditora.Text = "";
                txtGenero.Text = "";
                txtAutor.Text = "";
                btnAdd.Enabled = true;
                txtPha.Text = "";

            }
        }
        private void limpaTexto()
        {
            foreach (Control ctl in gpbAdicionar.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
                else if (ctl is RadioButton)
                {
                    ((RadioButton)ctl).Checked = false;
                }
            }
        }

        private void cadTipos_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnVoltar_Click(null, null, Box1.Text);
        }

        public void btnVoltar_Click(object sender, EventArgs e, string text)
        {
            if (Box1.Text == "livro")
            {
                cadLivro cadTipo = cadLivro.cadSelf;
                cadLivro.cadSelf.carregarComboCategoria();
                cadLivro.cadSelf.carregarComboEditora();
                cadLivro.cadSelf.carregarComboGenero();
                cadLivro.cadSelf.carregaAutor();
                cadLivro.cadSelf.carregarColecao();
                cadTipo.Visible = true;
                this.Dispose();



            }

            else if (Box1.Text == "periodicos")
            {
                cadPeriodicos cadTipo = cadPeriodicos.cSelf;
                cadPeriodicos.cSelf.carregaAutor();
                cadPeriodicos.cSelf.carregarComboEditoraP();
                cadTipo.Visible = true;
                this.Dispose();
            }
            foreach (Control ctr in cadLivro.cadSelf.Controls)
            {
                if (ctr is GroupBox)
                {
                    foreach (Control ct2 in ctr.Controls)
                    {
                        if (ct2 is ComboBox)
                        {
                            if (((ComboBox)ct2).Items.Count < 1)
                            {
                                ct2.Enabled = false;
                            }
                            else
                            {
                                ct2.Enabled = true;
                            }
                        }
                    }
                }
            }
        }




        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaTexto();
        }

        private void rdbAutor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAutor.Checked == true)
            {
                txtGenero.Enabled = false;
                txtEditora.Enabled = false;
                txtCategoria.Enabled = false;
                txtAutor.Enabled = true;
                txtColecao.Enabled = false;
                txtPha.Enabled = true;

                txtColecao.Text = "";
                txtAutor.Text = "";
                txtCategoria.Text = "";
                txtEditora.Text = "";
                txtGenero.Text = "";
                txtPha.Text = "";
                btnAdd.Enabled = true;

            }
        }

        private void rdbColecao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbColecao.Checked == true)
            {
                txtAutor.Enabled = false;
                txtCategoria.Enabled = false;
                txtColecao.Enabled = true;
                txtEditora.Enabled = false;
                txtGenero.Enabled = false;
                txtPha.Enabled = false;

                txtGenero.Text = "";
                txtEditora.Text = "";
                txtPha.Text = "";
                txtColecao.Text = "";
                txtCategoria.Text = "";
                txtAutor.Text = "";
                btnAdd.Enabled = true;
            }
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            btnVoltar_Click(null, null, Box1.Text);
        }
    }



}
