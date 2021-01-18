using Holiday_Booking_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EmployeeWebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    //http://stuiis.cms.gre.ac.uk/ka5054d/HolidayBookingSystem/EmployeeWebService/webservice.asmx
    public class WebService : System.Web.Services.WebService
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public bool Login(string username, string password)
        {

            //bool b = false;
            //var query = from emp in context.Employees
            //            where emp.Username == username
            //            && emp.Password == password
            //            && emp.is_admin == 0
            //            select emp;

            //if (query.Any())
            //{
            //    b= true;
            //}
            //else
            //{
            //    b=false;

            //}

             return true;

        }
        [WebMethod]
        public bool LoginProcess(string username, string password)
        {
            bool b = false;
            var query = from emp in context.Employees
                        where emp.Username == username
                        && emp.Password == password
                        && emp.is_admin == false
                        select emp;
            if (query.Any())
            {
                b = true;
            }
            else
            {
                b = false;
            }

            return b;

        }

        [WebMethod]

        public int? GetEmployeeID(string username, string password)
        {
            int? EmpID;
            var query = from emp in context.Employees
                        where emp.Username == username
                        && emp.Password == password
                        && emp.is_admin == false
                        select emp;
            if (query.Any())
            {
                EmpID = query.FirstOrDefault().Employee_id;
            }
            else
            {
                EmpID = null;
            }

            return EmpID;

        }
        [WebMethod]

        public void SubmitHolidayRequest(int EmployeeID, DateTime startdate, DateTime enddate)
        {

            HolidayRequest newRequest = new HolidayRequest

            {
                EmployeeID = EmployeeID,
                start_date = startdate,
                end_date = enddate,
                approved = 2


            };
           
            context.HolidayRequests.InsertOnSubmit(newRequest);
            context.SubmitChanges();
        }

    }
}
