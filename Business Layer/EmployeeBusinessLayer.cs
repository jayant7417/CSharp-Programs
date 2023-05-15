using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace Business_Layer
{
    public class EmployeeBusinessLayer
    {
        public static string connstring = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        
        public IEnumerable<Employee> Employees
        {
            get
            {
                List<Employee> employees = new List<Employee>();

                SqlConnection con = new SqlConnection(connstring);

                SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read()) {
                    Employee emp = new Employee();
                    emp.ID = (int)rd["Id"];
                    emp.Name = (string)rd["Name"];
                    emp.Gender = (string)rd["Gender"];
                    emp.City = (string)rd["City"];
                    emp.DateOfBirth = (DateTime)rd["DateOfBirth"];
                    if (!DBNull.Value.Equals(rd["ProfilePic"]))
                        emp.ImagePath = (string)rd["ProfilePic"];

                    else
                        emp.ImagePath = String.Empty;

                    employees.Add(emp);
                }
                return employees;
            }
        }

        public void EditEmployee(Employee employee)
        {
            SqlConnection con = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("spEditEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paramName = new SqlParameter();
            paramName.ParameterName = "@Name";
            paramName.Value = employee.Name;
            cmd.Parameters.Add(paramName);

            SqlParameter paramGender = new SqlParameter();
            paramGender.ParameterName = "@Gender";
            paramGender.Value = employee.Gender;
            cmd.Parameters.Add(paramGender);

            SqlParameter paramCity = new SqlParameter();
            paramCity.ParameterName = "@City";
            paramCity.Value = employee.City;
            cmd.Parameters.Add(paramCity);

            SqlParameter paramDOB = new SqlParameter();
            paramDOB.ParameterName = "@DateOfBirth";
            paramDOB.Value = employee.DateOfBirth;
            cmd.Parameters.Add(paramDOB);

            SqlParameter paramId = new SqlParameter();
            paramId.ParameterName = "@Id";
            paramId.Value = employee.ID;
            cmd.Parameters.Add(paramId);

            con.Open();
            int i = cmd.ExecuteNonQuery();
        }

        public void DeleteEmployee(int id)
        {
            SqlConnection con = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("spDeleteEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paramID = new SqlParameter();
            paramID.ParameterName = "@ID";
            paramID.Value = id;
            cmd.Parameters.Add(paramID);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public Employee EmployeeDetails(int id)
        {
            SqlConnection con = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("spEmployeeDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paramID = new SqlParameter();
            paramID.ParameterName = "@ID";
            paramID.Value = id;
            cmd.Parameters.Add(paramID);

            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            Employee emp = new Employee();

            while (rd.Read())
            {
                emp.ID = (int)rd["Id"];
                emp.Name = (string)rd["Name"];
                emp.Gender = (string)rd["Gender"];
                emp.City = (string)rd["City"];
                emp.DateOfBirth = (DateTime)rd["DateOfBirth"];
                if (!DBNull.Value.Equals(rd["ProfilePic"]))
                    emp.ImagePath = (string)rd["ProfilePic"];

                else
                    emp.ImagePath = String.Empty;
            }

            return emp;
        }

        public void UploadImage(Employee employee)
        {
            SqlConnection con = new SqlConnection(connstring);

            SqlCommand cmd = new SqlCommand("spUploadImage", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paramId = new SqlParameter();
            paramId.ParameterName = "@Id";
            paramId.Value = employee.ID;
            cmd.Parameters.Add(paramId);

            if (employee.ProfilePic != null)
            {
                SqlParameter paramProfilePic = new SqlParameter();
                paramProfilePic.ParameterName = "@ProfilePic";
                paramProfilePic.Value = employee.ImagePath;
                cmd.Parameters.Add(paramProfilePic);
            }
            else
            {
                SqlParameter paramProfilePic = new SqlParameter();
                paramProfilePic.ParameterName = "@ProfilePic";
                paramProfilePic.Value = null;
                cmd.Parameters.Add(paramProfilePic);
            }

            con.Open();
            int i = cmd.ExecuteNonQuery();
        }

    }
}
