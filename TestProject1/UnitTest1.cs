using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Xml.XPath;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver driver;
        string path = "T:\\הנדסת תוכנה\\שנה ב\\קבוצה ב\\קורס אוטומציה\\Sari\\drivers";
        private IAlert alert;
        // private WebDriverWait wait;
        public Tests()
        {
        }
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(path  );
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));  
        }

        [Test]
        public void Test1()
        {
            //1
            driver.Navigate().GoToUrl("https://demoqa.com/");

            //2-4
            IReadOnlyList<IWebElement> cards = driver.FindElements(By.ClassName("category-cards"));
            cards[0].Click();
            string idButton = "item-1";
            ClickElementById(idButton);

            string idTimerButton = "timerAlertButton";
            ClickElementById(idTimerButton);

            //5
            System.Threading.Thread.Sleep(10000);
            alert=driver.SwitchTo().Alert();
            alert.Accept();

            //6
          
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
        public void ClickElementByXPath(string pathElement)
        {
            IWebElement element = driver.FindElement(By.XPath(pathElement));
            element.Click();
        }
        public void ClickElementById(string idElement)
        {
            IWebElement element = driver.FindElement(By.Id(idElement));
            element.Click();
        }
    }
    
}