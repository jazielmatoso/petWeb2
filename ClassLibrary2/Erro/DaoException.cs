using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Erro
{
    public class DaoException : Exception
    {

        public DaoException()
            : base()
        {
        }

        public DaoException(string msg) 
            : base(msg) 
        { 
        
        
        }   
        
    }
}
