using System;
using System.Collections.Generic;
using System.IO;

namespace FileProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\martv\Desktop\New folder";
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            List<string> lines = new List<string>();


            foreach(string file in files)
            {
                Console.WriteLine(file);
                var fileData = new FileInfo(file);
                Console.WriteLine(fileData);

                string fileName = fileData.Name;
                string FileDirectory = fileData.DirectoryName;
                long fileSize = fileData.Length;

                Console.WriteLine($"File name: {fileName}; location: {FileDirectory}; size: {fileSize}");
                string line = $"File name: {fileName}; location: {FileDirectory}; size: {fileSize} bytes";

                lines.Add(line);

            }

            string fileDataPath = @"C:\Users\martv\Desktop\New folder\FileData.txt";
            File.WriteAllLines(fileDataPath, lines);
        }
    }
}
