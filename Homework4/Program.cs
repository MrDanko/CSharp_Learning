using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[6]; 
                
            people[0] = new Person();
            people[1] = new Person("Ann", 1996,5,6);
            people[2] = new Person("John", 2011,2,19);
            people[3] = new Person("Lui", 2000,1,1);
            people[4] = new Person("Greg", 1986,12,31);
            people[5] = new Person("Tom", 2004,10,1);
            foreach (Person p in people)
            {
                Console.WriteLine(p.Name + "\t " + p.Age());
            }
            foreach (Person p in people)
            {
                if (p.Age() <= 16)
                    p.ChangeName("Very Young");
            }
            Console.WriteLine();
            foreach (Person p in people)
            {
                p.Output();
               
            }
            Console.ReadKey();
        }
    }
    class Person
    {
        DateTime birthYear;
        public string Name { get; set; }
        public int BirthYear
        {
            get
            {
                return birthYear.Year;
            }
        }
        public Person()
        {
            Name = "Tom";
            birthYear = new DateTime(1990,01,01);
        }
        public Person(string n, int y, int m, int d)
        {
            Name = n;
            birthYear = new DateTime(y,m,d);
        }
        public int Age()
        {
            return (DateTime.Today.Year - BirthYear);

        }
        public void ChangeName(string n)
        {
            Name = n;
        }
        public override string ToString()
        {
            string str = Name + " was born in " +birthYear.Year;
          
            return str;
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
    }
}
