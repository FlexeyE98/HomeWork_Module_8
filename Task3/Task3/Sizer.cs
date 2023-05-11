using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
 
    public class Sizer
    {
        public long Size { get; private set; }


        public long SizerFolder(string path)
        {
            long size = 0;
            while (true)
            {

                if (Directory.Exists(path))
                {

                    DirectoryInfo directory = new DirectoryInfo(path);
                    DirectoryInfo[] dirs = directory.GetDirectories();
                    FileInfo[] files = directory.GetFiles();

                    try
                    {
                        foreach (var file in files)
                        {
                            size += file.Length;

                        }

                        foreach (var dir in dirs)
                        {
                            size += SizerFolder(dir.FullName);

                        }

                    }
                    catch (Exception error)
                    {

                        Console.WriteLine($"Произошла ошибка: {error.Message}");

                    }

                    break;

                }

                else
                {

                    Console.Write("Указан некорректный путь к папке либо же неверно указано название папки. Проверьте и повторите еще раз: ");
                    string correctPath = Console.ReadLine();
                    if (Directory.Exists(correctPath))
                    {
                        path = correctPath;

                    }


                }



            }
            Size = size;
            return size;
            

        }
    }
}

