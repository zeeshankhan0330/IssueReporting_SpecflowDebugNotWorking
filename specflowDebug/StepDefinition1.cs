using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace specflowDebug
{
    [Binding]
    public sealed class StepDefinition1
    {
        private Utility util;
        public StepDefinition1(Utility util)
        {
            this.util = util;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            Console.WriteLine("DebugPoint_1");
            util.Test();
        }

    }
}
