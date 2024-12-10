using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SafonovRV.Sprint6.Task6.V24.Lib
{
    public class DataService : ISprint6Task6V24
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder res = new StringBuilder();
            using (StreamReader sw = new StreamReader(path))
            {
                string line;
                while ((line = sw.ReadLine()) != null)
                {
                    string[] lines = line.Split(' ');
                    res.Append(lines[0]).Append(' ');
                }
            }
            return res.ToString().Trim();


        }
    }
}



