using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Dog : Animal
    {
        private string breed;
        private bool neutered;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public bool Neutered
        {
            get { return neutered; }
            set { neutered = value; }
        }

        public Dog(int aID, int age, string sx, string co, string si, string breed, bool neutered)
           : base(aID, age, sx, co, si)
        {
            this.breed = breed;
            this.neutered = neutered;
        }
    }
}

