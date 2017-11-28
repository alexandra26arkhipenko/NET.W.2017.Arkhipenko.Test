using System;
using System.IO;

namespace Task2.Solution.Interface
{
    public interface IRandomFileGenerator
    {
       string WorkingDirectory { get; }
       string FileExtension { get; }
       void GenerateFiles(int filesCount, int contentLength);
       byte[] GenerateFileContent(int contentLength);
       void WriteBytesToFile(string fileName, byte[] content);
    }
}