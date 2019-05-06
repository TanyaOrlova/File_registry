﻿using System;
using System.IO;

namespace File_registry_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
//            var wd = Directory.GetCurrentDirectory();
            var wd = "E:\\";
            var metaFetcher = new File_manager.HeaderFetcher();
            var fileManager = new File_manager.Manager<File_manager.TextFileHeader>(wd, metaFetcher);
            Console.WriteLine("Enter file name:");
            var fileId = Console.ReadLine().Trim();
            var fileInfo = fileManager.GetFile(fileId);
            Console.WriteLine(fileInfo.Item1.ToString());
        }
    }
}
