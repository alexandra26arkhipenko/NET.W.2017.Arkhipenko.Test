using System;
using System.IO;
using Task2.Solution.Interface;

namespace Task2.Solution.Implementation
{
    public class RandomBytesFileGenerator : IRandomFileGenerator
    {
        public string WorkingDirectory => "Files with random bytes";

        public string FileExtension => ".bytes";

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        byte[] IRandomFileGenerator.GenerateFileContent(int contentLength)
        {
            return GenerateFileContent(contentLength);
        }
        
        void IRandomFileGenerator.WriteBytesToFile(string fileName, byte[] content)
        {
            WriteBytesToFile(fileName, content);
        }

        private void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }

        private byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }

    }
}