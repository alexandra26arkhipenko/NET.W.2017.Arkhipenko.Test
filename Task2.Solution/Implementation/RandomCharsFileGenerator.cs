﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using Task2.Solution.Interface;

namespace Task2.Solution.Implementation
{
    public class RandomCharsFileGenerator : IRandomFileGenerator
    {
        public string WorkingDirectory => "Files with random chars";

        public string FileExtension => ".txt";

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

        private byte[] GenerateFileContent(int contentLength)
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

        private void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }

    }
}