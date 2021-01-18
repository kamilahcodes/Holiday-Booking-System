using Holiday_Booking_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeWebSite
{
    public partial class ViewRequests : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            int id2 = Convert.ToInt32(id);
            DataClasses1DataContext context = new DataClasses1DataContext();
          
            


          
            GridView1.DataSource = (from hr in context.HolidayRequests
                                    where hr.EmployeeID == id2
                                    && hr.approved == 1
                                    select new { hr.start_date, hr.end_date, hr.HolidayRequestID}).ToList();
            
            GridView1.DataBind();
           

            //no approved



            GridView2.DataSource = (from hr1 in context.HolidayRequests
                                    where hr1.EmployeeID == id2
                                    && hr1.approved == 0
                                    select new { hr1.start_date, hr1.end_date, hr1.HolidayRequestID }).ToList();
            
            GridView2.DataBind();
         

        }
    }
}