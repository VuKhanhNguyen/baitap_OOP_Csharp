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
            PartTimeEmployee pte = new PartTimeEmployee("Nguyen Vu khanh",18000,5);
            PartTimeEmployee pte2 = new PartTimeEmployee("Tran Dinh Quy", 18000,6);

            FullTimeEmployee fte = new FullTimeEmployee("Nguyen Dinh Duc", 20000);
            FullTimeEmployee fte2 = new FullTimeEmployee("Le Thi Tra Giang", 30000);

            Console.WriteLine(pte.toString());
            Console.WriteLine(pte2.toString());
            Console.WriteLine(fte.toString());
            Console.WriteLine(fte2.toString());

        }
    }
}
