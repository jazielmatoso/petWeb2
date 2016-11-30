using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Erro
{
    public class ValidacaoException : Exception
    {




        public ValidacaoException()
            : base()
        {


        }


        public ValidacaoException(string msg) 
            : base(msg){
        
        
        }
            
    }
}
