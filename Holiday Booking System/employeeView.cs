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
    public partial class employeeView : Form
    {
        public employeeView()
        {
            InitializeComponent();
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'na8363cDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.na8363cDataSet.Employee);

        }
    }
}
