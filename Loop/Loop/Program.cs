using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if(i == 5)
                continue;
                Console.WriteLine(i);
                //if(i == 5)
                //break;
            }
            Console.ReadLine();

            //int i = 1;
            //while(i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.ReadLine();

            //int i=0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i < 10);
            //Console.ReadLine();

        }
    }
}
