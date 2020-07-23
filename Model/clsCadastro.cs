using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMBIBLIO
{
    class clsCadastro
    {
        clsConexão conexao = new clsConexão();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public void salvarCliente(string nome, string endereco, string cidade, string fone, string cell, string email, string cpfCliente, string rgCliente, string data)
        {
            // comando de texto será digitado na query do sql 
            cmd.CommandText = "INSERT INTO CLIENTE (NOME, ENDERECO, CIDADE, FONE,CELULAR, EMAIL, CPF_CLIENTE, RG_CLIENTE, DATA_NASC) VALUES (@nome, @endereco, @cidade, @fone,@cell, @email, @cpf_cliente, @rg_cliente, @data_nasc)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@fone", fone);
            cmd.Parameters.AddWithValue("@cell", cell);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@cpf_cliente", cpfCliente);
            cmd.Parameters.AddWithValue("@rg_cliente", rgCliente);
            cmd.Parameters.AddWithValue("@data_nasc", data);
            try
            {
                // conecta com o banco
                cmd.Connection = conexao.conectar();
                //executa comando
                cmd.ExecuteNonQuery();
                //fecha conexao
                conexao.desconectar();

                mensagem = "Cadastrado com sucesso";
            }
            catch (SqlException e)
            {
                mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
            finally
            {
                conexao.desconectar();
            }
        }
        
        public void salvarLivro(string titulo, int autor, string ISBN, bool referencia, int codCategoria, int codEditora, int codGenero, int codColecao, string cdu, string exemplares, string paginas,string volume)
        {
            cmd.CommandText = "INSERT INTO LIVRO ( TITULO, AUTOR_LIVRO, ISBN, REFERENCIA, CATEG_LIVRO, EDITORA_LIVRO,GENERO_LIVRO,COLECAO_LIVRO,CDU,N_EXEMPLARES,N_PAGINAS,VOLUME) VALUES (@titulo, @autor, @isbn, @referencia, @categoria, @editora, @genero, @colecao, @cdu, @exemplares, @paginas, @volume)";
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@autor", autor);
            cmd.Parameters.AddWithValue("@isbn", ISBN);
            cmd.Parameters.AddWithValue("@referencia", referencia);
            cmd.Parameters.AddWithValue("@categoria", codCategoria);
            cmd.Parameters.AddWithValue("@editora", codEditora);
            cmd.Parameters.AddWithValue("@genero", codGenero);
            cmd.Parameters.AddWithValue("@colecao", codColecao);
            cmd.Parameters.AddWithValue("@cdu", cdu);
            cmd.Parameters.AddWithValue("@exemplares", exemplares);
            cmd.Parameters.AddWithValue("@paginas", paginas);
            cmd.Parameters.AddWithValue("@volume", volume);
            try
            {
                //conecta com o banco
                cmd.Connection = conexao.conectar();
                //executa comando
                cmd.ExecuteNonQuery();
                //fecha conexao
                conexao.desconectar();
                mensagem = "Livro Cadastrado com Sucesso";
            }
            catch (SqlException e)
            {
                mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
            finally
            {
                conexao.desconectar();
            }
        }


        public void locar(int cliente, int livro, string dataInicial, string datafinal)
        {

            cmd.CommandText = "INSERT INTO LOCACAO(CLI_LOCACAO,LIVR_LOCACAO,DATA_INICIAL,DATA_ENTREGA,LIVR_LOCADO) VALUES (@cliente,@livro,@dataInicial,@datafinal,1)";
            cmd.Parameters.AddWithValue("@cliente", cliente);
            cmd.Parameters.AddWithValue("@livro", livro);
            cmd.Parameters.AddWithValue("@dataInicial", dataInicial);
            cmd.Parameters.AddWithValue("@datafinal", datafinal);


            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                mensagem = "Locação de livro realizada com sucesso";



            }
            catch (SqlException e)
            {
                mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
            finally
            {
                conexao.desconectar();
            }



        }
        public void locarPeriodico(int cliente, int livro, string dataInicial, string datafinal)        
        {
            cmd.CommandText = "INSERT INTO LOCA_PERIODICO(CLI_LOCACAO,PERI_LOCADO,DATA_INICIAL,DATA_ENTREGA,PERIODICO_LC) VALUES (@cliente, @livro, @datainicial, @datafinal,1) ";
            cmd.Parameters.AddWithValue("@cliente", cliente);
            cmd.Parameters.AddWithValue("@livro", livro);
            cmd.Parameters.AddWithValue("@datainicial", dataInicial);
            cmd.Parameters.AddWithValue("@datafinal", datafinal);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteReader();
                conexao.desconectar();
                mensagem = "Locação de periódico realizada com sucesso";
            }catch(SqlException e)
            {
                mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
            finally
            {
                conexao.desconectar();
            }
        }
        public void devolver(int codcliente, int codleitor)
        {

            cmd.CommandText = "UPDATE LOCACAO SET LIVR_LOCADO = 0 WHERE CLI_LOCACAO = @cliente AND LIVR_LOCACAO = @livro";
            cmd.Parameters.AddWithValue("@cliente", codcliente);
            cmd.Parameters.AddWithValue("@livro", codleitor);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
            }
            catch (SqlException e)
            {

                mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
            finally
            {
                conexao.desconectar();
            }

        }


        public void editar(int valor, string nome, string endereco, string cidade, string teledone, string celular, string email, string cpf, string rg, string data_nasc)
        {

            cmd.CommandText = "UPDATE CLIENTE SET NOME = @nome,ENDERECO = @endereco, CIDADE = @cidade, FONE = @telefone,CELULAR = @cell, EMAIL =@email, CPF_CLIENTE =@cpf, RG_CLIENTE= @rg, DATA_NASC = @nascimento WHERE ID_CLIENTE = @id";
            cmd.Parameters.AddWithValue("@id", valor);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@telefone", teledone);
            cmd.Parameters.AddWithValue("@cell", celular);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@rg", rg);
            cmd.Parameters.AddWithValue("@nascimento", data_nasc);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                mensagem = "Usuário editado com sucesso";
            }
            catch (SqlException e)
            {

                mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
            finally
            {
                conexao.desconectar();
            }

        }

        public void excluir(int cod)
        {
            cmd.CommandText = "DELETE FROM CLIENTE WHERE ID_CLIENTE = @cliente";
            cmd.Parameters.AddWithValue("@cliente", cod);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                mensagem = "Cliente excluído com sucesso!";
            }
            catch (SqlException e)
            {
                if (e.Number == 547)
                {
                    mensagem = "Este cliente possui um livro locado. É necessário que se devolva os livros antes!";

                    DialogResult dialog = MessageBox.Show("Deseja excluir todos os livros do cliente?",
                            "", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        cmd.CommandText = "DELETE FROM LOCACAO WHERE CLI_LOCACAO = @cliente";
                        try
                        {
                            cmd.Connection = conexao.conectar();
                            cmd.ExecuteNonQuery();
                            conexao.desconectar();
                            cmd.CommandText = "DELETE FROM CLIENTE WHERE ID_CLIENTE = @cliente";
                            try
                            {
                                //conectar com o banco
                                cmd.Connection = conexao.conectar();
                                //executar comando
                                cmd.ExecuteNonQuery();
                                //desconectar
                                conexao.desconectar();
                                this.mensagem = "Cadastros excluídos com sucesso!";
                            }
                            catch (SqlException e2)
                            {
                                this.mensagem = "Não foi possível deletar o cliente!";
                            }
                        }
                        catch (SqlException e3)
                        {
                            this.mensagem = "Não foi possível deletar os livros!";
                        }
                        finally
                        {
                            conexao.desconectar();
                        }
                    }
                    else
                    {
                        this.mensagem = "Operação cancelada.";
                    }

                }
                else
                {
                    this.mensagem = "Erro ao tentar se conectar com o banco de Dados";
                }

            }
        }
        public void editarLivro(string titulo, int codigoAutor, string txtISBN, int codigoEditora, int codigoCategoria, int codigoGenero, int codigoColecao, bool referencia, string POG,string vol, string pagina, string exemp, string cdu)
        {//L.ID_LIVRO[Código], L.TITULO[Titulo], L.ISBN, L.CDU, L.REFERENCIA[Referencia], A.NOME_AUTOR[Autor], A.PHA, E.NOME_EDITORA[Editora], C.NOME_CATEGORIA[Categoria], G.NOME[Gênero], CO.NOME_COLECAO[Coleção], L.VOLUME[Volume], L.N_PAGINAS[N° páginas], L.N_EXEMPLARES[N° exemplares] 
            cmd.CommandText = "UPDATE LIVRO SET TITULO = @titulo,AUTOR_LIVRO = @autor,ISBN = @isbn,EDITORA_LIVRO= @editora,CATEG_LIVRO=@categoria,GENERO_LIVRO= @genero,COLECAO_LIVRO=@colecao, REFERENCIA=@refe, VOLUME = @vol, N_PAGINAS = @pag, N_EXEMPLARES = @exemp, CDU = @cdu WHERE ID_LIVRO = @pog";
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@autor", codigoAutor);
            cmd.Parameters.AddWithValue("@isbn", txtISBN);
            cmd.Parameters.AddWithValue("@editora", codigoEditora);
            cmd.Parameters.AddWithValue("@categoria", codigoCategoria);
            cmd.Parameters.AddWithValue("@genero", codigoGenero);
            cmd.Parameters.AddWithValue("@colecao", codigoColecao);
            cmd.Parameters.AddWithValue("@refe", referencia);
            cmd.Parameters.AddWithValue("@pog", POG);
            cmd.Parameters.AddWithValue("@vol", vol);
            cmd.Parameters.AddWithValue("@pag", pagina);
            cmd.Parameters.AddWithValue("@exemp", exemp);
            cmd.Parameters.AddWithValue("@cdu", cdu);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                mensagem = "Livro editado com sucesso!";
            }
            catch(SqlException e)
            {
                mensagem = "Erro ao tentar se conectar com o banco de Dados";
            }
            finally
            {
                conexao.desconectar();
            }
        }

        public void excluir_livro(int cod)
        {
            cmd.CommandText = "DELETE FROM LIVRO WHERE ID_LIVRO = @livro";
            cmd.Parameters.AddWithValue("@livro", cod);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                mensagem = "livro excluído com sucesso!";
            }
            catch (SqlException e)
            {
                if (e.Number == 547)
                {
                    mensagem = "Este livro está locado. É necessário que se devolva o livro antes!";

                    DialogResult dialog = MessageBox.Show("Deseja excluir o livro mesmo assim?",
                            "", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        cmd.CommandText = "DELETE FROM LOCACAO WHERE LIVR_LOCACAO = @livro";
                        try
                        {
                            cmd.Connection = conexao.conectar();
                            cmd.ExecuteNonQuery();
                            conexao.desconectar();
                            cmd.CommandText = "DELETE FROM LIVRO WHERE ID_LIVRO = @livro";
                            try
                            {
                                //conectar com o banco
                                cmd.Connection = conexao.conectar();
                                //executar comando
                                cmd.ExecuteNonQuery();
                                //desconectar
                                conexao.desconectar();
                                this.mensagem = "livro excluído com sucesso!";
                            }
                            catch (SqlException e2)
                            {
                                this.mensagem = "Não foi possível deletar o livro!";
                            }
                        }
                        catch (SqlException e3)
                        {
                            this.mensagem = "Não foi possível devolver os livros!";
                        }
                        finally
                        {
                            conexao.desconectar();
                        }
                    }
                    else
                    {
                        this.mensagem = "Operação cancelada.";
                    }

                }
                else
                {
                    this.mensagem = "Erro ao tentar se conectar com o banco de Dados";
                }
            }
        }
        //txtPeriodico.Text,codigoAutorP,codigoEditora,codigoMaterial, cbAssinatura.SelectedItem.ToString
        public void salvarPeriodico(string titulo, int codAutor, int codEditora, string material, string assinatura,bool emprestimo)
        {
            cmd.CommandText = "INSERT INTO PERIODICOS (TITULO, ASSINATURA, AUTOR, EDITORA, MATERIAL,EMPRESTIMO) VALUES (@titulo1, @assinatura1, @autor1, @editora1, @material1, @emprestimo1)";
            //cmd.CommandText = "EXECUTE SALVAPERIODICO @titulo = @titulo1, @assinatura = @assinatura1, @autor = @autor1, @editora = editora1, @material = @material1, @emprestimo = @emprestimo1 ";
            cmd.Parameters.AddWithValue("@titulo1", titulo);
            cmd.Parameters.AddWithValue("@assinatura1", assinatura);
            cmd.Parameters.AddWithValue("@autor1", codAutor);
            cmd.Parameters.AddWithValue("@editora1", codEditora);
            cmd.Parameters.AddWithValue("@material1", material);
            cmd.Parameters.AddWithValue("@emprestimo1", emprestimo);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                mensagem = "Periódico cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                mensagem = "Erro ao tentar se conectar com o banco de Dados";
            }
            finally
            {
                conexao.desconectar();
            }
        }

        public void devolverPeri(int codigoCli, int codigoLiv)
        {
            cmd.CommandText = "UPDATE LOCA_PERIODICO SET PERIODICO_LC = 0 WHERE CLI_LOCACAO = @cliente AND PERI_LOCADO = @livro";
            cmd.Parameters.AddWithValue("@cliente", codigoCli);
            cmd.Parameters.AddWithValue("@livro", codigoLiv);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
            }
            catch (SqlException e)
            {

                mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
            finally
            {
                conexao.desconectar();
            }
        }
        public void editarPeri(string titulo, string material, int autor, string assinatura, int editora, bool emprestimo, string txtID)
        {
            cmd.CommandText = "UPDATE PERIODICOS SET TITULO = @titulo,AUTOR = @autor,EDITORA= @editora,MATERIAL=@material,ASSINATURA= @assinatura,EMPRESTIMO=@emprestimo WHERE ID like @id_peri";
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@autor", autor);
            cmd.Parameters.AddWithValue("@editora", editora);
            cmd.Parameters.AddWithValue("@material", material);
            cmd.Parameters.AddWithValue("@assinatura", assinatura);
            cmd.Parameters.AddWithValue("@emprestimo", emprestimo);
            cmd.Parameters.AddWithValue("@id_peri", txtID);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                mensagem = "Periódico editado com sucesso!";
            }
            catch (SqlException e)
            {
                mensagem = "Erro ao tentar se conectar com o banco de Dados";
            }
            finally
            {
                conexao.desconectar();
            }

        }

        public void excluirPeri(int peri)
        {
            cmd.CommandText = "DELETE FROM PERIODICOS WHERE ID = @perio";
            cmd.Parameters.AddWithValue("@perio", peri);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                mensagem = "Periódico excluído com sucesso!";
            }
            catch (SqlException e)
            {
                if (e.Number == 547)
                {
                    mensagem = "Este Periódico está locado. É necessário que se devolva o Periódico antes!";

                    DialogResult dialog = MessageBox.Show("Deseja excluir o periódico mesmo assim?",
                            "", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        cmd.CommandText = "DELETE FROM LOCA_PERIODICO WHERE PERI_LOCADO = @perio";
                        try
                        {
                            cmd.Connection = conexao.conectar();
                            cmd.ExecuteNonQuery();
                            conexao.desconectar();
                            cmd.CommandText = "DELETE FROM PERIODICOS WHERE ID = @perio";
                            try
                            {
                                //conectar com o banco
                                cmd.Connection = conexao.conectar();
                                //executar comando
                                cmd.ExecuteNonQuery();
                                //desconectar
                                conexao.desconectar();
                                this.mensagem = "Periódico excluído com sucesso!";
                            }
                            catch (SqlException e2)
                            {
                                this.mensagem = "Não foi possível deletar o Periódicos!";
                            }
                        }
                        catch (SqlException e3)
                        {
                            this.mensagem = "Não foi possível devolver os Periódicos!";
                        }
                        finally
                        {
                            conexao.desconectar();
                        }
                    }
                    else
                    {
                        this.mensagem = "Operação cancelada.";
                    }

                }
                else
                {
                    this.mensagem = "Erro ao tentar se conectar com o banco de Dados";
                }
            }
        }
    }
}


