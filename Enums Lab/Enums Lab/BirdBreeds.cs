using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Lab
{   public enum BirdyBreeds {Parakeet,Budgerigar,Chicken,Cockatiel,Concure,Parrot,Lovebird,Cockatoo,Macaw,Amazon,Other,Quaker,Caique,Parrotlet,Accentor,Goose,Finch,Pigeon,Rosella,Duck,Lorikeet,Spearow,HummingBirdy,Robin,Cardinal,Falcon,Eagle,Crow};
            
    class BirdBreeds : Animal
    {

        Random random = new Random();
        public void print()
        {
            Array BirdNames = Enum.GetValues(typeof(Names));
            Array Bbreeds = Enum.GetValues(typeof(BirdyBreeds));
            Names myName = (Names)BirdNames.GetValue(random.Next(BirdNames.Length));
            BirdyBreeds myBreeds = (BirdyBreeds)Bbreeds.GetValue(random.Next(Bbreeds.Length));

            Console.WriteLine("Name: " +myName);
            Console.WriteLine("Age : " +random.Next(1,11));
            Console.WriteLine("Breed: " +myBreeds);
        }
    }
}
