using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class Program
    {

        int num1;
        int num2;
        int result;

            void Add()
            {
                result = num1 + num2;
                Console.WriteLine(result);
                Console.ReadLine();
            }
            void subtract()
            {
                result = num1 - num2;
                Console.WriteLine(result);
                Console.ReadLine();
            }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.num1 = 20;
            program.num2 = 20;
            program.Add();
            program.subtract();
            Console.WriteLine("Ankush");
            Console.ReadLine();
        }
    }
}
