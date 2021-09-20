using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Task> Tasks { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public string Deadline { get; set; }
    }
}
