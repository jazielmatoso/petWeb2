using System;
using System.Collections.Generic;

using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Util;
using Backend.Basicas;
using Backend.Erro;

namespace Backend.Dados
{
    public class EspecieDaoImp  : EspecieDao {

        Conexao conn;


        public EspecieDaoImp()
        {

            this.conn = new Conexao();
        }


        
        public Especie getEspecie(int especieId)
        {


            try
            {
                this.conn.openConnection();
                Especie especie = new Especie();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT id,nome,descricao,data_cadastro FROM especie WHERE id = @especie";
                cmd.Connection = this.conn.SqlConn;
                cmd.Parameters.AddWithValue("@especie", especieId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    especie.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    especie.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    especie.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                    especie.DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro"));
                }
                this.conn.closeConnection();

                return especie;
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Alterar Especie :" + ce.Message);
            }


        }



        

        public void inserirEspecie(Especie especie)
        {
            try
            {

                this.conn.openConnection();
                string sql = "INSERT INTO especie (nome,descricao) VALUES (@nome,@descricao)";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@nome", especie.Nome);
                cmd.Parameters.AddWithValue("@descricao", especie.Descricao);
                //cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Espécie :" + ce.Message);
            }


        }



        public void alterarEspecie(Especie especie)
        {
            try
            {

                this.conn.openConnection();
                string sql = "UPDATE especie SET nome = @nome,descricao = @descricao WHERE codEspecie = @id_especie";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id_especie", especie.Id);
                cmd.Parameters.AddWithValue("@nome", especie.Nome);
                cmd.Parameters.AddWithValue("@descricao", especie.Descricao);
                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Alterar Espécie :" + ce.Message);
            }


        }


        public void deletarEspecie(Especie especie)
        {
            try
            {

                this.conn.openConnection();
                string sql = "DELETE FROM especie WHERE codEspecie = @especie_id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@especie_id", especie.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Especies :" + ce.Message);
            }





        }


        public List<Especie> listarEspecie()
        {

            List<Especie> lEspecie = new List<Especie>();

            try
            {
                this.conn.openConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select especie_id,nome,descricao from especie";
                cmd.Connection = this.conn.SqlConn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Especie especie = new Especie();
                    especie.Id = reader.GetInt32(reader.GetOrdinal("especie_id"));
                    especie.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    especie.Descricao = reader.GetString(reader.GetOrdinal("descricao"));

                    lEspecie.Add(especie);
                }
                this.conn.closeConnection();
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Espécies :" + ce.Message);
            }

            return lEspecie;



        }

    }
}

