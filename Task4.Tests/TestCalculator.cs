using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using Task4.Solution;

namespace Task4.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> _values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            Calculator calculator = new Calculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(_values, new Mean());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMeanDelegate()
        {
            Calculator calculator = new Calculator();
            Mean mean = new Mean();
            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(_values, mean.AveragingMethod);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            Calculator calculator = new Calculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(_values, new Median());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedianDelegate()
        {
            Calculator calculator = new Calculator();
            Median median = new Median();
            
            double expected = 8.0;

            double actual = calculator.CalculateAverage(_values, median.AveragingMethod);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Calculator1CallIDoubleAverange_ComputeAverangeMethod()
        {
            var doubleAverangeMock = new Mock<IAverageInterface>();
            var calculator = new Calculator();

            calculator.CalculateAverage(_values, doubleAverangeMock.Object);

            doubleAverangeMock.Verify(calc => calc.AveragingMethod(It.Is<List<double>>(list => list.SequenceEqual(_values))), Times.Once);
        }
    }
}