using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Dados;
using Backend.Erro;
using System.Xml;

namespace Backend.Negocio
{
    public class DoseController
    {



        private DoseDaoImp doseDao = null;

        public DoseController() {


            this.doseDao = new DoseDaoImp();


        }

        
        public void cadastrar(Dose dose) {

            try {
                this.doseDao = new DoseDaoImp();
                if (dose.Equals(null) || dose.Equals(""))
                {
                    throw new Exception("Objeto Dose Nulo");
                }
                this.doseDao.insertDose(dose);
             

             }catch(ConexaoException c){
                throw new GeralException(c.Message);
             }catch(DaoException d){
                throw new GeralException(d.Message);
             }

        }


        public void alterar(Dose Dose)
        {

            try
            {
                this.doseDao = new DoseDaoImp();
                if (Dose.Equals(null) || Dose.Equals(""))
                {
                    throw new Exception("Objeto Dose Nulo");
                }
                this.doseDao.alterarDose(Dose);


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


        public void deletar(Dose dose)
        {

            try
            {
                this.doseDao = new DoseDaoImp();
                if (dose.Equals(null) || dose.Equals(""))
                {
                    throw new Exception("Objeto Dose Nulo");
                }
                this.doseDao.deletarDose(dose);


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

        public List<Dose> listar()
        {
            try{
        
                DoseDaoImp doseDao = new DoseDaoImp();
                return doseDao.listDose();
            }catch(ConexaoException c){
                throw new GeralException(c.Message);
            }catch(DaoException d){
                throw new GeralException(d.Message);
            }
        
        }



        public List<Medida> listarMedidas() {
            try
            {
                XmlDocument medidas = new XmlDocument();
                medidas.Load(@"C:\projeto\petWeb\ClassLibrary2\File\Medidas.xml");
                List<Medida> listMedida = new List<Medida>();
                foreach (XmlNode item in medidas.DocumentElement.ChildNodes ) {
                   Medida medida =  new Medida();
                   medida.Nome = item.ChildNodes.Item(0).ChildNodes.Item(0).InnerText;
                   medida.Abreviatura = item.ChildNodes.Item(1).ChildNodes.Item(0).InnerText;
                   listMedida.Add(medida); 
                }
                return listMedida;
            }

            catch (GeralException c)
            {
                throw new GeralException(c.Message);
            }
        
        }

    }
}
