﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.Employees
{
    public class EmployeeDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public decimal hourlySalary { get; set; }
        public decimal monthlySalary { get; set; }
        public decimal Salary { get; set; }

    }
}
