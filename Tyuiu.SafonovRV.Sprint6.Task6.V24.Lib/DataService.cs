using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SafonovRV.Sprint6.Task6.V24.Lib
{
    public class DataService : ISprint6Task6V24
    {
        public string CollectTextFromFile(string path)
        {
            string reStr = " ";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    reStr = reStr + " " + line.Split(' ')[0];

                }
            }
            return reStr;
        }
    }
}
        
    

