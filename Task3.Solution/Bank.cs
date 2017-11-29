using System;

namespace Task3.Solution
{
    public class Bank 
    {
        public string Name { get; set; }

        public Bank(string name, Stock stock)
        {
            Name = name;
            stock.StockInfoEventHandler += Update;
        }

        public void Update(object sender, StockInfoEventHandlerEventArg e)
        {
            StockInfoEventHandlerEventArg sInfoEventHandlerEventArg = e;

            Console.WriteLine(
                sInfoEventHandlerEventArg.Euro > 40
                    ? "Банк {0} продает евро;  Курс евро: {1}"
                    : "Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfoEventHandlerEventArg.Euro);
        }
    }
}
