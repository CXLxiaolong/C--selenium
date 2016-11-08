using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using MyDriver;

namespace PageObject
{
   public class LoginPage
    {


        private readonly WebDriver _driver;

        public LoginPage(WebDriver driver)
        {
            _driver = driver;
        }

        public WebElement UserName
        {
            get
            {
                var element = _driver.FindElement(By.Id("edit-name"));
                return element;
            }
        }

        public WebElement Password
        {
            get
            {
                var element = _driver.FindElement(By.Id("edit-pass"));
                return element;
            }
        }

        public WebElement login
        {
            get
            {
                var element = _driver.FindElement(By.Id("edit-submit"));
                return element;
            }
        }

    }
}
