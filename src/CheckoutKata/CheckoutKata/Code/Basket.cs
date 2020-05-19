namespace CheckoutKata.Code
{
    public class Basket
    {
        private ItemCode _itemCode;

        public void Add(ItemCode itemCode)
        {
            _itemCode = itemCode;
        }

        public ItemCode RemoveNext()
        {
            var returnItem = new ItemCode(_itemCode.ToString());
            _itemCode = null;
            return returnItem;
        }

        protected bool Equals(Basket other)
        {
            return Equals(_itemCode, other._itemCode);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Basket) obj);
        }

        public override int GetHashCode()
        {
            return (_itemCode != null ? _itemCode.GetHashCode() : 0);
        }

        public override string ToString()
        {
            return _itemCode.ToString();
        }
    }
}