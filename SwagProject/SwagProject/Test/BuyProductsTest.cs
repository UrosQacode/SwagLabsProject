using OpenQA.Selenium;
using SwagProject.Driver;
using SwagProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagProject.Test
{
    public class Tests
    {
        LoginPage loginPage;
        ProductPage productPage;
        CartPage cartPage;
        


        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();
            cartPage = new CartPage();
            
            

        }

        [TearDown]
        public void ClosePage()
        {
            WebDrivers.CleanUp();
        }


        [Test]
        public void TC01_AddTwoProductInCart_ShouldDisplayedTwoProduct()

        {
            loginPage.Login("standard_user", "secret_sauce");

            productPage.AddBackpack.Click();
            productPage.AddBoltTShirt.Click();
            Assert.That("2", Is.EqualTo(productPage.Cart.Text));


        }
        [Test]

        public void TC02_SortProductByPrice_ShouldSortHighPrice()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.SelectOption("Price (high to low)");
            Assert.That(productPage.SortByPrice.Displayed);
        }

        [Test]
        public void TC03_GoToAboutPage_ShoulRedactioToNewPage()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.MenuClick.Click();
            productPage.AboutClick.Click();

            Assert.That("https://saucelabs.com/", Is.EqualTo(WebDrivers.Instance.Url));


        }

        [Test]
        public void TC04_BuyProducts_ShouldBeFinishedShopping()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddBackpack.Click();
            productPage.AddBoltTShirt.Click();
            productPage.ShoppingCartClick.Click();
            
            cartPage.Checkout.Click();
            cartPage.FirstName.SendKeys("Uros");
            cartPage.LastName.SendKeys("Zivadinovic");
            cartPage.Zip.SendKeys("11000");
            cartPage.ButtonContinue.Submit();
            cartPage.ButtonFinish.Click();
            

            Assert.That("THANK YOU FOR YOUR ORDER", Is.EqualTo(cartPage.OrderFinished.Text));

        }
    }
}

