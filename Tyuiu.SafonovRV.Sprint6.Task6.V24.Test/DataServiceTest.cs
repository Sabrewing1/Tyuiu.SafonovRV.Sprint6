namespace Tyuiu.SafonovRV.Sprint6.Task6.V24.Test
{
    [TestClass]
    

        public class DataServiceTest
        {
            [TestMethod]
            public void CheckFileExist()
            {
                string path = @"C:\Users\rusla\source\repos\Tyuiu.SafonovRV.Sprint6\InPutFileTask6V24.txt";

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            }
        }
    }

    
