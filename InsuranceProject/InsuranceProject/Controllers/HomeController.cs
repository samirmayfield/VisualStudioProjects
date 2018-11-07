using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //created signup function, automatically an integrated function for form returns
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                //connects to created database
                string connectionString = @"Data Source=DESKTOP-DGRD2S8\SQLEXPRESS;Initial Catalog=MFT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                //inserts names into table called SignUps, line 30 are the column names, line 31 are the captured text field paramters that are being passed through the method
                string queryString = @"INSERT INTO SignUps(firstName, lastName, EmailAddress) VALUES  
                                        (@firstName, @lastName, @emailAddress)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //adding paramters
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@firstName", SqlDbType.VarChar);
                    command.Parameters.Add("@lastName", SqlDbType.VarChar);
                    command.Parameters.Add("@emailAddress", SqlDbType.VarChar);
                    //giving values
                    command.Parameters["@firstName"].Value = firstName;
                    command.Parameters["@lastName"].Value = lastName;
                    command.Parameters["@emailAddress"].Value = emailAddress;
                    //opens connection
                    connection.Open();
                    //executes query
                    command.ExecuteNonQuery();
                    //closes query
                    connection.Close();

                    int Quote = 100;

                    ViewBag.newQuote = Quote;

                }
                return View("Success");
            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}