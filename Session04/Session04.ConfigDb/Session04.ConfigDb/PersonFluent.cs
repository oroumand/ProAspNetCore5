using System;

namespace Session04.ConfigDb
{
    public enum PersonType
    {
        Parent,
        Child,
        Student
    }

    public class NationalCode
    {
        public string Value { get; private set; }
        public NationalCode(string nationalCode)
        {
            //checking SSN
            Value = nationalCode;
        }
    }
    public class PersonName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class PersonFluent
    {
        public int Id { get; set; }
        public PersonName Name { get; set; }
        public string FullName { get; set; }

        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public PersonType PersonType { get; set; }
        public string EncriptedText { get; set; }
        public NationalCode NationalCode { get; set; }
    }


    public class PersonFluentPk
    {
  
        public int MyPrimaryKey01 { get; set; }
        public int MyPrimaryKey02 { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
