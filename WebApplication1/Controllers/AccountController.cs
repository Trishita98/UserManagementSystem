using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.SqlClient;


namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con= new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void ConnectionString()
        {
            con.ConnectionString = "data source=10.50.18.16; database=training_db; integrated security=SSPI;";
        }

        public ActionResult Verify(Account acc)
        {
            ConnectionString();
            con.Open();
            
            com.Connection = con;
            com.CommandText = "select * from";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                return View();
            }
            else
            {
                return View();
            }
            con.Close();
        }
    }
}