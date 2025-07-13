using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAssign
{
    public class Student : Person
    {
        public string Branch { get; set; }

        public Student(int id, string address, DateTime dob, string branch) : base(id, address, dob)
        {
            Branch = branch;
        }
    }
}
