

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FrontEnd
{
    public partial class AlterarUsuarioView : Form
    {
        //public Fachada f;

        //private Usuario usuario = null;

        public AlterarUsuarioView()
        {
            InitializeComponent();

            //this.f = Fachada.getInstancia();
        }

        /* public AlterarUsuarioView(Usuario usuario)
         {

             InitializeComponent();
             //this.loadUser(usuario);
            
         }*/


        /*  public void loadUser(Usuario usuario) {
              this.tNomeUsuario.Text = usuario.Nome;
              this.usuario = usuario;
          }*/



        private void button1_Click(object sender, EventArgs e)
        {

         /*   string msg = "";
            try {

               

                string nome = this.tNomeUsuario.Text;
                if (!usuario.Nome.Equals(nome))
                {
                    usuario.Nome = tNomeUsuario.Text;
                    f.alterarUsuario(usuario);
                }

                msg = "Alterado com sucesso";
                 

            }catch(GeralException g){
                msg = g.Message;
            }
            
            MessageBox.Show(msg);
            */
        }

        private void AlterarUsuarioView_Load(object sender, EventArgs e)
        {

        }
    }
}
