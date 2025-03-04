using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_OOP
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name_118, int paymentPerHour_118) : base(name_118, paymentPerHour_118)
        {

        }

        public override int calculateSalary()
        {
            return 8 * getPaymentPerHour();
        }

        public string toString()
        {
            return base.toString() + ", Salary: " + calculateSalary();
        }
    }
}
