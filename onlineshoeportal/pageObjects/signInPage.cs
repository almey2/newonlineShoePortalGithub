using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace onlineshoeportal.pageObjects
{
    class signInPage
    {
        public static int txtuserlenght = propertiesCollection.driver.FindElements(By.Id("usr")).Count;

        public static int txtpwdlenght = propertiesCollection.driver.FindElements(By.Id("pwd")).Count;

        public static int btnlogin = propertiesCollection.driver.FindElements(By.XPath("//*[@id=\"second_form\"]/input")).Count;

        public static int btnRegistration = propertiesCollection.driver.FindElements(By.Id("NewRegistration")).Count;
       
        public IWebElement btnNewRegistiration => propertiesCollection.driver.FindElement(By.Id("NewRegistration"));

        public void clickNewRegistiration()
        {
            btnNewRegistiration.Click();
        }
    }
}
