using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DBMIDProject_2022_CS_123l.BL
{
    public class Advisor
    {
        public int designation;
        public decimal salary;
        public Advisor(int designation, decimal salary)
        {
            this.designation = designation;
            this.salary = salary;
        }
    }
}
