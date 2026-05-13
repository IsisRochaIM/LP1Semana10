using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Queue<string> files = new Queue<string>();
            string fileName = args[0];
            File.Create(fileName);
            
            while(true)
            {
                string inp = Console.ReadLine();
                if(inp == "")
                {
                    break;
                }
                files.Enqueue(inp);
            }
            string path;
            path = $"C:\\LPSemana10\\{fileName}";
            Console.WriteLine($"Path: {path}");
            File.WriteAllLines(path, files);

        }
    }
}
