using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Core.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public int? ParenId { get; set; }
        public bool Is { get; set; }
        public List<Employee> Children { get; set; }
    }
}
