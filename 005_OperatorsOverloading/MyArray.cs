namespace _005_OperatorsOverloading
{
    class MyArray
    {
        public int[] Arr{ get; set; }
        public MyArray() { }
        public MyArray(int[] arr)
        {
            this.Arr = arr;
        }

        public int Length
        {
            get
            {
                return this.Arr.Length;
            }
        }

        public int this[int index]
        {
            get
            {
                return Arr[index];
            }
            set
            {
                if (index >= 0 && index < Arr.Length)
                {
                    Arr[index] = value;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine(string.Join(", ", this.Arr));
        }
        
        
    }
}
