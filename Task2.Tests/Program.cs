using System;
using Task2.Solution.AbstractClass;
using Task2.Solution.Implementation;

namespace Task2.Tests
{
    public class Program
    {
        static void Main()
        {
            RandomFileGenerator randomBytesFileGenerator = new RandomBytesFileGenerator();
            RandomFileGenerator randomCharFileGenerator = new RandomCharsFileGenerator();

            Console.WriteLine(randomBytesFileGenerator.WorkingDirectory);
            Console.WriteLine(randomCharFileGenerator.WorkingDirectory);

            Console.ReadKey();
        }
    }
}