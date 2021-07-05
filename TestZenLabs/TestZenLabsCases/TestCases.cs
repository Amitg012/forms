
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestZenLabsCore;
using TestZenLabsRepository;

namespace TestZenLabsCases
{
   [TestFixture]
    public class TestCases : TestPage
    {
        [Test]

        public void VerifyGeneralInformationForm1()
        {
            try
            {
                LogMessage("Navigate To Url", () => NavigateToUrl("https://testzenlabs.ie/general-information-form/", Driver));
  
                var pgGeneralInformation = Page<GeneralInformation>(Driver);

                LogMessage("Invoking Information Method ", () => pgGeneralInformation.Information("Amit", "Jaywant", "Ghodke", "0899802982"));
                LogMessage("Invoking DropDown Method", () => pgGeneralInformation.Address("26", "Belmont Avenue", "Dublin", "D04FK37"));
                LogMessage("Invoking CheckBoxes", () => pgGeneralInformation.CheckBox("Male", "Female", "Minor", "Major"));
                LogMessage("Invoking Continent Method ", () => pgGeneralInformation.Continent());
                //LogMessage("Invoking SwitchTo Method ", () => pgGeneralInformation.SwitchTo());
               // LogMessage("Invoking FileSelect Method ", () => pgGeneralInformation.FileSelect(@"C:Users.ghodk.OneDrive.Documents.Amitghodke_CV"));

                LogMessage("Invoking SingleClick Method ", () => pgGeneralInformation.Singleclick());
               //LogMessage("Invoking DropDown", () => pgGeneralInformation.DropDown());

                LogMessage("Close Browser", () => CloseBrowser(Driver));


            }
            catch (Exception)
            {
                LogMessage("Close Browser", () => CloseBrowser(Driver));
            }

        }
        [Test]
        public void VerifyEducationInformationForm2()
        {

            try
            {
                LogMessage("Navigate To Url", () => NavigateToUrl("https://testzenlabs.ie/education-form/", Driver));

                var pgEducationInformation = Page<EducationInformation>(Driver);

                LogMessage("Invoking Information Method ", () => pgEducationInformation.Information("JPNV", "SFJV", "JrSFJV", "RSCOE", "TUD"));
                LogMessage("Invoking Percentage", () => pgEducationInformation.Percentage());
                LogMessage("Invoking Offset", () => pgEducationInformation.ClickAndHold());
                LogMessage("Selecting CheckBox Method", () => pgEducationInformation.CheckBox("MR", "MRS", "Miss"));
                LogMessage("Close Browser", () => CloseBrowser(Driver));

            }

            catch (Exception)
            {
                LogMessage("Close Browser", () => CloseBrowser(Driver));
            }
        }

            [Test]
        public void VerifiyJobInformationForm3()
        {
            try
            {
                LogMessage("Navigate To Url", () => NavigateToUrl("https://testzenlabs.ie/job-details-form/", Driver));

                var pgJobDetails = Page<JobDetails>(Driver);

                LogMessage("Invoking Information Method ", () => pgJobDetails.Information("QT", "IC", "01091992", "13092016", "07072018", "28072021"));
                

                LogMessage("Selecting CheckBox Method", () => pgJobDetails.CheckBox("control-group", "QAWebManul", "QMobileManual", "QAMobileAutomation"));
                
                LogMessage("Invoking entering Data Method", () => pgJobDetails.AboutYou1("My Name is Amit Ghodke Currently Living in Dublin"));
                LogMessage("Invoking Submission Method", () => pgJobDetails.Submission());

                LogMessage("Close Browser", () => CloseBrowser(Driver));

            }

            catch (Exception)
            {
                LogMessage("Close Browser", () => CloseBrowser(Driver));
            }
        }
         
        }
       


        
        }
    

