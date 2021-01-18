using System;
using Holiday_Booking_System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class HolidayEntUnitTest
    {
        [TestMethod]
        /*
         * Check if Employee Id is present in Holiday Entitlement Table
         */
        public void CheckEmployeeTest()
        {
            
            int EmployeeId = 1;
           
            bool expected = true;
            HolidayEntitlementComponent Component = new HolidayEntitlementComponent();
            bool actual = Component.CheckEmployeeExists(EmployeeId);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateExtraDaysTest()
        {
            int EmployeeId = 1;
            HolidayEntitlementComponent Component = new HolidayEntitlementComponent();
            int actual = Component.ExtraDays(EmployeeId);
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
