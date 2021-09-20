using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models
{
    public class MockProjectsRepository : IProjectsRepository
    {
        public IEnumerable<Project> GetAllProjects()
        {
            List<Project> projects = new List<Project>()
            {
                new Project
                {
                    Id = 1,
                    Name = "Sample Project Name 1",
                    Description = "Sample project Description",
                    Employees = new List<Employee>{
                        new Employee
                        {
                            Id = 1,
                            Name = "Samesh Buddhika",
                            Designation = "SE"
                        },
                        new Employee
                        {
                            Id = 2,
                            Name = "Pamosha Wijesekera",
                            Designation = "QA"
                        }
                    },
                    Tasks = new List<Task>
                    {
                        new Task
                        {
                            Id = 1,
                            Name = "Sample Task Name 1"
                        },
                        new Task
                        {
                            Id = 2,
                            Name = "Sample Task Name 2"
                        }
                    },
                    Deadline = "2021-09-22"
                },
                 new Project
                {
                    Id = 1,
                    Name = "Sample Project Name 1",
                    Description = "Sample project Description",
                    Employees = new List<Employee>{
                        new Employee
                        {
                            Id = 1,
                            Name = "Samesh Buddhika",
                            Designation = "SE"
                        },
                        new Employee
                        {
                            Id = 2,
                            Name = "Pamosha Wijesekera",
                            Designation = "QA"
                        }
                    },
                    Tasks = new List<Task>
                    {
                        new Task
                        {
                            Id = 1,
                            Name = "Sample Task Name 1"
                        },
                        new Task
                        {
                            Id = 2,
                            Name = "Sample Task Name 2"
                        }
                    },
                    Deadline = "2021-09-22"
                },
                  new Project
                {
                    Id = 1,
                    Name = "Sample Project Name 1",
                    Description = "Sample project Description",
                    Employees = new List<Employee>{
                        new Employee
                        {
                            Id = 1,
                            Name = "Samesh Buddhika",
                            Designation = "SE"
                        },
                        new Employee
                        {
                            Id = 2,
                            Name = "Pamosha Wijesekera",
                            Designation = "QA"
                        }
                    },
                    Tasks = new List<Task>
                    {
                        new Task
                        {
                            Id = 1,
                            Name = "Sample Task Name 1"
                        },
                        new Task
                        {
                            Id = 2,
                            Name = "Sample Task Name 2"
                        }
                    },
                    Deadline = "2021-09-22"
                },
                   new Project
                {
                    Id = 1,
                    Name = "Sample Project Name 1",
                    Description = "Sample project Description",
                    Employees = new List<Employee>{
                        new Employee
                        {
                            Id = 1,
                            Name = "Samesh Buddhika",
                            Designation = "SE"
                        },
                        new Employee
                        {
                            Id = 2,
                            Name = "Pamosha Wijesekera",
                            Designation = "QA"
                        }
                    },
                    Tasks = new List<Task>
                    {
                        new Task
                        {
                            Id = 1,
                            Name = "Sample Task Name 1"
                        },
                        new Task
                        {
                            Id = 2,
                            Name = "Sample Task Name 2"
                        }
                    },
                    Deadline = "2021-09-22"
                },
            };
            return projects;
        }
    }
}
