using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SwagProject.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagProject.Pages
{
    public class ProductPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement AddBackpack => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement AddBoltTShirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement Cart => driver.FindElement(By.CssSelector("#shopping_cart_container .shopping_cart_badge"));
        public IWebElement SortByPrice => driver.FindElement(By.ClassName("product_sort_container"));
        public IWebElement MenuClick => driver.FindElement(By.Id("react-burger-menu-btn"));
        public IWebElement AboutClick => driver.FindElement(By.Id("about_sidebar_link"));
        public IWebElement ShoppingCartClick => driver.FindElement(By.Id("shopping_cart_container"));
        public IWebElement Checkout => driver.FindElement(By.Id("checkout"));


        public void SelectOption (string text)
        {
            SelectElement element = new SelectElement(SortByPrice);
            element.SelectByText(text);
        }
       

    }
}
