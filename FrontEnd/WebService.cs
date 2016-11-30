using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrontEnd.Service1;



namespace FrontEnd
{
    public class WebService
    {
            
        public static WebService instance;

        private Service1.Service1 service;

        public static Object objDefault = new { status = "", obj = new Object(), msg = "" };
       

        private WebService()
        {

             this.service = new Service1.Service1();
           
        }


        public static WebService getInstance{

            get
            {
               if (instance == null)
                {
                    instance = new WebService();
                }
                return instance; 
            
            }

        }

        public Service1.Service1 Service
        {
            get { return service; }
            set { service = value; }
        }


       
    }
}
