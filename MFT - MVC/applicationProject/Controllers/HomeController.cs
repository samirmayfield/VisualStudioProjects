using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
//using MySql.Data.MySqlClient;

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
        public ActionResult SignUp(string emailAddress, string password)
        {
            
            
            if (string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(password))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                //connects to created database
                string connectionString = @"Data Source=DESKTOP-DGRD2S8\SQLEXPRESS;Initial Catalog=CarInsurance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                //inserts names into table called SignUps, line 30 are the column names, line 31 are the captured text field paramters that are being passed through the method
                string queryString = @"INSERT INTO dbo.CarInsuranceData(firstName, lastName, emailAddress, date, carYear, carMake, carModel, anyDUI, speedingTickets, coverageType, quote) VALUES  
                                        (@email, @password, @wallet, @seed, @view, @api-user, @api-pass)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
          //          //adding paramters
          //          SqlCommand command = new SqlCommand(queryString, connection);
          //          command.Parameters.Add("@password", SqlDbType.VarChar);
          //          command.Parameters.Add("@email", SqlDbType.VarChar);
          //          command.Parameters.Add("@wallet", SqlDbType.VarChar);
          //          command.Parameters.Add("@seed", SqlDbType.VarChar);
          //          command.Parameters.Add("@view", SqlDbType.VarChar);
          //          command.Parameters.Add("@api-user", SqlDbType.VarChar);
          //          command.Parameters.Add("@api-pass", SqlDbType.VarChar);


          //          //giving values
          //          command.Parameters["@email"].Value = email;
          //          command.Parameters["@password"].Value = password;
          //          command.Parameters["@wallet"].Value = wallet;
          //          command.Parameters["@seed"].Value = seed;
          //          command.Parameters["@view"].Value = view;
          //          command.Parameters["@api-user"].Value = apiUser;
          //          command.Parameters["@api-pass"].Value = apiPass;
          //;
          //          //opens connection
          //          connection.Open();
          //          //executes query
          //          command.ExecuteNonQuery();                    
          //          //closes query
          //          connection.Close();

          //          ViewBag.firstName = firstName;
          //          ViewBag.lastName = lastName;
          //          ViewBag.emailAddress = emailAddress;
          //          ViewBag.Quote = quote;


                }
                return View("~/Views/Home/index.cshtml");
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