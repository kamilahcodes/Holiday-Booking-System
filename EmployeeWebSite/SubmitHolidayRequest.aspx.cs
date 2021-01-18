using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Holiday_Booking_System;

namespace EmployeeWebSite
{
    public partial class SubmitHolidayRequest : System.Web.UI.Page
    {

        ConstraintComponent c = new ConstraintComponent();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            string username = Request.QueryString["username"];
            Label1.Text = "Hello " + username;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DataClasses1DataContext context = new DataClasses1DataContext();



            string EmployeeId = Request.QueryString["id"];
            DateTime startdate = Calendar1.SelectedDate;
            DateTime enddate = Calendar2.SelectedDate;
            int EmpID = Convert.ToInt32(EmployeeId);
            HolidayRequest newRequest = new HolidayRequest
            
            {
                EmployeeID = EmpID,
                start_date = startdate,
                end_date = enddate,
                approved = 2


            };
 
            context.HolidayRequests.InsertOnSubmit(newRequest);
            context.SubmitChanges();


            c.ExceedHoliday(EmpID, newRequest.HolidayRequestID);
            c.HeadOfDep(EmpID, newRequest.HolidayRequestID);
            c.StaffOnDuty(EmpID, newRequest.HolidayRequestID);
            c.SixtyPercent(EmpID, newRequest.HolidayRequestID);
            c.FortyPercent(EmpID, newRequest.HolidayRequestID);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            Response.Redirect("ViewRequests.aspx?id=" + id);


        }
    }
}