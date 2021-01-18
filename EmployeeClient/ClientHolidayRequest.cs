using EmployeeClient.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient
{
    public partial class ClientHolidayRequest : Form
    {
        public ClientHolidayRequest(int EmployeeID)
        {
            InitializeComponent();

            int ID = EmployeeID;
           label3.Text = ID.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            WebServiceSoapClient service = new WebServiceSoapClient();
            DateTime startdate = dateTimePicker1.Value;
            DateTime enddate = dateTimePicker2.Value;
            service.SubmitHolidayRequest(Int32.Parse(label3.Text), startdate, enddate);

            MessageBox.Show("Holiday Request Submitted");
        }
    }
}
 