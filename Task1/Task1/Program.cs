using System.Collections.Specialized;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "set your path to directory";
            Cleaner clean = new Cleaner(path);
            clean.CleanFolder(path);
            Console.ReadLine();
        }





    }




}