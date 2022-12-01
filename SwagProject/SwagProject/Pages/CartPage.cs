using OpenQA.Selenium;
using SwagProject.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagProject.Pages
{
    public class CartPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement ShoppingCartClick => driver.FindElement(By.Id("shopping_cart_container"));
        public IWebElement Checkout => driver.FindElement(By.Id("checkout"));
        public IWebElement FirstName => driver.FindElement(By.Id("first-name"));
        public IWebElement LastName => driver.FindElement(By.Id("last-name"));
        public IWebElement Zip => driver.FindElement(By.Id("postal-code"));
        public IWebElement ButtonContinue => driver.FindElement(By.Id("continue"));
        public IWebElement ButtonFinish => driver.FindElement(By.Id("finish"));
        public IWebElement OrderFinished => driver.FindElement(By.CssSelector("#checkout_complete_container .complete-header"));
    }
}
