using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface Subject
    {
        void Register(Observer newObserver);
        void Unregister(Observer deleteObserver);
        void notifyObserver();
    }
}
