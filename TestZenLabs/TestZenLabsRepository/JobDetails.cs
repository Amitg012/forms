using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestZenLabsCore;

namespace TestZenLabsRepository
{
   public class JobDetails : MethodPage
    {
        public IWebDriver _driver = null;
        #region Constructor

        public JobDetails(IWebDriver driver)
        {
            _driver = driver;
        }
        #endregion

        #region Object Repository
        private IWebElement PreviousCompanyName => _driver.Css("input[placeholder='Previous Company Name']");
        private IWebElement CurrentCompanyName => _driver.Css("input[placeholder='Current Company Name']");

        private IWebElement Controlgroup => _driver.Css("#exp-2");
        private IWebElement QAWebManual => _driver.Css("#profession-0");
        private IWebElement QMobileManual => _driver.Css("#profession-3");
        private IWebElement QAMobileAutomation => _driver.XPath("(.//input[@id = 'profession-1'])[2]");
        private IWebElement DateOfBirth => _driver.XPath(".//div[@class ='kc-elm kc-css-443856 kc_text_block']//input[@name ='bday']");
        private IWebElement PreviousCompanyJoinDate => _driver.XPath("(.//input[@name ='bday'])[2]");
        private IWebElement PreviousCompanyEndDate => _driver.XPath("(.//input[@name ='bday'])[3]");
        private IWebElement CurrentCompanyJoinDate => _driver.XPath("(.//input[@name ='bday'])[4]");
        private IWebElement AboutYou => _driver.XPath(".//div[@class = 'kc-elm kc-css-205865 kc_text_block']/p/textarea");
        private IWebElement Submit => _driver.LinkText("Submit");
        #endregion

        #region TestCase Methods
        public void Information(string value, string value1, string value2, string value3, string value4, string value5)
        {
            LogMessage("Entering a vlaue into Previous Company Name", () => Input(PreviousCompanyName, value));
            LogMessage("Validating if Previous Company Name are Visible", () => AssertIsTrue(PreviousCompanyName.Displayed));

            LogMessage("Entering a vlaue into Current Company Name", () => Input1(CurrentCompanyName, value1));
            LogMessage("Validating if Current Company Name are Visible", () => AssertIsTrue(CurrentCompanyName.Displayed));

            LogMessage("Entering a Date of Birth", () => Input2(DateOfBirth, value2));
            LogMessage("Validating if DateOfBirth are Visible", () => AssertIsTrue(DateOfBirth.Displayed));

            LogMessage("Entering PreviousCompanyJoinDate", () => Input3(PreviousCompanyJoinDate, value3));
            LogMessage("Validating if PreviousCompanyJoinDate are Visible", () => AssertIsTrue(PreviousCompanyJoinDate.Displayed));

            LogMessage("Entering PreviousCompanyEndDate", () => Input4(PreviousCompanyEndDate, value4));
            LogMessage("Validating if PreviousCompanyEndDate are Visible", () => AssertIsTrue(PreviousCompanyEndDate.Displayed));

            LogMessage("Entering CurrentCompanyJoinDate", () => Input5(CurrentCompanyJoinDate, value5));
            LogMessage("Validating if CurrentCompanyJoinDate are Visible", () => AssertIsTrue(CurrentCompanyJoinDate.Displayed));

        }

        public void AboutYou1(string text)
        {
            LogMessage("Entering Data in TextBox", () => Input(AboutYou, text));
            LogMessage("Validating Text", () => AssertIsTrue(AboutYou.Displayed));

        }
        public void Submission()
        {
            LogMessage("Entering Submit", () => MouseHover(Submit, _driver));
            LogMessage("Click on Submit", () => Click(Submit));
        }

        public void CheckBox(string value, string value1, string value2, string value3)
        {



            LogMessage("Selecting 2+ tab", () => Input(Controlgroup, value));
            LogMessage("Entering a vlaue into 2+", () => Click(Controlgroup));
            LogMessage("Validating if MR are Visible", () => AssertIsTrue(Controlgroup.Displayed));

            LogMessage("Selecting QAWebmanual tab", () => Input1(QAWebManual, value1));
            LogMessage("Entering a vlaue into QAWebManual", () => Click(QAWebManual));
            LogMessage("Validating if MR are Visible", () => AssertIsTrue(QAWebManual.Displayed));

            LogMessage("Selecting  QMobileManual tab", () => Input2(QMobileManual, value2));
            LogMessage("Entering a vlaue into  QMobileManual", () => Click(QMobileManual));
            LogMessage("Validating if  QMobileManual are Visible", () => AssertIsTrue(QMobileManual.Displayed));

            LogMessage("Selecting QAMobileAutomation tab", () => Input3(QAMobileAutomation, value3));
            LogMessage("Entering a vlaue into  QAMobileAutomation", () => Click(QAMobileAutomation));
            LogMessage("Validating if  QAMobileAutomationare Visible", () => AssertIsTrue(QAMobileAutomation.Displayed));

        }
        #endregion
    }
}
