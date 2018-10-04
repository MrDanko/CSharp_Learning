using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Car
    {
        string name, color;
        double price;
       // public readonly string companyName;
        const string companyName = "BMW";
        public string Color
        {
            get
            { return color; }
        }
        //public Car(string companyName, string name, string color, double price)
        //{
        //    this.companyName = companyName;
        //    this.name = name;
        //    this.color = color;
        //    this.price = price;
        //}
            public Car(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;

        }
        public void Input(string color, double price)
        {
            this.color = color;
            this.price = price;

        }
        public void Input(string color)
        {
            this.color = color;
        }
        public void Input(double price)
        {
            this.price = price;

        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
        public void ChangePrice(double x)
        {
            price += price * (x / 100);
        }
        public override string ToString()
        {
            return ($"{companyName} {name} - color {color} - price {price} $");
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            string newColor;
            Car[] cars = new Car[3];
            //cars[0] = new Car("BMW", "M3", "White", 35000);
            //cars[1] = new Car("BMW", "X5", "Black", 65000);
            //cars[2] = new Car("Mercedes", "SLK", "White", 40000);
            cars[0] = new Car("M3", "White", 35000);
            cars[1] = new Car("X5", "Black", 65000);
            cars[2] = new Car("750i", "White", 40000);
            foreach (Car car in cars)
            {
                car.Print();
            }
            foreach (Car car in cars)
            {
                car.ChangePrice(-10);
                car.Print();
            }
            Console.WriteLine("Enter new color:");
            newColor = Console.ReadLine();
            
            foreach ( Car car in cars) 
            {
                if (car.Color=="White")
                    car.Input(newColor);
                car.Print();

            }
            Console.ReadKey();
        }
    }
}
