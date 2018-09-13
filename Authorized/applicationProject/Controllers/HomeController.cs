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
        public ActionResult SignUp(string firstName, string lastName, string emailAddress, string dateOfBirth, string carYear, string carMake, string carModel, string anyDUI, string speedingTickets, string coverageType)
        {
            
            DateTime date = new DateTime();            
            date = DateTime.Parse(dateOfBirth);
            int age = (
                Int32.Parse(DateTime.Today.ToString("yyyyMMdd")) -
                Int32.Parse(date.ToString("yyyyMMdd"))) / 10000;
            int carYearInt = Convert.ToInt32(carYear);
            int speedingTicketsInt = Convert.ToInt32(speedingTickets);
            int anyDUIInt = Convert.ToInt32(anyDUI);
            coverageType.ToLower();
            carMake.ToLower();
            carModel.ToLower();
            //AccountViewModel.quote = quote;
            double quote = 50;

            if (age < 25)
            {
                quote += 25;
            }
            if (age < 18)
            {
                quote += 100 ;
            }
            if (age > 100)
            {
                quote += 25;
            }
            if (carYearInt < 2000)
            {
                quote += 25;
            }
            if (carYearInt > 2015)
            {
                quote += 25;
            }
            if (carMake == "porsche")
            {
                quote += 25;
            }
            if (carMake == "porsche" && carModel == "911")
            {
                quote += 25;
            }
            if (speedingTicketsInt > 0)
            {
                quote += (speedingTicketsInt * 10) ;
            }
            if (anyDUIInt > 0)
            {
                quote = Convert.ToInt32(quote * 1.25);
                        }
            if (coverageType == "full coverage" || coverageType == "full")
            {
                quote = Convert.ToInt32(quote * 1.5);
            }
            ViewBag.Quote = quote;
            
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(anyDUI) || string.IsNullOrEmpty(speedingTickets) || string.IsNullOrEmpty(coverageType))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                //connects to created database
                string connectionString = @"Data Source=DESKTOP-DGRD2S8\SQLEXPRESS;Initial Catalog=CarInsurance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                //inserts names into table called SignUps, line 30 are the column names, line 31 are the captured text field paramters that are being passed through the method
                string queryString = @"INSERT INTO dbo.CarInsuranceData(firstName, lastName, emailAddress, date, carYear, carMake, carModel, anyDUI, speedingTickets, coverageType, quote) VALUES  
                                        (@firstName, @lastName, @emailAddress, @date, @carYear, @carMake, @carModel, @anyDUI, @speedingTickets, @coverageType, @quote)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //adding paramters
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@firstName", SqlDbType.VarChar);
                    command.Parameters.Add("@lastName", SqlDbType.VarChar);
                    command.Parameters.Add("@emailAddress", SqlDbType.VarChar);
                    command.Parameters.Add("@date", SqlDbType.VarChar);
                    command.Parameters.Add("@carYear", SqlDbType.VarChar);
                    command.Parameters.Add("@carMake", SqlDbType.VarChar);
                    command.Parameters.Add("@carModel", SqlDbType.VarChar);
                    command.Parameters.Add("@anyDUI", SqlDbType.VarChar);
                    command.Parameters.Add("@speedingTickets", SqlDbType.VarChar);
                    command.Parameters.Add("@coverageType", SqlDbType.VarChar);
                    command.Parameters.Add("@quote", SqlDbType.Money);

                    //giving values
                    command.Parameters["@firstName"].Value = firstName;
                    command.Parameters["@lastName"].Value = lastName;
                    command.Parameters["@emailAddress"].Value = emailAddress;
                    command.Parameters["@date"].Value = date;
                    command.Parameters["@carYear"].Value = carYear;
                    command.Parameters["@carMake"].Value = carMake;
                    command.Parameters["@carModel"].Value = carModel;
                    command.Parameters["@anyDUI"].Value = anyDUI;
                    command.Parameters["@speedingTickets"].Value = speedingTickets;
                    command.Parameters["@coverageType"].Value = coverageType;
                    command.Parameters["@quote"].Value = quote;
                    //opens connection
                    connection.Open();
                    //executes query
                    command.ExecuteNonQuery();                    
                    //closes query
                    connection.Close();


                   
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