using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Holiday_Booking_System;

namespace UnitTestProject1
{
    [TestClass]
    public class PrioritisastionUnitTest
    {
        [TestMethod]
        public void EasterSundayCalculation()
        {
           DateTime expectedEaster = new DateTime(DateTime.Now.Year,4,12);


            DateTime expected = expectedEaster;
            PrioritisationComponent p1 = new PrioritisationComponent();
            DateTime actual = p1.EasterSunday();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WeekBefore()
        {
            DateTime expectedEaster = new DateTime(DateTime.Now.Year, 4, 5);


            DateTime expected = expectedEaster;
            PrioritisationComponent p1 = new PrioritisationComponent();
            DateTime actual = p1.WeekBeforeEaster();
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void WeekAfter()
        {
            DateTime expectedEaster = new DateTime(DateTime.Now.Year, 4, 19);


            DateTime expected = expectedEaster;
            PrioritisationComponent p1 = new PrioritisationComponent();
            DateTime actual = p1.WeekAfterEaster();
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        /*
         * if holiday days(jul18 -jul20) are completely intersect, the peak times(july 15- aug 31)
         * 
         */
        public void DaysDuringPeakTimes()
        {

            DateTime july15 = new DateTime(DateTime.Now.Year, 07, 15);
            DateTime aug31 = new DateTime(DateTime.Now.Year, 08, 31);

            DateTime startdate = new DateTime(DateTime.Now.Year, 07, 18);
            DateTime enddate = new DateTime(DateTime.Now.Year, 07, 20);
            int expected = 2;
            
            PrioritisationComponent p1 = new PrioritisationComponent();
            int actual = p1.Dates(startdate, enddate, july15, aug31);
            Assert.AreEqual(expected, actual);

        }




        [TestMethod]
        /*
         * if holiday days(jul14 -jul25) are partially intersect, the peak times(july 15- aug 31)
         * 
         */
        public void DaysDuringPeakTimes1()
        {

            DateTime july15 = new DateTime(DateTime.Now.Year, 07, 15);
            DateTime aug31 = new DateTime(DateTime.Now.Year, 08, 31);

            DateTime startdate = new DateTime(DateTime.Now.Year, 07, 14);
            DateTime enddate = new DateTime(DateTime.Now.Year, 07, 25);
            int expected = 10;

            PrioritisationComponent p1 = new PrioritisationComponent();
            int actual = p1.Dates(startdate, enddate, july15, aug31);
            Assert.AreEqual(expected, actual);

        }



        [TestMethod]
        /*
         * if holiday days(jul25 - sept1) are completely intersect, the peak times(july 15- aug 31)
         * 
         */
        public void DaysDuringPeakTimes2()
        {

            DateTime july15 = new DateTime(DateTime.Now.Year, 07, 15);
            DateTime aug31 = new DateTime(DateTime.Now.Year, 08, 31);

            DateTime startdate = new DateTime(DateTime.Now.Year, 07, 25);
            DateTime enddate = new DateTime(DateTime.Now.Year, 09, 1);
            int expected = 38;

            PrioritisationComponent p1 = new PrioritisationComponent();
            int actual = p1.Dates(startdate, enddate, july15, aug31);
            Assert.AreEqual(expected, actual);

        }



    }
}
