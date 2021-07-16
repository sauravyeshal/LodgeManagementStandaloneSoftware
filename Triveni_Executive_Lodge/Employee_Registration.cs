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

    public partial class Employee_Registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Trivenidb;Integrated Security=True");
        String imagelocation = "";
            SqlCommand cmd;
        public Employee_Registration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            picupes.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string ImageLocation = "";
            OpenFileDialog dia = new OpenFileDialog();

            dia.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dia.ShowDialog() == DialogResult.OK)
            {
                imagelocation = dia.FileName.ToString();
                picupes.ImageLocation = imagelocation;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            
            //store images
              
                byte[] images = null;
                FileStream Stream = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Stream);
                images = brs.ReadBytes((int)Stream.Length);
                if (con.State != ConnectionState.Open)
                    con.Open();
                string sql = "Insert into empt_reg(eid,name,age,gender,country,zip,state,city,address,mob,email,image)values('" + txtempid.Text + "','" + txtname.Text + "','" + txtage.Text + "','" + txtgender.Text + "','" + cmbcountry.Text + "','" + txtzip.Text + "','" + cmbstate.Text + "','" + cmbcity.Text + "','" + txtaddress.Text + "','" + txtphone.Text + "','" + txtemail.Text + "',@images)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Saved");
                MainPage mp = new MainPage();
                mp.Show();
            
          

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {/*
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }//end*/
        }

        private void txtempid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }//end

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }//end
        }

        private void txtzip_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }//end
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }//end
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            {
                Regex mRegxExpression;

                if (txtemail.Text.Trim() != string.Empty)
                {

                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(txtemail.Text.Trim()))
                    {

                        MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtemail.Focus();

                    }
                }
            }
        }
    }
}
