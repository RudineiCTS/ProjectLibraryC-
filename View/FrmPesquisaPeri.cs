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
    public partial class FrmPesquisaPeri : Form
    {

        public FrmPesquisaPeri()
        {
            InitializeComponent();
            txtAutor.Enabled = false;
            txtEditora.Enabled = false;
            txtMaterial.Enabled = false;
            txtTitulo.Enabled = false;
            dataFill();
            cabecalho();

        }

        private void FrmPesquisaPeri_FormClosed(object sender, FormClosedEventArgs e)
        {
            //clsControl.abreMenu(frmMenu.Self);
            cadPeriodicos cadPeriodicos = cadPeriodicos.cSelf;
            cadPeriodicos.Visible = true;
            this.Dispose();


        }
        private void cabecalho()
        {
            dgvPeri.Columns[0].Width = 60;
            dgvPeri.Columns[1].Width = 145;
            dgvPeri.Columns[2].Width = 140;
            dgvPeri.Columns[3].Width = 95;
            dgvPeri.Columns[4].Width = 128;
            dgvPeri.Columns[5].Width = 100;
            dgvPeri.Columns[6].Width = 65;
       
        }

        private void dataFill()
        {
            clsConexão conexao = new clsConexão();

            try
            {
                // preenchendo tabela com os dados do banco 
                SqlDataAdapter dataAdp = new SqlDataAdapter("SELECT  PE.ID[Código],PE.TITULO[Titulo],AUTOR.NOME_AUTOR[Autor],PE.MATERIAL[Material],EDITORA.NOME_EDITORA[Editora],PE.ASSINATURA[Assinatura],PE.EMPRESTIMO[Emprestimo] FROM PERIODICOS AS PE INNER JOIN AUTOR ON AUTOR.ID_AUTOR = PE.AUTOR INNER JOIN EDITORA ON EDITORA.ID_EDITORA = PE.EDITORA ", conexao.conectar());
                DataTable tabelaDados = new DataTable();
                dataAdp.Fill(tabelaDados);
                dgvPeri.DataSource = tabelaDados;
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
            if (rdbTitulo.Checked == true)
            {
                txtTitulo.Enabled = true;
                txtMaterial.Enabled = false;
                txtEditora.Enabled = false;
                txtAutor.Enabled = false;

                txtTitulo.Text = "";
                txtMaterial.Text = "";
                txtEditora.Text = "";
                txtAutor.Text = "";
            }


        }

        private void rdbMaterial_CheckedChanged(object sender, EventArgs e)
        {

            txtTitulo.Enabled = false;
            txtMaterial.Enabled = true;
            txtEditora.Enabled = false;
            txtAutor.Enabled = false;

            txtTitulo.Text = "";
            txtMaterial.Text = "";
            txtEditora.Text = "";
            txtAutor.Text = "";
        }

        private void rdbAutor_CheckedChanged(object sender, EventArgs e)
        {

            txtTitulo.Enabled = false;
            txtMaterial.Enabled = false;
            txtEditora.Enabled = false;
            txtAutor.Enabled = true;

            txtTitulo.Text = "";
            txtMaterial.Text = "";
            txtEditora.Text = "";
            txtAutor.Text = "";
        }

        private void rdbEditora_CheckedChanged(object sender, EventArgs e)
        {

            txtTitulo.Enabled = false;
            txtMaterial.Enabled = false;
            txtEditora.Enabled = true;
            txtAutor.Enabled = false;

            txtTitulo.Text = "";
            txtMaterial.Text = "";
            txtEditora.Text = "";
            txtAutor.Text = "";
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (rdbTitulo.Checked)
            {
                pesquisaTitulo(txtTitulo.Text);
                btnDesfiltro.Enabled = true;
            }
            if (rdbAutor.Checked)
            {
                pesquisaAutor(txtAutor.Text);
                btnDesfiltro.Enabled = true;
            }
            if (rdbEditora.Checked)
            {
                pesquisaEditora(txtEditora.Text);
                btnDesfiltro.Enabled = true;
            }
            if (rdbMaterial.Checked)
            {
                pesquisaMaterial(txtMaterial.Text);
                btnDesfiltro.Enabled = true;
            }
        }

        private void pesquisaMaterial(string text)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();

            try
            {
                sqlB.Append("SELECT PE.ID[Código],PE.TITULO[Titulo],AUTOR.NOME_AUTOR[Autor],PE.MATERIAL[Material],EDITORA.NOME_EDITORA[Editora],PE.ASSINATURA[Assinatura],PE.EMPRESTIMO[Emprestimo] FROM PERIODICOS AS PE INNER JOIN AUTOR ON AUTOR.ID_AUTOR = PE.AUTOR INNER JOIN EDITORA ON EDITORA.ID_EDITORA = PE.EDITORA WHERE PE.MATERIAL like @valor");
                cmd.Parameters.Add(new SqlParameter("@valor", text + '%'));
                cmd.CommandText = sqlB.ToString();

                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPeri.DataSource = tabelaDados;
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void pesquisaEditora(string text)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();

            try
            {
                sqlB.Append("SELECT  PE.ID[Código],PE.TITULO[Titulo],AUTOR.NOME_AUTOR[Autor],PE.MATERIAL[Material],EDITORA.NOME_EDITORA[Editora],PE.ASSINATURA[Assinatura],PE.EMPRESTIMO[Emprestimo] FROM PERIODICOS AS PE INNER JOIN AUTOR ON AUTOR.ID_AUTOR = PE.AUTOR INNER JOIN EDITORA ON EDITORA.ID_EDITORA = PE.EDITORA WHERE EDITORA.NOME_EDITORA like @valor");
                cmd.Parameters.Add(new SqlParameter("@valor", text + '%'));
                cmd.CommandText = sqlB.ToString();

                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPeri.DataSource = tabelaDados;
                conexao.desconectar();


            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void pesquisaAutor(string text)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();

            try
            {
                sqlB.Append("SELECT  PE.ID[Código],PE.TITULO[Titulo],AUTOR.NOME_AUTOR[Autor],PE.MATERIAL[Material],EDITORA.NOME_EDITORA[Editora],PE.ASSINATURA[Assinatura],PE.EMPRESTIMO[Emprestimo] FROM PERIODICOS AS PE INNER JOIN AUTOR ON AUTOR.ID_AUTOR = PE.AUTOR INNER JOIN EDITORA ON EDITORA.ID_EDITORA = PE.EDITORA WHERE AUTOR.NOME_AUTOR like @valor");
                cmd.Parameters.Add(new SqlParameter("@valor", text + '%'));
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPeri.DataSource = tabelaDados;
                conexao.desconectar();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }

        }

        private void pesquisaTitulo(string text)
        {
            clsConexão conexao = new clsConexão();
            StringBuilder sqlB = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            DataTable tabelaDados = new DataTable();

            try
            {
                
                sqlB.Append("SELECT PE.ID[Código],PE.TITULO[Titulo],AUTOR.NOME_AUTOR[Autor],PE.MATERIAL[Material],EDITORA.NOME_EDITORA[Editora],PE.ASSINATURA[Assinatura],PE.EMPRESTIMO[Emprestimo] FROM PERIODICOS AS PE INNER JOIN AUTOR ON AUTOR.ID_AUTOR = PE.AUTOR INNER JOIN EDITORA ON EDITORA.ID_EDITORA = PE.EDITORA WHERE PE.TITULO like @valor");
                cmd.Parameters.Add(new SqlParameter("@valor", text + '%'));
                cmd.CommandText = sqlB.ToString();
                cmd.Connection = conexao.conectar();
                tabelaDados.Load(cmd.ExecuteReader());
                dgvPeri.DataSource = tabelaDados;
                conexao.desconectar();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados");
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void btnDesfiltro_Click(object sender, EventArgs e)
        {
            dataFill();
            btnDesfiltro.Enabled = false;
            clsControl.limparPesquisa(this);
/*
            foreach (Control item in gpbFiltro.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;


                }
                else if (item is RadioButton)
                {

                    ((RadioButton)item).Checked = false;
                }
                btnDesfiltro.Enabled = false;

            }*/

        }

        private void dgvPeri_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPeri.Rows.Count > 0)
            {
                string valid = Convert.ToString(dgvPeri.CurrentRow.Cells[0].Value);
                cadPeriodicos novocadastro = new cadPeriodicos(valid);
                novocadastro.txtPeriodico.Text = Convert.ToString(dgvPeri.CurrentRow.Cells[1].Value);
                novocadastro.txtMaterial.Text = Convert.ToString(dgvPeri.CurrentRow.Cells[3].Value);
                novocadastro.cbAutorP.Text = Convert.ToString(dgvPeri.CurrentRow.Cells[2].Value);
                novocadastro.cbEditoraP.Text = Convert.ToString(dgvPeri.CurrentRow.Cells[4].Value);
                novocadastro.cbAssinatura.Text = Convert.ToString(dgvPeri.CurrentRow.Cells[5].Value);
                novocadastro.chkEmprestimo.Checked = Convert.ToBoolean(dgvPeri.CurrentRow.Cells[6].Value);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Nenhum dado cadastrado!");
            }
            
        }
    }
}
/*  rdbAutor.Checked = false;
            rdbEditora.Checked = false;
            rdbMaterial.Checked = false;
            rdbTitulo.Checked = false;
            txtAutor.Enabled = false;
            txtEditora.Enabled = false;
            txtMaterial.Enabled = false;
            txtTitulo.Enabled = false;
            txtTitulo.Text = "";
            txtMaterial.Text = "";
            txtEditora.Text = "";
            txtAutor.Text = "";
 */
