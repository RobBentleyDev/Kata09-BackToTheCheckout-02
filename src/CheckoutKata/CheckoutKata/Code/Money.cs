namespace CheckoutKata.Code
{
    public class Money
    {
        private int _amount;

        public Money(int amount)
        {
            _amount = amount;
        }

        public void Add(Money amount)
        {
            _amount += amount._amount;
        }

        public void Subtract(Money amount)
        {
            _amount -= amount._amount;
        }

        protected bool Equals(Money other)
        {
            return _amount == other._amount;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Money)obj);
        }

        public override int GetHashCode()
        {
            return _amount;
        }

        public override string ToString()
        {
            return _amount.ToString();
        }
    }
}