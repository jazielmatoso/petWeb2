using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Backend;
using Backend.Basicas;
using Backend.Erro;
using System.Web.Script.Serialization;


namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public Fachada fachada = null;


        public Service1() {

            this.fachada = Fachada.getInstancia();
        
        }


        public string getVeterinario(int id) {


            Object val = new Object();
            string msg = "sucesso";
            bool stat = true;  
         
            try
            {
            
                val =  this.fachada.getVeterinario(id);

            }
            catch (GeralException g)
            {
                stat = false;
                msg = g.Message;
            }

            var obj = new { status = stat, valor = val, message = msg };
            string json = new JavaScriptSerializer().Serialize(obj);
            return json;
        
        }


        public string insertVacinacao(string  vacinacao)
        {


            Object val = new Object();
            string msg = "sucesso";
            bool stat = true;

            try
            {

                this.fachada.insertVacinacao(vacinacao);

            }
            catch (GeralException g)
            {
                stat = false;
                msg = g.Message;
            }

            var obj = new { status = stat, valor = val, message = msg };
            string json = new JavaScriptSerializer().Serialize(obj);
            return json;

        }



        public string listMedida(){

            Object val = new Object();
            string msg = "sucesso";
            bool stat = true;  
         
            try
            {

               val = this.fachada.listarMedidas();
            

            }
            catch (GeralException g)
            {
                stat = false;
                msg = g.Message;
            }

            var obj = new { status = stat, valor = val, message = msg };
            string json = new JavaScriptSerializer().Serialize(obj);
            return json;
        }


        public string listAnimal() {
            
            Object val = new Object();
            string msg = "sucesso";
            bool stat = true;  
         
            try
            {
            
                val =  this.fachada.listAnimal();
            
            }
            catch (GeralException g)
            {
                stat = false;
                msg = g.Message;
            }

            var obj = new { status = stat, valor = val, message = msg };
            string json = new JavaScriptSerializer().Serialize(obj);
            return json;

        }

        public string listVacinaForEspecie(int especieId) {

            Object val = new Object();
            string msg = "sucesso";
            bool stat = true;  
         
            try
            {
   
                //List<Vacina> lVacina = this.fachada.listVacinaForEspecie(especieId);
                val = this.fachada.listVacinaForEspecie(especieId);
                
            }
            catch (GeralException g)
            {
                stat = false;
                msg = g.Message;
            }

            var obj = new { status = stat, valor = val, message = msg };
            string json = new JavaScriptSerializer().Serialize(obj);
            return json;

        }


        public string getSequenciaDose(int animalId, int vacinaId) {


            string val   = "";
            string msg = "sucesso";
            bool   stat  = true;  
         
            try
            {
                 val  = this.fachada.getSequenciaDose(animalId, vacinaId).ToString();
                  
            }
            catch (GeralException g) {
                stat = false;
                msg = g.Message; 
            }

            var obj = new { status = stat, valor = val, message = msg };
            string json = new JavaScriptSerializer().Serialize(obj);
            return json;
        }



        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }




        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
