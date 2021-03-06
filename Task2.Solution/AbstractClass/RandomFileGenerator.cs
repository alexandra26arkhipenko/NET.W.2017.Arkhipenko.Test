﻿using System;
using System.IO;

namespace Task2.Solution.AbstractClass
{
    public abstract class RandomFileGenerator
    {
        public bool GenerateFiles(int filesCount, int contentLength)
        {
            try
            {
                for (var i = 0; i < filesCount; ++i)
                {
                    var generatedFileContent = this.GenerateFileContent(contentLength);

                    var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                    this.WriteBytesToFile(generatedFileName, generatedFileContent);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        
        public abstract string WorkingDirectory { get; }
        public abstract string FileExtension { get; }

        protected abstract byte[] GenerateFileContent(int contentLength);

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