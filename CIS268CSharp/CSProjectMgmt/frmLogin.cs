using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        }

        private void cmdReset_Click(object sender, EventArgs e)
        {

        }


        //When the user clicks the login button:
        // * Read username password from filedatabase (usercred.txt)
        // * Goto main form.
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            String currentLine;
            String userCredentialsToCheck = txtUsername.Text + txtPassword.Text;

            // Read the file
            System.IO.StreamReader usercreds = new System.IO.StreamReader("usercred.txt");

            //while the file reader hasn't reach the end of the file.
            while ((currentLine = usercreds.ReadLine()) != null)
            {
                if (currentLine == userCredentialsToCheck)
                {
                    //Entered correct username and password, change user form to main.
                }

            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
