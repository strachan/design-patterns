using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class StockObserver : Observer
    {
        private double _petrPrice;
        private double _valePrice;
        private double _abevPrice;

        private static int _observerIDTracker = 0;
        private int _observerID;
        private Subject _stockGrabber;

        public StockObserver(Subject stockGrabber)
        {
            _observerID = ++_observerIDTracker;
            _stockGrabber = stockGrabber;

            _stockGrabber.Register(this);
        }

        public void Update(double petrPrice, double valePrice, double abevPrice)
        {
            _petrPrice = petrPrice;
            _valePrice = valePrice;
            _abevPrice = abevPrice;

            PrintPrices();
        }

        private void PrintPrices()
        {
            Console.WriteLine(_observerID);
            Console.WriteLine("Petrobras: " + _petrPrice);
            Console.WriteLine("Vale: " + _valePrice);
            Console.WriteLine("Ambev: " + _abevPrice);
        }
    }
}
