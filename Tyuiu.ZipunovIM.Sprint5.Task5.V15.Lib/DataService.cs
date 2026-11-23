using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZipunovIM.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            double res = double.MaxValue;

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string val in values)
                    {
                        double num = double.Parse(val.Replace(',', '.'), CultureInfo.InvariantCulture);
                        if (num % 5 == 0 && num < res)
                        {
                            res = num;
                        }
                    }
                }
            }

            return Math.Round(res, 3);
        }
    }
}