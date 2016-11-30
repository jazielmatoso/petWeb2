using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Util;
using Backend.Erro;

namespace Backend.Dados
{
    public class VeterinarioDaoImp
    {

        public Conexao conn;

        public VeterinarioDaoImp()
        {

            this.conn = new Conexao();
        }




        public Veterinario getVeterinario(int VeterinarioId)
        {


            try
            {
                this.conn.openConnection();
                Veterinario Veterinario = new Veterinario();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT u.id,u.nome,u.email,u.login,u.telefone,u.data_cadastro,v.crmv FROM veterinario v  INNER JOIN usuario u ON v.usuario_id  = u.id WHERE u.id = @veterinario";
                cmd.Connection = this.conn.SqlConn;
                cmd.Parameters.AddWithValue("@veterinario", VeterinarioId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Veterinario.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    Veterinario.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    Veterinario.Email = reader.GetString(reader.GetOrdinal("email"));
                    Veterinario.Login = reader.GetString(reader.GetOrdinal("login"));
                    Veterinario.Crmv =  reader.GetString(reader.GetOrdinal("crmv"));
                    Veterinario.Telefone = reader.GetString(reader.GetOrdinal("telefone"));


                }
                this.conn.closeConnection();

                return Veterinario;
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Veterinarios :" + ce.Message);
            }





        }





    }
}
