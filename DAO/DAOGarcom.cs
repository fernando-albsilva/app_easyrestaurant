using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using model;

namespace DAO
{
    public class DAOGarcom
    {
       
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=app_easy_restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private string queyString;
      
        public List<Garcom> consultaTabelaGarcom()
        {

            List<Garcom> listaDeGarcom = new List<Garcom>();
            try
            {
                SqlConnection sqlConn = new SqlConnection(connectionString);

                sqlConn.Open();

                queyString = "select * from tabela_garcom";
                SqlCommand cmd = new SqlCommand(queyString, sqlConn);
                SqlDataReader dados = cmd.ExecuteReader();

                while (dados.Read())
                {


                    Garcom garcom = new Garcom("", "");
                    garcom.Nome = dados.GetString(0);
                    garcom.Cpf_garcom = dados.GetString(1);
                    listaDeGarcom.Add(garcom);

                }

                dados.Close();
                return listaDeGarcom;
            }
            catch (SqlException ex)
            {
              
                Console.WriteLine(ex.ToString());
                return listaDeGarcom;
            }
        }


        public Garcom consultaGarcom(Garcom garcom)
        {
         
               
            try
            {
                SqlConnection sqlConn = new SqlConnection(connectionString);

                sqlConn.Open();

                queyString = "select * from tabela_garcom where cpf ='"+ garcom.Cpf_garcom+"'";
                SqlCommand cmd = new SqlCommand(queyString, sqlConn);
                SqlDataReader dados = cmd.ExecuteReader();

                while (dados.Read())
                {


                    garcom.Nome = dados.GetString(0);
                    garcom.Cpf_garcom = dados.GetString(1);


                }
                dados.Close();
                Console.WriteLine(" nome garcom:" + garcom.Nome);
                Console.WriteLine(" cpf garcom:" + garcom.Cpf_garcom);
                return garcom;
            }
            catch (SqlException ex)
            {
                
                Console.WriteLine(ex.ToString());
                return garcom;
            }
        }

        public void insereGarcom(Garcom garcom)
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


        public void alteraGarcom(Garcom garcom, string cpfPk)
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