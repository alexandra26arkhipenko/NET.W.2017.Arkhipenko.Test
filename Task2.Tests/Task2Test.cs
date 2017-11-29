using NUnit.Framework;
using Task2.Solution.AbstractClass;
using Task2.Solution.Implementation;

namespace Task2.Tests
{
    [TestFixture]
    class Task2Test
    {
        [TestCase(ExpectedResult = true)]
        public bool GenerateFileWithBytes()
        {
            RandomFileGenerator randomBytesFileGenerator = new RandomBytesFileGenerator();
            return randomBytesFileGenerator.GenerateFiles(1, 10);
        }

        [TestCase(ExpectedResult = true)]
        public bool GenerateFileWithChars()
        {
            RandomFileGenerator randomCharsFileGenerator = new RandomCharsFileGenerator();
            return randomCharsFileGenerator.GenerateFiles(1, 10);
        }
    }
}
