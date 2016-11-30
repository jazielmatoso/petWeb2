using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Usuario
    {
        private int id;
        private string nome;
        private string telefone;
        private string email;
        private string login;
        private string senha;
        private Permissao permissao;
 


        public Usuario() {


            this.Permissao = new Permissao();

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

        public string Email
        {
            get { return email; }
            set { email = value; }
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

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public Permissao Permissao
        {
            get
            {
                return permissao;
            }

            set
            {
                permissao = value;
            }
        }
    }
}
