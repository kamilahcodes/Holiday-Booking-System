using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Holiday_Booking_System;

namespace UnitTestProject1
{
    [TestClass]
    public class ConstraintsUnitTest
    {
        [TestMethod]
        public void CheckDate ()
        {
           
            bool expected = true;
            ConstraintComponent Component = new ConstraintComponent();
            bool actual = Component.Checkdate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsItAugust()
        {
            bool expected = false;
            ConstraintComponent Component = new ConstraintComponent();
            bool actual = Component.IsAugust();
            Assert.AreEqual(expected, actual);

        }

        //[TestMethod]
        //public void CheckHod()
        //{
        //    ConstraintComponent Component = new ConstraintComponent();
        // // Component.HeadOfDep(1,1);
        //    Assert.IsNull(Component.HeadOfDep(1, 1));
        //}
    }
}
