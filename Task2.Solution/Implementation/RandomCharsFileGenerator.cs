using System;
using System.IO;
using System.Linq;
using System.Text;
using Task2.Solution.AbstractClass;

namespace Task2.Solution.Implementation
{
    public class RandomCharsFileGenerator : RandomFileGenerator
    {
        public override string WorkingDirectory => "FilesWithRandomChars";
        public override string FileExtension => ".txt";

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var generatedString = this.RandomString(contentLength);

            var bytes = Encoding.Unicode.GetBytes(generatedString);

            return bytes;
        }
        private string RandomString(int Size)
        {
            var random = new Random();

            const string input = "abcdefghijklmnopqrstuvwxyz0123456789";

            var chars = Enumerable.Range(0, Size).Select(x => input[random.Next(0, input.Length)]);

            return new string(chars.ToArray());
        }




    }
}