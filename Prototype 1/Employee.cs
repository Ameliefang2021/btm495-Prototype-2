using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public abstract class Employee
    {
        private int employeeID;
        private string name;
        private DateTime start;
        private double salary;

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee() { }

        public Employee(int eID, string n, DateTime st, double s)
        {
            EmployeeID = eID;
            Name = n;
            Start = st;
            Salary = s;
        }
    }
}
