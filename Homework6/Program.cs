using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    interface IFlyable
    {
        void Fly();
    }
    class Bird:IFlyable
    {
        string name;
        bool canFly;
        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }
        public Bird()
        {
            name = "Colibry";
            canFly = true;
        }
        public void Fly()
        {
            if (canFly==true)
            Console.WriteLine($"I am {name} and I can fly");
            else Console.WriteLine($"I am {name} and can't fly");
        }
    }
    class Plane : IFlyable
    {
        string name;
        int highFly;
        public void Fly()
        {
            Console.WriteLine("This is {0} and it can fly at {1} meters",name, highFly);
        }
        public Plane(string name, int high)
        {
            this.name = name;
            highFly = high;
        }
        public Plane()
        {
            name = "Boeing";
            highFly = 6000;
        }
    }

    interface IDeveloper
    {
        string Tool { get; set; }
        void Create();
        void Destroy();

    }
    class Programmer : IDeveloper
    {
        string language;
        public string Tool { get; set; }
        public void Create()
        {
        }
        public void Destroy()
        {
        }
       
    }
    class Builder : IDeveloper
    {
        string tool;
        public string Tool { get; set; }
        public void Create()
        {
        }
        public void Destroy()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyables=new IFlyable[4];
            flyables[0] = new Bird("Pinguin", false);
            flyables[1] = new Plane("Airbus", 7500);
            flyables[2] = new Plane();
            flyables[3] = new Bird();
            foreach(IFlyable flyable in flyables)
            {
                flyable.Fly();
            }
            Console.ReadKey();
        }
        
    }
}
