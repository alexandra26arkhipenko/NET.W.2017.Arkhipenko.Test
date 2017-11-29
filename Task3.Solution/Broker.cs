using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Broker
    {

        public string Name { get; set; }
        private readonly Stock _stock;

        public Broker(string name, Stock stock)
        {
            this.Name = name;
            _stock = stock;
            _stock.StockInfoEventHandler += Update;
        }

        public void StopTrade()
        {
            if (_stock.StockInfoEventHandler != null)
            {

                _stock.StockInfoEventHandler -= Update;
            }
        }

        public void Update(object sender, StockInfoEventHandlerEventArg e)
        {
            StockInfoEventHandlerEventArg sInfoEventHandlerEventArg = e;

            if (sInfoEventHandlerEventArg.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, sInfoEventHandlerEventArg.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfoEventHandlerEventArg.Euro);
        }
    }
}

