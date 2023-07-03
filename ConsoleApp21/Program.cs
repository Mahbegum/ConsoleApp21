using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            employee empl1 = new employee();
            empl1.Id = 1;
            empl1.FirstName = "Raziq";
            empl1.LastName = "Ali";

            employee empl2 = new employee();
            empl2.Id = 2;
            empl2.LastName = "Raziq";
            empl2.LastName = "Ali";

            // comparing two inputs 
            Console.WriteLine(empl1 == empl2);
            Console.WriteLine(empl2 != empl1);
            Console.ReadLine();

        }
    }
}
