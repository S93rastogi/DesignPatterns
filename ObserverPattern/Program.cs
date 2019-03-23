using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var weather = new WeatherStation();
            var displayAndriod = new PhoneDisplay(weather);
            var windowDisplay = new PhoneDisplay(weather);
            weather.Add(displayAndriod);
            weather.Add(windowDisplay);
            weather.Notify();
            Console.ReadLine();
        }

    }
}
