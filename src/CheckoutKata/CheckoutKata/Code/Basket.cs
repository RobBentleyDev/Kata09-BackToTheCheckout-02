using System.Collections;
using System.Collections.Generic;

namespace CheckoutKata.Code
{
    public class Basket : IEnumerable<ItemCode>
    {
        private readonly Queue<ItemCode> _itemCodes;

        public Basket()
        {
            _itemCodes = new Queue<ItemCode>();
        }

        public void Add(ItemCode itemCode)
        {
            _itemCodes.Enqueue(itemCode);
        }

        public ItemCode RemoveNext()
        {
            return _itemCodes.Dequeue();
        }

        protected bool Equals(Basket other)
        {
            return Equals(_itemCodes, other._itemCodes);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Basket)obj);
        }

        public override int GetHashCode()
        {
            return (_itemCodes != null ? _itemCodes.GetHashCode() : 0);
        }

        public IEnumerator<ItemCode> GetEnumerator()
        {
            return _itemCodes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}