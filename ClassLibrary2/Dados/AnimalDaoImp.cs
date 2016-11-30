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
    public class AnimalDaoImp
    {

        public Conexao conn;
        
        public AnimalDaoImp() {

            this.conn = new Conexao();
        }




        public Animal getAnimal(int animalId)
        {

            try
            {
                
                EspecieDaoImp especieImp = new EspecieDaoImp();

                this.conn.openConnection();
                Animal animal = new Animal();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT id,nome,idade,peso,especie_id,data_cadastro FROM animal WHERE id = @animal";
                cmd.Connection = this.conn.SqlConn;
                cmd.Parameters.AddWithValue("@animal", animalId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    
                    animal.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    animal.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    animal.Idade = reader.GetInt32(reader.GetOrdinal("idade"));
                    animal.Peso = (float) reader.GetDouble(reader.GetOrdinal("peso"));
                    int especieId =  reader.GetInt32(reader.GetOrdinal("especie_id"));
                    animal.Especie = especieImp.getEspecie(especieId);
                    animal.DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro"));


                }
                this.conn.closeConnection();

                return animal;
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Animals :" + ce.Message);
            }


        }



        public List<Animal> listAnimal() {

            try
            {

                this.conn.openConnection();


                string sql = "SELECT id,nome,idade,peso,especie_id FROM animal";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = this.conn.SqlConn;
               
                SqlDataReader handle =  cmd.ExecuteReader();

                EspecieDaoImp especieDaoImp = new EspecieDaoImp();
                List<Animal> lAnimal = new List<Animal>();

                while (handle.Read()) {


                    Animal animal = new Animal();

                    animal.Id      = handle.GetInt32(handle.GetOrdinal("id"));
                    animal.Idade   = handle.GetInt32(handle.GetOrdinal("idade"));
                    animal.Peso =    (float) handle.GetDouble(handle.GetOrdinal("peso"));
                    animal.Nome =     handle.GetString(handle.GetOrdinal("nome"));

                    int especieId  = handle.GetInt32(handle.GetOrdinal("especie_id"));
                    animal.Especie = especieDaoImp.getEspecie(especieId);

                    


                    lAnimal.Add(animal);
            
                }

                return lAnimal;    


            }
            catch (ConexaoException ce) {

                throw new DaoException(ce.Message);
            
            }
            
        
        
        }

    }
}
