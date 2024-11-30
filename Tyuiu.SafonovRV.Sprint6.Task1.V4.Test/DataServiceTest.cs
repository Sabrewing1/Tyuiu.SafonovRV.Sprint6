using Tyuiu.SafonovRV.Sprint6.Task1.V4.Lib;

namespace Tyuiu.SafonovRV.Sprint6.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        
            public void GetMassFunction()
            {
                DataService ds = new DataService();
                int res = GetMassFunction(2);
                int wait = 1;
                Assert.AreEqual(wait, res);
            }
        }
    }

    
