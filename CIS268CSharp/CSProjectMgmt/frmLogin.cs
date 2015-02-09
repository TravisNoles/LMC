using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms;

namespace CSProjectMgmt
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
   
            // Setup and initiliaze
            if (!System.IO.File.Exists("usercred.txt")) // if userpass db doesn't exist:
            {
                using (FileStream fs = File.Create("usercred.text")) //using fileestream namespace
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("username password" + System.Environment.NewLine + "admin password"); //default data in file
                    //Create new user.
                }
            }else//if file exists (expected on second and beyond launches)
            {
                // Process the file (Check for username and password.

            }


        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            // Password reset form/popup
        }


        //When the user clicks the login button:
        // 1) Read username password from filedatabase (usercred.txt)
        // 2) Check credentials w/ file.
        // 3) IF correct goto main form.
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            String currentLine;
            String userCredentialsToCheck = txtUsername.Text + " " + txtPassword.Text; // store to 

            // Read the file
            System.IO.StreamReader usercreds = new System.IO.StreamReader("usercred.txt");


            while ((currentLine = usercreds.ReadLine()) != null)  //while the file reader hasn't reach the end of the file.
            {
                if (currentLine == userCredentialsToCheck)
                {
                    //If entered correct username and password, change user form to main.
                }else
                {



                }

            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {

        }

    }
}
