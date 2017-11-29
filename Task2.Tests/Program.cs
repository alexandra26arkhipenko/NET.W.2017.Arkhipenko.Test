using System;
using System.IO;
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
            
            Console.WriteLine();
            if(randomBytesFileGenerator.GenerateFiles(1, 10))
                Console.WriteLine(randomBytesFileGenerator.WorkingDirectory + " was created");
            
            Console.WriteLine();
            if(randomCharFileGenerator.GenerateFiles(1, 10))
                Console.WriteLine(randomCharFileGenerator.WorkingDirectory + " was created was created");
           
            Console.ReadKey();
        }
    }
}