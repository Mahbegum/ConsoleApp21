using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class employee
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // To check if two inputs are the same

        public static bool operator ==(employee empl1, employee empl2)
        {
            if (ReferenceEquals(empl1, empl2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool operator !=(employee empl1, employee empl2)
        {
            if (!ReferenceEquals(empl1, empl2))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
