using CheckoutKata.Code;
using FluentAssertions;
using NUnit.Framework;

namespace CheckoutKata.Tests
{
    public class CheckoutTests
    {

        // Item Unit      Special
        //      Price     Price
        // --------------------------
        // A     50       3 for 130
        // B     30       2 for 45
        // C     20
        // D     15

        [Test]
        public void GivenSingleProduct_WhenScanned_ThenTotalIsPriceOfProduct()
        {
            var checkout = new Checkout();

            checkout.Scan(new ItemCode("A"));

            checkout.Total().Should().Be(new Money(50));
        }

        [Test]
        public void GivenItemAAndItemB_WhenScanned_ThenTotalIsSumOfBothProducts()
        {
            var checkout = new Checkout();

            checkout.Scan(new ItemCode("A"));
            checkout.Scan(new ItemCode("B"));

            checkout.Total().Should().Be(new Money(80));
        }

        [Test]
        public void Given3Products_WhenScanned_ThenTotalIsSumOf3Products()
        {
            var checkout = new Checkout();

            checkout.Scan(new ItemCode("A"));
            checkout.Scan(new ItemCode("B"));
            checkout.Scan(new ItemCode("C"));

            checkout.Total().Should().Be(new Money(100));
        }

        [Test]
        public void Given4Products_WhenScanned_ThenTotalIsSumOf4Products()
        {
            var checkout = new Checkout();

            checkout.Scan(new ItemCode("A"));
            checkout.Scan(new ItemCode("B"));
            checkout.Scan(new ItemCode("C"));
            checkout.Scan(new ItemCode("D"));

            checkout.Total().Should().Be(new Money(115));
        }

        [Test]
        public void GivenABasketOf1Product_WhenScanned_ThenTotalIsPriceOfProduct()
        {
            var checkout = new Checkout();

            var basket = new Basket
            {
                new ItemCode("A")
            };

            checkout.Scan(basket);

            checkout.Total().Should().Be(new Money(50));
        }

        [Test]
        public void GivenABasketOf2Products_WhenScanned_ThenTotalIsSumOfBothProducts()
        {
            var checkout = new Checkout();

            var basket = new Basket
            {
                new ItemCode("A"),
                new ItemCode("B")
            };

            checkout.Scan(basket);

            checkout.Total().Should().Be(new Money(80));
        }

        [Test]
        public void GivenABasketOf3AProducts_WhenScanned_ThenTotalIsSpecialOfferPriceFor3()
        {
            var checkout = new Checkout();

            var basket = new Basket
            {
                new ItemCode("A"),
                new ItemCode("A"),
                new ItemCode("A")
            };

            checkout.Scan(basket);

            checkout.Total().Should().Be(new Money(130));
        }

        [Test]
        public void GivenABasketOf2BProducts_WhenScanned_ThenTotalIsSpecialOfferPriceFor2()
        {
            var checkout = new Checkout();

            var basket = new Basket
            {
                new ItemCode("B"),
                new ItemCode("B")
            };

            checkout.Scan(basket);

            checkout.Total().Should().Be(new Money(45));
        }
    }
}