using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace onlineshoeportal.pageObjects
{
    class registration
    {
        public static IWebElement btnSubmit => propertiesCollection.driver.FindElement(By.XPath("//input[@value='Submit']"));
        public static IWebElement txtFirstName => propertiesCollection.driver.FindElement(By.Id("firstName"));
        public static IWebElement txtLastName => propertiesCollection.driver.FindElement(By.Id("lastName"));
        public static IWebElement txtEmailid => propertiesCollection.driver.FindElement(By.Id("emailId"));

        public static IWebElement txtUsername => propertiesCollection.driver.FindElement(By.Id("usr"));
        public static IWebElement txtPassword => propertiesCollection.driver.FindElement(By.Id("pwd"));
        public static IWebElement txtErrorMsg => propertiesCollection.driver.FindElement(By.XPath("//*[@id=\"first_form\"]/div/span"));

        public static IWebElement txtErrorMsg2 => propertiesCollection.driver.FindElement(By.XPath("//*[@id=\"first_form\"]/div/span"));
    
        public static void select_salutation()
        {
            SelectElement drpSalutation = new SelectElement(propertiesCollection.driver.FindElement(By.Id("Salutation")));
            drpSalutation.SelectByText(ConfigurationManager.AppSettings["Salutation"]);
        }
    
        public static void click_Submit()
        {
            btnSubmit.Click();   
        }

        public static void enter_Firstname()

        {
            txtFirstName.SendKeys(ConfigurationManager.AppSettings["firstName"]);
        }
        public static void enter_Lastname()

        {
            txtLastName.SendKeys(ConfigurationManager.AppSettings["lastName"]);
        }
        public static void enter_InvalidEmail()
        {
            txtEmailid.SendKeys(ConfigurationManager.AppSettings["invalidEmailAddress"]);
        }
        public static void enter_validEmail()
        {
            txtEmailid.SendKeys(ConfigurationManager.AppSettings["ValidEmailAddress"]);
        }
        public static void enter_UsrName()
        {
            txtUsername.SendKeys(ConfigurationManager.AppSettings["Username"]);
        }
        public static void enter_Password()
        {
            txtPassword.SendKeys(ConfigurationManager.AppSettings["Password"]);
        }

    }

}
