using System.Collections.Generic;

namespace CourseStore.Core.Domain
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName}, {LastName}";
        public List<CourseTeacher> CourseTeachers { get; set; }
    }
}
