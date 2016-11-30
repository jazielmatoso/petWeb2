using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Dados
{
    interface EspecieDao
    {

        Especie getEspecie(int id);

        List<Especie> listarEspecie();

        void inserirEspecie(Especie especie);

        void alterarEspecie(Especie especie);

        void deletarEspecie(Especie especie);
    }
}
