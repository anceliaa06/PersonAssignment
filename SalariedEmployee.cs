using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAssign
{
    public abstract class SalariedEmployee : Person
    {
        public decimal BaseSalary { get; set; }
        public int ExperienceYears { get; set; }
        public SalariedEmployee(int id, string address, DateTime dob, decimal baseSalary, int experienceYears) : base(id, address, dob)
        {
            BaseSalary = baseSalary;
            ExperienceYears = experienceYears;
        }
        public abstract decimal CalculateSalary();


    }
}
