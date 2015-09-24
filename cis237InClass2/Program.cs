using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class Program
    {
        static void Main(string[] args)
        {

            Factorial factorial = new Factorial();

            Console.WriteLine("The answer to 5! is: ");
            Console.WriteLine(factorial.Calculate(5));

            Console.WriteLine("\n");
            Console.WriteLine("*******************");
            Console.WriteLine("\n");

            Hanoi hanoi = new Hanoi();

            hanoi.moveDisc(3, 'A', 'B', 'C');
        }
    }
}
