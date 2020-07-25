using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace BooksWagon1.Pages
{
    public class ReviewOrder
    {
        public IWebDriver driver;

        public ReviewOrder(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//textarea[@name='ctl00$cpBody$ShoppingCart$lvCart$txtGiftMessage']")]
        public IWebElement message;

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Review your Order')]")]
        public IWebElement validation;

        [FindsBy(How = How.XPath, Using = "//input[@name='ctl00$cpBody$ShoppingCart$lvCart$savecontinue']")]
        public IWebElement saveAndContinue;

        public void OrderReview()
        {
            message.SendKeys("Happy Birthday");
            Thread.Sleep(5000);
            saveAndContinue.Click();
            Thread.Sleep(8000);
        }

        public IWebElement Validate()
        {
            return validation;
        }
    }
}
