using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {//part1
                int day, month;
                Console.WriteLine("Enter two numbers :");
                day = int.Parse(Console.ReadLine());
                month = int.Parse(Console.ReadLine());
                if (day >= 1 && day <= 31)
                    if (month >= 1 && month <= 12)
                        Console.WriteLine("true");
                    else Console.WriteLine("false"); ;
                Console.ReadKey();
            }
            {// part2 
                int n1 = 0, n2 = 0, sum, i;
                string temp;
                Console.WriteLine("Enter number with floating point :");
                temp = Console.ReadLine();
                for (i = 0; i < temp.Length; i++)
                {
                    if ((temp[i] == '.') || (temp[i] == ','))
                    {
                        n1 = Int32.Parse(temp[i + 1].ToString());
                        n2 = Int32.Parse(temp[i + 2].ToString());
                        break;
                    }
                    else { n1 = 0; n2 = 0; }
                }
                sum = n1 + n2;
                Console.WriteLine("Your number is {0}, and sum of first 2 elements after point ({1} and {2}) is {3} ", temp, n1, n2, sum);
                Console.ReadKey();
            }
            {//part3
                int h;
                Console.WriteLine("Enter hour :");
                h = int.Parse(Console.ReadLine());
                switch (h)
                {
                    case int i when (i>=0)&&(i<=6):
                        Console.WriteLine("Доброї ночі!");
                        break;
                    case int i when (i > 6) && (i <= 12):
                        Console.WriteLine("Доброї ранку!");
                        break;
                    case int i when (i >12) && (i <= 18):
                        Console.WriteLine("Доброго дня!");
                        break;
                    case int i when (i > 18) && (i < 24):
                        Console.WriteLine("Доброго вечора!");
                        break;
                    default:
                        Console.WriteLine("Хибний ввід");
                        break;
                }
                Console.ReadKey();

            }
        }
    }
}