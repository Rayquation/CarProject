using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bil 1
            Car c1 = new Car(ColorEnum.Black, "Mercedes","EQE",180,2495,292);

            //Bil 2
            Car c2 = new Car(ColorEnum.White, "Porsche","Cayenne");
            c2.Topspeed = 245;
            c2.Weight = 2565;
            c2.HP = 680;

            //Bil 3
            Car c3 = new Car();
            c3.Color = ColorEnum.Blue;
            c3.Brand = "Tesla";
            c3.Model = "Model 1";
            c3.Topspeed = 402;
            c3.Weight = 1304;
            c3.HP = 1020;

            //Udskrivning af biller
            Car[] cars = new Car[3];
            cars[0] = c1;
            cars[1] = c2;
            cars[2] = c3;
            Console.WriteLine("Unsorted Cars:");
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }

            //MyComparer mc = new MyComparer();
            //int result = mc.Compare(c1, c2);

            Console.WriteLine("\nSorted Cars:");
            Array.Sort(cars,new MyComparer());
            foreach(Car car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadKey();
        }
    }
}
