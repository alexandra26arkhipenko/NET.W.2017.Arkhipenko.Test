using Task3.Solution;

namespace Task3.Console
{
    class Program
    {
        static void Main()
        {
            var stock = new Stock();
            var bank = new Bank("UnitBank", stock);
            var broker = new Broker("Ivan Ivanov", stock);
            // имитация торгов
            stock.Market();
            // брокер прекращает наблюдать за торгами
            broker.StopTrade();
            // имитация торгов
            stock.Market();

            

            System.Console.ReadKey();
        }

    }
}
