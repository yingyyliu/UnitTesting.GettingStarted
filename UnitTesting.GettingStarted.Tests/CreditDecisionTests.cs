using Moq;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.GettingStarted.CreditDecisionExample;

namespace UnitTesting.GettingStarted.Tests
{
    [TestFixture]
    public class CreditDecisionTests
    {
        #region Private Fields
        private Mock<ICreditDecisionService> _mockCreditDecisionService;
        private CreditDecision _systemUnderTest;
        #endregion

        [SetUp]
        public void Init()
        {
            _mockCreditDecisionService = new Mock<ICreditDecisionService>(MockBehavior.Strict);
            _systemUnderTest = new CreditDecision(_mockCreditDecisionService.Object);
        }

        [TearDown]
        public void CleanUp()
        {
            _mockCreditDecisionService = null;
            _systemUnderTest = null;
        }

        #region Tests

        [TestCase(100, "Declined")]
        [TestCase(549, "Declined")]
        [TestCase(550, "Maybe")]
        [TestCase(674, "Maybe")]
        [TestCase(676, "We look forward to doing business with you!")]
        public void MakeCreditDecision_Always_ReturnsExpectedResult(int creditScore, string expectedResult)
        {
            #region Arrange
            _mockCreditDecisionService.Setup(p => p.GetCreditScore()).Returns(creditScore);


            #endregion

            #region Act
            string result = _systemUnderTest.MakeCreditDecision();
            #endregion

            #region Assert
            Assert.That(result, Is.EqualTo(expectedResult));

            _mockCreditDecisionService.VerifyAll();
            #endregion
        }


        [TestCase(576, "We look forward to doing business with you!")]
        public void MakeCreditDecision_Always_NotReturnsExpectedResult(int creditScore, string expectedResult)
        {
            #region Arrange
            _mockCreditDecisionService.Setup(p => p.GetCreditScore()).Returns(creditScore);

            #endregion

            #region Act
            string result = _systemUnderTest.MakeCreditDecision();
            #endregion

            #region Assert
            Assert.That(result, Is.Not.EqualTo(expectedResult));

            _mockCreditDecisionService.VerifyAll();
            #endregion
        }

        #endregion
    }
}
