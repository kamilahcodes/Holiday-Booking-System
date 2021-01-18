using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Booking_System
{
    class dbConnectionClass
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
       
        public IOrderedQueryable<Employee_view> FillDataGrid()
        {
            var q = from p in context.Employee_views
                    orderby p.Employee_id
                    select p;

            return q;
        }

        public List<Department> GetDepartments()
        {
            var q = context.Departments.ToList();

            return q;
        }

        public List<Role> GetRoles()
        {
            var q = context.Roles.ToList();

            return q;
        }

        public Employee GetSingleEmployee(int id)
        {
            var r = (from p in context.Employees
                     where p.Employee_id == id
                     select p).SingleOrDefault();
            return r;
        }

        public void RemoveEmployee(int id)
        {
            var r = (from p in context.Employees
                     where p.Employee_id == id
                     select p).FirstOrDefault();
            context.Employees.DeleteOnSubmit(r);
            context.SubmitChanges();
        }

        public void InsertEmployee(string fn, string ln, string pw, string un, int dptID, int roleId, string pn, bool admin, bool duty, DateTime date)
        {
            Employee emp = new Employee();
            emp.First_name = fn;
            emp.Last_name = ln;
            emp.Password = pw;
            emp.Username = un;
            emp.Departmentid = dptID;
            emp.Roleid = roleId;
            emp.Phone_number = pn;
            emp.is_admin = admin;
            emp.on_duty = duty;
            emp.date_joined = date;

     
           
            context.Employees.InsertOnSubmit(emp);
            context.SubmitChanges();
        }


        public void UpdateEmployee(int empId, string fn, string ln, string un, int dptID, int roleId, string pn, bool admin, bool duty, DateTime date)
        {
            Employee emp = GetSingleEmployee(empId);
            emp.First_name = fn;
            emp.Last_name = ln;
            //emp.Password = pw;
            emp.Username = un;
            emp.Departmentid = dptID;
            emp.Roleid = roleId;
            emp.Phone_number = pn;
            emp.is_admin = admin;
            emp.on_duty = duty;
            emp.date_joined = date;



 
            context.SubmitChanges();
        }

        public bool CheckUsername(string username)
        {
            bool result;
            var q = from p in context.Employees
                    where p.Username == username
                     select p;


            if (q.Any())
            {


                result= true;


            }
            else
            {
                result = false;
            }

            return result;
        }


    }
}

