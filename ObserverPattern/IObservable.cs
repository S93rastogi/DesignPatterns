using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface IObservable
    {
        void Add(IObserver display);
        void Remove(IObserver display);
        void Notify();
        int CurrentTemperature();

    }
}
