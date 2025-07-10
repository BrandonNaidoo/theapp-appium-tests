using AppiumTests.Utils;

using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTests.Framework
{
    public abstract class TestBase
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

            options.AddAdditionalAppiumOption("appPackage", "com.appiumpro.the_app");
            options.AddAdditionalAppiumOption("appActivity", ".MainActivity");
            options.AddAdditionalAppiumOption("appWaitActivity", ".MainActivity");

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
