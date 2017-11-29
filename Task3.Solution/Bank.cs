using System;

namespace Task3.Solution
{
    public class Bank 
    {
        public string Name { get; set; }
        private readonly Stock _stock;

        public Bank(string name, Stock stock)
        {
            Name = name;
            _stock = stock;
            _stock.StockInfoEventHandler += Update;
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
