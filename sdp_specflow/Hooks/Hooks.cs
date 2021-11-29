using BoDi;
using GL_SDP.Drivers;
using GL_SDP.PageObjects;
using TechTalk.SpecFlow;

namespace GL_SDP.Hooks
{
    public class SharedBrowserHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun(ObjectContainer testThreadContainer)
        {
            testThreadContainer.BaseContainer.Resolve<BrowserDriver>();
        }

        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var glPageObject = new PageObjectGlobalLogic(browserDriver.Current);
            glPageObject.EnsurePageIsOpened();
            glPageObject.MaximixeWindow();
        }
    }
}