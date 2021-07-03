using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Educational_Form
{
    public static class ObjectRetrivel
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int waittime = 20)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waittime));

            return wait.Until(ExpectedConditions.ElementExists(by));
        }

        public static IList<IWebElement> FindElements(this IWebDriver driver, By by, int waittime = 25)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waittime));

            return wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
        }

        public static IWebElement css(this IWebDriver driver, string CssSelector)
        {
            return driver.FindElement(By.CssSelector(CssSelector));

        }

        public static IList<IWebElement> Allcss(this IWebDriver driver, string cssSelector)
        {
            return driver.FindElements(By.CssSelector(cssSelector));
        }
        public static IWebElement LinkText(this IWebDriver driver, string text)
        {
            return driver.FindElement(By.LinkText(text));
        }
        public static IWebElement XPath(this IWebDriver driver, string XPath)
        {
            return driver.FindElement(By.XPath(XPath));
        }
        public static IList<IWebElement> AllXPath(this IWebDriver driver, string XPath)
        {
            return driver.FindElements(By.XPath(XPath));
        }

    }




}

    

