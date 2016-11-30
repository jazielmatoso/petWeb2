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
    public class UsuarioDaoImp : UsuarioDao
    {
        Conexao conn;

        public UsuarioDaoImp()
        {
            this.conn = new Conexao();
        }


        public void insertUsuario(Usuario usuario)
        {
            try
            {

                this.conn.openConnection();

                string sql = "INSERT INTO usuario (nome,login,senha,telefone)  VALUES (@nome,@login,@senha,@telefone)";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@login", usuario.Login);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Usuario :" + ce.Message);
            }
            
                
        }



        public void alterarUsuario(Usuario usuario)
        {
            try
            {

                this.conn.openConnection();
                string sql = "UPDATE usuario SET nome = @nome WHERE id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@id", usuario.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Alterar Usuario :" + ce.Message);
            }


        }


        public void deletarUsuario(Usuario usuario)
        {
            try
            {

                this.conn.openConnection();
                string sql = "DELETE FROM usuario WHERE id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@id", usuario.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }catch (SqlException ce){

                throw new DaoException("Erro ao Alterar Usuario :" + ce.Message);
            }


        }


        public List<Usuario> listUsuario() { 
        
            List<Usuario> lUsuario = new List<Usuario>();
            
            try
            {
                this.conn.openConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select id,nome,telefone from usuario";
                cmd.Connection = this.conn.SqlConn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    usuario.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    lUsuario.Add(usuario);
                }
                this.conn.closeConnection();
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Usuarios :" + ce.Message);
            }

            return lUsuario;



        }
    }
}

