using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestZenLabsCore;

namespace TestZenLabsRepository
{
    public class EducationInformation : MethodPage
    {
        public IWebDriver _driver = null;
        #region Constructor

        public EducationInformation(IWebDriver driver)
        {
            _driver = driver;
        }
        #endregion

        #region Object Repository
        private IWebElement PrimarySchoolName => _driver.Css("input[placeholder='Primary School Name']");
        private IWebElement SecondarySchoolName => _driver.Css("input[placeholder='Secondary School Name']");
        private IWebElement IntermediateCollegeName => _driver.Css("input[placeholder='Intermediate College Name']");
        private IWebElement EngineeringCollegeName => _driver.Css("input[placeholder='Engineering College Name']");
        private IWebElement UniversityName => _driver.Css("input[placeholder='University Name']");

        private IWebElement Controls1 => _driver.XPath(".//div[@class ='kc-elm kc-css-170325 kc_text_block']/child::div");
        private IWebElement UniversityPercentage => _driver.XPath(".//div[@class ='selectize-dropdown-content']/child::div[3]");

        private IWebElement Controls2 => _driver.XPath(".//div[@class = 'kc-elm kc-css-915545 kc_text_block']/child::div");
        private IWebElement IntermediatePercentage => _driver.XPath(".//div[@class = 'kc-elm kc-css-915545 kc_text_block']//div[@class = 'selectize-dropdown-content']//child::div[2]");

        private IWebElement Controls3 => _driver.XPath(".//div[@class = 'kc-elm kc-css-899448 kc_text_block']/child::div");
        private IWebElement EngineeringPercentage => _driver.XPath(".//div[@class = 'kc-elm kc-css-899448 kc_text_block']//div[@class = 'selectize-dropdown-content']//child::div[2]");

        private IWebElement Slider1 => _driver.Css("#myRange");
        private IWebElement Slider => _driver.Css("#myRange4");

        private IWebElement Slider2 => _driver.Css("#myRange2");
        private IWebElement MR => _driver.Css("#profession-0");

        private IWebElement MRS => _driver.Css("#profession-1");
        private IWebElement MISS => _driver.Css("#profession-3");
        #endregion

        #region TestCase Methods
        public void Information(string value, string value1, string value2, string value3, string value4)
        {
            LogMessage("Entering a vlaue into Primary School Name", () => Input(PrimarySchoolName, value));
            LogMessage("Validating if Primary Name are Visible", () => AssertIsTrue(PrimarySchoolName.Displayed));

            LogMessage("Entering a vlaue into Secondary School Name", () => Input1(SecondarySchoolName, value1));
            LogMessage("Validating if Secondary School Name are Visible", () => AssertIsTrue(SecondarySchoolName.Displayed));

            LogMessage("Entering a vlaue into IntermediateCollegeName", () => Input2(IntermediateCollegeName, value2));
            LogMessage("Validating if Intermediate College Name are Visible", () => AssertIsTrue(IntermediateCollegeName.Displayed));

            LogMessage("Entering a vlaue into EngineeringCollegeName", () => Input3(EngineeringCollegeName, value3));
            LogMessage("Validating if Your Engineering College Name are Visible", () => AssertIsTrue(EngineeringCollegeName.Displayed));

            LogMessage("Entering a vlaue into University Name", () => Input4(UniversityName, value4));
            LogMessage("Validating if University Name are Visible", () => AssertIsTrue(UniversityName.Displayed));
        }

        public void CheckBox(string value1, string value2, string value3)
        {
            LogMessage("MoveToElementAndClick on MR Text", () => Input1(MR, value1));
            LogMessage("Entering a vlaue into MR", () => Click(MR));
            LogMessage("Validating if MR are Visible", () => AssertIsTrue(MR.Displayed));

            LogMessage("MoveToElementAndClick on MRS Text", () => Input2(MRS, value2));
            LogMessage("Entering a vlaue into MRS", () => Click(MRS));
            LogMessage("Validating if MRS are Visible", () => AssertIsTrue(MRS.Displayed));

            LogMessage("MoveToElementAndClick on Services Text", () => Input3(MISS, value3));
            LogMessage("Entering a vlaue into MISS", () => Click(MISS));
            LogMessage("Validating if MISS are Visible", () => AssertIsTrue(MISS.Displayed));
        }
        public void ClickAndHold()
        {
            LogMessage("ClickAndHol by using Offet", () => DragAndDrop(Slider, _driver));

            LogMessage("ClickAndHol by using Offet", () => DragAndDrop(Slider1, _driver));

            LogMessage("ClickAndHol by using Offet", () => DragAndDrop(Slider2, _driver));

        }
        public void Percentage()
        {

            LogMessage("Selecting Controls1", () => MoveToElementAndClick(Controls1, _driver));
            LogMessage("Selecting University Percentage", () => MoveToElementAndClick(UniversityPercentage, _driver));
            // LogMessage("Validating if University Percentage are Visible", () => AssertIsTrue(UniversityPercentage.Displayed));

            LogMessage("Selecting Controls2", () => MoveToElementAndClick(Controls2, _driver));
            LogMessage("Selecting IntermediatePercentage", () => MoveToElementAndClick(IntermediatePercentage, _driver));
            // LogMessage("Validating if IntermediatePercentage are Visible", () => AssertIsTrue(IntermediatePercentage.Displayed));

            LogMessage("Selecting Controls3", () => MoveToElementAndClick(Controls3, _driver));
            LogMessage("Selecting Engineering Percentage", () => MoveToElementAndClick(EngineeringPercentage, _driver));
            //LogMessage("Validating if EngineeringPercentage are Visible", () => AssertIsTrue(EngineeringPercentage.Displayed));


        }
        #endregion
    }
}
