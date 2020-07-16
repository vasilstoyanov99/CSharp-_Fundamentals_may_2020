using System;

namespace _03.Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int startIndexOfFileName = input.LastIndexOf('\\');
            int fileExtensionStartIndex = input.LastIndexOf('.');
            int start = startIndexOfFileName + 1;
            int count = fileExtensionStartIndex - start;
            string fileName = input.Substring(start, count);
            start = fileExtensionStartIndex + 1;
            count = input.Length - start;
            string fileExtension = input.Substring(start, count);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
