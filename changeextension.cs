using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changeextension
{
    class Program
    {
        static void Main(string[] args)
        {
            string orginalfile = "simple.txt";
            string filename= Path.GetFileNameWithoutExtension(orginalfile);
            string convertedfile = filename + ".newname";
            try
            {
                File.Move(orginalfile, convertedfile); // Try to move
                Console.WriteLine("Extension name changed"); 
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex); // Write error
            }
            Console.ReadLine();
        }
    }
}
