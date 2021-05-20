using System;

namespace Session11.UnitTesting.Logic
{
    public enum Gender
    {
        Mele,
        Female
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public bool HasChild { get; set; }
        public bool? MilitaryStatus { get; set; }
    }
}
