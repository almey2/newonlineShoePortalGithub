using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineshoeportal.pageObjects
{
    class HomePages

    {
        private IWebElement menu_input =>     internal class PropertiesCollection.driver.FindElement(By.CssSelector("#menuToggle > input[type=checkbox]"));
        private IWebElement lnksignInPortal =>     internal class PropertiesCollection.driver.FindElement(By.CssSelector("#menu > a:nth-child(2) > li"));

        public void click_SignInPortal()
        { 
        menu_input.Click();

        PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        lnksignInPortal.Click();
        }
    }
}
