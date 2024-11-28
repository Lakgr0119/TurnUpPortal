using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TurnUpPortalCode.Pages
{
    public  class TmPage
    {
        public void createTimeRecord(IWebDriver driver)
        {
            try
            {
                IWebElement newButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
                newButton.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("create new button hasn't been found");
            }
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

        }
        public void verifyTimeRecord(IWebDriver driver)
        {

            IWebElement lastButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            lastButton.Click();
            IWebElement lastCodeElement = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(lastCodeElement.Text == "TyepeText", "Test passed");
           // if (lastCodeElement.Text == "TyepeText")
           // {
               // Assert.Pass("Test passed");
           // }
           // else
           // {
               // Assert.Fail("Test failed");
           // }
            Thread.Sleep(2000);

        }
        public void editTimeRecord(IWebDriver driver)
        {
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[5]/a[1]"));
            editButton.Click();
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCode.Click();
            Thread.Sleep(2000);
            IWebElement timeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeDropdown.Click();
            IWebElement code = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            code.SendKeys("entry");
            IWebElement description = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            description.SendKeys("Details given");
            IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnit.SendKeys("2000");
            IWebElement save = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            save.Click();
            Thread.Sleep(3000);
        }
        public void verifyEditTimeRecord(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement lastEntry = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            lastEntry.Click();
            IWebElement lastEntryElement = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (lastEntryElement.Text == "entry" )
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
           

        }
        public void deletTimeRecord(IWebDriver driver)

        {
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[5]/a[2]"));
            Thread.Sleep(2000);
            deleteButton.Click();
            Thread.Sleep(1000);
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
