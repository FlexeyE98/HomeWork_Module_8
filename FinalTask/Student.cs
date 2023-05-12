using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Unicode;

namespace FinalTask
{
    [Serializable]
    public class Student
    {

        public string Name { get; private set; }
        public string Group { get; private set; }
        public DateTime Birthday { get; private set; }

        public void SortStudents(string path)
        {
            while (true)
            {
                if (File.Exists(path))
                {
                    Directory.CreateDirectory(@"C:\Users\Привет\Desktop\Students");
                    BinaryFormatter bf = new BinaryFormatter();
                    using (FileStream fs = new FileStream(path, FileMode.Open))
                    {
                        var newStudent = (Student[])bf.Deserialize(fs);
                        foreach (var student in newStudent)
                        {
                            if (student.Group == student.Group)
                            {
                                using (StreamWriter sw = File.AppendText(@$"C:\Users\Привет\Desktop\Students\{student.Group}.txt"))
                                {
                                    sw.WriteLine($"Студент: {student.Name}, Дата рождения: {student.Birthday}");


                                }
                                
                            }

                        }

                        break;
                    }

                }
                else
                {
                    Console.Write("Такого файла не существует. Повторите попытку: ");
                    string correctPath = Console.ReadLine();
                    if (File.Exists(correctPath))
                    {
                        path = correctPath;

                    }

                }


            }

        }
    }
}
