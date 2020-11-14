using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntGreaterThan
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            int compNum = 0;
            Console.WriteLine("Enter an integer to comare");
            string compare = Console.ReadLine();
            Int32.TryParse(compare, out compNum);

            while (value <= compNum)
            {
                Console.Write("Enter an integer: ");

                string line = Console.ReadLine();

                Int32.TryParse(line, out value);
            }

            Console.WriteLine($"Integer greater than {compNum} detected!");

            Console.ReadLine();
        }
    }
}
