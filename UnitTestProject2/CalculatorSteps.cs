﻿using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example;

namespace UnitTestProject2
{
    [Binding]
    public class CalculatorSteps
    {
        private int result;
        private Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }
        [When(@"I press sub")]
        public void WhenIPressSub()
        {
            result = calculator.Sub();
        }
        [When(@"I press mul")]
        public void WhenIPressMul()
        {
            result = calculator.Mul();
        }
        [When(@"I press div")]
        public void WhenIPressDiv()
        {
            result = calculator.Div();
        }
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }       
    }
}
