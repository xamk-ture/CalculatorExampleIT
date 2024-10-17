using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{

    //Class is a blueprint of a thing
    //For example here is a blueprint of a car that what every car has (this is simpler version)
    //And later on we can set values to this variables that tell whatk kind of car it is
    //For example (example can be found at Program.cs)

    //Car car = new Car();

    //car.Year = 2000;
    //car.Model = "BMW";
    //car.HorsePower = 500;
    public class Car
    {
        //Here is some variables that each car has
        public string Model;
        public int Year;
        public int HorsePower;

        private string privateInfo = "private string variable text";

        /// <summary>
        /// Here this class has few methods (methods are like functions but the function is inside a class)
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Engine is staring");
        }

        public void Stop()
        {
            Console.WriteLine("Engine stopping");
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Model: {Model}, Year: {Year}, Private text: {privateInfo}");
        }

    }

    /// <summary>
    /// This is a static class and that means that there is only one instance of StaticClassDemo
    /// </summary>
    public static class StaticClassDemo
    {
        /// <summary>
        /// This is a function because there can be only one instance
        /// This means that there can be only one instance of StaticClassDemo. Car class can be created as many times as needed
        /// </summary>
        public static void StaticPrintDemo()
        {
            Console.WriteLine("Printing static function");
        }
    }
}
