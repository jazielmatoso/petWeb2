using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Especie
    {
        private int id;
        private string nome;
        private string descricao;
        private DateTime dataCadastro;

     


        public Especie() {
            //this.dataCadastro = new DateTime();
        }



        public Especie(int id, string nome, string descricao, DateTime dataCadastro)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
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

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }


        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

      
    }
}
