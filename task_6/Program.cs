using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", 2022, "Sedan", 35000, "Series", 1, "Red");
            car.CarInfo();
            car.StartEngine();
            car.StopEngine();

            CarTest carTest = new CarTest("BMW", 2022, "Sedan", 35000, "Series", 1, "Red", 100, 5);
            carTest.StartEngine();
            carTest.StopEngine();
            carTest.CarInfo();
            carTest.CarTestInfo();

            Console.ReadLine();
        }
    }
    public class Car
    {
        public string make { get; set; }
        public int year { get; set; }
        public string type { get; set; }
        public double price { get; set; }
        public string model { get; set; }
        public int palletNo { get; set; }  
        public string color { get; set; }
        private bool EngineStarted { get; set; }

        public Car(string make, int year, string type, double price, string model, int palletNo, string color)
        {
            this.make = make;
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            this.palletNo = palletNo;
            this.color = color;
            EngineStarted = false;
        }

        public void StartEngine()
        {
            if (!EngineStarted)
            {
                EngineStarted = true;
                Console.WriteLine("Engine started.");
            }
            else
            {
                Console.WriteLine("Engine is already running.");
            }
        }

        public void StopEngine()
        {
            if (EngineStarted)
            {
                EngineStarted = false;
                Console.WriteLine("Engine stopped.");
            }
            else
            {
                Console.WriteLine("Engine is already stopped.");
            }
        }

        public void CarInfo()
        {
            Console.WriteLine($"Make: {make}, Year: {year}, Type: {type}, Price: {price}, Model: {model}, Pallet No: {palletNo}, Color: {color}");
        }
    }
    public class CarTest: Car
    {
        public int speed { get; set; }
        public int size { get; set; }
        
        public CarTest(string make, int year, string type, double price, string model, int palletNo, string color, int speed, int size) : base(make, year, type, price, model, palletNo, color)
        {
            this.speed = speed;
            this.size = size;
        }
        public void CarTestInfo()
        {
            Console.WriteLine($"Speed: {speed}, Size: {size}");
            //Console.WriteLine($"Make: {make}, Year: {year}, Type: {type}, Price: {price}, Model: {model}, Pallet No: {palletNo}, Color: {color}");
        }
    }
}
