using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;

namespace WebDriver.Chrome.Tests
{
    [TestFixture]
    public class ChromeDriverServiceTest
    {
        [TestCase(ChromiumDriverLogLevel.All, " --log-level=ALL")]
        [TestCase(ChromiumDriverLogLevel.Debug, " --log-level=DEBUG")]
        [TestCase(ChromiumDriverLogLevel.Info, " --log-level=INFO")]
        [TestCase(ChromiumDriverLogLevel.Off, " --log-level=OFF")]
        [TestCase(ChromiumDriverLogLevel.Severe, " --log-level=SEVERE")]
        [TestCase(ChromiumDriverLogLevel.Warning, " --log-level=WARNING")]
        public void ShouldAllowSettingLogLevel(ChromiumDriverLogLevel logLevel, string expectedArgument)
        {
            var service = ChromeDriverService.CreateDefaultService();
            service.LogLevel = logLevel;

            var clArgs = typeof(ChromeDriverService).GetProperty("CommandLineArguments", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(service);
            Assert.That(clArgs, Contains.Substring(expectedArgument));
        }

        [Test]
        public void ShouldNotSetLogLevelIfDefaultImplicit()
        {
            var service = ChromeDriverService.CreateDefaultService();

            var clArgs = typeof(ChromeDriverService).GetProperty("CommandLineArguments", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(service);
            Assert.That(clArgs, Does.Not.Contain("--log-level="));
        }

        [Test]
        public void ShouldNotSetLogLevelIfDefaultExplicit()
        {
            var service = ChromeDriverService.CreateDefaultService();
            service.LogLevel = ChromiumDriverLogLevel.Default;

            var clArgs = typeof(ChromeDriverService).GetProperty("CommandLineArguments", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(service);
            Assert.That(clArgs, Does.Not.Contain("--log-level="));
        }
    }
}
