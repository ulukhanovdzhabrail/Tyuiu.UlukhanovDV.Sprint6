using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.UlukhanovDV.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string path)
        {          
            string resStr = ("");
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                string[] words = text.Split(' ', '\n');
                foreach (string word in words)
                {
                    if (word.Contains("l"))
                    {
                        resStr += word + ' ';
                    }

                }
            }
            return resStr.TrimEnd();
        }
    }
}
