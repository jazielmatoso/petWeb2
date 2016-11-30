using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Backend.Erro
{
    public class GeralException : Exception
    {

        public GeralException()
            : base()
        {

        }


        public GeralException(string msg)
            : base(msg)
        {

        }


    }
}
