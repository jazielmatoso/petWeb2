using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Dados
{

     
    interface VacinaDao 
    {

        Vacina getVacina(int vacinaId);

        List<Vacina> listVacinaEspecie(Especie especie); 

        
        List<Vacina> listVacina();

       
        void inserirVacina(Vacina vacina);

        
        void alterarVacina(Vacina vacina);

        
        void deletarVacina(Vacina vacina);


        
    }
}
