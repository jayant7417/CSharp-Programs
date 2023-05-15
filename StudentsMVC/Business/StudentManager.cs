using StudentsMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentsMVC.Business
{
    public class StudentManager
    {
        public string _connection;
        public StudentManager()
        {
            _connection  = ConfigurationManager.ConnectionStrings["appDB"].ConnectionString;
        }
        public List<Student> StudentData(int courseid)
        {
            List<Student> students = new List<Student>();

            SqlConnection con = new SqlConnection(_connection);
            string querystring1 = "Select * from tblStudents where CourseId = @CourseId";
            string querystring2 = "Select * from tblStudents";
            con.Open();

            //Condition check
            SqlCommand cmd;
            if (courseid == 0)
                cmd = new SqlCommand(querystring2, con);
            else
            {
                cmd = new SqlCommand(querystring1, con);
                cmd.Parameters.Add("@CourseId", SqlDbType.Int).Value = courseid;
            }

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Student entity = new Student
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        City = (string)reader["City"]
                    };
                    students.Add(entity);
                }
            }

            return students;
        }
        public int UpdateStudent(Student obj)
        {
            int i;
            SqlConnection con = new SqlConnection(_connection);
            string querystring = "update tblStudents set Name= @StudentName, City= @City where Id = @StudentId";
            con.Open();

            //Condition check
            SqlCommand cmd = new SqlCommand(querystring, con);
            cmd.Parameters.Add("@StudentName", SqlDbType.NVarChar, 50).Value = obj.Name;
            cmd.Parameters.Add("@City", SqlDbType.NVarChar, 50).Value = obj.City;
            cmd.Parameters.Add("@StudentId", SqlDbType.Int).Value = obj.Id;
            i = cmd.ExecuteNonQuery();

            return i;
        }
        public int DeleteStudent(int id)
        {
            int i;
            SqlConnection con = new SqlConnection(_connection);
            string querystring = "delete from tblStudents where Id = @StudentId";
            con.Open();

            //Condition check
            SqlCommand cmd = new SqlCommand(querystring, con);
            cmd.Parameters.Add("@StudentId", SqlDbType.Int).Value = id;
            i = cmd.ExecuteNonQuery();

            return i;
        }
        public List<Course> CourseData()
        {
            List<Course> courses = new List<Course>();

            SqlConnection con = new SqlConnection(_connection);
            string querystring = "Select * from tblCourse";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Course entity = new Course
                    {
                        CourseId = (int)reader["CourseId"],
                        CourseName = (string)reader["CourseName"]
                    };
                    courses.Add(entity);
                }
            }

            return courses;
        }
    }
}