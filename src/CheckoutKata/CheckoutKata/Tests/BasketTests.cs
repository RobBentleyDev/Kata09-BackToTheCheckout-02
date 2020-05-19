using CheckoutKata.Code;
using FluentAssertions;
using NUnit.Framework;

namespace CheckoutKata.Tests
{
    public class BasketTests
    {
        [Test]
        public void TwoEmptyBasketTheSameShouldBeEqual()
        {
            var basket1 = new Basket();
            var basket2 = new Basket();

            basket1.Should().Be(basket2);
        }
        
        [Test]
        public void TwoBasketTheSameShouldBeEqual()
        {
            var basket1 = new Basket();
            basket1.Add(new ItemCode("A"));

            var basket2 = new Basket();
            basket2.Add(new ItemCode("A"));

            basket1.Should().Be(basket2);
        }

        [Test]
        public void RemoveLastItemFromBasketShouldLeaveBasketEmpty()
        {
            var basket1 = new Basket();
            basket1.Add(new ItemCode("A"));

            var basket2 = new Basket();

            basket1.RemoveNext();

            basket1.Should().Be(basket2);
        }
    }
}
