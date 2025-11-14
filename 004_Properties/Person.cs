namespace _004_Properties
{
    class Person
    {
        string lastName;
        /*int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }*/


        public int Age {  get; set; }


        /*public void SetLastName(string LastName)
        {
            this.LastName = LastName;
        }
        public string GetLastName()
        {
            return this.LastName;
        }*/

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }

            
        }




        }
    }
