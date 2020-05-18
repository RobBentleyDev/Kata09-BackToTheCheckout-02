using System.Collections;
using System.Collections.Generic;

namespace CheckoutKata.Code
{
    public class ScannedItems : IEnumerable<ItemCode>
    {
        private readonly List<ItemCode> _items;

        public ScannedItems()
        {
            _items = new List<ItemCode>();
        }

        public void Add(ItemCode itemCode)
        {
            _items.Add(itemCode);
        }

        public IEnumerator<ItemCode> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}