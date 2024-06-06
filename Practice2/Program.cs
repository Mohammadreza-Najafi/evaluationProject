using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Enter A Number");
                string numA = Console.ReadLine();
                HugeInteger hugeIntegerA = new HugeInteger();
                if (numA.Length > 0)
                {
                     hugeIntegerA = new HugeInteger(numA);
                }
                else
                    break;


                Console.WriteLine("Enter B Number");
                string numB = Console.ReadLine();
                HugeInteger hugeIntegerB = new HugeInteger();
                if (numB.Length > 0)
                {
                    hugeIntegerB = new HugeInteger(numB);
                }
                else
                    break; 

               
                bool result = hugeIntegerA.Equals(hugeIntegerB);
                if(result)
                    Console.WriteLine("Number A is Equals with Number B");

                result = hugeIntegerA.IsGreaterThan(hugeIntegerB);
                if (result)
                    Console.WriteLine("Number A Is Greater Than Number B");

                result = hugeIntegerA.IsLessThan(hugeIntegerB);
                if (result)
                    Console.WriteLine("Number A Is Less Than Number B");


            }


            Console.WriteLine("The program was closed");

            Console.ReadKey();
        }
    }
}
