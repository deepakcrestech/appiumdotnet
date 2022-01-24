using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using BrowserStack;
using System.Runtime.InteropServices;
using System.Threading;

namespace android.local
{
	public class BrowserStackNUnitTest
	{
		protected AndroidDriver<AndroidElement> driver;
		protected string profile;
		protected string device;
		private Local browserStackLocal;

		public BrowserStackNUnitTest(string profile, string device)
		{
			this.profile = profile;
			this.device = device;
		}

		[SetUp]
		public void Init()
		{
			//it works like a haspmap in java, key value pair
			NameValueCollection caps = ConfigurationManager.GetSection("capabilities/" + profile) as NameValueCollection;
			NameValueCollection devices = ConfigurationManager.GetSection("environments/" + device) as NameValueCollection;

			AppiumOptions options = new AppiumOptions();

			foreach (string key in caps.AllKeys)
			{
                options.AddAdditionalCapability(key, caps[key]);
			}

			//foreach (string key in devices.AllKeys)
			//{
			//	options.AddAdditionalOption(key, devices[key]);
			//}

			//String username = Environment.GetEnvironmentVariable("BROWSERSTACK_USERNAME");
			//if (username == null)
			//{
			//	username = ConfigurationManager.AppSettings.Get("user");
			//}

			//String accesskey = Environment.GetEnvironmentVariable("BROWSERSTACK_ACCESS_KEY");
			//if (accesskey == null)
			//{
			//	accesskey = ConfigurationManager.AppSettings.Get("key");
			//}

			//options.AddAdditionalOption("browserstack.user", username);
			//options.AddAdditionalOption("browserstack.key", accesskey);

			//String appId = Environment.GetEnvironmentVariable("BROWSERSTACK_APP_ID");
			//if (appId != null)
			//{
			//	options.AddAdditionalOption("app", appId);
			//}

   //         // if the platform is Windows, enable local testing fropm within the test
			//// for Mac and GNU/Linux, run the local binary manually to enable local testing (see the docs)
			//if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
			//		&& options.ToCapabilities().HasCapability("browserstack.local")
			//		&& options.ToCapabilities().GetCapability("browserstack.local").ToString() == "true")
			//{
			//	browserStackLocal = new Local();
			//	List<KeyValuePair<string, string>> bsLocalArgs = new List<KeyValuePair<string, string>>() {
			//			new KeyValuePair<string, string>("key", accesskey)
			//	};
			//	browserStackLocal.start(bsLocalArgs);
			//}

			Uri uri = new Uri("http://" + ConfigurationManager.AppSettings.Get("server") + "/wd/hub/");
			driver = new AndroidDriver<AndroidElement>(uri, options, System.TimeSpan.FromSeconds(60));
			//driver.InstallApp("C:\\Users\\deepak\\Downloads\\ApiDemos-debug.apk");
			//driver.LaunchApp();
		}

		[TearDown]
		public void Cleanup()
		{
			driver.Quit();
			if (browserStackLocal != null)
			{
				browserStackLocal.stop();
			}
		}

	}
}
