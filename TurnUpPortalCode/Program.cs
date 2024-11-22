using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
        //open chrome browser

        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        //launch turnup portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
        IWebElement userName = driver.FindElement(By.Id("UserName"));
        userName.SendKeys("hari");
        IWebElement passWord = driver.FindElement(By.Id("Password"));
        passWord.SendKeys("123123");
        IWebElement logIn = driver.FindElement(By.XPath("//input[@value ='Log in']"));
        logIn.Click();
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (helloHari.Text == "Hello hari!")
        {
            Console.WriteLine("user successfully loggedin");
        }
        else
        {
            Console.WriteLine("User did not log in successufully");
        }
        IWebElement adminTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        adminTab.Click();
        IWebElement timeMaterialTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeMaterialTab.Click();
        IWebElement newButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        newButton.Click();
        IWebElement typeCodeButton = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
        typeCodeButton.Click();
        Thread.Sleep(2000);
        IWebElement timeTab = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        timeTab.Click();
        IWebElement codeTab = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
        codeTab.SendKeys("TyepeText");
        IWebElement descriptTab = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
        descriptTab.SendKeys("Description Given");
        IWebElement pricePerUnitTab = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        pricePerUnitTab.SendKeys("12");
        IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
        saveButton.Click();
        Thread.Sleep(2000);
        IWebElement lastButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
        lastButton.Click();
        IWebElement lastCodeElement = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        if (lastCodeElement.Text == "TyepeText")
        {
            Console.WriteLine("Test passed");
        }
        else
        {
            Console.WriteLine("Test failed");
        }

    }
}