using ERCSelenium.SUT;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Selenio.Core.SUT;
using Selenio.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERCSelenium.PageObjects
{
    public class AmazonTest : PageObject
    {
        #region WebElements

        
        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        public IWebElement SearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/input[@class = 'nav-input']")]
        public IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//SPAN[@class='a-size-medium a-color-base a-text-normal'][text()='The Legend of Zelda: Hyrule Historia']")]
        public IWebElement SearchedItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id = 'selectQuantity']//div/span[@class = 'a-dropdown-container']//select[@id = 'quantity']")]
        public IWebElement QtyDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "productTitle")]
        public IWebElement ProductTitle { get; set; }

        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        public IWebElement AddToCartBtn { get; set; }
        
        [FindsBy(How = How.Id, Using = "nav-cart-count")]
        public IWebElement CartCount { get; set; }
        
        [FindsBy(How = How.Id, Using = "hlb-ptc-btn-native")]
        public IWebElement CheckOutBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id = 'huc-first-upsell-row']//div[@class = 'a-row huc-v2-upsell-row']")]
        public IWebElement SuggestionsItems  { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id = 'huc-first-upsell-row']//div[@class = 'a-row huc-v2-upsell-row']//div/a/img[@class = 'sc-product-image']")]
        public IWebElement SuggestedItem1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//A[@href='/international-sales-offers/b/?ie=UTF8&node=15529609011&ref_=nav_navm_intl_deal_btn']")]
        public IWebElement TodaysDeals { get; set; }

        [FindsBy(How = How.Id, Using = "//B[text()='Deals and Promotions'][1]")]
        public IWebElement DealAndPromoTtl { get; set; }
                
        [FindsBy(How = How.XPath, Using = "//div[@class = 'a-fixed-left-grid-col rightCol']//div[@id = '100_dealView_0']//div/a[@id = 'dealImage']")]
        public IWebElement FirstDeal { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'a-container background-gary-1']")]
        public IWebElement SelectItemOfDealPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id = 'octopus-dlp-asin-stream']//div/a/img[@alt ='asin image url']")]
        public IWebElement FirstItemOfDeals { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id = 'nav-search']//div[@class ='nav-search-facade']")]
        public IWebElement DepartmentDroDown { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//A[@href='/gift-cards/b/?ie=UTF8&node=2238192011&ref_=nav_cs_gift_cards'][text()='Gift Cards']")]
        public IWebElement GiftCardBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='a-row a-spacing-micro']/span[@class='a-size-medium a-align-center huc-subtotal' and 1]/span[@class='a-color-price hlb-price a-inline-block a-text-bold' and 2]")]
        public IWebElement SubTotal { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/div/div[1]/div/div[1]/div[2]/div/div/div[2]/div[1]/div/div/a/img")]
        public IWebElement EGift { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/div/div[1]/div/div[1]/div[2]/div/div/div[2]/div[2]/div/div/a/img")]
        public IWebElement PrintAtHomeGC { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/div/div[1]/div/div[1]/div[2]/div/div/div[2]/div[3]/div/div/a/img")]
        public IWebElement Mail { get; set; }

        [FindsBy(How = How.XPath, Using = "//IMG[@src='https://images-na.ssl-images-amazon.com/images/I/41i8AUfL7uL._SX65_SY45_CR,0,0,65,45_.jpg']")]
        public IWebElement MailGiftCardDesign { get; set; }

        [FindsBy(How = How.Id, Using = "gc-order-form-custom-amount")]
        public IWebElement GiftcardAmount { get; set; }

        [FindsBy(How = How.Id, Using = "gc-order-form-recipients")]
        public IWebElement GiftCardRecipient { get; set; }

        [FindsBy(How = How.Id, Using = "gc-order-form-senderName")]
        public IWebElement GiftCardSender{ get; set; }

        [FindsBy(How = How.XPath, Using = "//IMG[@src='https://m.media-amazon.com/images/I/81sJe21t0JL._AC_UL320_ML3_.jpg']")]
        public IWebElement AmazonGiftCardMail { get; set; }

        [FindsBy(How = How.Id, Using = "gc-buy-box-atc")]
        public IWebElement GiftCardAddToCard { get; set; }

        [FindsBy(How = How.Id, Using = "a-autoid-12-announce")]
        public IWebElement FiftyGiftCard { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[1]/div[6]/div[5]/div[1]/div[1]/div/div[1]/div/div/div[1]/div[3]/div[1]/div[2]/div[3]/span/span/input")]
        public IWebElement ProceedToCheckOut2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[1]/div[6]/div[5]/div[1]/div[1]/div/div[1]/div/div")]
        public IWebElement CheckOutPopUp { get; set; }

        




        #endregion
        #region Methods
        public AmazonTest NavigateToAmazon(IWebElement element = null)
        {
            App.Driver.Navigate().GoToUrl("https://www.amazon.com/");
            this.WaitForScreen(element);
            return this;
        }

        public void SearchItems(string text, IWebElement element =null)
        {
            App.AmazonTest.SearchTextBox.SendKeys(text);
            App.AmazonTest.SearchBtn.Click();
            this.WaitForElement(element);
        }
        public void SelectElementByText(IWebElement element, string text)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(text);
        }

        public void ChooseDeal()
        {
            App.AmazonTest.FirstDeal.Click();
            App.AmazonTest.WaitForScreen(App.AmazonTest.SearchBtn);

            if (App.AmazonTest.SelectItemOfDealPage.Displayed)
            {
                App.AmazonTest.FirstItemOfDeals.Click();
                this.WaitForElement(App.AmazonTest.ProductTitle);
            }
            else
            {
                this.WaitForElement(App.AmazonTest.ProductTitle);
            }
        }
            public void ChooseGiftCard(string type =null, string amount=null, string recipient = null, string sender = null)
            {
            switch (type)
            {
                case "eGift":
                    App.AmazonTest.EGift.Click();
                    App.AmazonTest.WaitForElement(App.AmazonTest.SearchTextBox);
                    App.AmazonTest.GiftcardAmount.SendKeys(amount);
                    App.AmazonTest.GiftCardRecipient.SendKeys(recipient);
                    App.AmazonTest.GiftCardSender.SendKeys(sender);
                    App.AmazonTest.GiftCardAddToCard.Click();
                    App.AmazonTest.WaitForElement(App.AmazonTest.CheckOutBtn);

                    break;
                case "Print at home":
                    App.AmazonTest.PrintAtHomeGC.Click();
                    App.AmazonTest.WaitForElement(App.AmazonTest.SearchTextBox);
                    App.AmazonTest.GiftcardAmount.SendKeys(amount);
                    App.AmazonTest.GiftCardAddToCard.Click();
                    App.AmazonTest.WaitForElement(App.AmazonTest.CheckOutBtn);                    
                    break;

                case "Mail":
                    App.AmazonTest.Mail.Click();
                    App.AmazonTest.WaitForElement(App.AmazonTest.AmazonGiftCardMail);
                    App.AmazonTest.AmazonGiftCardMail.Click();
                    App.AmazonTest.WaitForElement(App.AmazonTest.SearchTextBox);
                    App.AmazonTest.AddToCartBtn.Click();
                    App.AmazonTest.WaitForElement(App.AmazonTest.CheckOutBtn);
                    break;


                default:
                    break;
            }
           

            }
            
        #endregion


    }
}
