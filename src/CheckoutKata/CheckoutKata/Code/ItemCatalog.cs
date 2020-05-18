using System.Collections;
using System.Collections.Generic;
using CheckoutKata.Code;

namespace CheckoutKata.Code
{
    public class ItemCatalog : IEnumerable<KeyValuePair<ItemCode, Money>>
    {
        private readonly Dictionary<ItemCode, Money> _itemCatalog;

        public ItemCatalog()
        {
            _itemCatalog = new Dictionary<ItemCode, Money>();
        }

        public void Add(ItemCode itemCode, Money itemPrice)
        {
            _itemCatalog.Add(itemCode, itemPrice);
        }

        public Money PriceOf(ItemCode itemCode)
        {
            return _itemCatalog[itemCode];
        }

        public IEnumerator<KeyValuePair<ItemCode, Money>> GetEnumerator()
        {
            return _itemCatalog.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}