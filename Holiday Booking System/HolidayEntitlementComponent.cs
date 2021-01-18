using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Booking_System
{
    public partial class HolidayEntitlementComponent : Component
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        public HolidayEntitlementComponent()
        {
            InitializeComponent();
        }

        public HolidayEntitlementComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void FillHolidayEntTab (int EmployeeId){
      

            if (CheckEmployeeExists(EmployeeId) == true) {
                

                HolidayEntitlement ent = new HolidayEntitlement();

                ent.EmployeeID = EmployeeId;
                //ent.Entitlement_days_left = 30;
                ent.Extra_days = ExtraDays(EmployeeId);

                context.SubmitChanges();


            }
            else {
             
                HolidayEntitlement ent = new HolidayEntitlement();
                ent.EmployeeID = EmployeeId;
                ent.Entitlement_days_left = 30;
                ent.Extra_days = ExtraDays(EmployeeId); // calculate extra days
                context.HolidayEntitlements.InsertOnSubmit(ent);
                context.SubmitChanges();

            }
            
        
           


        }

        public bool CheckEmployeeExists(int Employee)
        {
            bool exists;

            var query = from ent in context.HolidayEntitlements
                        where ent.EmployeeID == Employee
                        select ent;

            if (query.Any()) {
                exists = true;

            }
            else {
                exists = false;
            }

            return exists;
        }

        public int ExtraDays(int EmployeeId)
        {
            int extraDays;
            DateTime Today = new DateTime(2020, 03, 19);

            var query = from emp in context.Employees
                        where emp.Employee_id == EmployeeId
                        select emp;
            DateTime dateJoined = query.FirstOrDefault().date_joined;

            
            string datesString = (Today - dateJoined).TotalDays.ToString();
            int differenceDates = (Today - dateJoined).Days;
            int years = differenceDates / 365;
            if (years > 0)
            {


                int division = (int)Math.Floor(years / 5.0);
                extraDays = division;
            
            }
            else
            {
                extraDays = 0;
            }

            return extraDays;
        }

        //public  int CheckNewYear()
        //{
        //    int HolidayEnt;
        //    DateTime newYear = new DateTime(DateTime.Now.Year+1, 01, 04);

        //    if (DateTime.Now == newYear)
        //    {
        //        HolidayEnt = 30;
        //        return HolidayEnt;

        //    }
            
        //}
    }
}
