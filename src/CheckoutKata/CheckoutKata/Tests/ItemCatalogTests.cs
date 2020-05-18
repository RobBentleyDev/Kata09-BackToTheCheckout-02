using CheckoutKata.Code;
using FluentAssertions;
using NUnit.Framework;

namespace CheckoutKata.Tests
{
    public class ItemCatalogTests
    {
        [Test]
        public void TwoEmptyItemCatalogsTheSameShouldBeEqual()
        {
            var itemCatalog1 = new ItemCatalog();
            var itemCatalog2 = new ItemCatalog();

            itemCatalog1.Should().Equal(itemCatalog2);
        }

        [Test]
        public void TwoItemCatalogsTheSameShouldBeEqual()
        {
            var itemCatalog1 = new ItemCatalog()
            {
                {new ItemCode("A"), new Money(50)}
            };
            var itemCatalog2 = new ItemCatalog()
            {
                {new ItemCode("A"), new Money(50)}
            };

            itemCatalog1.Should().Equal(itemCatalog2);
        }

        [Test]
        public void TwoDifferentItemCatalogsShouldNotBeEqual()
        {
            var itemCatalog1 = new ItemCatalog()
            {
                {new ItemCode("A"), new Money(50)}
            };
            var itemCatalog2 = new ItemCatalog()
            {
                {new ItemCode("B"), new Money(30)}
            };

            itemCatalog1.Should().NotEqual(itemCatalog2);
        }

        [Test]
        public void PriceOfItemIsReturnedForExistingItem()
        {
            var itemCatalog = new ItemCatalog()
            {
                {new ItemCode("A"), new Money(50)},
                {new ItemCode("B"), new Money(30)}
            };

            itemCatalog.PriceOf(new ItemCode("A")).Should().Be(new Money(50));
        }
    }
}
