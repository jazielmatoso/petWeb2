using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Basicas
{
    public class Vacinacao
    {
        private int id;
        private DateTime dataVacinacao;
        private Animal animal;
        private Veterinario veterinario;
        private List<DoseVacina> lDoseVacina;



        public Vacinacao() { 
                
            this.animal = new Animal();
            this.veterinario = new Veterinario();
            this.lDoseVacina = new List<DoseVacina>();
    

         }

        public Vacinacao(int id, DateTime dataVacinacao, Animal animal, Veterinario veterinario, List<DoseVacina> lDoseVacina)
        {
            this.id = id;
            this.dataVacinacao = dataVacinacao;
            this.animal = animal;
            this.Veterinario = veterinario;
            this.lDoseVacina = lDoseVacina;
        
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

        public DateTime DataVacinacao
        {
            get
            {
                return dataVacinacao;
            }

            set
            {
                dataVacinacao = value;
            }
        }

        public Animal Animal
        {
            get
            {
                return animal;
            }

            set
            {
                animal = value;
            }
        }

        public Veterinario Veterinario
        {
            get
            {
                return veterinario;
            }

            set
            {
                veterinario = value;
            }
        }


        public List<DoseVacina> LDoseVacina
        {
            get
            { 
                
                return lDoseVacina; 
            
            }


            set 
            { 
                
                lDoseVacina = value; 
            
            }
        }
    }
}
