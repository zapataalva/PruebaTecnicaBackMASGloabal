using Business.Constants;
using Cross.Employees;
using DataAcess.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Employees
{
    public class EmployeeBM
    {
        public List<EmployeeDTO> GetAll(string name)
        { 
            EmployeeDM employeeDM = new EmployeeDM();
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            if (string.IsNullOrEmpty(name))
            {
                 employees = employeeDM.GetAll();
            }
            else
            {
                employees = employeeDM.GetAll()
                    .Where(x => (x.name.ToLower()).Contains(name.ToLower()))
                    .ToList();
            }
            
            foreach (var item in employees)
            {
                
                if (item.contractTypeName == Constant.HOURLY_SALARY_EMPLOYEE)
                {
                    item.Salary = (Constant.CIENTOVEINTE * item.hourlySalary * Constant.DOCE);
                }
                else
                {
                    item.Salary = ( item.monthlySalary * Constant.DOCE);
                }
            }
            return employees;
            
        }
    }
}
