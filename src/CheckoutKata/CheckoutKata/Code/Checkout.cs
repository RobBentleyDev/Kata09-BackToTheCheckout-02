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
                {new ItemCode("C"), new Money(20)}
            };

            _scannedItems = new ScannedItems();
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

            return total;
        }
    }
}