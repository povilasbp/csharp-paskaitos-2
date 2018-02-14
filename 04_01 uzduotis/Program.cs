using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int usersNumber = 0;
            while(usersNumber < 1 || usersNumber > 10)
            {
                Console.Write("Enter a number between 1 and 10: ");
                string usersResponse = Console.ReadLine();
                usersNumber = Convert.ToInt32(usersResponse);
            }
            Console.WriteLine("ivedete: {0}", usersNumber);
        }
    }
}
