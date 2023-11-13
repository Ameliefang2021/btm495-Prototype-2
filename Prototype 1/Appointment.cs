using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Appointment
    {
        private int appointID;
        private DateTime time;
        private Client client;
        private Agent agent;

        public int AppointID
        {
            get { return appointID; }
            set { appointID = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public Client Client { get => client; set => client = value; }
        public Agent Agent { get => agent; set => agent = value; }

        public Appointment() { }

        public Appointment(int appointID, DateTime ti)
        {
            AppointID = appointID;
            Time = ti;
        }

        public Appointment(int appointID, DateTime time, Client client, Agent agent)
        {
            AppointID = appointID;
            Time = time;
            Client = client;
            Agent = agent;
        }
    }
}
