using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Veterinarian : Employee
    {
        private string specialization;

        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }

        public Veterinarian(int eID, string n, DateTime st, double s, string specialization)
           : base(eID, n, st, s) => this.specialization = specialization;
    
        public void UpdateMedicalHistory(MedicalHistory medicalHistory)
        {
            medicalHistory.Treatment= "update treatment";
            medicalHistory.Disease = "new disease";
        }
    }
}
