using OpenQA.Selenium;
using SpecFlowEnterpriseTechTest.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowEnterpriseTechTest.PageObjects
{
    public class W3schoolPage
    {
        IWebDriver driver;
        public W3schoolPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        private IWebElement login => driver.FindElement(By.Id(""));






        public void Clickloginbtn() => login.ClickElementViaJs(driver);

        public void NavigateToSite(string url) => driver.Navigate().GoToUrl(url);

    }
}
