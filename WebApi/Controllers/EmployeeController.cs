using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Business.Employees;
using Cross.Employees;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebApi.Controllers
{

    [Route("[controller]")] 
    [ApiController]

    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("GetAllEmployees/{name}")]
        
        public ActionResult<List<EmployeeDTO>> GetAll(string name)
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            EmployeeBM employee = new EmployeeBM();

            return employee.GetAll(name);
        }

        [HttpGet]
        [Route("GetAllEmployees")]
        public ActionResult<List<EmployeeDTO>> GetAll()
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            EmployeeBM employee = new EmployeeBM();

            return employee.GetAll(null);
        }
    }
}