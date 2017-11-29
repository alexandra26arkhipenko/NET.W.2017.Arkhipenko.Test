using System;

namespace Task3.Solution
{
    public class Stock
    {

        private readonly StockInfoEventHandlerEventArg _stocksInfoEventHandlerEventArg;
        
        public EventHandler<StockInfoEventHandlerEventArg> StockInfoEventHandler = delegate { };

        public Stock()
        {
            _stocksInfoEventHandlerEventArg = new StockInfoEventHandlerEventArg();
        }

        public void Market()
        {
            var rnd = new Random();
            _stocksInfoEventHandlerEventArg.USD = rnd.Next(20, 40);
            _stocksInfoEventHandlerEventArg.Euro = rnd.Next(30, 50);
            Notify();
        }

        private void Notify()
        {
            StockInfoEventHandler.Invoke(this, _stocksInfoEventHandlerEventArg);
        }

        
    }
}
