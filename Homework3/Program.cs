using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
//            int count1=0,count2=0,count3=0,count4=0 ;
            string str;
            Console.WriteLine("Введіть деякий текст :");
            str = Console.ReadLine();
            for (int i=0; i<str.Length; i++)
            {
                switch (str[i])
                {
                    case 'а':
                        count++;
//                        count1++;
                        break;
                    case 'о':
                        count++;
//                        count2++;
                        break;
                    case 'ї':
                        count++;
 //                       count3++;
                        break;
                    case 'е':
                        count++;
 //                       count4++;
                        break;
                }
            }
            Console.WriteLine("Number of \'а', \'о',\'ї', \'е' is {0}", count);
//            Console.WriteLine($"Number of \'а' - {count1}, \'о' - {count2}, \'ї' - {count3}, \'е' - {count4}");
            
            int month,sum;
            bool pos = true;
            Console.WriteLine("Введіть номер місяця");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine($"Кількість днів у {month} місяці - "+DateTime.DaysInMonth(2018, month));
            Console.ReadKey();
            //int[] numbers = new int[10];
            //Console.WriteLine("Введіть 10 чисел");
            //for (int i=0; i<10; i++)
            //numbers[i] = int.Parse(Console.ReadLine());
            

        }
    }
}
