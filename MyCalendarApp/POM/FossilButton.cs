using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace MyCalendarApp.POM
{
    class FossilButton
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public FossilButton(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }

        private readonly By _mapButton = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/" +
            "android.view.View/android.view.View/android.view.View[11]/android.view.View/android.widget.ListView/" +
            "android.view.View[1]/android.view.View");
        private readonly By _hubButton = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/" +
            "android.view.View/android.view.View[11]/android.view.View/android.widget.ListView/android.view.View[2]/" +
            "android.view.View");
        private readonly By _helpButton = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/" +
            "android.view.View/android.view.View[11]/android.view.View/android.widget.ListView/android.view.View[3]/" +
            "android.view.View");
        private readonly By _moreButton = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/" +
            "android.view.View/android.view.View[11]/android.view.View/android.widget.ListView/android.view.View[4]/" +
            "android.view.View");
        private readonly By _findFossilButton = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
           "android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/" +
           "android.view.View/android.view.View[10]");

        private readonly By _mapPage = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/" +
            "android.view.View/android.view.View[1]/android.view.View[2]");
        private readonly By _helpPage = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/" +
            "android.view.View/android.view.View[1]/android.view.View[2]");
        private readonly By _hubPage = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/" +
            "android.view.View/android.view.View[3]");
        private readonly By _contentPage = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/" +
            "android.view.View/android.view.View[1]/android.view.View[2]");

        public void TapFindFossil(string findFossilButton) =>
         _driver.FindElement(_findFossilButton).Click();

        public void TapMapButton(string mapButton) =>
        _driver.FindElement(_mapButton).Click();

        public void TapHubButton(string hubButton) =>
       _driver.FindElement(_hubButton).Click();

        public void TapHelpButton(string helpButton) =>
       _driver.FindElement(_helpButton).Click();

        public void TapMoreButton(string moreButton) =>
       _driver.FindElement(_moreButton).Click();

        public string MapPage() =>
            _driver.FindElement(_mapPage).Text;

        public string HubPage() =>
        _driver.FindElement(_hubPage).Text;

        public string HelpPage() =>
         _driver.FindElement(_helpPage).Text;

        public string ContentPage() =>
         _driver.FindElement(_contentPage).Text;
    }
}
