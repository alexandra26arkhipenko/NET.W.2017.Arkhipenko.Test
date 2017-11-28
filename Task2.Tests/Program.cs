using System;
using Task2.Solution.Implementation;
using Task2.Solution.Interface;

namespace Task2.Tests
{
    public class Program
    {
        static void Main()
        {
            IRandomFileGenerator randomBytesFileGenerator = new RandomBytesFileGenerator();
            IRandomFileGenerator randomCharFileGenerator = new RandomCharsFileGenerator();

            Console.WriteLine(randomBytesFileGenerator.WorkingDirectory);
            Console.WriteLine(randomCharFileGenerator.WorkingDirectory);

            Console.ReadKey();
        }
    }
}