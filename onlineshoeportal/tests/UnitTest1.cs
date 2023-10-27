
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.Configuration;
using OpenQA.Selenium.Support.UI;
using onlineshoeportal.pageObjects;

namespace onlineshoeportal.tests
{
    [TestClass]
    public class TS01_User_Registration
    {
        
        [TestMethod]
        public void TC01_UserReg_ErrValidation()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("-no-sandbox");
            propertiesCollection.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);
            propertiesCollection.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);


            homePages.click_SignInPortal();

            Assert.AreEqual(1, signInPage.txtuserlenght);
            Assert.AreEqual(1, signInPage.txtpwdlenght);         
            Assert.AreEqual(1, signInPage.btnlogin);           
            Assert.AreEqual(1, signInPage.btnRegistration);


            registration.select_salutation();
            registration.click_Submit();

            Assert.AreEqual("This field is required", registration.txtErrorMsg);

            registration.enter_Firstname();
            registration.click_Submit();

            Assert.AreEqual("This field is required", registration.txtErrorMsg);

            registration.enter_Lastname();
            registration.click_Submit();

            Assert.AreEqual("Enter a valid email", registration.txtErrorMsg);

            registration.enter_InvalidEmail();
            registration.click_Submit();
            Assert.AreEqual("Enter a valid email", registration.txtErrorMsg2);

            registration.enter_validEmail();
            registration.click_Submit();
            Assert.AreEqual("This field is required", registration.txtErrorMsg);

            registration.enter_UsrName();
            registration.click_Submit();
            Assert.AreEqual("This field is required", registration.txtErrorMsg);

            registration.enter_Password();
            registration.click_Submit();

        }
    }
}
