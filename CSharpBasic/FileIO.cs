using System;
using System.IO;

namespace FileDirectoryHandling
{
    public class FileIO
    {
        public void LearnFileReading()
        {
            string fileContent = File.ReadAllText(@"C:\xampp\htdocs\samip.shrestha");//verveting character
            Console.WriteLine(fileContent);
        }
        public void LearnFileWriting()
        {
            File.WriteAllText("A.cs", "iAM NEW FILEJUST CREATED.");

        }
        public void LearnFileInfo()
        {
            FileInfo fileInfo = new FileInfo("A.html");
            var x = fileInfo.Length;
            var y = fileInfo.CreationTime;
            var z = fileInfo.DirectoryName;

            Console.WriteLine($"FileSize: {x} bytes");
            Console.WriteLine($"Created: {y}");
            Console.WriteLine($"Directory: {z}");
        }

        internal void LearnDirectory()
        {
            Directory.CreateDirectory("ABC");
            File.WriteAllText(@"ABC\A.samip","My name is Samip");
        }
        internal void LearnDirectoryInfo()
        {
            string folderPath = @"C:\xampp\htdocs\samip.shrestha";
            DirectoryInfo directory =  new DirectoryInfo(folderPath);
            var files = directory.GetFiles();
            Console.WriteLine("FileContent:" + files.Length);
        }


    }
}