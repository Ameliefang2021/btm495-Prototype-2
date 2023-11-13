using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class MedicalHistory
    {
        private string disease;
        private string treatment;
        private Veterinarian vet;
        private Animal animal;
     
        public MedicalHistory() { }

        public MedicalHistory(string disease, string treatment, Veterinarian vet, Animal animal)
        {
            this.disease = disease;
            this.treatment = treatment;
            this.vet = vet;
            this.animal = animal;
        }

        public string Disease { get => disease; set => disease = value; }
        public string Treatment { get => treatment; set => treatment = value; }
        public Veterinarian Vet { get => vet; set => vet = value; }
        public Animal Animal { get => animal; set => animal = value; }
    }
}
