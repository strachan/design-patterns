using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class ChocolateBoiler
    {
        private bool _isEmpty;
        private bool _isBoiled;
        private static ChocolateBoiler _chocolateBoiler;
        private static object _thisLock = new object();


        private ChocolateBoiler()
        {
            _isEmpty = true;
            _isBoiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (_chocolateBoiler == null)
            {
                // thread safe
                lock (_thisLock)
                {
                    if (_chocolateBoiler == null)
                    {
                        _chocolateBoiler = new ChocolateBoiler();
                    }
                        
                }
            }
            return _chocolateBoiler;
        }

        public void Fill()
        {
            if (_isEmpty)
            {
                _isEmpty = false;
                _isBoiled = false;
            }
        }

        public void Drain()
        {
            if (!_isEmpty && _isBoiled)
            {
                _isEmpty = true;
            }
        }

        public void Boil()
        {
            if (!_isEmpty && !_isBoiled)
            {
                _isBoiled = true;
            }
        }
    }
}
