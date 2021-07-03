using Educational_Form;
using EF_Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test.TestCases
{
    [TestFixture]
    public class DemoChartTextCases : BaseTest
    {

        [Test]
        public void VerifiyEducationInformationForm()
        {
            try
            {
                LogMessage("Navigate To Url", () => NavigateToUrl("https://testzenlabs.ie/education-form/", Driver));

                var pgDemoChart = Page<DemoChart>(Driver);

                LogMessage("Invoking Information Method ", () => pgDemoChart.Information1("JPNV", "SFJV", "JrSFJV", "RSCOE", "TUD"));
                LogMessage("Invoking Percentage", () => pgDemoChart.Percentage());
                LogMessage("Invoking Offset", () => pgDemoChart.ClickAndHold());
                LogMessage("Selecting CheckBox Method", () => pgDemoChart.CheckBox("MR", "MRS", "Miss"));
                LogMessage("Close Browser", () => CloseBrowser(Driver));

            }

            catch (Exception)
            {
                LogMessage("Close Browser", () => CloseBrowser(Driver));
            }
        }

        [Test]

        public void VerifiyGeneralInformationForm()
        {
            try
            {
                LogMessage("Navigate To Url", () => NavigateToUrl("https://testzenlabs.ie/general-information-form/", Driver));

                var pgDemoChart = Page<DemoChart>(Driver);

                LogMessage("Invoking Information Method ", () => pgDemoChart.Information("Amit", "Jaywant", "Ghodke", "0899802982"));
                LogMessage("Invoking DropDown Method", () => pgDemoChart.Address("26", "Belmont Avenue", "Dublin", "D04FK37"));
                LogMessage("Invoking CheckBoxes", () => pgDemoChart.CheckBox("Male", "Female", "Minor", "Major"));            
                LogMessage("Invoking Continent Method ", () => pgDemoChart.Continent());
                LogMessage("Invoking SingleClick Method ", () => pgDemoChart.Singleclick());
                LogMessage("Invoking DropDown", () => pgDemoChart.DropDown());




                LogMessage("Close Browser", () => CloseBrowser(Driver));

            }

            catch (Exception)
            {
                LogMessage("Close Browser", () => CloseBrowser(Driver));
            }

        }

        [Test]
        public void VerifiyJobInformationForm()
        {
            try
            {
                LogMessage("Navigate To Url", () => NavigateToUrl("https://testzenlabs.ie/job-details-form/", Driver));

                var pgDemoChart = Page<DemoChart>(Driver);

                LogMessage("Invoking Information Method ", () => pgDemoChart.Information2("QT", "IC", "01091992", "13092016", "07072018", "28072021"));
                LogMessage("Invoking Submission Method", () => pgDemoChart.Submission());

                LogMessage("Selecting CheckBox Method", () => pgDemoChart.CheckBox1("control-group", "QAWebManul", "QMobileManual", "QAMobileAutomation"));

                LogMessage("Close Browser", () => CloseBrowser(Driver));

            }

            catch (Exception)
            {
                LogMessage("Close Browser", () => CloseBrowser(Driver));
            }
        }


    }
}
