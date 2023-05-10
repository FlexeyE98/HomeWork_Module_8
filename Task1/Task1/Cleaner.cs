using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cleaner
    {
        public DateTime LastAccessTimeUtc { get; set; }

        public Cleaner(string path)
        {
            LastAccessTimeUtc = Directory.GetLastAccessTimeUtc(path);
        }

        public void CleanFolder(string path)
        {

            if (Directory.Exists(path) && Directory.GetLastAccessTime(path).Minute > TimeSpan.FromMinutes(30).Minutes)
            {
                try
                {
                    DirectoryInfo directories = new DirectoryInfo(path);
                    DirectoryInfo[] dirs = directories.GetDirectories();
                    FileInfo[] files = directories.GetFiles();

                    foreach (var f in files)
                    { 
                        f.Delete();
                        Console.WriteLine($"Файл {f.FullName} был удален");

                    }

                    foreach (var dir in dirs)
                    {
                        CleanFolder(dir.FullName);
                        dir.Delete(true);
                        Console.WriteLine($"Папка: {dir.FullName} была удалена");
                    }
                     

                }
                catch (Exception error)
                {
                    Console.WriteLine($"Произошла ошибка: {error.Message}");

                }
            
            
            }

        }



    }
}
