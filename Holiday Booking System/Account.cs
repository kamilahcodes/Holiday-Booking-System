using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Booking_System
{
     class Account
    {
        private bool isAdmin;
        private string username;

        static Account instance = null;

         private Account() {

        }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public string Username { get => username; set => username = value; }

        // This is the static method that controls the access to the singleton
        // instance. On the first run, it creates a singleton object and places
        // it into the static field. On subsequent runs, it returns the client
        // existing object stored in the static field.
        public static Account GetInstance()
        {
            if (instance == null)
            {
                instance = new Account();
            }
            return instance;
        }

    }
}
