using Tyuiu.ZipunovIM.Sprint5.Task5.V15.Lib;

namespace Tyuiu.ZipunovIM.Sprint5.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Зипунов И. М. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Зипунов Игорь Максимович | ИИПб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask5V15.txt (файл взять из архива*");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную C:\\DataSprint5\\ и      *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор значений. Найти минимальное*");
            Console.WriteLine("* вещественное число в файле, которое делится на 5. Полученный результат  *");
            Console.WriteLine("* вывести на консоль. У вещественных значений округлить до трёх знаков    *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask5V15.txt");
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Минимальное число, делящееся на 5 = " + res);
            Console.ReadKey();
        }
    }
}