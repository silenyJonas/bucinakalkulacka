using bucinakalkulacka.components;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Counter counterDesCisla = new Counter(false);
        Counter counterCeleCisla = new Counter(true);

        [TestMethod]
        public void ScitaniCeleCislo()
        {
            string result = counterCeleCisla.GetValue("5+3");
            Assert.AreEqual("8", result);            
           
        }
        [TestMethod]
        public void ScitaniDesCislo()
        {         
            string result = counterDesCisla.GetValue("5.4+1.3");
            Assert.AreEqual("6.7", result);
        }
        [TestMethod]
        public void Mocnina()
        {
            string result = counterCeleCisla.Mocnit("3");
            Assert.AreEqual("9",result);
        }
        [TestMethod]
        public void Odmocnina()
        {
            string result = counterCeleCisla.Odmocnit("64");
            Assert.AreEqual("8",result);
        }
        [TestMethod]
        public void UdelatCeleCisloNahoru()
        {            
            string result = counterCeleCisla.UdelatCeleCislo("6.7");
            Assert.AreEqual("7", result);
        }
        [TestMethod]
        public void UdelatCeleCisloDolu()
        {
            string result = counterCeleCisla.UdelatCeleCislo("6.4");
            Assert.AreEqual("6", result);            
        }
    }
}