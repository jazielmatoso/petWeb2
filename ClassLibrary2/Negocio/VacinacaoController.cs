using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Dados;
using Backend.Erro;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Backend.Negocio
{
    public class VacinacaoController
    {


         
        private VacinacaoDaoImp vacinacaoDao = null;

        public VacinacaoController() {


            this.vacinacaoDao = new VacinacaoDaoImp();
        }

        
        public void cadastrar(string jsonVacinacao) {

            try
            {



                var objParse = JObject.Parse(jsonVacinacao);

                JArray l = (JArray)JsonConvert.DeserializeObject(objParse["LDoseVacina"].ToString());

                throw new ValidacaoException(l[0]["Vacina"]["Nome"].ToString());



                //Vacinacao vacinacao = new JavaScriptSerializer().Deserialize<Vacinacao>(jsonVacinacao);

                //string nomeAnimal = vacinacao.Animal.Nome;


                /*if (vacinacao.Equals(null) || vacinacao.Equals(""))
                {
                    throw new ValidacaoException("Objeto Vacinacao Nulo");
                }*/

                // validar 
                // vacinacao.Animal
                // vacinacao.Veterinario
                // vacinacao.LDoseVacina

                
                    
                    

                //this.vacinacaoDao.insertVacinacao(vacinacao);


            }
            catch (ConexaoException c){
                throw new GeralException(c.Message);
            }
            catch (DaoException d){
                throw new GeralException(d.Message);
            }
            catch (ValidacaoException ve) {
                throw new GeralException(ve.Message);
            }

        }


        public void alterar(Vacinacao vacinacao)
        {

            try
            {
             
                if (vacinacao.Equals(null) || vacinacao.Equals(""))
                {
                    throw new Exception("Objeto vacinacao Nulo");
                }
                this.vacinacaoDao.updateVacinacao(vacinacao);


            }
            catch (ConexaoException c)
            {
                throw new GeralException(c.Message);
            }
            catch (DaoException d)
            {
                throw new GeralException(d.Message);
            }

        }


        public void deletar(Vacinacao vacinacao)
        {

            try
            {
               
                if (vacinacao.Equals(null) || vacinacao.Equals(""))
                {
                    throw new Exception("Objeto vacinacao Nulo");
                }
                this.vacinacaoDao.deleteVacinacao(vacinacao);


            }
            catch (ConexaoException c)
            {
                throw new GeralException(c.Message);
            }
            catch (DaoException d)
            {
                throw new GeralException(d.Message);
            }

        }


        public int getSequenciaDose(int animalId, int vacinaId) { 
            
             try
            {
                // verificar se o int passado é maior q 0
                if (animalId <= 0 || vacinaId <= 0 )
                {
                    throw new ValidacaoException("Parametro passado é invalido, isto é ,  menor ou igual à 0 ");
                }

                //verificar se o animal existe
                AnimalDaoImp animalDao = new AnimalDaoImp();

                Animal animal = animalDao.getAnimal(animalId);

                // verifica se o animal existe
                if (animal == null)
                {
                    throw new ValidacaoException("Animal inexistente.");
                }


                VacinaDaoImp  vacinaDao = new VacinaDaoImp();

                Vacina vacina = vacinaDao.getVacina(vacinaId);

                 // verifica se a vacina existe
                if (vacina == null)
                {
                    throw new ValidacaoException("Vacina inexistente.");
                }


                return vacinacaoDao.getSequenciaDose(animal,vacina);


            }
            catch (ConexaoException c)
            {
                throw new GeralException(c.Message);
            }
            catch (DaoException d)
            {
                throw new GeralException(d.Message);
            }
            catch (ValidacaoException v) {
            
                throw new GeralException(v.Message);
            
            }
        
        }


        public List<Vacinacao> listarVacinacaoForAnimal(int animalId)
        {
            try
            {
                // verificar se o int passado é maior q 0
                if (animalId <= 0)
                {
                    throw new ValidacaoException("Parametro passado é invalido, isto é ,  menor ou igual à 0 ");
                }

                //verificar se o animal existe
                AnimalDaoImp animalDao = new AnimalDaoImp();

                Animal animal = animalDao.getAnimal(animalId);

                // verifica se o animal existe
                if (animal == null)
                {
                    throw new ValidacaoException("Animal inexistente.");
                }

                return vacinacaoDao.listVacinacaoForAnimal(animal);


            }
            catch (ConexaoException c)
            {
                throw new GeralException(c.Message);
            }
            catch (DaoException d)
            {
                throw new GeralException(d.Message);
            }
            catch (ValidacaoException v) {
            
                throw new GeralException(v.Message);
            
            }
        
        }

    }
}
