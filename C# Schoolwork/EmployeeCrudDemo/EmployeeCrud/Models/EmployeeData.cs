using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using DataAccessLayer;

namespace EmployeeCrud.Models
{
    public class EmployeeData
    {
        DataAccessBridge employeeDAL = new DataAccessBridge();

        /// <summary>
        /// Get all employees from Business Layer
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EmployeeInfo> GetAllEmployees()
        {
            return employeeDAL.GetAllEmployees();
        }

        /// <summary>
        /// Sending the data to business layer to add another employee to the database
        /// </summary>
        /// <param name="emp"></param>
        public void AddEmployee(EmployeeInfo emp)
        {
            employeeDAL.AddEmployee(emp);
        }
    }
}
