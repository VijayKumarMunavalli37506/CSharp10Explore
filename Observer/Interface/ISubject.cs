using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Interface
{
    interface ISubject
    {
        void registerObserver(IObserver observer);
        void unregisterObserver(IObserver observer);
        void notifyObservers();
    }
}
