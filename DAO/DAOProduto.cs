using model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAO
{
    public class DaoProduto
    {
       
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=app_easy_restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private string queyString;
      
        public List<Produto> cosultaTabelaProduto()
        {

            List<Produto> listaDeProduto = new List<Produto>();
            try
            {
                SqlConnection sqlConn = new SqlConnection(connectionString);

                sqlConn.Open();

                queyString = "select * from tabela_produto";
                SqlCommand cmd = new SqlCommand(queyString, sqlConn);
                SqlDataReader dados = cmd.ExecuteReader();

                while (dados.Read())
                {


                    Produto produto = new Produto("", "");
                    //refazer os atributos
                    produto.Nome = dados.GetString(0);
                    produto.Cpf_garcom = dados.GetString(1);
                    listaDeProduto.Add(produto);

                }

                dados.Close();
                return listaDeProduto;
            }
            catch (SqlException ex)
            {
              
                Console.WriteLine(ex.ToString());
                return listaDeProduto;
            }
        }


        public Produto consultaGarcom(Produto produto)
        {
         
               
            try
            {
                SqlConnection sqlConn = new SqlConnection(connectionString);

                sqlConn.Open();

                queyString = "select * from tabela_produto where cpf ='" + produto.Cpf_garcom+"'";
                SqlCommand cmd = new SqlCommand(queyString, sqlConn);
                SqlDataReader dados = cmd.ExecuteReader();

                while (dados.Read())
                {


                    produto.Nome = dados.GetString(0);
                    produto.Cpf_garcom = dados.GetString(1);


                }
                dados.Close();
                Console.WriteLine(" nome garcom:" + produto.Nome);
                Console.WriteLine(" cpf garcom:" + produto.Cpf_garcom);
                return produto;
            }
            catch (SqlException ex)
            {
                
                Console.WriteLine(ex.ToString());
                return produto;
            }
        }

        public void insereGarcom(Produto garcom)
        {

            
            try
            {
                SqlConnection sqlConn = new SqlConnection(connectionString);

                sqlConn.Open();

                queyString = "insert into tabela_garcom (nome_garcom,cpf) values  ('" + garcom.Nome +  "','" + garcom.Cpf_garcom + "')";

                SqlCommand cmd = new SqlCommand(queyString, sqlConn);

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());

            }
        }


        public void alteraGarcom(Produto garcom, string cpfPk)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(connectionString);

                sqlConn.Open();

                queyString = "update tabela_garcom set nome_garcom = '"+ garcom.Nome+"',cpf = '"+ garcom.Cpf_garcom +"'  where cpf='"+cpfPk+"'";

                SqlCommand cmd = new SqlCommand(queyString, sqlConn);

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());

            }
        }

        public void deletaGarcom(string cpfPk)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(connectionString);

                sqlConn.Open();

                queyString = "delete from tabela_garcom where cpf='" + cpfPk + "'";

                SqlCommand cmd = new SqlCommand(queyString, sqlConn);

                cmd.ExecuteNonQuery();

                cmd.Dispose();

            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());

            }
        }

    }
    
}

//https://www.connectionstrings.com/
//https://docs.microsoft.com/pt-br/dotnet/api/system.data.sqlclient.sqldatareader?view=dotnet-plat-ext-5.0