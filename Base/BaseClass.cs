using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Westpac_Assessment.Config;
using static Westpac_Assessment.Helpers.Drivers;

namespace Westpac_Assessment.Base
{
    public class BaseClass
    {
        //public static int Browser = Int32.Parse(BuggyResources.Browser);
        public static string path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
        public static string Screenshot = path + "\\" + BuggyResources.ScreenShot;
        public static string ExcelPath = path + "\\" + BuggyResources.Excel;
        public string BaseUrl = "https://buggy.justtestit.org/";

        public void Initialize()
        {
            //initialize browser
            InitializeBrowser();
            driver.Navigate().GoToUrl(BaseUrl);
        }
    }
}
