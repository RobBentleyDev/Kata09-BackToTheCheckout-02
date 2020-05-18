using CheckoutKata.Code;
using FluentAssertions;
using NUnit.Framework;

namespace CheckoutKata.Tests
{
    public class MoneyTests
    {
        [Test]
        public void TwoMoneyTheSameShouldBeEqual()
        {
            var money1 = new Money(10);
            var money2 = new Money(10);

            money1.Should().Be(money2);
        }
        
        [Test]
        public void TwoDifferentMoneyTheSameShouldNotBeEqual()
        {
            var money1 = new Money(10);
            var money2 = new Money(20);

            money1.Should().NotBe(money2);
        }

        [Test]
        public void TwoMoneyAddedShouldBeSumOfBoth()
        {
            var money = new Money(10);

            money.Add(new Money(20));

            money.Should().Be(new Money(30));
        }
    }
}
