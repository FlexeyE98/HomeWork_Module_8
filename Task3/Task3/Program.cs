namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\\Users\Привет\Desktop\test";
            Sizer sizer = new Sizer();
            sizer.SizerFolder(path);
            Console.WriteLine($"Исходный размер папки: {sizer.Size}");
            Cleaner cleaner = new Cleaner(path);
            cleaner.CleanFolder(path);
            Console.WriteLine($"Было освобождено: {cleaner.Size}");
            long longSizer = sizer.SizerFolder(path);
            Console.WriteLine($"Текущий размер папки: {longSizer}");

            Console.ReadLine();

            /*
             
             Не очень понял как обойти в рекурсии метод Console.WriteLine для вывода информации.
             Метод при первой итерации выводит размер подпапки и далее с каждой итерацией захода рекурсии входит в следующую и выводит инфу на экран
             Такой подход немного отличается от того, что требуется в задаче. Поэтому пришлось кривокодить :)
             
             */

        }
    }
}