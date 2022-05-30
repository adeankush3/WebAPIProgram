using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConditionalSatement conditionalSatement = new ConditionalSatement();
            conditionalSatement.statement();
            
            Console.WriteLine(" Welcome To CSharp Programming");
            int x, y;
            x = 100;
            y = x / 2;
            Console.WriteLine(y);
            //Camel Case = firstNumber(Only Variable)
            //Pascel case= FirstNumber(Reamaning all)

            byte smallNumber = 1; //Datatype variable;
            int Number = 20;//Identifier = Datatype variable(Meaning full name);
            float PointValue = 20.2f;
            decimal valuaeOfPi = 3.14m;
            char singleLatter = 'a';
            bool isItWorking = true;
            Console.WriteLine(smallNumber);
            Console.WriteLine(Number);
            Console.WriteLine(PointValue);
            Console.WriteLine(valuaeOfPi);
            Console.WriteLine(singleLatter);
            Console.WriteLine(isItWorking);


            //Operator
            int a = 10, b = 20, c = 10;
            Console.WriteLine(a == b && a == c);
            Console.WriteLine(a == b || a == c);

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a > b);
            //Console.ReadLine();

            //Type Conversion
            //Implicit,Explicitand Conversion between compatible type
            //Implicit byte b=10;      float f=b;
            //Explicit double d=765.25;   int i=(int)d;
            //compatible string s="1234";    int i=Convert.ToInt32(s);

            byte m = 10;
            int n = m;
            long l = y;
            Console.WriteLine(n);
            Console.WriteLine(l);
            //Getting User input
            string name;
            Console.Write("Enter Your Name:-");
            name=Console.ReadLine();
            Console.WriteLine("User Name:"+name);
            //Console.ReadLine();
            //Conditional Satement=
            //If Statement if(Condition){Bofy Of If}

            


        }

    }
}
