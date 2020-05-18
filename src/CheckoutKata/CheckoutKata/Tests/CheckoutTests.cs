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

            checkout.Scan("A");

            checkout.Total().Should().Be(50);
        }
    }
}