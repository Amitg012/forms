using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZenLabsCore
{
  public class MethodPage
    {
        protected void LogMessage(string message, Action method)
        {
            TestContext.Write($"step:{message}");

            try
            {
                method();
                TestContext.WriteLine(" - Passed");
            }
            catch (Exception)
            {
                TestContext.WriteLine(" - Failed");
                throw;
            }
        }
        #region EnterText
        protected static void Input(IWebElement element, string data)
        {
            element.SendKeys(data);
        }
        protected static void Input1(IWebElement element1, string data)
        {
            element1.SendKeys(data);
        }
        protected static void Input2(IWebElement element2, string data)
        {
            element2.SendKeys(data);
        }
        protected static void Input3(IWebElement element3, string data)
        {
            element3.SendKeys(data);
        }
        protected static void Input4(IWebElement element4, string data)
        {
            element4.SendKeys(data);
        }
        protected static void Input5(IWebElement element5, string data)
        {
            //string FilePath = @"C:Users.ghodk.OneDrive.Documents.Documents.Amitghodke_CV";

            element5.SendKeys(data);
        }
        //public static void SelectElement(IWebElement element, IWebDriver driver)
        //{
        //    SelectElement select = new SelectElement(element);
        //    Actions action = new Actions(driver);

        //    action.MoveToElement(element);
        //    select.SelectByText("element");
        //}


        #endregion
        //public void Frames(IWebElement element , IWebDriver driver)
        //{
        //    driver.SwitchTo().Window(driver.WindowHandles.First());
        //    driver.SwitchTo().Frame(element);
            
        //}


        #region ClickFunction

        public static void Click(IWebElement element)
        {

            element.Click();
        }

        protected static void MoveToElementAndClick(IWebElement element, IWebDriver driver)
        {
            Actions action = new Actions(driver);
            
            action.MoveToElement(element);
            element.Click();

        }
        #endregion
        protected static void DragAndDrop(IWebElement element, IWebDriver driver)
        {
            Actions action = new Actions(driver);

            action.ClickAndHold(element).MoveByOffset(25, 0).Release().Build().Perform();

            //action.ClickAndHold(element).MoveByOffset(-25, 0).Release().Build().Perform();
        }

        #region MouseHover

        protected static void MouseHover(IWebElement element, IWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();
        }
        #endregion
       


        #region Assert Functions

        protected static void AssertIsTrue(bool value)
        {
            Assert.IsTrue(value);
        }
        protected static void AssertAreEqual(Object actual, Object Expected)
        {
            Assert.AreEqual(actual, Expected);
        }
        #endregion

    }
}


