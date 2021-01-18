using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Booking_System
{
    class Emp
    {
        private string firstname;
        private string lastname;
        private string phoneNo;
        private DateTime date_joined;
        private DepartmentType dp;
        private RoleType rp;
        private int entitlementdays;
        private bool onduty;

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public DateTime Date_joined { get => date_joined; set => date_joined = value; }
        public DepartmentType Dp { get => dp; set => dp = value; }
        public int Entitlementdays { get => entitlementdays; set => entitlementdays = value; }
        public bool Onduty { get => onduty; set => onduty = value; }
        internal RoleType Rp { get => rp; set => rp = value; }
    }
}
