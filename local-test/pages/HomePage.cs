using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Appium.PageObjects;
using System;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.PageObjects.Attributes;

namespace android.local_test.pages
{
    class HomePage
    {
        [FindsByAndroidUIAutomator(XPath = "//android.widget.TextView[@content-desc='Accessibility']")]
        public IWebElement AccessibilityOpt1;
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this, new AppiumPageObjectMemberDecorator());
        }
    }
}
