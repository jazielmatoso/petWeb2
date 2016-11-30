using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Periodicidade
    {
        private int id;
        private int qtdeDias;
        private int numero;
        private string equivalecia;

        public Periodicidade() { }

        public Periodicidade(int id, int qtdeDias, int numero, string equivalecia)
        {
            this.id = id;
            this.qtdeDias = qtdeDias;
            this.numero = numero;
            this.equivalecia = equivalecia;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int QtdeDias
        {
            get
            {
                return qtdeDias;
            }

            set
            {
                qtdeDias = value;
            }
        }



        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Equivalecia
        {
            get { return equivalecia; }
            set { equivalecia = value; }
        }


    }
}
