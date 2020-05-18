using CheckoutKata.Code;
using FluentAssertions;
using NUnit.Framework;

namespace CheckoutKata.Tests
{
    public class ItemCodeTests
    {
        [Test]
        public void TwoItemCodesTheSameShouldBeEqual()
        {
            var itemCode1 = new ItemCode("A");
            var itemCode2 = new ItemCode("A");

            itemCode1.Should().BeEquivalentTo(itemCode2);
        }

        [Test]
        public void TwoDifferentItemCodesShouldNotBeEqual()
        {
            var itemCode1 = new ItemCode("A");
            var itemCode2 = new ItemCode("B");

            itemCode1.Should().NotBeEquivalentTo(itemCode2);
        }
    }
}
