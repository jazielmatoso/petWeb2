using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Util;
using Backend.Basicas;
using System.Data.SqlClient;
using Backend.Erro;

namespace Backend.Dados
{
    public class DoseDaoImp : DoseDao
    {

        Conexao conn;

        public DoseDaoImp()
        {
            this.conn = new Conexao();
        }


        public int insertDose(Dose dose)
        {
            try
            {

                this.conn.openConnection();
                string sql = "INSERT INTO dose (dosagem,numero,medida,data_cadastro) OUTPUT INSERTED.ID VALUES (@dosagem , @numero , @medida  ,CURRENT_TIMESTAMP)";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@dosagem", dose.Dosagem);
                cmd.Parameters.AddWithValue("@numero", dose.Numero);
                cmd.Parameters.AddWithValue("@medida", dose.Medida);

                int doseId = (int) cmd.ExecuteScalar();
                this.conn.closeConnection();

                return doseId;
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Dose :" + ce.Message);
            }
            
                
        }



        public void alterarDose(Dose dose)
        {
            try
            {

                this.conn.openConnection();
                string sql = "UPDATE dose SET dosagem = @dosagem , numero = @numero , medida = @medida WHERE id = @id";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@dosagem", dose.Dosagem);
                cmd.Parameters.AddWithValue("@numero", dose.Numero);
                cmd.Parameters.AddWithValue("@medida", dose.Medida);
                cmd.Parameters.AddWithValue("@id", dose.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Alterar Dose :" + ce.Message);
            }


        }


        public void deletarDose(Dose dose)
        {
            try
            {

                this.conn.openConnection();
                string sql = "DELETE FROM dose WHERE id = @id";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;
                    
                cmd.Parameters.AddWithValue("@id", dose.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }catch (SqlException ce){

                throw new DaoException("Erro ao deletar dose :" + ce.Message);
            }


        }


        public List<Dose> listDose() { 
        
            List<Dose> lDose = new List<Dose>();
            
            try
            {
                this.conn.openConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select id,medida, dosagem , numero  from dose";
                cmd.Connection = this.conn.SqlConn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dose dose = new Dose();

                    dose.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    dose.Dosagem = reader.GetFloat(reader.GetOrdinal("dosagem"));
                    dose.Numero = reader.GetInt32(reader.GetOrdinal("numero"));
                    dose.Medida = reader.GetString(reader.GetOrdinal("medida"));



                    lDose.Add(dose);
                }
                this.conn.closeConnection();
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Doses :" + ce.Message);
            }

            return lDose;



        }

    }
}
