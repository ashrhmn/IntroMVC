using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace IntroMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

            SqlConnection conn = new SqlConnection("Data Source=1.10.11.107;Initial Catalog=IntroMVP;Persist Security Info=True;User ID=sa;Password=mssql-2019");
            conn.Open();
            string query = "select * from students";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student student = new Student();
                student.ID = reader["ID"].ToString();
                student.Name = reader["Name"].ToString();
                student.Department = reader["Department"].ToString();
                students.Add(student);
            }
            return View(students);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Submit(Student s)
        {
            SqlConnection conn = new SqlConnection("Data Source=1.10.11.107;Initial Catalog=IntroMVP;Persist Security Info=True;User ID=sa;Password=mssql-2019");
            conn.Open();
            string query = "insert into students (id,name, department) values('" + s.ID + "','" + s.Name + "','" + s.Department + "')";
            SqlCommand cmd = new SqlCommand(query,conn);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return RedirectToAction("Index","Student");
        }
    }
}