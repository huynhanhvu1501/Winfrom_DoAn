using Exercise_01.DAL;
using Exercise_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.BAL
{
    public class EmployeeBAL
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();
        public List<Employee>ReadAllEmployee()
        {
            List<Employee> lstEmployee = employeeDAL.ReadAllEmployee();
            return lstEmployee;
        }
        public void NewEmployee(Employee emp)
        {
            employeeDAL.NewEmployee(emp);
        }
        public void DeleteEmployee(Employee emp)
        {
            employeeDAL.DeleteEmployee(emp);
        }
        public void EditEmployee(Employee emp)
        {
            employeeDAL.EditEmployee(emp);
        }
    }
}
