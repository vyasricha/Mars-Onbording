using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    public class Start : Driver
    {

        [BeforeScenario]
        public void setup()
        {
            //launch the browser
            Initialize();
            Thread.Sleep(5000);

            //call the SignIn class
            SignIn.SigninStep();
        }

        [AfterScenario]
        public void TearDown()
        {
            Thread.Sleep(500);
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));

            // end test. (Reports)
            CommonMethods.extent.EndTest(CommonMethods.test);

            // calling Flush writes everything to the log file (Reports)
            CommonMethods.extent.Flush();

            //Close the browser
            Close();

        }
    }
}
