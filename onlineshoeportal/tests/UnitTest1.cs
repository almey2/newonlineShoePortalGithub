
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


            HomePages.click_SignInPortal();

            Assert.AreEqual(1, SignInPage.txtuserlenght);
            Assert.AreEqual(1, SignInPage.txtpwdlenght);         
            Assert.AreEqual(1, SignInPage.btnlogin);           
            Assert.AreEqual(1, SignInPage.btnRegistration);


            Registration.select_salutation();
            Registration.click_Submit();

            Assert.AreEqual("This field is required", Registration.txtErrorMsg);

            Registration.enter_Firstname();
            Registration.click_Submit();

            Assert.AreEqual("This field is required", Registration.txtErrorMsg);

            Registration.enter_Lastname();
            Registration.click_Submit();

            Assert.AreEqual("Enter a valid email", Registration.txtErrorMsg);

            Registration.enter_InvalidEmail();
            Registration.click_Submit();
            Assert.AreEqual("Enter a valid email", Registration.txtErrorMsg2);

            Registration.enter_validEmail();
            Registration.click_Submit();
            Assert.AreEqual("This field is required", Registration.txtErrorMsg);

            Registration.enter_UsrName();
            Registration.click_Submit();
            Assert.AreEqual("This field is required", Registration.txtErrorMsg);

            Registration.enter_Password();
            Registration.click_Submit();

        }
    }
}
