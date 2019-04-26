using System;

namespace Employees.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public Department(int id, string name) {
            this.DepartmentId = id;
            this.Name = name;
        }

    }
}
