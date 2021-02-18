using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.ConfigDb
{
    public class Student
    {
        public int Id { get; set; }
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }


        private string _myBackingFieldForLastName;
        public string LastName
        {
            get
            {
                return _myBackingFieldForLastName;
            }
            set
            {
                _myBackingFieldForLastName = value;
            }
        }

        private string _studentNumber;
        public void SetStudentNumner(string studentNumber)
        {
            _studentNumber = studentNumber;
        }
        public string GetStudentNumner()
        {
            return _studentNumber;
        }
    }
}
