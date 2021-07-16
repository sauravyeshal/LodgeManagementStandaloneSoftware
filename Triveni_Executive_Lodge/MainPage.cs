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
using System.IO;
using System.Text.RegularExpressions;


namespace Triveni_Executive_Lodge
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hide main form
            this.Hide();

            // show other form
            loginform form2 = new loginform();
            form2.ShowDialog();

            // close application
            this.Close();
   
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomer nc = new NewCustomer();
            nc.Show();
            
        }

        private void roomREgistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Registration er = new Employee_Registration();
            er.Show();
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
          
        }

        private void customerRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Record rd = new Customer_Record();
            rd.Show();

        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void employRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeRecord er = new EmployeeRecord();
            er.Show();
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            }

        private void foodDishesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            food f = new food();
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            NewCustomer mp = new NewCustomer();
            mp.TopLevel = false;
            MainPanel.Controls.Add(mp);
            mp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mp.Dock = DockStyle.Fill;
            mp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Employee_Registration mp = new Employee_Registration();
            mp.TopLevel = false;
            MainPanel.Controls.Add(mp);
            mp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mp.Dock = DockStyle.Fill;
            mp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            food mp = new food();
            mp.TopLevel = false;
            MainPanel.Controls.Add(mp);
            mp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mp.Dock = DockStyle.Fill;
            mp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Customer_Record mp = new Customer_Record();
            mp.TopLevel = false;
            MainPanel.Controls.Add(mp);
            mp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mp.Dock = DockStyle.Fill;
            mp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            EmployeeRecord mp = new EmployeeRecord();
            mp.TopLevel = false;
            MainPanel.Controls.Add(mp);
            mp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mp.Dock = DockStyle.Fill;
            mp.Show();
        }
    }
}
