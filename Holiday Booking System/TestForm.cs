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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // constraintComponent1.StaffOnDuty(1008, 19);
            //    string OffPeak = "23 December";
            // DateTime Dec = Convert.ToDateTime(OffPeak).AddYears(1);
            //MessageBox.Show(Dec.ToString());
            //PrioritisationComponent p = new PrioritisationComponent();
            //   p.StaffLowerHolidays();
            // p.StaffLowerHolidays();
            // listBox1.Items.Add ( p.StaffLowerHolidays());

            //VisualisationComponent v = new VisualisationComponent();


            //foreach (var i in v.getEmployeeHolidays(1006))
            //{
            //    listBox1.Items.Add(i);
            //}

            visualisationComponent1.Employee = 1006;
        }

    }
}
