using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Util;
using Backend.Basicas;
using Backend.Erro;
using System.Data.SqlClient;

namespace Backend.Dados
{
    public class ClienteDaoImp : ClienteDao
    {
        Conexao conn;

        public ClienteDaoImp()
        {
            this.conn = new Conexao();
        }
        public void alterarCliente(Cliente cliente)
        {
            try
            {

                this.conn.openConnection();
                string sql = "UPDATE cliente SET cpf = @cpf WHERE usuario_id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@nome", cliente.Cpf);
                cmd.Parameters.AddWithValue("@id", cliente.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Alterar Usuario :" + ce.Message);
            }
        }

        public void deletarCliente(Cliente cliente)
        {
            try
            {

                this.conn.openConnection();
                string sql = "DELETE FROM cliente WHERE id_usuario = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@id", cliente.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Alterar Usuario :" + ce.Message);
            }
        }

        public void insertCliente(Cliente cliente)
        {
            try
            {

                this.conn.openConnection();
                string sql = "INSERT INTO cliente(usuario_id,cpf,rg) VALUES (@usuario_id,@cpf,@rg)";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@usuario_id", cliente.Id);
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@rg", cliente.Rg);



                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Usuario :" + ce.Message);
            }
        }

        public List<Cliente> listCliente()
        {
            {
                List<Cliente> lcliente = new List<Cliente>();

                try
                {
                    this.conn.openConnection();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select usuario_id,cpf,rg from cliente";
                    cmd.Connection = this.conn.SqlConn;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.Id= reader.GetInt32(reader.GetOrdinal("usuario_id"));
                        cliente.Cpf = reader.GetInt32(reader.GetOrdinal("cpf"));
                        cliente.Rg = reader.GetInt32(reader.GetOrdinal("rg"));
                        lcliente.Add(cliente);
                    }
                    this.conn.closeConnection();
                }
                catch (SqlException ce)
                {

                    throw new DaoException("Erro ao listar Usuarios :" + ce.Message);
                }

                return lcliente;



            }
        }
    }
}

    

 


