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

            StockGrabber stockGrabber = new StockGrabber();

            StockObserver observer = new StockObserver(stockGrabber);

            stockGrabber.PetrPrice = 18.20;
            stockGrabber.ValePrice = 19.17;
            stockGrabber.AbevPrice = 19.70;

            StockObserver observer2 = new StockObserver(stockGrabber);

            stockGrabber.PetrPrice = 10;
            stockGrabber.ValePrice = 11;
            stockGrabber.AbevPrice = 12;

            stockGrabber.Unregister(observer);

            stockGrabber.PetrPrice = 18.20;
            stockGrabber.ValePrice = 19.17;
            stockGrabber.AbevPrice = 19.70;

            Console.ReadKey();
        }
    }
}
