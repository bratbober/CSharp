namespace _005_OperatorsOverloading
{
    class Shop
    {
        Laptop[] laptops;

        public Shop()
        {
            
        }
        public Shop(Laptop[] laptops)
        {
            this.laptops = laptops;
        }

        public override string ToString()
        {
            
            return string.Join("\n", laptops.Select(s => s.ToString()).ToArray());
        }
        public Laptop this[int index]
        {
            get
            {
                return laptops[index];
            }
            set
            {
                if (index >= 0 && index < laptops.Length)
                {
                    laptops[index] = value;
                }
            }
        }
        public int FindIndexByVendor(string vendors)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Vendor == vendors) return i;
            }
            return -1;
        }
        public Laptop this[string vendors]
        {
            get
            {
                int index = FindIndexByVendor(vendors);
                    return laptops[index];
            }

        }

        public int FindIndexByPrice(double price)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == price) return i;
            }
            return -1;
        }

        public Laptop this[double price]
        {
            get
            {
                int index = FindIndexByPrice(price);
                return laptops[index];
            }

        }
    }
}
