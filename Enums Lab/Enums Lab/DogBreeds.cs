using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Lab
{
    public enum DoggyBreeds {Labrador,Bulldog,GermanShephard,GoldRetriever,Poodle,Beagle,SiberianHusky,Chihuahua,Boxer,Pug,Rottweiler,Greyhound,Pointer,Akita,Pomeranian};
   
    class DogBreeds
    {
        Random random = new Random();
        public void print()
        {
            Array DogNames = Enum.GetValues(typeof(Names));
            Array Dbreeds = Enum.GetValues(typeof(DoggyBreeds));
            Names myName = (Names)DogNames.GetValue(random.Next(DogNames.Length));
            BirdyBreeds myBreeds = (BirdyBreeds)Dbreeds.GetValue(random.Next(Dbreeds.Length));

            Console.WriteLine("Name: " + myName);
            Console.WriteLine("Age : " + random.Next(1, 11));
            Console.WriteLine("Breed: " + myBreeds);
        }
    }
}
