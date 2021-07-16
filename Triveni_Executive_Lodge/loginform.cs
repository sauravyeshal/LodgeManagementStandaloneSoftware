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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
                    SqlConnection con = new SqlConnection("Data Source=localhost;initial catalog=Trivenidb;Integrated security=true");
       
            bool login=false;
  con.Open();
String sql = "select * from loginpage where username='" + usertxt.Text + "' and password='" + pwdtxt.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr=cmd.ExecuteReader();
while(dr.Read())
{
login=true;
}
dr.Close();
con.Close();
if(login==true)
{
    // hide main form
    this.Hide();

    // show other form
    MainPage form2 = new MainPage();
    form2.ShowDialog();

    // close application
    this.Close();
   
    
}
else
{
MessageBox.Show("Failed");
}


  }
            


        private void canbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginfrom_Load(object sender, EventArgs e)
        {
            
        }

        private void LPlabel_Click(object sender, EventArgs e)
        {

        }

        private void pwdtxt_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void pwdtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pwdtxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(pwdtxt.Text))
            {
                errorProvider1.SetError(pwdtxt, "Password required!");
            }
            else if (!Regex.IsMatch(pwdtxt.Text, @"[A-Za-z][A-Za-z0-9]{2,7}"))
            {
                errorProvider1.SetError(pwdtxt, "Password invalid!");
            }
            else
            {
                errorProvider1.SetError(pwdtxt, null);
            }
        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        }
    
}
