using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TurnUpPortalCode.Pages
{
    public class Login
    {
        public void loginActions(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserName")));
            try
            {
                IWebElement userName = driver.FindElement(By.Id("UserName"));
                userName.SendKeys("hari");
            }catch(Exception ex)
            {
                Assert.Fail("user name text box is not  located" );
            }
            
            IWebElement passWord = driver.FindElement(By.Id("Password"));
            passWord.SendKeys("123123");
            IWebElement logIn = driver.FindElement(By.XPath("//input[@value ='Log in']"));
            logIn.Click();
        }
    }
}
