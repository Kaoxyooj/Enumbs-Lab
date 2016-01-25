using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Lab
{
    class Forecast : SevenDaysABS
    {
        SevenDaysABS seven = new SevenDaysABS();
        enum MyForecast
        {
            Sunny,
            Cloudy,
            Rainy,
            Thunderstorms,
            PartlyCloudy,
            Foggy,
            Humid,           
        };
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };
        Random random = new Random();
        public void Forecasts()
        {
            Array myValues = Enum.GetValues(typeof(MyForecast));
            Array Values = Enum.GetValues(typeof(Days));

            foreach (Days day in Values) {
                MyForecast randomForecast = (MyForecast)myValues.GetValue(random.Next(myValues.Length));
                Console.WriteLine(day);
                Console.WriteLine(randomForecast);
                Console.WriteLine("--------------------");
            };        
        }
    }
}
