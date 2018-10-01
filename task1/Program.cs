using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            {//part 1
                int a, b;
                Console.WriteLine("Enter first number: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("a + b = " + (a + b));
                Console.WriteLine("a - b = " + (a - b));
                Console.WriteLine("a * b = " + (a * b));
                Console.WriteLine("a / b = " + (Convert.ToDouble(a) / Convert.ToDouble(b)));
            }
            {//part 2
                Console.WriteLine("How are you?");
                string answer = Console.ReadLine();
                Console.WriteLine("You are " + answer);
            }
            {//part 3 
                char ch1, ch2, ch3;
                Console.WriteLine("Enter first char: ");
                ch1 = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter second char: ");
                ch2 = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter third char: ");
                ch3 = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("You entered {0}, {1}, {2}", ch1, ch2, ch3);
            }
            {//part 4
                int i1, i2;
                bool rez;
                string ans;
                Console.WriteLine("Enter 2 numbers: ");
                i1 = int.Parse(Console.ReadLine());
                i2 = int.Parse(Console.ReadLine());
                rez = (i1 > 0) && (i2 > 0);
                ans = rez ? "positive" : "negative";
                Console.WriteLine("Numbers {0} and {1} are {2} ({3})", i1, i2, ans, rez);
                Console.ReadKey();
            }    
        }
    }
}
