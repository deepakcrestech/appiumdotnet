using System;
using System.Threading;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Appium;
using android.local_test.pages;
using OpenQA.Selenium.Appium.PageObjects;

namespace android.local
{
    [TestFixture("local", "pixel-3")]
    public class LocalTest : BrowserStackNUnitTest
    {
        HomePage homePage;
        // this is used to call the base contructor with given fixture params
        public LocalTest(string profile, string device) : base(profile, device) { }
        [Test]
        public void testLocal()
        {
            homePage = new HomePage(driver);

            //TimeOutDuration timeSpan = new TimeOutDuration(new TimeSpan(0, 0, 0, 5, 0));
            //PageFactory.InitElements(driver, homePage, new AppiumPageObjectMemberDecorator());
            homePage.AccessibilityOpt1.Click();

           // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           //wait.Until(SeleniumExtras.WaitHelpers.ExpectedCondition  )

            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(homePage.loginButton)));
            //searchElement.Click();
            //AndroidElement testElement = (AndroidElement) wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName("android.widget.TextView")));

            //ReadOnlyCollection<AndroidElement> allTextViewElements = driver.FindElements(By.ClassName("android.widget.TextView"));

            //Thread.Sleep(5000);

            //foreach (AndroidElement textElement in allTextViewElements)
            //{
            //    if (textElement.Text.Contains("The active connection is"))
            //    {
            //        Assert.True(textElement.Text.Contains("The active connection is wifi"),"Incorrect Text");        
            //    }
            //}

        }
    }
}
