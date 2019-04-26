using Employees.Models;
using EmployeesPortal.Repository;
using System;
using System.Collections.Generic;

namespace EmployessPortal.Services
{
    public class DepartmentServices
    {

        IDepartmentsRepository departmentRepository = new DepartmentsRepository();

        public IEnumerable<Department> getDepartments() {

            return this.departmentRepository.getDepartmentsList();

        }

    }
}
