using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TurnUpPortalCode.Utilities;

namespace TurnUpPortalCode.Pages
{
    public class HomePage
    {
        public void verifyuserLogin(IWebDriver driver)
        {
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("user successfully loggedin");
            }
            else
            {
                Console.WriteLine("User did not log in successufully");
            }
        }
        public void navigateToTmPage(IWebDriver driver)
        {
            IWebElement adminTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminTab.Click();
            wait.waitToBeClickable(driver,"xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 10);
            IWebElement timeMaterialTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterialTab.Click();
        }
    }
}
