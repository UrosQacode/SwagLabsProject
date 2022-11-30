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

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();

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


    }
}

