namespace CheckoutKata.Code
{
    public class ItemCode
    {
        private readonly string _itemCode;

        public ItemCode(string itemCode)
        {
            _itemCode = itemCode;
        }

        protected bool Equals(ItemCode other)
        {
            return _itemCode == other._itemCode;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ItemCode)obj);
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