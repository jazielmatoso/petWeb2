using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace FrontEnd.Vacinacao
{
    public partial class VacinacaoView : Form
    {



        public List<Object> newDoseVacina;


        public VacinacaoView()
        {

           InitializeComponent();
           this.loadComboBoxAnimal();
           this.loadComboBoxMedida();

           newDoseVacina = new List<Object>(); 
        }


        public void loadComboBoxAnimal() {
       
            string json = WebService.getInstance.Service.listAnimal();
            JObject objResp = JObject.Parse(json);
            //var objDefault = new { status = false, valor = new List<Object>(), message = "" };
            //var objResp = JsonConvert.DeserializeAnonymousType(json, objDefault);

            if (bool.Parse(objResp["status"].ToString()))
            {

                comboAnimal.DataSource = objResp["valor"];
                comboAnimal.DisplayMember = "Nome";
                comboAnimal.ValueMember = "Id";

            }
            else
            {
                MessageBox.Show(objResp["message"].ToString());
            }

        }

         public void loadComboBoxVacina(JObject especie)
         {
             string json = WebService.getInstance.Service.listVacinaForEspecie(Int32.Parse(especie["Id"].ToString()),true);
             JObject objResp = JObject.Parse(json);

             if (bool.Parse(objResp["status"].ToString()))
             {
                 comboVacina.DataSource = objResp["valor"];
                 comboVacina.DisplayMember = "Nome";
                 comboVacina.ValueMember = "Id";

             }
             else
             {
                 MessageBox.Show(objResp["message"].ToString());
             }



         }



        public void loadComboBoxMedida()
        {


            string json = WebService.getInstance.Service.listMedida();
            JObject objResp = JObject.Parse(json);


            if (bool.Parse(objResp["status"].ToString()))
            {

                comboMedida.DataSource = objResp["valor"];
                comboMedida.DisplayMember = "Exibicao";
                comboMedida.ValueMember = "Abreviatura";

            }
            else
            {
                MessageBox.Show(objResp["message"].ToString());
            }
            
            /*string json = WebService.getInstance.Service.listMedida();

            var objDefault = new { status = false, valor = new List<Medida>(), message = "" };
            var objResp = JsonConvert.DeserializeAnonymousType(json, objDefault);

            if (objResp.status)
            {

                comboMedida.DataSource = objResp.valor;
                comboMedida.DisplayMember = "Exibicao";
                comboMedida.ValueMember = "Abreviatura";

            }
            else
            {
                MessageBox.Show(objResp.message);
            }*/

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            JObject animal = (JObject) comboAnimal.SelectedItem;

            this.loadComboBoxVacina((JObject) animal["Especie"]);

        }

        private void VacinacaoView_Load(object sender, EventArgs e)
        {



        }

        private void comboVacina_SelectedIndexChanged(object sender, EventArgs e)
        {

            JObject animal = (JObject)comboAnimal.SelectedItem;
            JObject vacina = (JObject)comboVacina.SelectedItem;

            int animalId = Int32.Parse(animal["Id"].ToString());
            int vacinaId = Int32.Parse(vacina["Id"].ToString());

            string json = WebService.getInstance.Service.getSequenciaDose(animalId, true, vacinaId, true);
            var objResp = JObject.Parse(json);

            if (bool.Parse(objResp["status"].ToString()))
            {
                int sequencia = Int32.Parse(objResp["valor"].ToString());
                textAplicacoes.Text = sequencia.ToString();

            }
            else {
                MessageBox.Show(objResp["message"].ToString());
            }
            
        }

         private DateTime getProximaVacinacao(JObject vacina, JObject dose)
         {


             DateTime proximaVacinacao = DateTime.Now;
             bool done = false;
             int proximaDoseNumero = Int32.Parse(dose["Numero"].ToString());
             proximaDoseNumero++;


             JArray periodicidades = new JArray();
             periodicidades = (JArray)vacina["Periodicidade"];

             foreach (JObject periodicidade in periodicidades)
             {

                 int numero  = 0;
                 int qtdDias = 0;

                 numero = Int32.Parse(periodicidade["Numero"].ToString());
                 qtdDias = Int32.Parse(periodicidade["QtdeDias"].ToString());

                 switch (periodicidade["Equivalecia"].ToString())
                 {
                     case "igual":
                         if (numero.Equals(proximaDoseNumero))
                           {
                             proximaVacinacao = proximaVacinacao.AddDays(qtdDias);
                             done = true;
                         }
                         break;
                     case "maior":
                         if (numero < proximaDoseNumero)
                         {
                             proximaVacinacao = proximaVacinacao.AddDays(qtdDias);
                             done = true;
                         }
                         break;
                 }

                 if (done == true)
                 {
                     break;
                 }

             }

             return proximaVacinacao; 
        
         }

       /* private JObject addNewDoseVacina()
        {

            JObject dose = new JObject();

            dose["Dosagem"] = float.Parse(textDosagem.Text);
            dose["Numero"] = Int32.Parse(textAplicacoes.Text);

            dose["Medida"] = comboMedida.SelectedValue.ToString();
            JObject vacina = (JObject) comboVacina.SelectedItem;

            JObject doseVacina = new JObject();
            doseVacina["Dose"] = dose;
            doseVacina["Vacina"]= vacina;
            // vacina periodicidade calcular px Data
            doseVacina["ProximaAplicacao"] = this.getProximaVacinacao(vacina, dose);
            newDoseVacina.Add(doseVacina);
            return doseVacina;
        }*/

        private JObject addNewDoseVacina()
        {

            JObject dose = new JObject();

            dose["Dosagem"] = float.Parse(textDosagem.Text);
            dose["Numero"] = Int32.Parse(textAplicacoes.Text);

            dose["Medida"] = comboMedida.SelectedValue.ToString();
            JObject vacina = (JObject)comboVacina.SelectedItem;

            JObject doseVacina = new JObject();
            doseVacina["Dose"] = dose;
            doseVacina["Vacina"] = vacina;
            // vacina periodicidade calcular px Data
            doseVacina["ProximaAplicacao"] = this.getProximaVacinacao(vacina, dose);

           // var doseVacinaList = new { Dose = dose.ToString(Formatting.None), Vacina = vacina.ToString(Formatting.None), ProximaAplicacao = DateTime.Parse(doseVacina["ProximaAplicacao"].ToString()) };
            newDoseVacina.Add(doseVacina);
            return doseVacina;
        }




        private void button3_Click(object sender, EventArgs e)
        {

            JObject doseVacina = this.addNewDoseVacina();

            ListViewItem newLine = new ListViewItem(doseVacina["Dose"]["Dosagem"].ToString());

            newLine.SubItems.Add(doseVacina["Dose"]["Medida"].ToString());
            newLine.SubItems.Add(doseVacina["Dose"]["Numero"].ToString());
            newLine.SubItems.Add(doseVacina["Vacina"]["Nome"].ToString());
            newLine.SubItems.Add(doseVacina["ProximaAplicacao"].ToString());

            listDoseVacina.Items.Add(newLine);

            //desabilita a selecao do animal
            comboAnimal.Enabled = false;
        }

        private void listDoseVacina_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listDoseVacina.SelectedItems[0].Index;
            newDoseVacina.RemoveAt(index);
            listDoseVacina.SelectedItems[0].Remove();
            if (newDoseVacina.Count() == 0) {
                comboAnimal.Enabled = true;    
            }
         }

        private void button4_Click(object sender, EventArgs e)
        {


              string json = WebService.getInstance.Service.getVeterinario(1, true);
              var objResp = JObject.Parse(json);

              if (bool.Parse(objResp["status"].ToString()))
              {

                  JObject vacinacao = new JObject();


                  string jsonNewDoseVacina = JsonConvert.SerializeObject(newDoseVacina, Formatting.None);
                 
                  vacinacao["Animal"] = JObject.Parse(comboAnimal.SelectedItem.ToString());
                  vacinacao["Veterinario"] = JObject.Parse(objResp["valor"].ToString());
                  vacinacao["LDoseVacina"] = jsonNewDoseVacina;
              
                  string jsonVacinacao = vacinacao.ToString(Formatting.None);
                  string resposta = WebService.getInstance.Service.insertVacinacao(jsonVacinacao);

                   
                  MessageBox.Show(resposta);


                  newDoseVacina.Clear();
                  listDoseVacina.Items.Clear();



              }
              else {

                  MessageBox.Show(objResp["message"].ToString());
              }




            //
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
