using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Bird : Animal
    {
        private string species;
        private string breed;

        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public Bird(int aID, int age, string sx, string co, string si, string species, string breed)
            : base(aID, age, sx, co, si)
        {
            this.species = species;
            this.breed = breed;
        }

    }
}
