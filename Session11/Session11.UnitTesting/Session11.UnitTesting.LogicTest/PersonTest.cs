using Session11.UnitTesting.Logic;
using System;
using Xunit;

namespace Session11.UnitTesting.LogicTest
{
    public class PersonMother
    {
        public static Person GetFather()
        {
            return new Person
            {
                FirstName = "",
                LastName = "",
                HasChild = true,
                Gender = Gender.Mele
            };
        }

        public static Person GetMother()
        {
            return new Person
            {
                FirstName = "",
                LastName = "",
                HasChild = true,
                Gender = Gender.Female
            };
        }

        public static Person GetSarbazFarari()
        {
            return new Person
            {
                FirstName = "",
                LastName = "",
                Gender = Gender.Mele,
                MilitaryStatus = false,
                BirthDate = DateTime.Now.AddYears(-18)
            };
        }
    }


    public class PersonBuilder
    {

        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private Gender _gender;
        private bool _hasChild;
        private bool? _militaryStatus;
        public PersonBuilder()
        {

        }
        public PersonBuilder WithFirstName(string firstName)
        {
            this._firstName = firstName;
            return this;
        }
        public PersonBuilder WithLastName(string lastName)
        {
            this._lastName = lastName;
            return this;
        }
        public Person Build()
        {
            return new Person
            {
                BirthDate = _birthDate,
                FirstName = _firstName,
                Gender = _gender,
                HasChild = _hasChild,
                LastName = _lastName,
                MilitaryStatus = _militaryStatus
            };
        }
    }
    public class PersonTest
    {
        [Fact]
        public void CheckFather()
        {
            var father = PersonMother.GetFather();
        }

        [Fact]
        public void CheckMother()
        {
            var mother = PersonMother.GetMother();
        }

        [Fact]
        public void CheckSarbazFarari()
        {
            var sarbaz = PersonMother.GetSarbazFarari();
        }
    }
}
