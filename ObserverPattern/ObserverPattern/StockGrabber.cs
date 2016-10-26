using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class StockGrabber : Subject
    {
        private List<Observer> _observerList;
        private double _petrPrice;
        private double _valePrice;
        private double _abevPrice;

        public double PetrPrice {
            get { return _petrPrice; }
            set 
            { 
                _petrPrice = value;
                notifyObserver();
            } 
        }

        public double ValePrice
        {
            get { return _valePrice; }
            set
            {
                _valePrice = value;
                notifyObserver();
            }
        }

        public double AbevPrice
        {
            get { return _abevPrice; }
            set
            {
                _abevPrice = value;
                notifyObserver();
            }
        }

        public StockGrabber()
        {
            _observerList = new List<Observer>();
        }

        public void Register(Observer newObserver)
        {
            _observerList.Add(newObserver);
        }

        public void Unregister(Observer deleteObserver)
        {
            _observerList.Remove(deleteObserver);
        }

        public void notifyObserver()
        {
            foreach (Observer observer in _observerList)
            {
                observer.Update(PetrPrice, ValePrice, AbevPrice);
            }
        }
    }
}
