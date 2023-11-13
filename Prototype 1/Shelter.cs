using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Shelter
    {
        private string address;
        private double capacity;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public double Capacity
        {
            get { return Capacity; }
            set { Capacity = value; }
        }

        public Shelter() { }

        public Shelter(string add, double cap)
        {
            Address = add;
            Capacity = cap;
        }

        public int CalOccupation()
        {
            List<Animal> animals = new List<Animal>();
            return animals.Count;
        }
    }
}
