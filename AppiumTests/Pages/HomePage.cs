using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTests.Pages
{
    public class HomePage
    {
        private readonly AndroidDriver driver;

        public HomePage(AndroidDriver driver)
        {
            this.driver = driver;
        }

        public AppiumElement GetMenuItem(string resourceId)
        {
            return driver.FindElement(MobileBy.AndroidUIAutomator(
              $"new UiScrollable(new UiSelector().scrollable(true))" +
              $".scrollIntoView(new UiSelector().resourceId(\"{resourceId}\"))"));
        }
        public string GetLabel(AppiumElement container, string expectedLabelText)
        {
            var label = container.FindElement(MobileBy.AndroidUIAutomator(
                $"new UiScrollable(new UiSelector().scrollable(true))" +
                $".scrollIntoView(new UiSelector().text(\"{expectedLabelText}\"))"));
            return label.Text;
        }

        public string GetDescription(AppiumElement container, string expectedDescriptionText)
        {
            var description = container.FindElement(MobileBy.AndroidUIAutomator(
                $"new UiScrollable(new UiSelector().scrollable(true))" +
                $".scrollIntoView(new UiSelector().text(\"{expectedDescriptionText}\"))"));
            return description.Text;
        }

        public void TapMenuItem(string labelText)
        {
            driver.FindElement(By.XPath($"//*[@text='{labelText}']")).Click();
        }
    }
}
