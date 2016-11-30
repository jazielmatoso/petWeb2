using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Vacina
    {

        private int id;
        private string nome;
        private string descricao;
        private List<Doenca> doenca;
        private List<Periodicidade> periodicidade;
        private DateTime dataCadastro;

        

        public Vacina() {
            this.doenca = new List<Doenca>();
            this.periodicidade = new List<Periodicidade>();
        }

        public Vacina(int id, string nome, string descricao, List<Doenca> doenca, List<Periodicidade> periodicidade , DateTime dataCadastro)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.doenca = doenca;
            this.Periodicidade = periodicidade;
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

        public List<Doenca> Doenca
        {
            get
            {
                return doenca;
            }

            set
            {
                doenca = value;
            }
        }

        public List<Periodicidade> Periodicidade
        {
            get
            {
                return periodicidade;
            }

            set
            {
                periodicidade = value;
            }
        }


        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
    }
}
