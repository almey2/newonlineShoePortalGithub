using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace onlineshoeportal.pageObjects
{
    class SignInPage
    {
        public static int txtuserlenght = PropertiesCollection.driver.FindElements(By.Id("usr")).Count;

        public static int txtpwdlenght = PropertiesCollection.driver.FindElements(By.Id("pwd")).Count;

        public static int btnlogin = PropertiesCollection.driver.FindElements(By.XPath("//*[@id=\"second_form\"]/input")).Count;

        public static int btnRegistration = PropertiesCollection.driver.FindElements(By.Id("NewRegistration")).Count;
       
        public IWebElement btnNewRegistiration => PropertiesCollection.driver.FindElement(By.Id("NewRegistration"));

        public void clickNewRegistiration()
        {
            btnNewRegistiration.Click();
        }
    }
}
