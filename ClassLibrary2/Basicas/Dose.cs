using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Dose
    {
        private int id;
        private float dosagem;
        private int numero;
        private string medida;
        private DateTime dataCadastro;

       

        public Dose() { }

        public Dose(int id, float dosagem, int numero,  string medida ,DateTime dataCadastro )
        {
            this.id = id;
            this.dosagem = dosagem;
            this.numero = numero;
            this.dataCadastro = dataCadastro;
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

        public string Medida
        {
            get { return medida; }
            set { medida = value; }
        }


        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public float Dosagem
        {
            get
            {
                return dosagem;
            }

            set
            {
                dosagem = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }
    }
}
