using Tyuiu.SafonovRV.Sprint6.Task7.V17.Lib;

namespace Tyuiu.SafonovRV.Sprint6.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\Users\rusla\source\repos\Tyuiu.SafonovRV.Sprint6\Tyuiu.SafonovRV.Sprint6.Task7.V17\bin\Debug\net8.0-windows\InPutFileTask7V17.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}