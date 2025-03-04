using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_OOP
{
    internal class PartTimeEmployee : Employee
    {
        private int workingHours_118 { get; set; }

        public PartTimeEmployee(string name_118, int paymentPerHour_118, int workingHours_118) : base(name_118, paymentPerHour_118)
        {
            this.workingHours_118 = workingHours_118;
        }

        public override int calculateSalary()
        {
            return workingHours_118 * getPaymentPerHour();
        }

    }
}
