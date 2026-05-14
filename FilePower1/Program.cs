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
            Queue<string> files = new();
            string fileName = args[0];
            
            while(true)
            {
                string inp = Console.ReadLine();
                if(inp == "")
                {
                    break;
                }
                files.Enqueue(inp);
            }

            File.WriteAllLines(fileName, files);

        }
    }
}
