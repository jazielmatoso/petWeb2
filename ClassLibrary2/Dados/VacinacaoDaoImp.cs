using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Erro;
using Backend.Util;
using System.Data.SqlClient;


namespace Backend.Dados
{
    public class VacinacaoDaoImp : VacinacaoDao
    {


        public Conexao conn;
        public AnimalDaoImp animalImp;
        public VeterinarioDaoImp veterinarioImp;

        public VacinacaoDaoImp()
        {
            this.conn = new Conexao();
            this.animalImp = new AnimalDaoImp();
            this.veterinarioImp = new VeterinarioDaoImp();

        }

        public void insertVacinacao(Vacinacao vacinacao) {

            try
            {

                this.conn.openConnection();
                string sql = "INSERT INTO vacinacao(veterinario_id,animal_id,data_vacinacao) OUTPUT INSERTED.ID  VALUES (@veterinario , @animal , CURRENT_TIMESTAMP);";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@veterinario", vacinacao.Veterinario.Id);
                cmd.Parameters.AddWithValue("@animal", vacinacao.Animal.Id);

                int vacinacaoId = (int) cmd.ExecuteScalar();
                
                vacinacao.Id = vacinacaoId;

                this.insertDoseVacina(vacinacao);

                
                
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Usuario :" + ce.Message);
            }
         
        
        }

        public void updateVacinacao(Vacinacao vacinacao)
        {


            try
            {

                this.conn.openConnection();
                string sql = "UPDATE vacinacao SET veterinario_id = @veterinario ,animal_id = @animal WHERE id= @vacinacao";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@veterinario",vacinacao.Veterinario.Id);
                cmd.Parameters.AddWithValue("@animal", vacinacao.Animal.Id);
                cmd.Parameters.AddWithValue("@vacinacao", vacinacao.Id);

                cmd.ExecuteNonQuery();

                this.conn.closeConnection();

                this.updateDoseVacina(vacinacao);  
                

            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Usuario :" + ce.Message);
            }
         

        }

        public void deleteVacinacao(Vacinacao vacinacao)
        {

            try
            {

                this.conn.openConnection();
                string sql = "DELETE FROM vacinacao WHERE id = @vacinacao";
               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@vacinacao", vacinacao.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Deletar Vacinacao :" + ce.Message);
            }
         

        }

        public void insertDoseVacina(Vacinacao vacinacao)
        {
            try
            {

                this.conn.openConnection();

                DoseDaoImp doseDao = new DoseDaoImp();

                foreach (DoseVacina doseVacina in vacinacao.LDoseVacina)
                {
                    doseVacina.Dose.Id = doseDao.insertDose(doseVacina.Dose);
            
                    string sql = "INSERT INTO dose_vacina(dose_id , vacina_id ,vacinacao_id ,data_aplicacao ,  data_proxima_aplicacao ) VALUES (@dose , @vacina , @vacinacao , CURRENT_TIMESTAMP , @proxima_aplicacao)";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.conn.SqlConn;
                    
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@dose", doseVacina.Dose.Id);
                    cmd.Parameters.AddWithValue("@vacina", doseVacina.Vacina.Id);
                    cmd.Parameters.AddWithValue("@vacinacao", vacinacao.Id);
                    cmd.Parameters.AddWithValue("@proxima_aplicacao", doseVacina.ProximaAplicacao);
                    cmd.ExecuteNonQuery();
                }

               this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Dose vacina :" + ce.Message);
            }



        }

        public void updateDoseVacina(Vacinacao vacinacao)
        {

            try
            {

                this.conn.openConnection();


                foreach (DoseVacina doseVacina in vacinacao.LDoseVacina)
                {

                    string sql = "UPDATE dose_vacina SET dose_id = @dose , vacina_id = @vacina ,vacinacao_id = @vacinacao  ,  data_proxima_aplicacao = @proxima_aplicacao WHERE  id= @dose_vacina";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.conn.SqlConn;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@dose", doseVacina.Dose.Id);
                    cmd.Parameters.AddWithValue("@vacina", doseVacina.Vacina.Id);
                    cmd.Parameters.AddWithValue("@vacinacao", vacinacao.Id);
                    cmd.Parameters.AddWithValue("@proxima_aplicacao", doseVacina.ProximaAplicacao);
                    cmd.Parameters.AddWithValue("@dose_vacina", doseVacina.Id); 
                    cmd.ExecuteNonQuery();
                }


                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao alterar Dose vacina :" + ce.Message);
            }
         
            
        
        
        }

        public void deleteDoseVacina(List<DoseVacina> lDoseVacina) {

            try
            {

                this.conn.openConnection();


                foreach (DoseVacina doseVacina in lDoseVacina)
                {

                    string sql = "DELETE FROM dose_vacina WHERE id= @dose_vacina";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.conn.SqlConn;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@dose_vacina", doseVacina.Id);
                    cmd.ExecuteNonQuery();
                }


                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao deletar Dose vacina :" + ce.Message);
            }
         
        
        
        }
        
        public List<Vacinacao> listVacinacaoForAnimal(Animal animal ) {

            try
            {

                this.conn.openConnection();

                List<Vacinacao> lVacinacao = new List<Vacinacao>();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT id,veterinario_id,animal_id,data_vacinacao FROM vacinacao WHERE animal_id = @animal";
                cmd.Connection = this.conn.SqlConn;
                cmd.Parameters.AddWithValue("@animal" , animal.Id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Vacinacao vacinacao = new Vacinacao();
                    vacinacao.Id = reader.GetInt32(reader.GetOrdinal("id"));

                    int animalId = reader.GetInt32(reader.GetOrdinal("animal_id"));
                    vacinacao.Animal = this.animalImp.getAnimal(animalId);

                    int veterinarioId = reader.GetInt32(reader.GetOrdinal("veterinario_id"));
                    vacinacao.Veterinario = this.veterinarioImp.getVeterinario(veterinarioId);

                    vacinacao.LDoseVacina = this.getDoseVacina(vacinacao); 


                    lVacinacao.Add(vacinacao);
                }

                this.conn.closeConnection();


                return lVacinacao;


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Dose vacina :" + ce.Message);
            }


            
        
        
        }

        public List<DoseVacina> getDoseVacina(Vacinacao vacinacao) {

            try
            {

                this.conn.openConnection();

                //cmd.CommandText =
                List<DoseVacina> lDoseVacina = new List<DoseVacina>();
                SqlCommand cmd = new SqlCommand();
                
                string sql = " SELECT dv.id, dv.dose_id ,dv.vacina_id  , dv.data_proxima_aplicacao , dv.data_aplicacao ";
                       sql += " , d.dosagem , d.numero ,d.medida ,d.data_cadastro as dose_data_cadastro, v.nome , v.descricao ";
                       sql += " FROM dose_vacina dv INNER JOIN  dose d ON dv.dose_id = d.id ";
                       sql += " INNER JOIN vacina v ON dv.vacina_id = v.id WHERE vacinacao_id = @vacinacao";
                
                cmd.CommandText = sql;      
                cmd.Connection = this.conn.SqlConn;
                cmd.Parameters.AddWithValue("@vacinacao", vacinacao.Id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DoseVacina doseVacina = new DoseVacina();
                    // dose
                    Dose dose = new Dose();

                    dose.Id = reader.GetInt32(reader.GetOrdinal("dose_id"));
                    dose.Dosagem = (float) reader.GetDouble(reader.GetOrdinal("dosagem"));
                    dose.Numero =  reader.GetInt32(reader.GetOrdinal("numero"));
                    dose.Medida = reader.GetString(reader.GetOrdinal("medida"));
                    dose.DataCadastro = reader.GetDateTime(reader.GetOrdinal("dose_data_cadastro"));
                                         
                    doseVacina.Dose = dose;
                    // vacina 
                    Vacina vacina = new Vacina();

                    vacina.Id = reader.GetInt32(reader.GetOrdinal("vacina_id"));
                    vacina.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    vacina.Descricao = reader.GetString(reader.GetOrdinal("descricao"));

                    doseVacina.Vacina = vacina;

                    doseVacina.DataAplicacao = reader.GetDateTime(reader.GetOrdinal("data_aplicacao"));
                    doseVacina.ProximaAplicacao = reader.GetDateTime(reader.GetOrdinal("data_proxima_aplicacao"));


                    lDoseVacina.Add(doseVacina);
                }

                this.conn.closeConnection();


                return lDoseVacina;


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Dose vacina :" + ce.Message);
            }

        
        }


        public int getSequenciaDose(Animal animal , Vacina vacina) {


            try
            {

                this.conn.openConnection();


                string sql = "SELECT TOP 1 d.numero FROM dose_vacina dv INNER JOIN dose d ON dv.dose_id = d.id WHERE dv.vacina_id = @vacina AND dv.vacinacao_id = ";
                       sql += "(SELECT TOP 1 v.id  FROM vacinacao v WHERE v.animal_id = @animal  order by v.id DESC)";
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@vacina", vacina.Id);
                cmd.Parameters.AddWithValue("@animal", animal.Id);
              
                SqlDataReader reader =  cmd.ExecuteReader();

                int numero = 0; 
                while (reader.Read()) { 
                   numero = reader.GetInt32(reader.GetOrdinal("numero"));
                }

                this.conn.closeConnection();

                    
                return ++numero;

            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao alterar Dose vacina :" + ce.Message);
            }
         
            


            
        
        
        }
    
    
    }
}
