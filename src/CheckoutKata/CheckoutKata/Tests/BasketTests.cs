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

            basket1.Should().Equal(basket2);
        }
        
        [Test]
        public void TwoBasketTheSameShouldBeEqual()
        {
            var basket1 = new Basket
            {
                new ItemCode("A")
            };

            var basket2 = new Basket
            {
                new ItemCode("A")
            };

            basket1.Should().Equal(basket2);
        }

        [Test]
        public void RemoveLastItemFromBasketShouldLeaveBasketEmpty()
        {
            var basket1 = new Basket
            {
                new ItemCode("A")
            };

            var basket2 = new Basket();

            basket1.RemoveNext();

            basket1.Should().Equal(basket2);
        }
    }
}
