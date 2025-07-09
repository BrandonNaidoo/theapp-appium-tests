using AppiumTests.Framework;
using AppiumTests.Pages;
using AppiumTests.TestData;

using FluentAssertions;
using FluentAssertions.Execution;

using OpenQA.Selenium.Appium;

namespace AppiumTests.Tests
{
    public class HomePageTests : TestBase
    {
        private HomePage homePage;

        [SetUp]
        public async Task SetUp()
        {
            await base.Setup();
            homePage = new HomePage(driver);
        }

        [Test]
        public void Given_HomePage_When_Loaded_Then_Display_All_MenuItems()
        {
            using (new AssertionScope())
            {
                foreach (var item in HomePageMenuItems.All)
                {
                    var container = driver.FindElement(MobileBy.AndroidUIAutomator(
                      $"new UiSelector().resourceId(\"{item.Label}\")"));

                    // Find label text inside container by text
                    var label = container.FindElement(MobileBy.AndroidUIAutomator(
                      $"new UiSelector().text(\"{item.Label}\")"));

                    label.Text.Should().Be(item.Label);

                    // Find description text inside container by text
                    var description = container.FindElement(MobileBy.AndroidUIAutomator(
                      $"new UiSelector().text(\"{item.Description}\")"));

                    description.Text.Should().Be(item.Description);
                }
            }
        }

        [Test]
        public void Given_HomePage_When_EchoBox_MenuItem_Tapped_Then_Navigate_To_EchoBox_Screen()
        {
            homePage.TapMenuItem("Echo Box");

            var titleElement = driver.FindElement(MobileBy.AndroidUIAutomator("new UiSelector().text(\"Echo Screen\")"));
            titleElement.Text.Should().Be("Echo Screen");
        }
    }
}
