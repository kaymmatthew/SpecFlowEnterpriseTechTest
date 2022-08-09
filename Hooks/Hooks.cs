﻿using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowEnterpriseTechTest.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowEnterpriseTechTest.Hooks
{
    [Binding]
    public sealed class Hooks : DriverHelper
    {
        IObjectContainer container;
        public Hooks(IObjectContainer _container)
        {
            container = _container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            container.RegisterInstanceAs<IWebDriver>(driver);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
        }

      

        [AfterScenario]
        public void AfterScenario()
        {
            driver?.Quit();
        }
    }
}