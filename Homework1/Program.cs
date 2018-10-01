using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,sqr,per;
            Console.WriteLine("Enter new number: ");
            a = Int32.Parse(Console.ReadLine());
            per = 2 * (a + a);
            sqr = a * a;
            Console.WriteLine("Периметр квадрата з стороною {0} рівний {1}, а його площа - {2}", a, per, sqr);
            Console.ReadKey();
            string name;
            int age;
            Console.WriteLine("What's your name: ");
            name = Console.ReadLine();
            Console.WriteLine("How old are you, {0}:", name);
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and you're {1} years old", name, age);
            Console.ReadKey();
            double r, l,v,area;
            Console.WriteLine("Enter radius: ");
            r = Double.Parse(Console.ReadLine());
            l = 2 * Math.PI * r;
            area = Math.PI * r * r;
            v = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine("Circle with radius {0} has length - {1}, area - {2} and volume {3}", r, l, area, v);
            Console.ReadKey();

        }
    }
}
