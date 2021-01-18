using Holiday_Booking_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeWebSite
{
    public partial class EmployeeLogin : System.Web.UI.Page
    {
      
        protected void page_load(object sender, EventArgs e)
        {
            
        }


        public void Login(string username, string password)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var query = from emp in context.Employees
                    where emp.Username == username
                    && emp.Password == password 
                    && emp.is_admin == false
                    select emp;
            if (query.Any())
            {
                int EmpID = query.FirstOrDefault().Employee_id;
                HiddenField1.Value = EmpID.ToString();
                HolidayEntitlementComponent h = new HolidayEntitlementComponent();
                h.FillHolidayEntTab(EmpID);
                Response.Redirect("SubmitHolidayRequest.aspx?id=" + HiddenField1.Value + "&username="+ username);
                
            }
            else
            {
                Label2.Text = "Incorrect login";
            
             }
        }


        protected void LoginBtn_Click(object sender, EventArgs e)



        {

            Login(TextBox1.Text, TextBox2.Text);

       


        }
    }
}
