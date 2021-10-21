using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {

        public IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:4200/RegistroMecanicos");
        }

        [Test]
        public void Test1()
        {
   
            IWebElement txtId = driver.FindElement(By.Id("txtid"));
            txtId.SendKeys("123");

            IWebElement txtname = driver.FindElement(By.Id("txtNombre"));
            txtname.SendKeys("ama");

            IWebElement txLasttname = driver.FindElement(By.Id("txtApellidos"));
            txLasttname.SendKeys("ama");

            IWebElement txtfecha = driver.FindElement(By.Id("txtFECHA"));
            txtfecha.SendKeys("ama");

            IWebElement txtDireccion = driver.FindElement(By.Id("txtDireccion"));
            txtDireccion.SendKeys("ama");

            IWebElement txtespecialidad = driver.FindElement(By.Id("txtEspecialidad"));
            txtespecialidad.SendKeys("ama");



        }
    }
}