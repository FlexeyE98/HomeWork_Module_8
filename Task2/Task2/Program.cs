namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {

            string path = "your path to directory";
            Sizer sizer = new Sizer();
            long lengthFolder = sizer.SizerFolder(path);
            Console.WriteLine($"Итоговое количество элементов в папке {path}: {lengthFolder}");

            Console.ReadLine();

        }
    }
}