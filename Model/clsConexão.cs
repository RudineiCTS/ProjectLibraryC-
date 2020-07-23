using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMBIBLIO
{
  
    public class clsConexão
    {
        SqlConnection con = new SqlConnection();
        //Construtor


        public clsConexão()
        {
            //Pega o endereço daonde o banco de dados está instalado
            //con.ConnectionString = @"Data Source=localhost;Initial Catalog=db_PMBY;Integrated Security=True";
            //con.ConnectionString = @"Data Source=UNIFAFIBE-PC\UNIFAFIBE;Initial Catalog=db_PMBY;Integrated Security=True"; //Altere a senha se necessário
            //con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_PMBY;user id=sa;password=sa";//Altere a senha se necessário
            con.ConnectionString = @"Data Source=DESKTOP-9A1B1A3\SQLEXPRESS;Initial Catalog=db_PMBBLIO;Integrated Security=True";
        }
        //Método para conexão
        public SqlConnection conectar()
        {
            //verifica se a conexão já está aberta, se não está, abre
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            return con;
        }

        //Método para desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
