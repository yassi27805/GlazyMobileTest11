using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace GlazyMobileTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IWebDriver driver;
            DesiredCapabilities capability = new DesiredCapabilities();
            capability.SetCapability("device", "iPhone 8");
            capability.SetCapability("realMobile", "true");
            capability.SetCapability("os_version", "11.0");
            capability.SetCapability("browserstack.user", "yassamansoussani1");
            capability.SetCapability("browserstack.key", "uuxCo3Pr6hNp9GiK7MR2");

            driver = new RemoteWebDriver(
                     new Uri("http://hub-cloud.browserstack.com/wd/hub/"), capability
                        );
                        

            //IWebDriver driver = new ChromeDriver(@"c:\\automation");
            var Surl = "http://test-gp.classifiedsolutionsgroup.com//account//registrationredirection";
            //obj.setupdriver(Surl);
            driver.Url = Surl;
            //driver.Manage().Window.Maximize();

            GlazyCommonMethods obj = new GlazyCommonMethods();

  //          obj.Signup(driver);
  //          obj.CreateAccount(driver);

            obj.MainLogin(driver);
            obj.Login(driver);

        }
    }
}
