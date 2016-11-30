using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class DoseVacina
    {
        private int id;

        private Dose dose;

        private Vacina vacina;

        private DateTime dataAplicacao;

        private DateTime proximaAplicacao;

        //private Vacinacao vacinacao;


 
        public DoseVacina() {
            
            this.vacina = new Vacina();
            this.dose = new Dose();
           // this.vacinacao = new Vacinacao();

        }

        public DoseVacina(int id, Dose dose, Vacina vacina, DateTime dataAplicacao, DateTime proximaAplicacao/*, Vacinacao vacinacao*/)
        {

            this.id = id;
            this.vacina = vacina;
            this.dose = dose;
            this.dataAplicacao = dataAplicacao;
            this.proximaAplicacao = proximaAplicacao;
            //this.vacinacao = vacinacao;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Dose Dose
        {
            get { return dose; }
            set { dose = value; }
        }

        public Vacina Vacina
        {
            get { return vacina; }
            set { vacina = value; }
        }


        public DateTime DataAplicacao
        {
            get { return dataAplicacao; }
            set { dataAplicacao = value; }
        }


        public DateTime ProximaAplicacao
        {
            get { return proximaAplicacao; }
            set { proximaAplicacao = value; }
        }




        

    }
}
