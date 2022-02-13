using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Provider
{
    public class Observer : IObserver
    {
        public string ObserverName;
        public Observer(string name)
        {
            ObserverName = name;
        }
        public void Update()
        {
            //Observer can update his system accordingly  
            Console.WriteLine("Hello " + ObserverName + ", a new article has been published by the author.");
        }
    }
}
