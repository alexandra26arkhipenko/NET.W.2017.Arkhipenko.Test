namespace Test6.Solution
{
    public class Formula2 : ICalculate<int>
    {
        public int CalculateNumber(int number, int previousNumber)
        {
            return 6*number - 8*previousNumber;
        }
    }
}