using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSharp_Manage_Contact
{
    public partial class Login_Register_Form : Form
    {
     
        public Login_Register_Form()
        {
            InitializeComponent();
        }

       
      /*  private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            // displaying image on the panel(close and minimize)
            panel1.BackgroundImage = Image.FromFile("../../images/cancel.png");
            panel1.BackgroundImage = Image.FromFile("../../images/mize.png");
        }
        */

        //login button 
        private void Button_Signin_Click(object sender, EventArgs e)
        {

        }

        // register button
        private void Button_SignUp_Click(object sender, EventArgs e)
        {

        }
        //search for image
        private void Button_Search_Click(object sender, EventArgs e)
        {

        }
        // label go to the register page
        private void Label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label_GoToRegister.Enabled = false;
            label_GoToLogin.Enabled = false;
        }
        // label go to login page
        private void Label1_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
            label_GoToRegister.Enabled = false;
            label_GoToLogin.Enabled = false;
        }
        // button close
        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        //button minimize
        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        // when this timer will start we will show only the register page
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //-320 is where you can see the register page
            // the first 320 is where the login page is
            // so the panel need to go outside the form by 320
            //and the same when we want to show the login part
            if(panel5.Location.X > -320)
            {
                panel5.Location = new Point(panel5.Location.X-10, panel5.Location.Y);
            }
            else
            {
                timer1.Stop();
                label_GoToLogin.Enabled = true;
                label_GoToRegister.Enabled = true;
                
            }
        }
        // when this timer will start we will show only the login page
        private void Timer2_Tick(object sender, EventArgs e)
        {

            if (panel5.Location.X < 0)
            {
                panel5.Location = new Point(panel5.Location.X + 10, panel5.Location.Y);
            }
            else
            {
                timer2.Stop();
                label_GoToLogin.Enabled = true;
                label_GoToRegister.Enabled = true;

            }
        }
    }
}
