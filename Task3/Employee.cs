using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Employee
    {
        string name, surname;
        float salary = 1000f;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void DisplayName()
        { 
            Console.WriteLine("Name: "+name+" Surname: "+surname);
        }

        public void CalculateSalary(string position, float termin)
        {
            Console.WriteLine("Salary = " + (salary + (100 * termin) + (200 * (position == "Senior" ? 1 : 0))));
        }

        public void CalculateTaxes(string position, float termin)
        {
            float nfl = 200;
            Console.WriteLine("Taxes = " + Convert.ToSingle(((salary + (100 * termin) + (200 * (position == "Senior" ? 1 : 0))) - nfl)*0.18f));
        }
    }
}
