using System.Collections.Generic;

namespace CheckoutKata.Code
{
    public class Checkout
    {
        private readonly Dictionary<ItemCode, Money> _itemCatalog;
        private readonly List<ItemCode> _scannedItems;

        public Checkout()
        {
            _itemCatalog = new Dictionary<ItemCode, Money>
            {
                {new ItemCode("A"), new Money(50)},
                {new ItemCode("B"), new Money(30)}
            };

            _scannedItems = new List<ItemCode>();
        }

        public void Scan(ItemCode itemCode)
        {
            _scannedItems.Add(itemCode);
        }

        public Money Total()
        {
            var total = new Money(0);

            foreach (var item in _scannedItems)
            {
                total.Add(_itemCatalog[item]);
            }

            return total;
        }
    }
}