using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Stock
    {

        private readonly StockInfoEventHandlerEventArg _stocksInfoEventHandlerEventArg;

        //private readonly List<IObserver> observers;
        public EventHandler<StockInfoEventHandlerEventArg> StockInfoEventHandler = delegate { };

        public Stock()
        {
            _stocksInfoEventHandlerEventArg = new StockInfoEventHandlerEventArg();
        }

        private void Notify()
        {
            StockInfoEventHandler.Invoke(this, _stocksInfoEventHandlerEventArg);
        }

        public void Market()
        {
            var rnd = new Random();
            _stocksInfoEventHandlerEventArg.USD = rnd.Next(20, 40);
            _stocksInfoEventHandlerEventArg.Euro = rnd.Next(30, 50);
            Notify();
        }
    }
}
