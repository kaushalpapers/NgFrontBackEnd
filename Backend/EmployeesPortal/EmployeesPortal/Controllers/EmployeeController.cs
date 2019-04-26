using EmployessPortal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmployeesPortal.Controllers
{
    [EnableCors(origins:"http://localhost:4200", headers: "*", methods: "*")]
    [RoutePrefix("employeesportal")]
    public class EmployeeController : ApiController
    {

        DepartmentServices departmentServices = new DepartmentServices();

        [HttpGet]
        [Route("getdepartments")]
        public HttpResponseMessage getDepartments() {

            return Request.CreateResponse(HttpStatusCode.OK, departmentServices.getDepartments());
        }

    }
}
