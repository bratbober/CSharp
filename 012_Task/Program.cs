using _012_Task;

Person person = new Person() { Name = "John", Age = 17 };
Person person1 = new Person() { Name = "Jack", Age = 20 };

Shop shop = new Shop() { ShopName = "ATБ" };
person.ShopEvemt += shop.YesNo;
person1.ShopEvemt += shop.YesNo;
person.Buy();
person1.Buy();
