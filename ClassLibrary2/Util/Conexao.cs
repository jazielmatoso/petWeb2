using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Backend.Erro;

namespace Backend.Util
{
    public class Conexao
    {

        public const String usuario = "admin";
        public const String senha = "123456";
        public const String banco = "petweb";
        public const String host = @"TI01\SQLEXPRESS";

        public String connectionString = "";

        private SqlConnection sqlConn;

        public SqlConnection SqlConn
        {
            get { return sqlConn; }
            set { sqlConn = value; }
        }

        public Conexao()
        {
            this.ConnectionString = @"Data Source=" + host + ";Initial Catalog=" + banco + ";User Id=" + usuario + ";Password=" + senha + ";";
        }


        public String ConnectionString { get; set ;}
        
        public void openConnection()
        {
            try
            {
                this.sqlConn = new SqlConnection(this.ConnectionString);
                this.sqlConn.Open();
            }
            catch (SqlException error)
            {
                throw new ConexaoException("Erro ao abrir conexao :" + error.Message);
            }
        }



        public void closeConnection()
        {
            try
            {

                this.sqlConn.Close();
                this.sqlConn.Dispose();


            }
            catch (SqlException error)
            {
                throw new ConexaoException("Erro ao fechar conexao :" + error.Message);
            }
        }
    }
}