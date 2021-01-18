using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Booking_System
{
    class EmployeeDetailsClass
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string phoneNumber { get; set; }

        public int roleId{ get; set; }

        public int dptId { get; set; }

        public bool isAdmin { get; set; }
        public bool onDuty { get; set; }

        public DateTime dateJoined { get; set; }
    }
}
