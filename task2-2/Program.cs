using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_2
{
    class Program
    {
        enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted };
        struct RGB
        {
            public byte red, green, blue;
        }
        static void Main(string[] args)
        {
            TestCaseStatus testStatus = TestCaseStatus.Pass;
            Console.WriteLine("Test status is {0}",testStatus);
            Console.ReadKey();
            RGB white, black;
            white.red = 0;
            white.green = 0;
            white.blue = 0;
            black.red = 255;
            black.green = 255;
            black.blue = 255;

        }
    }
}
