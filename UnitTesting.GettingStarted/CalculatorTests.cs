using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _testCalculator;

        [SetUp]
        public void TestSetup()
        {
            _testCalculator = new Calculator();
        }

        /*
        Test name method pattern: [Subject]_[Scenario] _[Result], where:
        Subject: is usually the name of the method under testing - "Add" in this case.
        Scenario: describes the circumstances that this test covers. For example
            GrantLoan_WhenCreditLessThan500_ReturnsFalse
        Result: describes the expected outcome of invoking the method under test
        */
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(1000, 1)]
        public void Add_Always_ReturnsExpectedResult(int lhs, int rhs)
        {
            #region Arrange
            int expectedResult = lhs + rhs;
            #endregion

            #region Act
            int actualResult = _testCalculator.Add(lhs, rhs);
            #endregion

            #region Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            #endregion
        }

        [TestCase(100, "Declined")]
        [TestCase(549, "Declined")]
        [TestCase(550, "Maybe")]
        [TestCase(674, "Maybe")]
        [TestCase(676, "We look forward to doing business with you!")]
        public void MakeCreditDecision_Always_ReturnsExpectedResult(int creditScore, string expectedResult)
        {
            #region Arrange
            #endregion

            #region Act
            string actualResult = _testCalculator.MakeCreditDecision(creditScore);
            #endregion

            #region Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
            #endregion
        }
    }
}
