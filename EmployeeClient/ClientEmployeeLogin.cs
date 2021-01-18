using EmployeeClient.ServiceReference;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;

namespace EmployeeClient
{
    public partial class ClientEmployeeLogin : Form
    {
        public ClientEmployeeLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            
            


           


      
        }

        private void ClientEmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            WebServiceSoapClient service = new WebServiceSoapClient();


            if (service.LoginProcess(username_login_txtBox.Text, password_login_txtBox.Text) == true)
            {
                int? id = service.GetEmployeeID(username_login_txtBox.Text, password_login_txtBox.Text);

                if (id.HasValue)
                {
                    int EmpID = id.Value;
                    ClientHolidayRequest f = new ClientHolidayRequest(EmpID);
                    f.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Incorrect Log in");
            }


        }
    }
}
