namespace Test6.Solution
{
    public interface ICalculate<T>
    {
        T CalculateNumber(T number, T previousNumber);
    }
}