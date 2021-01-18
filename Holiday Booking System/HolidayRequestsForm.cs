using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holiday_Booking_System
{
    public partial class HolidayRequestsForm : Form
    {
        Account userAccount = Account.GetInstance();
        DataClasses1DataContext context = new DataClasses1DataContext();
        public HolidayRequestsForm()
        {
            InitializeComponent();
        }

        //private void HideButton()
        //{
        //    reject_btn.Hide();
        //    accept_btn.Hide();
        //}
        //private void ShowButton()
        //{
        //    reject_btn.Show();
        //    accept_btn.Show();
        //}

        private void FillComboBox()
        {

            employee_filter_comBox.DataSource = context.Employees.ToList();
            employee_filter_comBox.DisplayMember = "Username";
            employee_filter_comBox.ValueMember = "Employee_id";
        }
       

        private void Pending_btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Location = new Point(130, 70); 
            PrioritisationComponent p = new PrioritisationComponent();
            IEnumerable<PrioritisationComponent.PeakDays> list = p.StaffLessPeakDays();
            IEnumerable<PrioritisationComponent.StaffHolidays> holidayslist = p.StaffLowerHolidays();




            var source = (from req in context.Constraints_Views.AsEnumerable()
                          join req2 in list on req.HolidayRequestID equals req2.HolidayReqID
                          join req3 in holidayslist on req.EmployeeID equals req3.EmployeeID

                          where req.approved == 2
                          orderby req3.dates, req2.TotalDays
                          select req).Distinct();

            //broken
            dataGridView3.ColumnCount = 4;
            dataGridView3.Columns[0].Name = "Employee ID";
            dataGridView3.Columns[1].Name = "Holiday RequestID";
            dataGridView3.Columns[2].Name = "Approved";
            dataGridView3.Columns[3].Name = "Constraints";

            //not broken
            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Name = "Employee ID";
            dataGridView2.Columns[1].Name = "Holiday RequestID";
            dataGridView2.Columns[2].Name = "Approved";
            dataGridView2.Columns[3].Name = "Constraints";


            foreach (var a in source)
            {

                if (a.ConstraintID == 6)
                {//if not broken
                    dataGridView2.Rows.Add(a.EmployeeID, a.HolidayRequestID, a.approved, a.ConstraintDetails);
                    //  dataGridView3.Rows.Add(a.EmployeeID, a.HolidayRequestID, a.approved);
                }

                else
                {
                    dataGridView3.Rows.Add(a.EmployeeID, a.HolidayRequestID, a.approved, a.ConstraintDetails);
                }

            };
           
        }


        private void Accepted_btn_Click(object sender, EventArgs e)

        {
            panel1.Visible = true;
            panel2.Visible = false;
            var q = from p in context.HolidayReq_Views

                    where p.approved == 1

                    select p;
            dataGridView1.DataSource = q;
            dataGridView1.Columns["approved"].Visible = false;
           
            filter_panel.Visible = false;
        }

        private void Rejected_btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            var q = from p in context.HolidayReq_Views

                    where p.approved == 0

                    select p;
            dataGridView1.DataSource = q;
            dataGridView1.Columns["approved"].Visible = false;
            
            filter_panel.Visible = false;
        }

        private void View_all_btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

            var q = from p in context.HolidayReq_Views

                    

                    select p;
            dataGridView1.DataSource = q;
            dataGridView1.Columns["approved"].Visible = false;
            


            filter_panel.Visible = true;
            FillComboBox();


            


        }

        private void Accept_btn_Click(object sender, EventArgs e)
        {
            //Int32 selectedColumnCount = dataGridView1.Columns
            //           .GetColumnCount(DataGridViewElementStates.Selected);
            DataGridViewRow selectedRow = dataGridView2.CurrentRow;
            int id = (int)selectedRow.Cells[1].Value;
           // selectedRow.Cells[4].Value = (byte)1;


            var r = (from p in context.HolidayRequests
                     where p.HolidayRequestID == id
                     select p).SingleOrDefault();

            HolidayRequest req = r;
            req.approved = 1;
           
            context.SubmitChanges();
        }

        private void Reject_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView2.CurrentRow;
            int id = (int)selectedRow.Cells[1].Value;
          //  selectedRow.Cells[4].Value = (byte)0;


            var r = (from p in context.HolidayRequests
                     where p.HolidayRequestID == id
                     select p).SingleOrDefault();

            HolidayRequest req = r;
            req.approved = 0;

            context.SubmitChanges();
        }

       

     
        private void Employee_filter_comBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(employee_filter_comBox.SelectedValue);
            var r = (from p in context.HolidayRequests
                    where p.EmployeeID == value
                    select p);
            ////HolidayRequest req = r;
            dataGridView1.DataSource = r;
            dataGridView1.Columns["EmployeeID"].Visible = false;
            dataGridView1.Columns["Employee"].Visible = false;
            visualisationComponent1.Employee = value;
            visualisationComponent1.doSomething();
            visualisationComponent1.Invalidate();
           
        }

        private void Filter_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = filter_dateTimePicker.Value;
            var r = (from p in context.HolidayRequests
                     where p.start_date == d || p.end_date == d
                     select p);
            dataGridView1.DataSource = r;
            dataGridView1.Columns["EmployeeID"].Visible = false;
            dataGridView1.Columns["Employee"].Visible = false;
        }

   

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Account.GetInstance().Username = null;
            Account.GetInstance().IsAdmin = false;

            this.Hide();
            LogReg_form l = new LogReg_form();
            l.Show();
        }

        private void Hreq_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard a = new AdminDashboard();
            a.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void HolidayRequestsForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            PrioritisationComponent p = new PrioritisationComponent();
            IEnumerable<PrioritisationComponent.PeakDays> list = p.StaffLessPeakDays();
            IEnumerable<PrioritisationComponent.StaffHolidays> holidayslist = p.StaffLowerHolidays();




            var noBreakConstraints = (from req in context.Constraints_Views.AsEnumerable()
                          join req2 in list on req.HolidayRequestID equals req2.HolidayReqID
                          join req3 in holidayslist on req.EmployeeID equals req3.EmployeeID

                          where req.approved == 2
                          && req.ConstraintID == 6
                          orderby req3.dates , req2.TotalDays


                          select req).Distinct();


            var breakConstraints = (from req in context.Constraints_Views.AsEnumerable()
                          join req2 in list on req.HolidayRequestID equals req2.HolidayReqID
                          join req3 in holidayslist on req.EmployeeID equals req3.EmployeeID

                          where req.approved == 2
                          && req.ConstraintID != 6
                          orderby req3.dates, req2.TotalDays


                          select req).Distinct();



            dataGridView3.DataSource = breakConstraints;
            dataGridView2.DataSource = noBreakConstraints;

            filter_panel.Visible = false;
         

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {


            //no constraints
          //  var q = (from p in context.Constraints_Views


            //        where p.approved == 2
                   // && p.Expr1 == 6

             //       select p).ToList(); // require
            //dataGridView2.DataSource = q;
/*
            foreach (var i in q)
            {
                if(i.Expr1 == 6) //non broken constraints
                {
                    dataGridView2.DataSource = i;
                }

                else
                {
                    dataGridView2.DataSource = i;
                }
            }
        */
            //dataGridView2.Columns["approved"].Visible = false;
            //dataGridView2.Columns["approved"].Visible = false;
            //filter_panel.Visible = false;
            //ShowButton();


        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView3.CurrentRow;
            int id = (int)selectedRow.Cells[1].Value;
            //  selectedRow.Cells[4].Value = (byte)0;


            var r = (from p in context.HolidayRequests
                     where p.HolidayRequestID == id
                     select p).SingleOrDefault();

            HolidayRequest req = r;
            req.approved = 0;

            context.SubmitChanges();
        }

        private void Filter_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
