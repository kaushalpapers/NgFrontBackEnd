using Employees.Models;
using System;
using System.Collections.Generic;

namespace EmployeesPortal.Repository
{

    public interface IDepartmentsRepository
    {

        IEnumerable<Department> getDepartmentsList();

    }

    public class DepartmentsRepository : IDepartmentsRepository
    {

        public static List<Department> Departments = new List<Department>(){
        new Department(1, "Accounts"),
        new Department(2, "Sales"),
        new Department(3, "IT")};

        public DepartmentsRepository() {


        }

        public IEnumerable<Department> getDepartmentsList() {

            return Departments;
        }


    }
}
