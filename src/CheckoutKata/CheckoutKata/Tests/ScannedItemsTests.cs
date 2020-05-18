using System;
using System.Text;
using CheckoutKata.Code;
using FluentAssertions;
using NUnit.Framework;

namespace CheckoutKata.Tests
{
    public class ScannedItemsTests
    {
        [Test]
        public void TwoEmptyScannedItemsTheSameShouldBeEqual()
        {
            var scannedItems1 = new ScannedItems();
            var scannedItems2 = new ScannedItems();

            scannedItems1.Should().Equal(scannedItems2);
        }

        [Test]
        public void TwoScannedItemsTheSameShouldBeEqual()
        {
            var scannedItems1 = new ScannedItems
            {
                new ItemCode("A")
            };
            var scannedItems2 = new ScannedItems
            {
                new ItemCode("A")
            }; 

            scannedItems1.Should().Equal(scannedItems2);
        }

        [Test]
        public void TwoDifferentScannedItemsShouldNotBeEqual()
        {
            var scannedItems1 = new ScannedItems
            {
                new ItemCode("A")
            };
            var scannedItems2 = new ScannedItems
            {
                new ItemCode("B")
            }; 

            scannedItems1.Should().NotEqual(scannedItems2);
        }
    }
}
