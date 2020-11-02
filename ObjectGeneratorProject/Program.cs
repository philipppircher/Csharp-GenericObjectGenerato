using ObjectGeneratorProject.Classes;
using System;
using System.Collections.Generic;

namespace ObjectGeneratorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectGenerator objectGenerator = new ObjectGenerator();

            // Get single object instances
            //
            Beer beer = objectGenerator.GetNewObject<Beer>();
            Car car = objectGenerator.GetNewObject<Car>();

            Console.WriteLine(beer.ToString());
            Console.WriteLine(car.ToString());
            Console.WriteLine(car.driving());

            // Get a list of objectinstances
            //
            List<Beer> beers = objectGenerator.GetNewObjects<Beer>(5);

            // Print all objects
            //
            foreach (var item in beers)
            {
                Console.WriteLine(item.ToString());
            }

            // Create Tiger and Monkeys
            Tiger tiger = objectGenerator.GetNewObject<Tiger>("Frosty");

            List<Tiger> tigers =
                objectGenerator.GetNewObjects<Tiger>(new string[]{"tommy", "todd"});
        }
    }
}
