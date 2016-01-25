using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Lab
{   public enum Names {Gypsy,Jordan,Sherlock,Aretha,Sphinx,Tiny,Gemini,Rave,Scooter,Galaxy,Breeze,Millhouse,Chakra,Spiral,Fonzie,Metal,Hank,Alf,Macy,Gonzo,Fairy,Sidney,Magnium,Turok,Rosco,Flare,Lacy,Lazy,Furby,Ringo,Phoebe};
    class Program
    {
        static void Main(string[] args)
        {
            Forecast myForecast = new Forecast();
            myForecast.Forecasts();
            Console.Read();
            Console.Read();

            BirdBreeds birds = new BirdBreeds();
            Console.WriteLine("Bird");
            birds.print();
            Console.WriteLine("-----------------");
            Console.Read();
            Console.Read();

            CatBreeds cats = new CatBreeds();
            Console.WriteLine("Cat");
            cats.print();
            Console.WriteLine("-----------------");
            Console.Read();
            Console.Read();

            DogBreeds dogs = new DogBreeds();
            Console.WriteLine("Dog");
            dogs.print();
            Console.WriteLine("-----------------");
            Console.Read();
            Console.Read();

            RabbitBreeds rabbit = new RabbitBreeds();
            Console.WriteLine("Rabbit");
            rabbit.print();
            Console.WriteLine("-----------------");

            Console.Read();
            Console.Read();


        }
    }
}
