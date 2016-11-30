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
    public class EspecieController
    {

        private EspecieDaoImp especieDao = null;

        public EspecieController() { 
            
            this.especieDao = new EspecieDaoImp();


        }




       public void cadastrar(Especie especie) {

            try {
                

                if (especie.Equals(null) || especie.Equals(""))
                {
                    throw new Exception("Objeto Especie Nulo");
                }
                this.especieDao.inserirEspecie(especie);
             

             }catch(ConexaoException c){
                throw new GeralException(c.Message);
             }catch(DaoException d){
                throw new GeralException(d.Message);
             }

        }

   

        public void alterar(Especie especie)
        {

            try
            {
                
                if (especie.Equals(null) || especie.Equals(""))
                {
                    throw new Exception("Objeto Especie Nulo");
                }
                this.especieDao.alterarEspecie(especie);


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


        public void deletar(Especie especie)
        {

            try
            {
                
                if (especie.Equals(null) || especie.Equals(""))
                {
                    throw new Exception("Objeto Especie Nulo");
                }
                this.especieDao.deletarEspecie(especie);


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


        public List<Especie> listar()
        {
            try{
        
                EspecieDaoImp especieDao = new EspecieDaoImp();
                return especieDao.listarEspecie();
            }catch(ConexaoException c){
                throw new GeralException(c.Message);
            }catch(DaoException d){
                throw new GeralException(d.Message);
            }
        
        }

    }
}

