using System;
using System.IO;
using System.Linq;
using System.Text;
using Task2.Solution.AbstractClass;

namespace Task2.Solution.Implementation
{
    public class RandomCharsFileGenerator : RandomFileGenerator
    {
        public override string WorkingDirectory => "Files With Random Chars";
        public override string FileExtension => ".txt";

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var generatedString = this.RandomString(contentLength);

            var bytes = Encoding.Unicode.GetBytes(generatedString);

            return bytes;
        }
        private string RandomString(int size)
        {
            var random = new Random();

            const string input = "abcdefghijklmnopqrstuvwxyz0123456789";

            var chars = Enumerable.Range(0, size).Select(x => input[random.Next(0, input.Length)]);

            return new string(chars.ToArray());
        }




    }
}