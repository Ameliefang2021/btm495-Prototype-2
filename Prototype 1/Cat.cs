using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Cat : Animal
    {
        private string breed;
        private bool declawed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public bool Declawed
        {
            get { return declawed; }
            set { declawed = value; }
        }
       

        public Cat() { }
        public Cat(int aID, int age, string sx, string co, string si, string breed, bool declawed)
            : base(aID,age, sx, co, si)
        {
            this.breed = breed;
            this.declawed = declawed;
        }

    }

}
