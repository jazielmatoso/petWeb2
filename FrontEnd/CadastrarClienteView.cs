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
    public partial class CadastrarClienteView : Form
    {
        
        public CadastrarClienteView()
        {

            //this.f = Fachada.getInstancia();
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
           /*
            Cliente cliente = new Cliente();
            cliente.Cpf = Convert.ToInt32(TextBoxCpf.Text);
            cliente.Rg = Convert.ToInt32(TextBoxRg.Text);
            f.inserirCliente(cliente);
            MessageBox.Show("Cliente cadastrado com sucesso!");
            //this.listarUsuarios();*/
        }

        private void CadastrarClienteView_Load(object sender, EventArgs e)
        {

        }
    }
}
