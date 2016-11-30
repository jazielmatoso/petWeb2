using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Dados
{
    public interface ClienteDao
    {

        List<Cliente> listCliente();

        void insertCliente(Cliente cliente);

        void alterarCliente(Cliente cliente);

        void deletarCliente(Cliente cliente);

    }
}
