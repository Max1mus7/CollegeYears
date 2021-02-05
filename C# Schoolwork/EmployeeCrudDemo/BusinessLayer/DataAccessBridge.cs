using System;
using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLayer
{
    /// <summary>
    /// This class is like a conduit for the DataAccess Layer and the Presentation Layer
    /// </summary>
    public class DataAccessBridge
    {   
        public IEnumerable<EmployeeInfo> GetAllEmployees()
        {
            DatabaseManager database = new DatabaseManager();
            return database.GetAllEmployees();
        }

        /// <summary>
        /// pass the employee post data to our data access layer
        /// </summary>
        /// <param name="emp"></param>
        public void AddEmployee(EmployeeInfo emp)
        {
            DatabaseManager database = new DatabaseManager();
            bool success = database.InsertEmployee(emp);
        }
    }
}
