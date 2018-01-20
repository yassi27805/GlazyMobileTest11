using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace GlazyMobileTest
{
    class GlazyCommonMethods
    {
        public IWebElement FindElementByXpath (string XpathVal,IWebDriver driver)
        {
            IWebElement xpathvaluefound;

            return xpathvaluefound = driver.FindElement(By.XPath(XpathVal));
        }

        public void Signup (IWebDriver driver)
        {
            var SignUP = driver.FindElement(By.XPath(GlazySignUpID.SignUpXpath));
            SignUP.Click();
        }

        public void MainLogin (IWebDriver driver)
        {
            var MainLogin = driver.FindElement(By.XPath(GlazyLoginId.LoginXpath));
            MainLogin.Click();
        }

        public void CreateAccount(IWebDriver driver)
        {
            var UserName = FindElementByXpath(GlazySignUpID.EmailXpath, driver);
           // var UserName = driver.FindElement(By.XPath(GlazySignUpID.EmailXpath));
            var Password = driver.FindElement(By.XPath(GlazySignUpID.PasswordXpath));
            var TypeItAgain = driver.FindElement(By.XPath(GlazySignUpID.TypeItAgainXpath));
            var SignUpButton = driver.FindElement(By.XPath( "html/body/div/div/div/form/div[2]/div[2]/input"));

            UserName.SendKeys(GlazyInputData.UserName);
            Password.SendKeys(GlazyInputData.Password);
            TypeItAgain.SendKeys(GlazyInputData.Password);

            SignUpButton.Click();
        }

        public void Login (IWebDriver driver)
        {
            var UserName = driver.FindElement(By.XPath(GlazyLoginId.LoginEmailXpath));
            var Password = driver.FindElement(By.XPath(GlazyLoginId.LoginPasswordXpath));
            var LoginButton = driver.FindElement(By.XPath(GlazyLoginId.LoginSignInXpath));

            UserName.SendKeys(GlazyInputData.UserName);
            Password.SendKeys(GlazyInputData.Password);
            LoginButton.Click();

        }

    }
}
