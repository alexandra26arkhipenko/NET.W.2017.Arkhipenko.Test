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
            randomBytesFileGenerator.GenerateFiles(1, 10);

            Console.WriteLine(randomCharFileGenerator.WorkingDirectory);
            randomCharFileGenerator.GenerateFiles(1, 10);


            Console.ReadKey();
        }
    }
}