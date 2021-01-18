using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holiday_Booking_System
{
    public partial class PhoneTextBoxComponent : System.Windows.Forms.TextBox
    {
       
      //// private int Length = 11;
       private Color ErrorColor = Color.Red;
     
        public PhoneTextBoxComponent()
        {

            //BackColor = Color.Gray;
            InitializeComponent();
        }

        public PhoneTextBoxComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                
            }
            if (base.Text.Length >= 11)
            {
                base.ForeColor = this.ErrorColor;
            }
            


        }
    }
}
