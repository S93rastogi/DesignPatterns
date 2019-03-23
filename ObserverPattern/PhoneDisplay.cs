using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class PhoneDisplay:IObserver
    {
        public PhoneDisplay(IObservable weatherStation)
        {
            WeatherStation = weatherStation;
        }

        private IObservable WeatherStation { get; set; }

        public void Update()
        {
            Incrementor++;
            Console.WriteLine("Called Update {0}",Incrementor);
            Console.WriteLine("The Temperature is {0}",WeatherStation.CurrentTemperature());
        }

        private int Incrementor { get; set; }
    }
}
