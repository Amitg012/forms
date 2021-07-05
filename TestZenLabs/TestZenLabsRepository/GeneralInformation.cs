using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestZenLabsCore;

namespace TestZenLabsRepository
{
   public class GeneralInformation : MethodPage
    {
        public IWebDriver _driver = null;
        #region Constructor

        public GeneralInformation(IWebDriver driver)
        {
            _driver = driver;
            
        }
        #endregion
        #region Object Repository
        private IWebElement YourName => _driver.Css("input[placeholder='Your Name']");
        private IWebElement YourMiddleName => _driver.Css("input[placeholder='Your Middle Name']");
        private IWebElement YourLastName => _driver.Css("input[placeholder='Your Last Name']");
        private IWebElement PhoneNumber => _driver.Css("input[placeholder='Phone Number']");
        private IWebElement YourAddress => _driver.Css("input[placeholder='Your Address']");
        private IWebElement YourAddressTwo => _driver.Css("input[placeholder='Your Address Two']");
        private IWebElement YourAddressthree => _driver.Css("input[placeholder='Your Address three']");
        private IWebElement YourPinCode => _driver.Css("input[placeholder='Your Pin Code']");
        private IWebElement Male => _driver.Css("#profession-0");
        private IWebElement Female => _driver.Css("#profession-1");
        private IWebElement Minor => _driver.Css("#exp-0");
        private IWebElement Major => _driver.Css("#exp-1");
      //  private IWebElement Services => _driver.XPath(".//li[@id = 'menu-item-9057']/child::a");
       // private IWebElement TestAutomationServices => _driver.XPath(".//li[@id = 'menu-item-9222']/child::a");
        public IWebElement Controls => _driver.XPath("//div[@class = 'kc-elm kc-css-164834 kc_text_block']//child::div");
        public IWebElement Europe => _driver.XPath("//div[contains(text(),'Europe')]");
        private IWebElement FormerlyRegistered => _driver.XPath("//div[@class = 'g-hove']//a[1]");
        private IWebElement EducationForm => _driver.XPath(".//div[@class = 'kc-elm kc-css-757776 kc_text_block']//a");
        private IWebElement Automation => _driver.LinkText("Automation");
      //  private IWebElement ChooseFile => _driver.XPath(".//div[@class ='kc-elm kc-css-733483 kc_text_block']//div/input");
       // private IWebElement ChooseFile => _driver.Id("photo");

        public void Information(string value, string value1, string value2, string value3)
        {
            LogMessage("Entering a vlaue into Your Name", () => Input(YourName, value));
            LogMessage("Validating if Your Name are Visible", () => AssertIsTrue(YourName.Displayed));

            LogMessage("Entering a vlaue into Your Middle Name", () => Input1(YourMiddleName, value1));
            LogMessage("Validating if Your Middle Name are Visible", () => AssertIsTrue(YourMiddleName.Displayed));

            LogMessage("Entering a vlaue into Your Last Name", () => Input2(YourLastName, value2));
            LogMessage("Validating if Your Last Name are Visible", () => AssertIsTrue(YourLastName.Displayed));

            LogMessage("Entering a vlaue into Phone Number", () => Input3(PhoneNumber, value3));
            LogMessage("Validating if Phone Number are Visible", () => AssertIsTrue(PhoneNumber.Displayed));

        }
        public void Address(string value, string value1, string value2, string value3)
        {
            LogMessage("Entering a vlaue into Your Address", () => Input(YourAddress, value));
            LogMessage("Validating if Your Address are Visible", () => AssertIsTrue(YourAddress.Displayed));

            LogMessage("Entering a vlaue into Your Address Two", () => Input1(YourAddressTwo, value1));
            LogMessage("Validating if Your Address Two are Visible", () => AssertIsTrue(YourAddressTwo.Displayed));

            LogMessage("Entering a vlaue into Your Address thre", () => Input2(YourAddressthree, value2));
            LogMessage("Validating if Your Address three are Visible", () => AssertIsTrue(YourAddressthree.Displayed));

            LogMessage("Entering a vlaue into Your Pin Code", () => Input3(YourPinCode, value3));
            LogMessage("Validating if Your Pin Code are Visible", () => AssertIsTrue(YourPinCode.Displayed));

           
        }
        public void Singleclick()
        {
            LogMessage("Clicking on FormerlyRegistered", () => Click(FormerlyRegistered));
            LogMessage("Clicking on Switch to ", () => Click(EducationForm));
            LogMessage("Validating Page", () => AssertIsTrue(EducationForm.Displayed));
            LogMessage("Clicking on Automation tab", () => Click(Automation));
        }
        //public void SwitchTo()
        //{
        //    LogMessage("Clicking on Switch to ", () => Frames(EducationForm, _driver));
        //    LogMessage("Clicking on Switch to ", () => Click(EducationForm));
        //    LogMessage("Validating Page", () => AssertIsTrue(EducationForm.Displayed));
        //}

      
        public void CheckBox(string value, string value1, string value2, string value3)
        {
            LogMessage("MoveToElementAndClick on Services Text", () => Input(Male, value));
            LogMessage("Entering a vlaue into MR", () => Click(Male));
            LogMessage("Validating if MR are Visible", () => AssertIsTrue(Male.Displayed));

            LogMessage("MoveToElementAndClick on Services Text", () => Input1(Female, value1));
            LogMessage("Entering a vlaue into MR", () => Click(Female));
            LogMessage("Validating if MR are Visible", () => AssertIsTrue(Female.Displayed));

            LogMessage("Clicking on Minor", () => Input2(Minor, value2));
            LogMessage("Clicking on Minor", () => Click(Minor));
            LogMessage("Validating if Minor are Visible", () => AssertIsTrue(Minor.Displayed));

            LogMessage("Clicking on MAjor", () => Input3(Major, value3));
            LogMessage("Clicking on Major", () => Click(Major));
            LogMessage("Validating if Major are Visible", () => AssertIsTrue(Major.Displayed));
        }

        //public void FileSelect(string value5)
        //{
        //    LogMessage("Selecting File", () => Input5(ChooseFile, value5));
            
        //   // LogMessage("Selecting File", () => Click(ChooseFile));
        //    LogMessage("Validating File", () => AssertIsTrue(ChooseFile.Displayed));
        //}
       
        //public void DropDown()
        //{
        //    LogMessage("Mouse Hover on Services text", () => MouseHover(Services, _driver));
        //    LogMessage("Click on TestAutomationServices", () => MouseHover(TestAutomationServices, _driver));
        //    LogMessage("Click", () => Click(TestAutomationServices));
        //}
        public void Continent()
        {
            
            LogMessage("Selecting Continent", () => MoveToElementAndClick(Controls, _driver));
            LogMessage("Click on Continenets", () => MoveToElementAndClick(Europe, _driver));
            LogMessage("Validating if Europe are Visible", () => AssertIsTrue(Europe.Displayed));
        }
        #endregion
    }
}
