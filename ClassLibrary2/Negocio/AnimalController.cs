using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Dados;
using Backend.Basicas;
using Backend.Erro;



namespace Backend.Negocio
{
    public class AnimalController
    {


        private AnimalDaoImp animalDaoImp = null;

        public AnimalController()
        {

            this.animalDaoImp = new AnimalDaoImp();
            
        }


        public List<Animal> listAnimal(){
            try
            {

              return this.animalDaoImp.listAnimal();

            }
            catch (ConexaoException ce)
            {

                throw new GeralException(ce.Message);


            }
            catch (DaoException de)
            {

                throw new GeralException(de.Message);


            }
        
            
        
        
        }





    }
}
