using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Booking_System
{
    public partial class ConstraintComponent : Component
    {
        //this is a for unit testign, chechking the dates 

        DataClasses1DataContext context = new DataClasses1DataContext();
        public ConstraintComponent()
        {
            InitializeComponent();
        }

        public ConstraintComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }



        public Boolean Checkdate()
        {
            DateTime dateOfBooking = new DateTime(2020, 03, 19); //yyyy m d //1, june

            DateTime Dec = Convert.ToDateTime("23 December");
            DateTime Jan = Convert.ToDateTime("03 January").AddYears(1);

            if (dateOfBooking >= Dec && dateOfBooking <= Jan) //if the date is  between this
            {
                return false; // date is between 
            }
            else
            {
                return true; //date not between
            }


        }


        public bool IsAugust()
        {

            bool isAug;
            DateTime date = new DateTime(2020, 03, 19);
            if (date.Month == 08)
            {
                isAug = true;
            }
            else
            {
                isAug = false;
            }

            return isAug;
        }


        public void ExceedHoliday(int EmployeeID, int HolidayRequestID) {
            //test1 - if requested is less than entitked should pss
            //2 - if req is more than entitled should fail
            // if the date is between 23d and 3j with testcase 2 should pass


            var query = from req in context.HolidayRequests
                        where req.HolidayRequestID == HolidayRequestID
                        && req.EmployeeID == EmployeeID
                        && req.approved == 2
                        select req;
            ///where req is outstanding

            DateTime start = query.FirstOrDefault().start_date;
            DateTime end = query.FirstOrDefault().end_date;

            int requested_days = (end - start).Days;

            var he_query = from emp in context.HolidayEntitlements
                           where emp.EmployeeID == EmployeeID
                           select emp;
            int entitled_days = he_query.FirstOrDefault().Entitlement_days_left;
            int extraDays = he_query.FirstOrDefault().Extra_days;
            int totalEntitledDays = entitled_days + extraDays;

            if (Checkdate())
            {
                if (requested_days > totalEntitledDays)
                {
                    HolidayReqConstraint con = new HolidayReqConstraint();
                    con.HolidayRequestID = HolidayRequestID;
                    con.ConstraintID = 1;

                    context.HolidayReqConstraints.InsertOnSubmit(con);
                    context.SubmitChanges();
                }
                else
                {
                    HolidayReqConstraint con = new HolidayReqConstraint();
                    con.HolidayRequestID = HolidayRequestID;
                    con.ConstraintID = 6;

                    context.HolidayReqConstraints.InsertOnSubmit(con);
                    context.SubmitChanges();

                }

            }
            else
            {
                HolidayReqConstraint con = new HolidayReqConstraint();
                con.HolidayRequestID = HolidayRequestID;
                con.ConstraintID = 6;

                context.HolidayReqConstraints.InsertOnSubmit(con);
                context.SubmitChanges();
            }


        }



        public void HeadOfDep(int EmployeeID, int HolidayRequestID)
        {
            //check if hods in dpt are on duty
            // if date
          

            var getdpt = from emp in context.Employees
                         where emp.Employee_id == EmployeeID
                         select emp;
            //  DateTime start = query.FirstOrDefault().start_date;
            int DptID = getdpt.FirstOrDefault().Departmentid;

            var getroleid = from emp2 in context.Employees
                            where emp2.Departmentid == DptID && emp2.on_duty == true &&
                            (emp2.Roleid == 1 || emp2.Roleid == 2)
                            select emp2;

            //get the dpt id 
            //select - for employees with dpt id
            //if role id = 1 or 2
            //if not
            //set constraints
            if (getroleid.Any() == false) {

                HolidayReqConstraint con = new HolidayReqConstraint();
                con.HolidayRequestID = HolidayRequestID;
                con.ConstraintID = 2;

                context.HolidayReqConstraints.InsertOnSubmit(con);
                context.SubmitChanges();

             

            }
            else
            {
                HolidayReqConstraint con = new HolidayReqConstraint();
                con.HolidayRequestID = HolidayRequestID;
                con.ConstraintID = 6;

                context.HolidayReqConstraints.InsertOnSubmit(con);
                context.SubmitChanges();

            }

        }


        public void StaffOnDuty(int EmployeeID, int HolidayRequestID)
        {
            


            var getdpt = from emp in context.Employees
                         where emp.Employee_id == EmployeeID
                         select emp;
            //  DateTime start = query.FirstOrDefault().start_date;
            int DptID = getdpt.FirstOrDefault().Departmentid;

            bool getManager = (from emp2 in context.Employees

                            where emp2.Departmentid == DptID
                             && emp2.Roleid == 3
                            select emp2).Any();
         

            bool getSeniorMember = (from emp3 in context.Employees
                                  where emp3.Departmentid == DptID
                                   && emp3.Roleid == 6
                                   select emp3).Any();


            if (Checkdate())
            {

                if (getManager && getSeniorMember == false)
                {

                    HolidayReqConstraint con = new HolidayReqConstraint();
                    con.HolidayRequestID = HolidayRequestID;
                    con.ConstraintID = 3;

                    context.HolidayReqConstraints.InsertOnSubmit(con);
                    context.SubmitChanges();


                }
                else
                {
                    HolidayReqConstraint con = new HolidayReqConstraint();
                    con.HolidayRequestID = HolidayRequestID;
                    con.ConstraintID = 3;

                    context.HolidayReqConstraints.InsertOnSubmit(con);
                    context.SubmitChanges();

                }
            }

            else
            {

                HolidayReqConstraint con = new HolidayReqConstraint();
                con.HolidayRequestID = HolidayRequestID;
                con.ConstraintID = 6;

                context.HolidayReqConstraints.InsertOnSubmit(con);
                context.SubmitChanges();


            }
        }

        public void SixtyPercent(int EmployeeID, int HolidayRequestID)
        {
            if (Checkdate()) {

                var getdpt = from emp in context.Employees
                             where emp.Employee_id == EmployeeID
                             select emp;
           
                int DptID = getdpt.FirstOrDefault().Departmentid;

                int getallindpt = (from emp2 in context.Employees
                                   where emp2.Departmentid == DptID && emp2.on_duty == true
                                   select emp2).Count();

                int getallemployees = (from emp3 in context.Employees
                                       where emp3.Departmentid == DptID
                                       select emp3).Count();


                double percentage = getallindpt / getallemployees;


                //count all in dpt/employees
                if (percentage <=  0.60) // if percentage of staff in dpt is on duty and equal to 1
                {
                    HolidayReqConstraint con = new HolidayReqConstraint();
                    con.HolidayRequestID = HolidayRequestID;
                    con.ConstraintID = 4;

                    context.HolidayReqConstraints.InsertOnSubmit(con);
                    context.SubmitChanges();
                }

                else
                {

                    HolidayReqConstraint con = new HolidayReqConstraint();
                    con.HolidayRequestID = HolidayRequestID;
                    con.ConstraintID = 6;

                    context.HolidayReqConstraints.InsertOnSubmit(con);
                    context.SubmitChanges();
                }

            }
            else
            {

                HolidayReqConstraint con = new HolidayReqConstraint();
                con.HolidayRequestID = HolidayRequestID;
                con.ConstraintID = 6;

                context.HolidayReqConstraints.InsertOnSubmit(con);
                context.SubmitChanges();


            }


        }


        public void FortyPercent(int EmployeeID, int HolidayRequestID)
        {
            if (Checkdate() && IsAugust())
            {
                var getdpt = from emp in context.Employees
                             where emp.Employee_id == EmployeeID
                             select emp;

                int DptID = getdpt.FirstOrDefault().Departmentid;

                int getallindpt = (from emp2 in context.Employees
                                   where emp2.Departmentid == DptID && emp2.on_duty == true
                                   select emp2).Count();

                int getallemployees = (from emp3 in context.Employees
                                       where emp3.Departmentid == DptID
                                       select emp3).Count();


                double percentage = getallindpt / getallemployees;

                if (percentage <= 0.40) // if percentage of staff in dpt is greater than 40%
                {
                    HolidayReqConstraint con = new HolidayReqConstraint();
                    con.HolidayRequestID = HolidayRequestID;
                    con.ConstraintID = 5;

                    context.HolidayReqConstraints.InsertOnSubmit(con);
                    context.SubmitChanges();
                }

                else
                {

                    HolidayReqConstraint con = new HolidayReqConstraint();
                    con.HolidayRequestID = HolidayRequestID;
                    con.ConstraintID = 6;

                    context.HolidayReqConstraints.InsertOnSubmit(con);
                    context.SubmitChanges();
                }




            }

        }







    }
}
