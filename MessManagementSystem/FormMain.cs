using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessManagementSystem
{
    public partial class FormMain : Form
    {
        public static Form main;
        public FormMain()
        {
            InitializeComponent();
        }
        // Go To Attendence Manager's Account When login Button is Pressed (UserName and Password Should be matched)
        private void btnManagerLogin_Click(object sender, EventArgs e)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();
            var varAttendenceManager = mms.AttendenceManagers.Where(x => x.UserName == txtBxManagerName.Text &&
                x.Password == txtBxManagerPword.Text).FirstOrDefault();
            if (varAttendenceManager != null)
            {
                FormAttendenceManager attendenceManagerForm = new FormAttendenceManager();
                attendenceManagerForm.Show();
                main = this;
                this.Hide();
                txtBxManagerName.Text = null;
                txtBxManagerPword.Text = null;

            }

            else
            {
                MessageBox.Show("Incorrect Password or Username");
                txtBxManagerName.Text = null;
                txtBxManagerPword.Text = null;
            }

        }

        // Go To Clerk's Account When login Button is Pressed (UserName and Password Should be matched)
        private void btnClerkLogin_Click(object sender, EventArgs e)
        {
            // Clerk clerk = new Clerk();
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();
            var varClerk = mms.Clerks.Where(x => x.UserName == txtbxClerkUserName.Text &&
                x.Password == txtBxClerkPword.Text).FirstOrDefault();
            if (varClerk != null)
            {
                FormClerk clerkForm = new FormClerk();
                clerkForm.Show();
                main = this;
                this.Hide();
                txtbxClerkUserName.Text = null;
                txtBxClerkPword.Text = null;
            }
            else
            {
                MessageBox.Show("Incorrect Password or Username");
                txtbxClerkUserName.Text = null;
                txtBxClerkPword.Text = null;
            }
        }

        // Exit Button ==> ask and confirm to close application Then close it .
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
