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

        [Then(@"Main page has correct title")]
        public void ThenMainPageHasCorrectTitle()
        {
            var title = _websitePageObject.GetTitle();
            Assert.AreEqual(title, "Usługi inżynierii aplikacji cyfrowych");
            
        }

        [When(@"I click on (.*) tab")]
        public void WhenIClickOnTab(string tabId)
        {
            var searchedTab = _websitePageObject.GetTabFromMenu(tabId);
            searchedTab.Click();
        }

        [Then(@"Url contains (.*) keyword")]
        public void ThenUrlContainsKeyword(string keyword)
        {
            var url = _websitePageObject.GetCurrentUrl();
            Assert.That(url.Contains(keyword));
        }

        [Then(@"Title contains (.*) phrase")]
        public void ThenTitleContainsPhrase(string titlePhrase)
        {
            var title = _websitePageObject.GetTitle();
            Assert.That(title.Contains(titlePhrase));
        }

        [When(@"I type (.*) in searchbox")]
        public void WhenITypePhraseInSearchbox(string text)
        {
            var searchbox = _websitePageObject.GetSearchbox();
            searchbox.SendKeys(text);

            var submitButton = _websitePageObject.GetSubmitButton();
            submitButton.Click();
        }

        [Then(@"Number of results: (.*)")]
        public void ThenNumberOfResults(int results)
        {
            var numberOfResults = _websitePageObject.GetResults();
            Assert.That(numberOfResults.Equals(results));
        }

    }
}