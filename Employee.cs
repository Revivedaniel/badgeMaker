namespace CatWorx.BadgeMaker
{
    //This is the Employee class that will be used to store the data from the user
    class Employee
    {
        private string FirstName;
        private string LastName;
        private int Id;
        private string PhotoUrl;
        // In C#, a class's constructor method has the same name as its class
        public Employee(string firstname, string lastName, int id, string photoUrl)
        {
            FirstName = firstname;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }

        public string GetName()
        {
            return FirstName + " " + LastName;
        }
        public int GetId()
        {
            return Id;
        }
        public string GetPhotoUrl()
        {
            return PhotoUrl;
        }
        public string GetCompanyName()
        {
            return "Cat Worx";
        }
    }
}