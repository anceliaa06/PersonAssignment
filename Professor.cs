using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAssign
{
    public  class Professor : SalariedEmployee
    {
        public string Department { get; set; }

        public Professor(int id, string address, DateTime dob, decimal baseSalary, int experienceYears, string department) : base(id, address, dob, baseSalary, experienceYears)
        {
            Department = department;
        }
        public override decimal CalculateSalary()
        {
            decimal bonusPerYear = 5000m;
            return BaseSalary + (ExperienceYears * bonusPerYear);
        }
    }
}
