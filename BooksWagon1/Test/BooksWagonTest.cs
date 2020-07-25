using Bookswagon.ExcelReader;
using Bookswagon.Pages;
using BooksWagon1.Base;
using BooksWagon1.Pages;
using NUnit.Framework;
using System.Threading;

namespace Bookswagon.Test
{

    [TestFixture("single", "chrome")]
    public class BooksWagonTest : BooksWagonBase

    {

        public BooksWagonTest(string profile, string environment) : base(profile, environment)
        {

        }
        public Credentials credentials = new Credentials();

        [Test, Order(1)]
        public void LoginTest()
        {
            Login login = new Login(driver);
            driver.Url = "https://www.bookswagon.com/login";
            login.BookwagonLogin(credentials.userName, credentials.pass);
            Assert.IsTrue(login.Validate("login").Displayed);
        }

        [Test, Order(2)]
        public void HomePageTest()
        {
            Homepage home = new Homepage(driver);
            home.SearchItem("cobain");
        }

        [Test, Order(3)]
        public void PlaceOrderTest()
        {
            PlaceOrder order = new PlaceOrder(driver);
            order.OrderBook();
            Thread.Sleep(6000);
        }

        [Test, Order(4)]
        public void CartCheckoutTest()
        {
            ShippingAdress cart = new ShippingAdress(driver);
            Assert.IsTrue(cart.Validate().Displayed);
            cart.AddShippingDetails();
        }

        [Test, Order(5)]
        public void ReviewOrderTest()
        {
            ReviewOrder order = new ReviewOrder(driver);
            Assert.IsTrue(order.Validate().Displayed);
            order.OrderReview();
        }

        [Test, Order(6)]
        public void LogoutTest()
        {
            Login login = new Login(driver);
            login.Logout();
            Assert.IsTrue(login.Validate("logout").Displayed);
        }
    }
}
