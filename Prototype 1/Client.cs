using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Client
    {
       
        private int clientID;
        private string firstName;
        private string lastName;
        private double familyIncome;
        private string livingArrangement;
        private int noChildren;
        private List<Appointment> appointments;
        private List<Application> applications;
        private List<Invoice> invoices;

        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public double FamilyIncome
        {
            get { return familyIncome; }
            set { familyIncome = value; }
        }

        public string LivingArrangement
        {
            get { return livingArrangement; }
            set { livingArrangement = value; }
        }

        public int NoChildren
        {
            get { return noChildren; }
            set { noChildren = value; }
        }

        public Client() { }

        public Client(int cID, string fn, string ln, double fi, string la, int nc)
        {
            ClientID = cID;
            FirstName = fn;
            LastName = ln;
            FamilyIncome = fi;
            LivingArrangement = la;
            NoChildren = nc;
        }

        public List<Application> applyAdoption(int appID, string stat,Client client,Animal animal)
        {
            Application adopotion = new Application(appID, stat, client, animal);
            List<Application> adoptionList = new List<Application>();
            adoptionList.Add(adopotion);

            return adoptionList;
        }

        public List<Appointment> bookAppointment(int appointID, DateTime ti, Client c,Agent a)
        {
            Appointment app =  new Appointment(appointID, ti, c, a);
            List<Appointment> appointList = new List<Appointment>();
            appointList.Add(app);

            return appointList;

        }

        public void cancalAppointment(Appointment app)
        {
            appointments = new List<Appointment>();
            appointments.Remove(app);
        }


    }
}
