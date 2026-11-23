using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZipunovIM.Sprint5.Task7.V28.Lib
{
    public class DataService : ISprint5Task7V28
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V28.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            if (fileInfo.Exists)
            {
                File.Delete(pathSaveFile);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string resLine = Regex.Replace(line, @" {2,}", " ");
                    File.AppendAllText(pathSaveFile, resLine + Environment.NewLine);
                }
            }

            return pathSaveFile;
        }
    }
}