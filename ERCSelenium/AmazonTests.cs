using System;
using ERCSelenium.SUT;
using Selenio.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ERCSelenium.Tools;
using System.Threading;

namespace ERC.Selenium
{
    [TestClass]
    public class AmazonTests : MasterTestClass
    {
        [TestMethod]
        public void ShoppingExperience()
        {
            RunTest(() =>
               {
                   App.Reporter.TestDescription = "Amazon basic shopping flow";
                   App.Reporter.TestStep = "Navigate to amazon.com";
                   App.AmazonTest.NavigateToAmazon(App.AmazonTest.SearchBtn);

                   App.Reporter.TestStep = "Search for an Item and select the item that was searched for";
                   App.AmazonTest.SearchItems("The Legend of Zelda: Hyrule Historia", App.AmazonTest.SearchedItem);
                   App.AmazonTest.SearchedItem.Click();
                   App.AmazonTest.WaitForElement(App.AmazonTest.ProductTitle);

                   App.Reporter.TestStep = "Validate the exact Item was selected";
                   Assertions.AreEqual(true, App.AmazonTest.ProductTitle.Text.Contains("The Legend of Zelda: Hyrule Historia"), "Validate that the item is the one the client is searching");

                   App.Reporter.TestStep = "Select how many items to buy";
                   App.AmazonTest.SelectElementByText(App.AmazonTest.QtyDropDown, "3");
                   App.AmazonTest.AddToCartBtn.Click();
                   App.AmazonTest.WaitForElement(App.AmazonTest.CheckOutBtn);

                   App.Reporter.TestStep = "Validate that all the aitems were added to the cart";
                   Assertions.AreEqual(true, App.AmazonTest.CartCount.Text.Contains("3"), "Validate that the cart was updated with the Quantity");

                   App.Reporter.TestStep = "Keep buying related items if the suggested items list is displayed";
                   if (App.AmazonTest.SuggestionsItems.Displayed == true)
                   {
                       App.AmazonTest.SuggestedItem1.Click();
                       App.AmazonTest.WaitForElement(App.AmazonTest.ProductTitle);
                       App.AmazonTest.AddToCartBtn.Click();
                       Thread.Sleep(4000);
                       App.Driver.SwitchTo();
                       if (App.AmazonTest.ProceedToCheckOut2.Displayed)
                       {
                           App.AmazonTest.WaitForElement(App.AmazonTest.ProceedToCheckOut2);
                           App.AmazonTest.ProceedToCheckOut2.Click();
                           App.Driver.Quit();

                       }
                       else
                       {
                           App.AmazonTest.WaitForElement(App.AmazonTest.CheckOutBtn);
                           Assertions.AreEqual(true, App.AmazonTest.CartCount.Text.Contains("4"), "Validate that the cart was updated with the Quantity");
                           App.AmazonTest.CheckOutBtn.Click();
                           App.Driver.Quit();
                       }
                   }
                   else
                   {
                       App.AmazonTest.CheckOutBtn.Click();
                       App.Driver.Quit();
                   }

               });

        }
            [TestMethod]
        public void ShoppingDeals()
        {
            RunTest(() =>
            {
                App.Reporter.TestDescription = "Amazon deals shopping flow";
                App.Reporter.TestStep = "Navigate to amazon.com";
                App.AmazonTest.NavigateToAmazon(App.AmazonTest.TodaysDeals);

                App.Reporter.TestStep = "Open Today's Deals page";
                App.AmazonTest.TodaysDeals.Click();
                App.AmazonTest.WaitForElement(App.AmazonTest.FirstDeal);
                                

                App.Reporter.TestStep = "Choose a deal";
                App.AmazonTest.ChooseDeal();

                App.Reporter.TestStep = "Add Item to cart";
                App.AmazonTest.AddToCartBtn.Click();
                App.AmazonTest.WaitForElement(App.AmazonTest.CheckOutBtn);
                Assertions.AreEqual(true, App.AmazonTest.CartCount.Text.Contains("1"), "Validate that the cart was updated with the Quantity");
                
                App.Reporter.TestStep = "Checkout";
                App.AmazonTest.CheckOutBtn.Click();
                App.Driver.Quit();

            });
        }
        [TestMethod]
        public void ShoppingGiftCard()
        {
            RunTest(() =>
            {
                App.Reporter.TestDescription = "Amazon deals shopping flow";
                App.Reporter.TestStep = "Navigate to amazon.com";
                App.AmazonTest.NavigateToAmazon(App.AmazonTest.GiftCardBtn);

                App.Reporter.TestStep = "Navigate to the Giftcard Page";
                App.AmazonTest.GiftCardBtn.Click();
                App.AmazonTest.WaitForElement(App.AmazonTest.EGift);

                App.Reporter.TestStep = "Buy an EGift card";
                App.AmazonTest.ChooseGiftCard("eGift", "63", "Reysi@test.com", "Jhon@test.com");

                App.Reporter.TestStep = "Validate the cart and the subtotal for the items";
                Assertions.AreEqual(true, App.AmazonTest.CartCount.Text.Contains("1"), "Validate that the cart was updated with the Quantity");
                Assertions.AreEqual(true, App.AmazonTest.SubTotal.Text.Contains("63"), "Validate that the cart was updated with the Quantity");

                App.Reporter.TestStep = "Navigate to the Giftcard Page";
                App.AmazonTest.GiftCardBtn.Click();
                App.AmazonTest.WaitForElement(App.AmazonTest.EGift);

                App.Reporter.TestStep = "Buy a Print At Home Gift Card";
                App.AmazonTest.ChooseGiftCard(type: "Print at home", amount: "55");

                App.Reporter.TestStep = "Validate the cart and the subtotal for the items";
                Assertions.AreEqual(true, App.AmazonTest.CartCount.Text.Contains("2"), "Validate that the cart was updated with the Quantity");
                Assertions.AreEqual(true, App.AmazonTest.SubTotal.Text.Contains("118"), "Validate that the cart was updated with the Quantity");

                App.Reporter.TestStep = "Navigate to the Giftcard Page";
                App.AmazonTest.GiftCardBtn.Click();
                App.AmazonTest.WaitForElement(App.AmazonTest.EGift);

                App.Reporter.TestStep = "Validate the exact Item was selected";
                App.AmazonTest.ChooseGiftCard(type: "Mail");

                App.Reporter.TestStep = "Validate the cart and the subtotal for the items";
                Assertions.AreEqual(true, App.AmazonTest.CartCount.Text.Contains("3"), "Validate that the cart was updated with the Quantity");
                Assertions.AreEqual(true, App.AmazonTest.SubTotal.Text.Contains("128"), "Validate that the cart was updated with the Quantity");


            });
        }
    }

}
