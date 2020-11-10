using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiDemo.Models;
using Microsoft.AspNetCore.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace ApiDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        List<CEmployee> emp = new List<CEmployee>()
        {
            new CEmployee{EmployeeId=1,EmployeeName="Umesh",EmployeeAddress="Ballia"},
            new CEmployee{EmployeeId=2,EmployeeName="Ramesh",EmployeeAddress="Ballia"},
            new CEmployee{EmployeeId=3,EmployeeName="Ram",EmployeeAddress="Ballia"}
        };

        //[HttpGet]
        [HttpGet]
        public ActionResult<IEnumerable<CEmployee>> getEmployee()
        {
            //return emp;
            return new[]
            {
                new CEmployee { EmployeeName = "Ana" },
                new CEmployee { EmployeeName = "Felipe" },
                new CEmployee { EmployeeName = "Emillia" }
            };
        }
        //[HttpGet]
        //public IEnumerable<CEmployee> getEmployeeById(int Id)
        //{
        //    var Emp = from emp in getEmployee() where emp.EmployeeId.Equals(Id) select emp;
        //    return Emp.ToList<CEmployee>();
        //}
        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetAll()
        {
            return new[]
            {
            new Person { Name = "Ana" },
            new Person { Name = "Felipe" },
            new Person { Name = "Emillia" }
        };
        }
        public class Person
        {
            public string Name { get; set; }
        }
    }
}
