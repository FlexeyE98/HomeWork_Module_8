using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Cleaner
    {
        public DateTime LastAccessTimeUtc { get; set; }
        public long Size { get; private set; }

        public Cleaner(string path)
        {
            LastAccessTimeUtc = Directory.GetLastAccessTimeUtc(path);
        }


        public long CleanFolder(string path)
        {
            long size = 0;

            if (Directory.Exists(path)) //&& Directory.GetLastAccessTime(path).Minute > TimeSpan.FromMinutes(30).Minutes)
            {
                try
                {
                    DirectoryInfo directories = new DirectoryInfo(path);
                    DirectoryInfo[] dirs = directories.GetDirectories();
                    FileInfo[] files = directories.GetFiles();

                    foreach (var f in files)
                    {
                        size += f.Length;
                        f.Delete();

                    }

                    foreach (var dir in dirs)
                    {
                        size += CleanFolder(dir.FullName);
                        dir.Delete(true);

                    }

                }
                catch (Exception error)
                {
                    Console.WriteLine($"Произошла ошибка: {error.Message}");

                }

                Size = size;
               
            }
            return size;

        }



    }
}
