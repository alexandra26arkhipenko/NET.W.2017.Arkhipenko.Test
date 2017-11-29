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

            //string path = @"E:\Учеба\EPAM\NET.W.2017.LastName.Test\Task2.Tests\bin\Debug\FilesWithRandomBytes\23640f5e-0cea-4800-b3fc-476629d13c89.bytes";
            Console.WriteLine(randomBytesFileGenerator.WorkingDirectory);
            randomBytesFileGenerator.GenerateFiles(1, 10);

            //var file = new StreamReader(path);
            //Console.WriteLine(file.ReadLine());

            Console.WriteLine(randomCharFileGenerator.WorkingDirectory);
            randomCharFileGenerator.GenerateFiles(1, 10);


            Console.ReadKey();
        }
    }
}