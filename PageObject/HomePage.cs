using MyDriver;
using OpenQA.Selenium;

namespace PageObject
{
    public class HomePage
    {
        private readonly WebDriver _driver;
        // 构造 函数 , 再类中传递参数
        public HomePage(WebDriver driver)
        {
            _driver = driver;
        }

        public WebElement ContactUS
        {
            get
            {
                var element = _driver.FindElement(By.XPath("//a[text()='CONTACT US']"));
                return element;
            }
        }
    }
}
