using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Holiday_Booking_System
{
    public partial class AdminDashboard : Form
    {
        Account userAccount = Account.GetInstance();
        

        dbConnectionClass dataLayer = new dbConnectionClass();
        EmployeeDetailsClass model = new EmployeeDetailsClass();







        public DateTime dateJoined { get; set; }
        public AdminDashboard()
        {
            InitializeComponent();
            LoadAll();
            greetinglbl.Text ="User: " + Account.GetInstance().Username;

        }

        private void LoadAll() {
       
            dgv.DataSource = dataLayer.FillDataGrid();
            recordAddpnl.Visible = false;
            recordEditpnl.Visible = false;


        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            recordAddpnl.Visible = true;
            recordEditpnl.Visible = false;
            recordAddpnl.Location = new Point(165, 304);

            departmentComboBox1.DataSource = dataLayer.GetDepartments();
            departmentComboBox1.DisplayMember = "Department_name";
            departmentComboBox1.ValueMember = "Departmentid";

            roleComboBox1.DataSource = dataLayer.GetRoles();
            roleComboBox1.DisplayMember = "Role_name";
            roleComboBox1.ValueMember = "Roleid";


            Phone_txtbox_add.Text = username_txtbox1.Text = firstName_txtbox1.Text = lastName_txtbox1.Text = "";
            onDuty_checkbox1.Checked = admin_checkbox1.Checked = false;
            

        }

        private void RemoveRecord_Click(object sender, EventArgs e)
        {


            DataGridViewRow selectedRow = dgv.CurrentRow;
            int id = (int)selectedRow.Cells[0].Value;
            string name = (string)selectedRow.Cells[1].Value;
            DialogResult dialogResult = MessageBox.Show("Do you want to delete " + name, "Confirm deletion.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataLayer.RemoveEmployee(id);
                LoadAll();


             }
                    
               
        }

        private void EditRecord_Click(object sender, EventArgs e)
        {
            recordAddpnl.Visible = false;
            recordEditpnl.Visible = true;
            recordEditpnl.Location = new Point(165, 304);
      



            departmentComboBox2.DataSource = dataLayer.GetDepartments();
            departmentComboBox2.DisplayMember = "Department_name";
            departmentComboBox2.ValueMember = "Departmentid";

            roleComboBox2.DataSource = dataLayer.GetRoles();
            roleComboBox2.DisplayMember = "Role_name";
            roleComboBox2.ValueMember = "Roleid";

       


            Int32 selectedColumnCount = dgv.Columns.GetColumnCount(DataGridViewElementStates.Selected);
 

                    DataGridViewRow selectedRow = dgv.CurrentRow;
                    int id = (int)selectedRow.Cells[0].Value;
                    username_txtbox2.Text = (string)selectedRow.Cells[1].Value;
                    firstName_txtbox2.Text = (string)selectedRow.Cells[2].Value;
                    lastName_txtbox2.Text = (string)selectedRow.Cells[3].Value;
 
                    roleComboBox2.Text = (string)selectedRow.Cells[4].Value;
                    departmentComboBox2.Text = (string)selectedRow.Cells[5].Value;
                    
                   admin_checkbox2.Checked = Convert.ToBoolean(selectedRow.Cells[6].Value);
                   onDuty_checkbox2.Checked = Convert.ToBoolean(selectedRow.Cells[7].Value);
                   dateTimePicker2.Value = Convert.ToDateTime(selectedRow.Cells[8].Value);
                   Phone_txtbox_edit.Text = (string)selectedRow.Cells[9].Value;

        }

        private void LoadEmp_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void SubmitNewbtn_Click(object sender, EventArgs e)
        {
            if (emptyPanelfields(recordAddpnl) == true)
            {
                if (dataLayer.CheckUsername(username_txtbox1.Text) == false) {
                    dataLayer.InsertEmployee(
                     firstName_txtbox1.Text,
                     lastName_txtbox1.Text,
                     "password12345",
                     username_txtbox1.Text,
                    Convert.ToInt32(departmentComboBox1.SelectedValue),
                    Convert.ToInt32(roleComboBox1.SelectedValue),
                     Phone_txtbox_add.Text,
                     admin_checkbox1.Checked,
                     onDuty_checkbox2.Checked,
                     dateTimePicker1.Value




                     );
                    LoadAll();

                    Phone_txtbox_add.Text = username_txtbox1.Text = firstName_txtbox1.Text = lastName_txtbox1.Text = "";
                    onDuty_checkbox1.Checked = admin_checkbox1.Checked = false;

                }
                else
                {
                    MessageBox.Show("Username Exists");
                    username_txtbox1.Text = "";
                }
            }


        }


        private void SubmitChangepnl_Click(object sender, EventArgs e)
        {

        }

        private void SubmitChangebtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgv.CurrentRow;
            int id = (int)selectedRow.Cells[0].Value;

            if (emptyPanelfields(recordEditpnl) == true)
            {

                if (dataLayer.CheckUsername(username_txtbox2.Text) == false)
                {
                    dataLayer.UpdateEmployee(
                    id,
                    firstName_txtbox2.Text,
                    lastName_txtbox2.Text,
                     username_txtbox2.Text,
                     Convert.ToInt32(departmentComboBox2.SelectedValue),
                     Convert.ToInt32(roleComboBox2.SelectedValue),
                     Phone_txtbox_edit.Text,
                     admin_checkbox2.Checked,
                     onDuty_checkbox2.Checked,
                     dateTimePicker2.Value




                    );
                    LoadAll();
                }
                else
                {
                    MessageBox.Show("Username Exists");
                    username_txtbox2.Text = "";
                }
            }


        }
        private bool emptyPanelfields(Panel pnl)
        {
            foreach (TextBox tb in pnl.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text.Trim()))
                {
                    MessageBox.Show("Fields can't be empty");
                    return false;
                }

            }
            return true;

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Account.GetInstance().Username = null;
            Account.GetInstance().IsAdmin = false;

            this.Hide();
            LogReg_form l = new LogReg_form();
            l.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HolidayRequestsForm h = new HolidayRequestsForm();
            h.Show();
        }
    }
}