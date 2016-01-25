using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Lab
{   public enum KittyBreeds {Bobtail,Curl,Shorthair,Balinese,Bengal,Birman,Bombay,Korat,Manx,Munchkin,Nebelung,Ocicat,Oriental,Persian,Ragdoll,Siamese,Snowshoe,Siberian,Singapura,Somali,Tonkinese};
    class CatBreeds
    {
        Random random = new Random();
        public void print()
        {
            Array CatNames = Enum.GetValues(typeof(Names));
            Array Cbreeds = Enum.GetValues(typeof(KittyBreeds));
            Names myName = (Names)CatNames.GetValue(random.Next(CatNames.Length));
            KittyBreeds myBreeds = (KittyBreeds)Cbreeds.GetValue(random.Next(Cbreeds.Length));

            Console.WriteLine("Name: " + myName);
            Console.WriteLine("Age : " + random.Next(1, 11));
            Console.WriteLine("Breed: " + myBreeds);
        }
    }
}
