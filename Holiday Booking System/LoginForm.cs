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
    public partial class LogReg_form : Form
    {
        Account userAccount;
        LoginClass businessLayer = new LoginClass();
        LoginDataClass dataLayer = new LoginDataClass();
        public LogReg_form()
        {
            InitializeComponent();
        }
       

        private void Login_btn_Click(object sender, EventArgs e)
        {

            businessLayer.username = username_login_txtBox.Text;
            businessLayer.password = password_login_txtBox.Text;
            bool loggedin = dataLayer.LoginProcess(username_login_txtBox.Text, password_login_txtBox.Text);


            if (businessLayer.username == null || businessLayer.password == null)
            {
                MessageBox.Show("Please Enter a value", "No values entered");
            }

            else if (loggedin== true)
            {
                userAccount = Account.GetInstance();

                userAccount.Username = businessLayer.username;
            
              
                MessageBox.Show("Log in successful " + userAccount.Username);

                this.Hide();
                AdminDashboard admin = new AdminDashboard();
                admin.Show();


                }
            else if (loggedin == false)
            {

                MessageBox.Show("Incorrect Log in");


            }




        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
