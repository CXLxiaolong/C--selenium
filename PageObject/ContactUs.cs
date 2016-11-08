using MyDriver;
using OpenQA.Selenium;

namespace PageObject
{
    public class ContactUs
    {
        private readonly WebDriver _driver;

        public ContactUs(WebDriver driver)
        {
            _driver = driver;
        }

        public WebElement TopicInterested
        {
            get
            {
                var element = _driver.FindElement(By.Id("edit-submitted-im-interesting-in"));
                return element;
            }
        }

        #region Element
        public WebElement Organization
        {
            get
            {
                var element = _driver.FindElement(By.Id("edit-submitted-organization"));
                return element;
            }
        }

        public WebElement Title
        {
            get
            {
                var element = _driver.FindElement(By.Id("edit-submitted-title"));
                return element;
            }
        }
        public WebElement FirstName
        {
            get
            {
                var element = _driver.FindElement(By.Id("edit-submitted-first-name"));
                return element;
            }
        }
        public WebElement LastName
        {
            get
            {
                var element = _driver.FindElement(By.Id("edit-submitted-last-name"));
                return element;
            }
        }
        public WebElement ContactNumber
        {
            get
            {
                var element = _driver.FindElement(By.Id("edit-submitted-contact-number"));
                return element;
            }
        }

        public WebElement Email
        {
            get
            {
                var element = _driver.FindElement(By.Id("edit-submitted-email"));
                return element;
            }
        }
        public WebElement Submit
        {
            get
            {
                var element = _driver.FindElement(By.Id("edit-submit"));
                return element;
            }
        }



        public WebElement HeaderText
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@id='node-104']/div/p[1]"));
                return element;
            }
        }

        public WebElement Login
        {
            get
            {
                var element = _driver.FindElement(By.LinkText("Login"));
                return element;
            }
        }


        public WebElement JionUS
        {
            get
            {
                var element = _driver.FindElement(By.Id("edit-submitted-join-us-2"));
                return element;
            }
        }

        // Error INFO
        public WebElement ErrorOrganization
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@class='messages error']/ul/li[1]"));
                return element;
            }
        }
        public WebElement ErrorTitle
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@class='messages error']/ul/li[2]"));
                return element;
            }
        }
        public WebElement ErrorFirstName
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@class='messages error']/ul/li[3]"));
                return element;
            }
        }
        public WebElement ErrorLastName
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@class='messages error']/ul/li[4]"));
                return element;
            }
        }
        public WebElement ErrorEmail
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@class='messages error']/ul/li[5]"));
                return element;
            }
        }
        public WebElement Erroremail
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@class='messages error']"));
                return element;
            }
        }
        public WebElement ErrorContactNumber
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//div[@class='messages error']/ul/li[6]"));
                return element;
            }
        }

        #endregion 


        #region operation

        public void EnterValueOnScreen(string email)
        {
            Organization.Sendkeys("迪原");
            Title.Sendkeys("创新");
            FirstName.Sendkeys("Test");
            LastName.Sendkeys("test");
            ContactNumber.Sendkeys("15010231234");
            Email.Sendkeys(email);

        }

        #endregion











    }
}
