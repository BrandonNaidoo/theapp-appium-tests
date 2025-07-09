using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;

namespace AppiumTests.Pages
{
    public class HomePage
    {
        private readonly AndroidDriver driver;

        public HomePage(AndroidDriver driver)
        {
            this.driver = driver;
        }

        public bool IsMenuItemPresent(string label) =>
          ElementExists(By.XPath($"//android.widget.TextView[@text='{label}']"));

        public bool IsMenuItemDescriptionPresent(string description) =>
          ElementExists(By.XPath($"//android.widget.TextView[@text='{description}']"));

        private bool ElementExists(By by)
        {
            try
            {
                return driver.FindElement(by).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void TapMenuItem(string labelText)
        {
            driver.FindElement(By.XPath($"//*[@text='{labelText}']")).Click();
        }
    }
}
