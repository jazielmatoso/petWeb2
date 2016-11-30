using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Dados
{
    interface DoseDao
    {


        List<Dose> listDose();

        int insertDose(Dose dose);

        void alterarDose(Dose dose);

        void deletarDose(Dose dose);


    }
}
