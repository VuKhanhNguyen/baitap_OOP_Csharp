using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_OOP
{
    internal class PartTimeEmployee : Employee
    {
        private int workingHours { get; set; }

        public PartTimeEmployee(string name, int paymentPerHour, int workingHours) : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }

        public override int calculateSalary()
        {
            return workingHours * getPaymentPerHour();
        }

    }
}
