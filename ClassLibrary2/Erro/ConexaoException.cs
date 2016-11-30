using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Erro
{
    public class ConexaoException : Exception
    {

        public ConexaoException()
            : base()
        {

        }

        public ConexaoException(string msg) 
            : base(msg)
        {
            
        }
    }
}
