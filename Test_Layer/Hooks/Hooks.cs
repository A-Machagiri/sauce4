using System;
using TechTalk.SpecFlow;

namespace TestLayer.Hooks
{
    [Binding]
    public class Hooks
    {
        // BeforeScenario will be run before the execution of each scenario
        [BeforeScenario]
        public void BeforeScenario()
        {
            // Setup code here (e.g., start a browser session)
        }

        // AfterScenario will be run after the execution of each scenario
        [AfterScenario]
        public void AfterScenario()
        {
            // Teardown code here (e.g., close the browser session)
        }
    }
}