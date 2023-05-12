using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FinalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"C:\Users\Привет\Desktop\Students.dat"; //enter your path to bin.file
            Student student = new Student();
            student.SortStudents(path);
            


        }
    }



}