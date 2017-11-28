using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Stock : IObservable
    {

        private readonly StockInfo _stocksInfo;

        //private readonly List<IObserver> observers;
        private EventHandler<StockInfo> _stockInfoEventHandler;

        public Stock()
        {
            _stocksInfo = new StockInfo();
        }

        public void Register(IObserver observer)
        {
            _stockInfoEventHandler += observer.Update;
        }

        public void Unregister(IObserver observer)
        {
            if (_stockInfoEventHandler != null)
                _stockInfoEventHandler -= observer.Update;
        }


        public void Notify()
        {
            _stockInfoEventHandler.Invoke(this, _stocksInfo);
        }

        public void Market()
        {
            var rnd = new Random();
            _stocksInfo.USD = rnd.Next(20, 40);
            _stocksInfo.Euro = rnd.Next(30, 50);
            Notify();
        }
    }
}
