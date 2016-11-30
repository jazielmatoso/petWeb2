using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Dados
{

     
    interface UsuarioDao 
    {


        List<Usuario> listUsuario();
        
        void insertUsuario(Usuario usuario);

        void alterarUsuario(Usuario usuario);

        void deletarUsuario(Usuario usuario);


        
    }
}
