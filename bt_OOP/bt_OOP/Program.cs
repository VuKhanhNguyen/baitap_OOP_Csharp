using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("||Nguyen Vu Khanh - 22115053122118||");
            Console.WriteLine("====================================");
            PartTimeEmployee pte_118 = new PartTimeEmployee("Nguyen Vu khanh",18000,5);
            PartTimeEmployee pte2_118 = new PartTimeEmployee("Tran Dinh Quy", 18000,6);

            FullTimeEmployee fte_118 = new FullTimeEmployee("Nguyen Dinh Duc", 20000);
            FullTimeEmployee fte2_118 = new FullTimeEmployee("Le Thi Tra Giang", 30000);

            Console.WriteLine(pte_118.toString());
            Console.WriteLine(pte2_118.toString());
            Console.WriteLine(fte_118.toString());
            Console.WriteLine(fte2_118.toString());

        }
    }
}
