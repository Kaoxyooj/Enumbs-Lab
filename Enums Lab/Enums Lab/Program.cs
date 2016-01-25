using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Forecast myForecast = new Forecast();
            myForecast.Forecasts();

            Console.Read();
        }
    }
}
