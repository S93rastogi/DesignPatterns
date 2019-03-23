using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherStation : IObservable
    {
        readonly List<IObserver> _observerDisplays = new List<IObserver>();

        public void Add(IObserver display)
        {
            _observerDisplays.Add(display);
        }

        public void Remove(IObserver display)
        {
            _observerDisplays.Remove(display);
        }

        public void Notify()
        {
            foreach (var displays in _observerDisplays)
            {
                displays.Update();   
            }
        }

        public int CurrentTemperature() => Temperature;

        private int Temperature { get; } = 23;
    }
}
