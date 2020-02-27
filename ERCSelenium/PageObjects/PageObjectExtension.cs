using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenio.Core.SUT;

namespace ERC.Selenium.PageObjects

{
    public static class PageObjectExtensions
    {
        public static void WaitForElement(this PageObject page, IWebElement element = null)
        {
            page.Wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}