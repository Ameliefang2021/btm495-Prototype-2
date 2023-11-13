using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class AnimalTransfer
    {
        private int animalTransferID;
        private DateTime date;
        private string origin;
        private string destination;

        public int AnimalTransferID
        {
            get { return animalTransferID; }
            set { animalTransferID = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public AnimalTransfer() { }

        public AnimalTransfer(int aTID, DateTime d, string o, string dest)
        {
            AnimalTransferID = aTID;
            Date = date;
            Origin = origin;
            Destination = destination;
        }

        public void UpdateAnimal(Animal animal)
        {
            animal.Location = "new location";
        }
    }
}
