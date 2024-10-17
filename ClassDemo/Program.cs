using System.Diagnostics;

namespace ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car car = new Car();

            car.Year = 2000;
            car.Model = "BMW";
            car.HorsePower = 500;
            car.Start();
            car.Stop();

            car.PrintCarInfo();

            StaticClassDemo.StaticPrintDemo();
        }
    }
}
