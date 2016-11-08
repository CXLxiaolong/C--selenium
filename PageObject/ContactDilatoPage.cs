using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using MyDriver;

namespace PageObject
{
   public class ContactDilatoPage
    {
       
        private readonly WebDriver _driver;

        public ContactDilatoPage(WebDriver driver)
        {
            _driver = driver;
        }

        public WebElement Gobacktotheform
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@class='links']"));
                return element;
            }
        }

        public WebElement ThankYou
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@class='webform-confirmation']"));
                return element;
            }
        }


    }
}
