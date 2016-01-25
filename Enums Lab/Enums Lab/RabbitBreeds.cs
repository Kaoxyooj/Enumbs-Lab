using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Lab
{   public enum BunnyBreeds {Alaska,Altex,American,Sable,Baladi,Beige,Beveren,Brazilian,Caldes,Californian,Chaudry,Cinnamon,Dutch,Elfin,Gotland,Harlequin,Havana,Himilayan,Lionhead,Lilac,PerlFee,Silver,Tan,Thuringer,Wheaten,Zemmouri};
    class RabbitBreeds
    {
        Random random = new Random();
        public void print()
        {
            Array RabbitNames = Enum.GetValues(typeof(Names));
            Array Rbreeds = Enum.GetValues(typeof(BunnyBreeds));
            Names myName = (Names)RabbitNames.GetValue(random.Next(RabbitNames.Length));
            BunnyBreeds myBreeds = (BunnyBreeds)Rbreeds.GetValue(random.Next(Rbreeds.Length));

            Console.WriteLine("Name: " + myName);
            Console.WriteLine("Age : " + random.Next(1, 11));
            Console.WriteLine("Breed: " + myBreeds);
        }
    }
}
