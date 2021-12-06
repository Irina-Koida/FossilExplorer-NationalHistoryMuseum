using MyCalendarApp.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace MyCalendarApp.Steps
{
    [Binding]
    public class FossilTapAButtonSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AndroidDriver<AndroidElement> _androidDriver;
        private readonly FossilButton _fossilButton;

        public FossilTapAButtonSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _androidDriver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _fossilButton = new FossilButton(_androidDriver);
        }

        [When(@"I tap a ""(.*)"" button")]
        public void WhenITapAButton(string findFossilButton)
        {
            _fossilButton.TapFindFossil(findFossilButton);
        }

        [Then(@"I navigate to the map, to find a fossil")]
        public void ThenINavigateToTheMapToFindAFossil()
        {
            string mapPage = _fossilButton.MapPage();
            bool result = mapPage.Contains(mapPage);
            Assert.AreEqual(actual: result, expected: true);
        }

        [When(@"I tap ""(.*)"" button")]
        public void WhenITapButton(string mapButton)
        {
            _fossilButton.TapMapButton(mapButton);
        }

        [Then(@"I navigate to the map")]
        public void ThenINavigateToTheMap()
        {
            string mapPage = _fossilButton.MapPage();
            bool result = mapPage.Contains(mapPage);
            Assert.AreEqual(actual: result, expected: true);
        }

        [When(@"I tap the ""(.*)"" button")]
        public void WhenITapTheButton(string hubButton)
        {
            _fossilButton.TapHubButton(hubButton);
        }

        [Then(@"I navigate to the hub page")]
        public void ThenINavigateToTheHubPage()
        {
            string hubPage = _fossilButton.HubPage();
            bool result = hubPage.Contains(hubPage);
            Assert.AreEqual(actual: result, expected: true);
        }

        [When(@"I tap in ""(.*)"" button")]
        public void WhenITapInButton(string helpButton)
        {
            _fossilButton.TapHelpButton(helpButton);
        }

        [Then(@"I navigate to the help page, where it is written how to use this application")]
        public void ThenINavigateToTheHelpPageWhereItIsWrittenHowToUseThisApplication()
        {
            string helpPage = _fossilButton.HelpPage();
            bool result = helpPage.Contains(helpPage);
            Assert.AreEqual(actual: result, expected: true);
        }

        [When(@"Tap the ""(.*)"" button")]
        public void WhenTapTheButton(string moreButton)
        {
            _fossilButton.TapMoreButton(moreButton);
        }

        [Then(@"Navigate to the content page")]
        public void ThenNavigateToTheContentPage()
        {
            string contentPage = _fossilButton.ContentPage();
            bool result = contentPage.Contains(contentPage);
            Assert.AreEqual(actual: result, expected: true);
        }
    }
}
