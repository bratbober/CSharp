using System.Diagnostics.SymbolStore;

namespace _005_OperatorsOverloading
{
    class Laptop
    {
        public string Vendor {  get; set; }
        public double Price { get; set; }

        public Laptop()
        {
            
        }
        public Laptop(string vendor, double price)
        {
            this.Vendor = vendor;
            this.Price = price;
        }



         public override string ToString()
        {
           return $"Vendor: {Vendor}, Price: {Price}" ;
        }
    }
}
