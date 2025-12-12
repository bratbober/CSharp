namespace _012_Task
{
     class Person
    {
        public EventHandler<ShopEventArgs> ShopEvemt;
        public string Name { get; set; }
        public int Age { get; set; }

        public void Buy()
        {
            ShopEvemt?.Invoke(this, new ShopEventArgs { Age = this.Age});
        }
    }
}
