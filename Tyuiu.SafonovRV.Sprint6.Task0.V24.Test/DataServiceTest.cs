using Tyuiu.SafonovRV.Sprint6.Task0.V24.Lib;

namespace Tyuiu.SafonovRV.Sprint6.Task0.V24.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
            public void ValidCalc()
            {
                DataService ds = new DataService();
                double res = ds.Calculate(2);
                double wait = 25;
                Assert.AreEqual(wait, res);
            }
        }
    }


