using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TurnUpPortalCode.Utilities;

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
            codeTab.SendKeys("TypeText");
            IWebElement descriptTab = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            descriptTab.SendKeys("Description Given");
            IWebElement pricePerUnitTab = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnitTab.SendKeys("12");
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveButton.Click();
            Thread.Sleep(2000);
            IWebElement lastButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            lastButton.Click();
                        
        }
        public string getCode(IWebDriver driver)
        {
            IWebElement lastCodeElement = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return lastCodeElement.Text;
        }
        public string getNewDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }
        public String getNewPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }

        public void editTimeRecord(IWebDriver driver, string code)
        {
            Thread.Sleep(4000);
            //Select a record and click edit button
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(2000);


            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(4000);
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            Thread.Sleep(2000);
            codeTextbox.SendKeys(code);
            Thread.Sleep(2000);

            //Click save
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(2000);
            IWebElement llastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            llastPageButton.Click();
           
                      
        }
       
        public string getEditedCode(IWebDriver driver)
        {        
                      
            IWebElement editedCodeEntry = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedCodeEntry.Text;
        }
        public void deletTimeRecord(IWebDriver driver)

        {
            wait.waitToBeClickable(driver, "xpath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[5]/a[2]", 10);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[5]/a[2]"));
            Thread.Sleep(2000);
            deleteButton.Click();
            Thread.Sleep(1000);
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
