using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "test";
            File.WriteAllText(@"C\:users\steph\OneDrive\Documents\Text.txt", text);
            
            Console.WriteLine("Please enter a number: ");
        }
    }
}
