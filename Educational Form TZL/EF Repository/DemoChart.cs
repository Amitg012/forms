using Educational_Form;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Repository
{

    public class DemoChart : BasePage
    {
        public IWebDriver _driver = null;
        #region Constructor

        public DemoChart(IWebDriver driver)
        {
            _driver = driver;
        }
        #endregion


        #region Object Repository
        
        private IWebElement Home => _driver.LinkText("Home");
        private IWebElement Careers => _driver.LinkText("Careers");
        private IWebElement Training => _driver.LinkText("Training");
        private IWebElement Blog => _driver.LinkText("Blog");
        private IWebElement Contact => _driver.LinkText("Contact");
        private IWebElement YourName => _driver.css("input[placeholder='Your Name']");
        private IWebElement YourMiddleName => _driver.css("input[placeholder='Your Middle Name']");
        private IWebElement YourLastName => _driver.css("input[placeholder='Your Last Name']");
        private IWebElement PhoneNumber => _driver.css("input[placeholder='Phone Number']");
        private IWebElement YourAddress => _driver.css("input[placeholder='Your Address']");
        private IWebElement YourAddressTwo => _driver.css("input[placeholder='Your Address Two']");
        private IWebElement YourAddressthree => _driver.css("input[placeholder='Your Address three']");
        private IWebElement YourPinCode => _driver.css("input[placeholder='Your Pin Code']");
        private IWebElement Male => _driver.css("#profession-0");
        private IWebElement Female => _driver.css("#profession-1");
        private IWebElement Minor => _driver.css("#exp-0");
        private IWebElement Major => _driver.css("#exp-1");
        private IWebElement Services => _driver.XPath(".//li[@id = 'menu-item-9057']/child::a");
        private IWebElement TestAutomationServices => _driver.XPath(".//li[@id = 'menu-item-9222']/child::a");
        public IWebElement Controls => _driver.XPath(".//div[@class = 'kc-elm kc-css-164834 kc_text_block']//child::div");
        public IWebElement Europe => _driver.XPath(".//div[contains(text(),'Europe')]");
        //private IWebElement FormerlyRegistered => _driver.LinkText("Formerly Registered");

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
            
            LogMessage("Clicking on Home", () => Click(Home));
            LogMessage("Clicking on Careers", () => Click(Careers));
            LogMessage("Clicking on Training", () => Click(Training));
            LogMessage("Clicking on Blog", () => Click(Blog));
            LogMessage("Clicking on Contact", () => Click(Contact));
            //LogMessage("Clicking on FormerlyRegistered", () => Click(FormerlyRegistered));

        }
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
        public void DropDown()
        {
            LogMessage("Mouse Hover on Services text", () => MouseHover(Services, _driver));
            LogMessage("Click on TestAutomationServices", () => MouseHover(TestAutomationServices, _driver));
            LogMessage("Click", () => Click(TestAutomationServices));
        }
        public void Continent()
        {
            LogMessage("Selecting Continent", () => MoveToElementAndClick(Controls, _driver ));
            LogMessage("Click on Continenets", () => MoveToElementAndClick(Europe, _driver));
            LogMessage("Validating if Europe are Visible", () => AssertIsTrue(Europe.Displayed));
        }


        #endregion

        #region Object Repository1
        private IWebElement PrimarySchoolName => _driver.css("input[placeholder='Primary School Name']");
        private IWebElement SecondarySchoolName => _driver.css("input[placeholder='Secondary School Name']");
        private IWebElement IntermediateCollegeName => _driver.css("input[placeholder='Intermediate College Name']");
        private IWebElement EngineeringCollegeName => _driver.css("input[placeholder='Engineering College Name']");
        private IWebElement UniversityName => _driver.css("input[placeholder='University Name']");

        private IWebElement Controls1 => _driver.XPath(".//div[@class ='kc-elm kc-css-170325 kc_text_block']/child::div");
        private IWebElement UniversityPercentage => _driver.XPath(".//div[@class ='selectize-dropdown-content']/child::div[3]");

        private IWebElement Controls2 =>  _driver.XPath(".//div[@class = 'kc-elm kc-css-915545 kc_text_block']/child::div");
        private IWebElement IntermediatePercentage => _driver.XPath(".//div[@class = 'kc-elm kc-css-915545 kc_text_block']//div[@class = 'selectize-dropdown-content']//child::div[2]");

        private IWebElement Controls3 => _driver.XPath(".//div[@class = 'kc-elm kc-css-899448 kc_text_block']/child::div");
        private IWebElement EngineeringPercentage => _driver.XPath(".//div[@class = 'kc-elm kc-css-899448 kc_text_block']//div[@class = 'selectize-dropdown-content']//child::div[2]");          
            
        private IWebElement Slider1 => _driver.css("#myRange");
        private IWebElement Slider => _driver.css("#myRange4");

        private IWebElement Slider2 => _driver.css("#myRange2");
        private IWebElement MR => _driver.css("#profession-0");

        private IWebElement MRS => _driver.css("#profession-1");
        private IWebElement MISS => _driver.css("#profession-3");
        #endregion

        #region TestCase Methods
        public void Information1(string value, string value1, string value2, string value3, string value4)
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
            LogMessage("MoveToElementAndClick on MR Text", () => Input4(MR, value1));
            LogMessage("Entering a vlaue into MR", () => Click(MR));
            LogMessage("Validating if MR are Visible", () => AssertIsTrue(MR.Displayed));

            LogMessage("MoveToElementAndClick on MRS Text", () => Input4(MRS, value2));
            LogMessage("Entering a vlaue into MRS", () => Click(MRS));
            LogMessage("Validating if MRS are Visible", () => AssertIsTrue(MRS.Displayed));

            LogMessage("MoveToElementAndClick on Services Text", () => Input4(MISS, value3));
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

        #region Object Repository2
        private IWebElement PreviousCompanyName => _driver.css("input[placeholder='Previous Company Name']");
        private IWebElement CurrentCompanyName => _driver.css("input[placeholder='Current Company Name']");

        private IWebElement controlgroup => _driver.css("#exp-2");
        private IWebElement QAWebManual => _driver.css("#profession-0");
        private IWebElement QMobileManual => _driver.css("#profession-3");
        private IWebElement QAMobileAutomation => _driver.XPath("(.//input[@id = 'profession-1'])[2]");
        private IWebElement DateOfBirth => _driver.XPath(".//div[@class ='kc-elm kc-css-443856 kc_text_block']//input[@name ='bday']");
        private IWebElement PreviousCompanyJoinDate => _driver.XPath("(.//input[@name ='bday'])[2]");
        private IWebElement PreviousCompanyEndDate => _driver.XPath("(.//input[@name ='bday'])[3]");
        private IWebElement CurrentCompanyJoinDate => _driver.XPath("(.//input[@name ='bday'])[4]");
        private IWebElement Submit => _driver.LinkText("Submit"); 
        #endregion

        #region TestCase Methods
        public void Information2(string value, string value1, string value2, string value3, string value4, string value5)
        {
            LogMessage("Entering a vlaue into Previous Company Name", () => Input(PreviousCompanyName, value));
            LogMessage("Validating if Previous Company Name are Visible", () => AssertIsTrue(PreviousCompanyName.Displayed));

            LogMessage("Entering a vlaue into Current Company Name", () => Input1(CurrentCompanyName, value1));
            LogMessage("Validating if Current Company Name are Visible", () => AssertIsTrue(CurrentCompanyName.Displayed));

            LogMessage("Entering a Date of Birth", () => Input2(DateOfBirth, value2));
            LogMessage("Validating if DateOfBirth are Visible", () => AssertIsTrue(DateOfBirth.Displayed));

            LogMessage("Entering PreviousCompanyJoinDate", () => Input3(PreviousCompanyJoinDate, value3));
            LogMessage("Validating if PreviousCompanyJoinDate are Visible", () => AssertIsTrue(PreviousCompanyJoinDate.Displayed));

            LogMessage("Entering PreviousCompanyEndDate", () => Input3(PreviousCompanyEndDate, value4));
            LogMessage("Validating if PreviousCompanyEndDate are Visible", () => AssertIsTrue(PreviousCompanyEndDate.Displayed));

            LogMessage("Entering CurrentCompanyJoinDate", () => Input3(CurrentCompanyJoinDate, value5));
            LogMessage("Validating if CurrentCompanyJoinDate are Visible", () => AssertIsTrue(CurrentCompanyJoinDate.Displayed));

        }
        

        public void Submission()
        {
            LogMessage("Entering Submit", () => MouseHover(Submit, _driver));
            LogMessage("Click on Submit", () => Click(Submit));
        }

        public void CheckBox1(string value, string value1, string value2, string value3)
        {
            LogMessage("Selecting 2+ tab", () => Input4(controlgroup, value));
            LogMessage("Entering a vlaue into 2+", () => Click(controlgroup));
            LogMessage("Validating if MR are Visible", () => AssertIsTrue(controlgroup.Displayed));

            LogMessage("Selecting QAWebmanual tab", () => Input3(QAWebManual, value1));
            LogMessage("Entering a vlaue into QAWebManual", () => Click(QAWebManual));
            LogMessage("Validating if MR are Visible", () => AssertIsTrue(QAWebManual.Displayed));

            LogMessage("Selecting  QMobileManual tab", () => Input3(QMobileManual, value2));
            LogMessage("Entering a vlaue into  QMobileManual", () => Click(QMobileManual));
            LogMessage("Validating if  QMobileManual are Visible", () => AssertIsTrue(QMobileManual.Displayed));

            LogMessage("Selecting QAMobileAutomation tab", () => Input3(QAMobileAutomation, value3));
            LogMessage("Entering a vlaue into  QAMobileAutomation", () => Click(QAMobileAutomation));
            LogMessage("Validating if  QAMobileAutomationare Visible", () => AssertIsTrue(QAMobileAutomation.Displayed));

        }
        #endregion
    }
}

