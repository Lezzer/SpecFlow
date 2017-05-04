using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlow.AcceptanceTests.Calculator.Add
{
    [Binding]
    public sealed class AddSteps
    {
        internal SpecFlow.Calculator.Calculator Calculator;

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            Calculator = new SpecFlow.Calculator.Calculator
            {
                FirstNumber = number
            };
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            Calculator.SecondNumber = number;
        }


        [When("I press add")]
        public void WhenIPressAdd()
        {
            Calculator.Add();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.That(Calculator.Result, Is.EqualTo(result));
        }
    }
}
