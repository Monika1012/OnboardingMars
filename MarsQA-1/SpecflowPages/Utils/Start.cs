using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {
       
        [BeforeScenario]
        public void Setup()
        {
            CommonMethods.ExtentReports();

            test = Extent.StartTest(TestContext.CurrentContext.Test.Name);
            var basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SpecflowTests", "Data");
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(basePath + @"/Mars.xlsx", "Credentials");
            //call the SignIn class
            SignIn.SigninStep();
        }

        [AfterScenario]
        public void TearDown()
        {
            
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            
           test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            Close();
            // end test. (Reports)
            CommonMethods.Extent.EndTest(test);
            
            // calling Flush writes everything to the log file (Reports)
            CommonMethods.Extent.Flush();
           

        }
    }
}
