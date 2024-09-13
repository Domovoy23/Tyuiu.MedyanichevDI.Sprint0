using Tyuiu.MedyanichevDI.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MedyanichevDI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChackGetMessageValid()
        {
            var name = "Денис";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Денис", res);    
        }
    }
}