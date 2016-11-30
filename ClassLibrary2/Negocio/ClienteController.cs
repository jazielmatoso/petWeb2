using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Erro;
using Backend.Dados;
using Backend.Basicas;

namespace Backend.Negocio
{
    class ClienteController
    {
        private ClienteDaoImp clienteDao = null;

        public ClienteController()
        {



        }


        public void cadastrar(Cliente cliente)
        {

            try
            {
                this.clienteDao = new ClienteDaoImp();
                if (cliente.Equals(null) || cliente.Equals(""))
                {
                    throw new Exception("Objeto Cliente Nulo");
                }
                this.clienteDao.insertCliente(cliente);


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



        public void alterar(Cliente cliente)
        {

            try
            {
                this.clienteDao = new ClienteDaoImp();
                if (cliente.Equals(null) || cliente.Equals(""))
                {
                    throw new Exception("Objeto Usuario Nulo");
                }
                this.clienteDao.alterarCliente(cliente);


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


        public void deletar(Cliente cliente)
        {

            try
            {
                this.clienteDao = new ClienteDaoImp();
                if (cliente.Equals(null) || cliente.Equals(""))
                {
                    throw new Exception("Objeto Usuario Nulo");
                }
                this.clienteDao.deletarCliente(cliente);


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

        public List<Cliente> listar()
        {
            try
            {

                ClienteDaoImp clienteDao = new ClienteDaoImp();
                return clienteDao.listCliente();
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
    }
}
