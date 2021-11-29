using GL_SDP.Drivers;
using GL_SDP.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace GL_SDP.Steps
{
    [Binding]
    public sealed class GlobalLogicStepDefinitions
    {
        private readonly PageObjectGlobalLogic _websitePageObject;

        public GlobalLogicStepDefinitions(BrowserDriver browserDriver)
        {
            _websitePageObject = new PageObjectGlobalLogic(browserDriver.Current);
        }

    }
}