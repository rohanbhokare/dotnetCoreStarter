using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Models
{
    public static class ModelBuilderExtension
    {
        public static void SeedEmployeeData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Paula",
                    Department = Dept.IT,
                    Email = "paula@xerox.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Charles",
                    Department = Dept.IT,
                    Email = "charles@google.com"
                }
            );
        }
    }
}
