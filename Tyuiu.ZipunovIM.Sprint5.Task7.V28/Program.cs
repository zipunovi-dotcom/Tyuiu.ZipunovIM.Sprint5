using Tyuiu.ZipunovIM.Sprint5.Task7.V28.Lib;

namespace Tyuiu.ZipunovIM.Sprint5.Task7.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Зипунов И. М. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к существующим данным в файле                          *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Зипунов Игорь Максимович | ИИПб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V28.txt (файл взять из архива*");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную C:\\DataSprint5\\ и      *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных. Заменить*");
            Console.WriteLine("* все пробелы, идущие подряд более одного, на один пробел. Полученный     *");
            Console.WriteLine("* результат сохранить в файл OutPutDataFileTask7V28.txt.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V28.txt");
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Результат сохранён в файл: " + pathSaveFile);
            Console.ReadKey();
        }
    }
}