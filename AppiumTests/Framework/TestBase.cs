using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using System;
using System.Threading.Tasks;
using AppiumTests.Utils;

namespace AppiumTests.Framework
{
    public class TestBase
    {
        protected AndroidDriver driver;

        [SetUp]
        public async Task Setup()
        {
            var apkPath = await ApkDownloader.DownloadApkAsync();

            var options = new AppiumOptions();
            options.PlatformName = "Android";
            options.DeviceName = "Android Emulator";
            options.AutomationName = "UiAutomator2";
            options.App = apkPath;

            driver = new AndroidDriver(new Uri("http://127.0.0.1:4723/"), options);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
