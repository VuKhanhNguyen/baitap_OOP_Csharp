using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_OOP
{
    public abstract class Employee : IEmployee
    {
        private string name_118;
        private int paymentPerHour_118;

        public void setName(string name_118)
        {
            this.name_118 = name_118;
        }

        public string getName()
        {
            return name_118;
        }

        public void setPaymentPerHour(int paymentPerHour_118)
        {
            this.paymentPerHour_118 = paymentPerHour_118;
        }

        public int getPaymentPerHour()
        {
            return paymentPerHour_118;
        }


        public Employee()
        {
            
        }

        public Employee(string name_118, int paymentPerHour_118)
        {
            this.name_118 = name_118;
            this.paymentPerHour_118 = paymentPerHour_118;
        }

        public abstract int calculateSalary();

        public string toString()
        {
            return "Name: " + name_118 + ", Payment per hour: " + paymentPerHour_118;
        }

    }
}
