using System;

namespace City
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Fiat", "Mustang", "blue", 123);

            Console.WriteLine(car1.brand);
            Console.WriteLine(car1.type);
            Console.WriteLine(car1.color);
            Console.WriteLine(car1.AutoNumber());

            Street street1 = new Street("Moldevei", 123);

            Console.WriteLine(street1.name);
            Console.WriteLine(street1.number);

            Park park1 = new Park("Central Park");
            Console.WriteLine(park1.name);

            Building building1 = new Building("Trade Center", 80);
            Console.WriteLine(building1.name);
            Console.WriteLine(building1.floors);

            School school1 = new School("Emanuel Theological High-School");
            Console.WriteLine(school1.name);
        }
    }
}
