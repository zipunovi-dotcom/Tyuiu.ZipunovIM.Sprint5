using Tyuiu.ZipunovIM.Sprint5.Task6.V12.Lib;

namespace Tyuiu.ZipunovIM.Sprint5.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Зипунов И. М. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовой информации                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Зипунов Игорь Максимович | ИИПб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask6V12.txt (файл взять из архива*");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную C:\\DataSprint5\\ и      *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных. Найти  *");
            Console.WriteLine("* количество удвоенных букв \"нн\" в заданной строке.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask6V12.txt");
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество удвоенных букв \"нн\" = " + res);
            Console.ReadKey();
        }
    }
}