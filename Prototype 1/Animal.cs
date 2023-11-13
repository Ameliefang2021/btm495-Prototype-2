using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public abstract class Animal
    {
        private int animalID;
        private string name;
        private int age;
        private string sex;
        private string color;
        private string size;
        private string location;
        private bool healthstatus;


        public int AnimalID
        {
            get { return animalID; }
            set { animalID = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public bool Healthstatus { get => healthstatus; set => healthstatus = value; }

        public Animal() { }

        public Animal(int aID, int age, string sx, string co, string si)
        {
            AnimalID = aID;
            Age = age;
            Sex = sx;
            Color = co;
            Size = si;
        }

        public Animal(int aID, string name,int age, string sx, string co, string si,string loc)
        {
            AnimalID = aID;
            Name = name;
            Age = age;
            Sex = sx;
            Color = co;
            Size = si;
            Location = loc;
        }

    }

    
}
