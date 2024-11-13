using System;
using TechTalk.SpecFlow;

namespace TestLayer.Hooks
{
    [Binding]
    public class Hooks
    {
        // BeforeScenario hook to set up the browser session
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Setting up the browser session.");
        }

        // AfterScenario hook to tear down the browser session
        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Tearing down the browser session.");
        }
    }
}