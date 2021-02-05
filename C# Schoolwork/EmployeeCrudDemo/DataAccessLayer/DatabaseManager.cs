using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class DatabaseManager
    {
        //Define the class attributes
        public string dbEmployeeConnection { get; set; }

        public DatabaseManager()
        {
            this.dbEmployeeConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbEmployee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public IEnumerable<EmployeeInfo> GetAllEmployees()
        {
            List<EmployeeInfo> employeeList = new List<EmployeeInfo>();

            using (SqlConnection conn = new SqlConnection(dbEmployeeConnection))
            {
                //Set the SQL command to the stored procedures
                using (SqlCommand cmd = new SqlCommand("usp_GetAllEmployees", conn))
                {
                    //By setting the command type to StoredProcedure, the first parameter 
                    //to the SQL command will be interpreted as the name of a stored procedure
                    //(instead of interpreting it as a command string) which would typically be the sql query

                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    //Provides a way or reading a forward-only stream of rows from a SQL server
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        EmployeeInfo emp = new EmployeeInfo();
                        try
                        {
                            emp.EmployeeID = Convert.ToInt32(dataReader["EmployeeID"].ToString());
                        }
                        catch
                        {
                            emp.EmployeeID = 0;
                        }
                        emp.Name = dataReader["Name"].ToString();
                        emp.Gender = dataReader["Gender"].ToString();
                        emp.Company = dataReader["Company"].ToString();
                        emp.Department = dataReader["Department"].ToString();
                        employeeList.Add(emp);
                    }
                    //end of the while loop

                }
                //good practice to close connnection 
                conn.Close();
            }
            return employeeList;
        }

        /*public IEnumerable<EmployeeInfo> UpdateEmployee()
        {
            //Set the SQL command to the stored procedures

            using (SqlCommand cmd = new SqlCommand("usp_UpdateEmployee"))
            {

            }
        }*/

        /*public IEnumerable<EmployeeInfo> DeleteEmployee()
        {
            //Set the SQL command to the stored procedures

            using (SqlCommand cmd = new SqlCommand("usp_DeleteEmployee"))
            {

            }
        }*/

        public bool InsertEmployee(EmployeeInfo emp)
        {
            bool success = true;
            using (SqlConnection conn = new SqlConnection(dbEmployeeConnection))
            {
                //Set the SQL command to the stored 
                //if you don't want to use stored procedures, this is a second example
                // string insertCmd = @"INSERT INTO Employee (Name, Gender, Company, Department)
                //                      VALUES(@Name, @Gender, @Company, @Department";
                //SqlCommand cmd = new SqlCommand(insertCmd, conn)
                using (SqlCommand cmd = new SqlCommand("usp_InsertEmployee", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                    cmd.Parameters.AddWithValue("@Company", emp.Company);
                    cmd.Parameters.AddWithValue("@Department", emp.Department);

                    conn.Open();
                    //ExecuteNonQuery used for executing queries that do not return any data
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return success;
        }
    }
}