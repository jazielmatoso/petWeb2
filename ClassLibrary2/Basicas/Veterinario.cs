using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Veterinario : Usuario
    {

        private string crmv;
        

        public Veterinario() { }

        public Veterinario(string crmv)
        {
            this.crmv = crmv;
        }

        public string Crmv
        {
            get
            {
                return crmv;
            }

            set
            {
                crmv = value;
            }
        }

        
    }
}
