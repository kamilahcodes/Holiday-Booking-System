using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Booking_System
{
    public enum DepartmentType
    {
        None, Engineering, Plumbing, Roofing, Carpentry, Bricklaying, Office
    }
    enum RoleType
    {
        None, Head, Deputy_Head, Manager, Apprentice, [Display(Name = "Junior Member")]
        Junior_Member, [Display(Name = "Senior Member")]
        Senior_Member
    }

}
