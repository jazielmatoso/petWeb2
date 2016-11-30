using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Dados;
using Backend.Basicas;

namespace Backend.Negocio
{
    public class VeterinarioController
    {
        private VeterinarioDaoImp veterinarioDao = null;

        public VeterinarioController()
        {
            this.veterinarioDao = new VeterinarioDaoImp();
        }


        public Veterinario getVeterinario(int id) {
            return this.veterinarioDao.getVeterinario(id);
        }

    }
}
