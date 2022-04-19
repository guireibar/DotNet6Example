using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private PrimeService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }

        [TestCase(@"case 1", Category = "Cat1, CatToIgnore")]
        [TestCase(@"case 2", Category = "Cat2, Cat3")]
        [Category("Cat4")]
        public void IsPrime_TestCaregories_1(string value)
        {
            var result = false;

            Assert.IsFalse(result, $"{value}");
        }

        [TestCase(@"case 1", Category = "CatToIgnore")]
        [TestCase(@"case 2", Category = "Cat2, Cat3")]
        [Category("Cat4")]
        public void IsPrime_TestCaregories_2(string value)
        {
            var result = false;

            Assert.IsFalse(result, $"{value}");
        }

        [Category("CatToIgnore")]
        public void IsPrime_TestCaregories_3(string value)
        {
            var result = false;

            Assert.IsFalse(result, $"{value}");
        }

    }
}