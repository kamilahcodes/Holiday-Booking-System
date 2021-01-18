using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Booking_System
{
    public partial class PrioritisationComponent : Component
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        public SortedDictionary<TimeSpan, int> tasks = new SortedDictionary<TimeSpan, int>();
        public PrioritisationComponent()
        {
            InitializeComponent();
        }

        public PrioritisationComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        public class PeakDays
            
        {
            public int HolidayReqID { get; set; }
           
            public int TotalDays { get; set; }
        }
      
        public class StaffHolidays
        {
            public int EmployeeID { get; set; }

            public int dates { get; set; }
        }
        


        public IEnumerable<StaffHolidays> StaffLowerHolidays()
        {
            //in current year....... to add....
            //go to holiday req table
            //get approved 
            //subtract end - start date
            //put in new column 
            //order by that column.
            var query = (from req in context.HolidayRequests.AsEnumerable()
                         where req.approved == 1
                         && req.end_date.Year == DateTime.Now.Year
                         && req.start_date.Year == DateTime.Now.Year

                         // orderby dates descending
                         
                        group req by new { req.EmployeeID } into empGroup
                        // let datess = req.end_date - req.start_date
                        //let datess = empGroup.Sum(t => Convert.ToInt32(t.end_date - t.start_date))
                         select new StaffHolidays {

                             EmployeeID = empGroup.Key.EmployeeID,
                             dates = empGroup.Sum(t => Convert.ToInt32((t.end_date - t.start_date).TotalDays))

                         });
            
            //foreach (var q in query)
            //{

            //    Console.WriteLine(q.EmployeeID);
            //    Console.WriteLine(q.dates);
            //}



            return query;

        }

        //return a list, of hrid and the totalpeak days taken
        //then compare list by hrform where hr id == hr id

        public IEnumerable<PeakDays> StaffLessPeakDays()
        {
            DateTime july15 = new DateTime(DateTime.Now.Year,7,15);
            DateTime aug31 = new DateTime(DateTime.Now.Year,8,31);

            DateTime dec15 = new DateTime(DateTime.Now.Year,12,15);
            DateTime dec22 = new DateTime(DateTime.Now.Year,12,22);

            DateTime beforeEaster = WeekBeforeEaster();
            DateTime easter = EasterSunday();
            DateTime afterEaster = WeekAfterEaster();



            var getRequest = (from req in context.HolidayRequests.AsEnumerable()

                              where req.approved == 2
                              let holStart = req.start_date
                              let holEnd = req.end_date

                              select new PeakDays

                              {
                                  HolidayReqID = req.HolidayRequestID,
                                  TotalDays = Dates(holStart, holEnd, july15, aug31) + Dates(holStart, holEnd, dec15, dec22) +
                                     Dates(holStart, holEnd, beforeEaster, easter) + Dates(holStart, holEnd, easter, afterEaster),
                                  
                              });

          
                                
                       
          
       

          //  foreach (var g in getRequest)
          //{




          //      Console.WriteLine(g.HolidayReqID);
          //      Console.WriteLine(g.TotalDays);

          // }


            return getRequest;

        }



        public int Dates(DateTime holStartDate, DateTime holEndDate, DateTime peakStart, DateTime peakEnd)
        {
           



            int diff = 0;


            if (holStartDate <= peakEnd && peakStart <= holEndDate) {

              
                if (holStartDate >= peakStart && holEndDate <= peakEnd)
                {
                   diff = (int)(holEndDate - holStartDate).TotalDays;
                  
                }

                else if(holStartDate < peakStart && holEndDate < peakEnd)
                {
                    diff = (int)(holEndDate - peakStart).TotalDays;
                   
                }

                else if (holStartDate < peakEnd && holEndDate > peakEnd)
                {
                    diff = (int)(peakEnd - holStartDate).TotalDays;
               
                }

                


            }
            else {
                // if holidays and peaktimes dont overlap
                diff = 0;
   
            }


            return diff;


        }



        /*
         * The Anonymous Gregorian computus algorithm.
         * from https://c-for-dummies.com/blog/?p=2431
         * The computus
         * First appearwd in Nature in 1876
          */
        public  DateTime EasterSunday()

        {
            int year = DateTime.Now.Year;
            var a = year % 19;
            var b = Math.Floor(year / 100m);
            var c = year % 100;
            var d = Math.Floor(b / 4);
            var e = b % 4;
            var f = Math.Floor((b + 8) / 25);
            var g = Math.Floor((b - f + 1) / 3);
            var h = ((19*a) + b -d -g + 15) % 30;
            var i = Math.Floor(c / 4m);
            var k = c % 4;
            var l = (32 + (2 * e) + (2 * i) - h - k) % 7;
            var m = Math.Floor((a + (11 * h) + (22 * l)) / 451);
            int month = Convert.ToInt32(Math.Floor((h + l - (7 * m) + 114) / 31));
            int day = Convert.ToInt32(((h + l - (7 * m) + 114) % 31) + 1);
            DateTime Easter = new DateTime(year, month, day);


            return Easter;

        }

        public DateTime WeekBeforeEaster()
        {
            DateTime weekBeforeEaster = EasterSunday().AddDays(-7);
            return weekBeforeEaster;
        }

        public DateTime WeekAfterEaster()
        {
            DateTime weekAfterEaster = EasterSunday().AddDays(7);
            return weekAfterEaster;
        }
        
    }
}
