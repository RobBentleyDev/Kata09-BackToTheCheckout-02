namespace CheckoutKata.Code
{
    public class Checkout
    {
        private readonly ItemCatalog _itemCatalog;
        private readonly ScannedItems _scannedItems;

        public Checkout()
        {
            _itemCatalog = new ItemCatalog
            {
                {new ItemCode("A"), new Money(50)},
                {new ItemCode("B"), new Money(30)},
                {new ItemCode("C"), new Money(20)},
                {new ItemCode("D"), new Money(15)}
            };

            _scannedItems = new ScannedItems();
        }

        internal void Scan(Basket basket)
        {
            while (basket.HasItems())
            {
                Scan(basket.RemoveNext());
            }
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
                total.Add(_itemCatalog.PriceOf(item));
            }

            total.Subtract(TotalDiscountGiven());

            return total;
        }

        private Money TotalDiscountGiven()
        {
            if (_scannedItems.CountOf(new ItemCode("A")) == 3)
            {
                return new Money(20);
            }
            if (_scannedItems.CountOf(new ItemCode("B")) == 2)
            {
                return new Money(15);
            }
            return new Money(0);
        }
    }
}