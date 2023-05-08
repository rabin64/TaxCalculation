using TaxCalculation;
using System;

namespace TaxCalculator.Test
{
    public class Tests
    {
        private CalculateTax _calculateTax;

        [SetUp]
        public void Setup()
        {
            _calculateTax = new CalculateTax();
        }

        [Test]
        public void TestScenario1()
        {

            double usualIncome = 400;
            double additionalIncome = 1500;
            double expectedTax = 240;
            double actualTax = _calculateTax.CalculateAdditionalTotalTax(usualIncome, additionalIncome);

            Assert.That(actualTax, Is.EqualTo(expectedTax));
        }

        [Test]
        public void TestScenario2()
        {

            double usualIncome = 1100;
            double additionalIncome = 7000;
            double expectedTax = 1715;
            double actualTax = _calculateTax.CalculateAdditionalTotalTax(usualIncome, additionalIncome);

            Assert.That(actualTax, Is.EqualTo(expectedTax));

        }
        [Test]
        public void TestNoAdditionalIncome()
        {

            double usualIncome = 3000;
            double additionalIncome = 0;
            double expectedTax = 0;
            double actualTax = _calculateTax.CalculateAdditionalTotalTax(usualIncome, additionalIncome);

            Assert.That(actualTax, Is.EqualTo(expectedTax));

        }

        [Test]
        public void TestNoUsualIncome()
        {

            double usualIncome = 0;
            double additionalIncome = 500;
            double expectedTax = 50;
            double actualTax = _calculateTax.CalculateAdditionalTotalTax(usualIncome, additionalIncome);

            Assert.That(actualTax, Is.EqualTo(expectedTax));

        }

    }
}