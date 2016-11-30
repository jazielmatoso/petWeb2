using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Dados;
using Backend.Negocio;

namespace Backend
{
   public class Fachada
    {

               
        
        private static Fachada instancia;

        private UsuarioController usuarioC;
        private ClienteController clienteC;
        private EspecieController especieC;
        private VeterinarioController veterinarioC;
        private AnimalController animalC;
        private VacinaController vacinaC;
        private DoseController doseC;
        private VacinacaoController vacinacaoC; 


       
        public Fachada() {
            usuarioC     = new UsuarioController();
            clienteC     = new ClienteController();
            especieC     = new EspecieController();
            veterinarioC = new VeterinarioController();
            animalC      = new AnimalController();
            vacinaC      = new VacinaController();
            doseC        = new DoseController();
            vacinacaoC   = new VacinacaoController();
        }


        
        public static Fachada getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Fachada();
            }

            return instancia;
        }

        public List<Medida> listarMedidas() {

            return doseC.listarMedidas();
            
        }

        public void insertVacinacao(string vacinacao) {

            vacinacaoC.cadastrar(vacinacao);
        
        }

        public Veterinario getVeterinario(int veterinarioId) {

            return veterinarioC.getVeterinario(veterinarioId);
        }


        public List<Vacinacao> listarVacinacaoForAnimal(int animalId) {

            return vacinacaoC.listarVacinacaoForAnimal(animalId);
        }


        public int getSequenciaDose(int animalId, int vacinaId) {

            return vacinacaoC.getSequenciaDose(animalId, vacinaId); 
        
        }


        public List<Animal> listAnimal()
        {

            return animalC.listAnimal();
        }

        public List<Vacina> listVacinaForEspecie(int especieId)
        {

            return vacinaC.listVacinaForEspecie(especieId);
                
        }


        public void inserirUsuario(Usuario usuario)
        {

            usuarioC.cadastrar(usuario);

        }

        public List<Usuario> listarUsuario()
        {
            return usuarioC.listar();
        }


        public void alterarUsuario(Usuario usuario)
        {
            usuarioC.alterar(usuario);
        }


        public void deletarUsuario(Usuario usuario)
        {
            usuarioC.deletar(usuario);
        }



        /////////////////////////////////////////////



        public void inserirCliente(Cliente cliente)
        {

            clienteC.cadastrar(cliente);

        }

        public List<Cliente> listarCliente()
        {
            return clienteC.listar();
        }


        public void alterCliente(Cliente cliente)
        {
            clienteC.alterar(cliente);
        }


        public void deletarCliente(Cliente cliente)
        {
            clienteC.deletar(cliente);
        }

        // Especie

        public void inserirEspecie(Especie especie)
        {

            especieC.cadastrar(especie);

        }

        public List<Especie> listarEspecie()
        {
            return especieC.listar();
        }


        public void alterarEspecie(Especie especie)
        {
           especieC.alterar(especie);
        }


        public void deletarEspecie(Especie especie)
        {
            especieC.deletar(especie);
        }

    }
}
