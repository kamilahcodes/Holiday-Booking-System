using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Booking_System
{
    class LoginDataClass
    {
       
        DataClasses1DataContext context = new DataClasses1DataContext();
        public bool LoginProcess(string username, string password)
        {
            bool result;
            var q = from p in context.Employees
                    where p.Username == username
                   && p.Password == password &&
                   p.is_admin == true
                    select p;


            if (q.Any())
            {
               

                result =  true;


            }
            else
            {
                result =  false;
            }

            return result;

        }
    }
}
