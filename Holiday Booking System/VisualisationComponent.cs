using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Booking_System
{
    public partial class VisualisationComponent : System.Windows.Forms.MonthCalendar
    {
        DataClasses1DataContext context = new DataClasses1DataContext();



        public int Employee { get; set; }
        public DateTime[] dates;
        public List<DateTime> allDates = new List<DateTime>();

        public VisualisationComponent()
        {
            InitializeComponent();
        }

        public VisualisationComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public List<DateTime> getEmployeeHolidays(int EmployeeID)
        {
          
            DateTime start1;
            DateTime end1;
            var startDateQuery = (from h in context.HolidayRequests
                                  where h.EmployeeID == 3

                                  select new { h.start_date, h.end_date });

            foreach (var start in startDateQuery)
            {
                start1 = start.start_date;
                end1 = start.end_date;
                for (var date1 = start1; date1 < end1;)
                {
                    allDates.Add(date1);
                    date1 = date1.AddDays(1);
                }
            }


            //var endDateQuery = (from h in context.HolidayRequests
            //                    where h.EmployeeID == EmployeeID

            //                    select h.end_date);
            //foreach (DateTime end in endDateQuery)
            //{
            //    allDates.Add(end);
            //}

        //    for(DateTime d )


            return allDates;
        }



        //public new DateTime[] BoldedDates{
        //    get { return dates; }

        //    set {
        //        dates = allDates.ToArray();// getEmployeeHolidays(Employee).ToArray();

        //        base.Invalidate();
        //    }

            
       // }

        public void doSomething()
        {
            base.BoldedDates = getEmployeeHolidays(Employee).ToArray();
        }




    }
}
