using OpenQA.Selenium;
using System.Linq;

namespace GL_SDP.PageObjects
{
    public class PageObjectGlobalLogic
    {
        private const string GLUrl = "https://globallogic.com/pl/";

        public readonly IWebDriver _webDriver;

        public string GetTitle() => _webDriver.Title;
        public string GetCurrentUrl() => _webDriver.Url;

        public PageObjectGlobalLogic(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        
        public IWebElement GetTabFromMenu(string tabName)
        {
           var searchedTab = _webDriver.FindElement(By.Id(tabName));
            return searchedTab;
        }

        public IWebElement GetSearchbox()
        {
            var search = _webDriver.FindElement(By.ClassName("search"));
            var searchbox = search.FindElement(By.ClassName("form-control"));
            return searchbox;
        }

        public IWebElement GetSubmitButton()
        {
            var submitButton = _webDriver.FindElement(By.ClassName("btn-outline-secondary"));
            return submitButton;

        }

        public int GetResults()
        {
            var results = _webDriver.FindElement(By.Id("filter_data"));
            var numberOfResults = results.FindElements(By.ClassName("col-lg-4")).Count;
            return numberOfResults;
        }
                     
        public void EnsurePageIsOpened()
        {
            if (_webDriver.Url != GLUrl)
            {
                _webDriver.Url = GLUrl;
            }
        }

        public void MaximixeWindow()
        {
            _webDriver.Manage().Window.Maximize();
        }

        public void Close()
        {
            _webDriver.Quit();
        }

    }
}
