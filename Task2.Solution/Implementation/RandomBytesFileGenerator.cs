using System;
using System.IO;
using Task2.Solution.AbstractClass;

namespace Task2.Solution.Implementation
{
    public class RandomBytesFileGenerator : RandomFileGenerator
    {
        public override string WorkingDirectory => "Files with random bytes";

        public override string FileExtension => ".bytes";

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }

    }
}