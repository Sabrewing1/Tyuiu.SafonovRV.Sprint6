using Tyuiu.SafonovRV.Sprint6.Task6.V24.Lib;

namespace Tyuiu.SafonovRV.Sprint6.Task6.V24.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
            public void CheckFileExist()
            {
                string path = @"C:\Users\rusla\source\repos\Tyuiu.SafonovRV.Sprint6\Tyuiu.SafonovRV.Sprint6.Task6.V24.Lib\bin\Debug\net8.0\InPutFileTask6V24.txt";

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            }
        }
    }

    
