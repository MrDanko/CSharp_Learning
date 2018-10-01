using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        enum HTTPError { BadRequest=400, Unauthorized, PaymentRequired, Forbidden, NotFound };
        struct Dog
        {
            public string Name;
            public string Mark;
            public int Age;
            public override string ToString()
            {
                return $"Your dog {Name} is {Mark} and {Age} years old";
            }
        }
        static void Main(string[] args)
        {
            {
                float a, b, c,min=-5,max=5;
                Console.WriteLine("Enter 3 numbers: ");
                a = float.Parse(Console.ReadLine());
                b = float.Parse(Console.ReadLine());
                c = float.Parse(Console.ReadLine());
                if ((min < a && a < max) && (min < b && b < max) && (min < c && c < max))
                {
                    Console.WriteLine("Numbers are in range");
                }
                else Console.WriteLine("Numbers are not in range");
                Console.ReadKey();
            }
            {
                int min,max,i;
                int[] a = new int[3];
                Console.WriteLine("Enter 3 numbers: ");
                
                min = a[0];
                max = a[0];
                for (i=1; i<3; i++)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                    else if (a[i] > max)
                    {
                        max = a[i];
                    }
                }
                Console.WriteLine("min - {0}, max - {1}", min, max);
                Console.ReadKey();
            }
            {
                int er;
                Console.WriteLine("Enter error number");
                er = int.Parse(Console.ReadLine());
                HTTPError error =(HTTPError) er;
                Console.WriteLine("Error {0}: {1}", (int)error, error);
                Console.ReadKey();
            }
            {
                Dog MyDog;
                Console.WriteLine("Enter yor dog's name:");
                MyDog.Name = Console.ReadLine();
                Console.WriteLine("Enter yor dog's mark:");
                MyDog.Mark = Console.ReadLine();
                Console.WriteLine("Enter yor dog's age:");
                MyDog.Age = int.Parse(Console.ReadLine());
                Console.WriteLine(MyDog.ToString());
                Console.ReadKey();
            }
        }
    }
}
