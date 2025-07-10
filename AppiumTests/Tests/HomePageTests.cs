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
                    var container = homePage.GetMenuItem(item.Label);

                    var labelText = homePage.GetLabel(container, item.Label);
                    labelText.Should().Be(item.Label);

                    var descriptionText = homePage.GetDescription(container, item.Description);
                    descriptionText.Should().Be(item.Description);
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
