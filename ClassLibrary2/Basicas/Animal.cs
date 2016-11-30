using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Animal
    {

        private int id;
        private int idade;
        private string nome;
        private float peso;
        private string cor;
        private string raca;
        private Especie especie;
        private DateTime dataCadastro;
        

        public Animal() {

            this.especie = new Especie();
        }

        public Animal(int id, int idade, string nome, float peso, string cor, string raca, Especie especie,DateTime dataCadastro)
        {
            this.id = id;
            this.idade = idade;
            this.nome = nome;
            this.peso = peso;
            this.cor = cor;
            this.raca = raca;
            this.especie = especie;
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

        public Especie Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public float Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public string Cor
        {
            get
            {
                return cor;
            }

            set
            {
                cor = value;
            }
        }

        public string Raca
        {
            get
            {
                return raca;
            }

            set
            {
                raca = value;
            }
        }

        public DateTime DataCadastro
        {
            get
            {
                return dataCadastro;
            }

            set
            {
                dataCadastro = value;
            }
        }

        
    }
}
