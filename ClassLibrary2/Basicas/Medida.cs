using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Medida
    {

        private string nome;
        private string abreviatura;
        private string exibicao;

      


        public Medida(){


        }

        public Medida(string nome , string abreviatura) {

            this.nome = nome;
            this.abreviatura = abreviatura;
                            
        }


        public string Abreviatura
        {
            get { return abreviatura; }
            set { abreviatura = value; }
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Exibicao
        {
            get { return abreviatura + " - " + nome; }
            
        }

    }
}
