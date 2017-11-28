namespace Test6.Solution
{
    public class Formula1 : ICalculate<int>
    {
        public int CalculateNumber(int number, int previousNumber)
        {
            return number + previousNumber;
        }
    }
}