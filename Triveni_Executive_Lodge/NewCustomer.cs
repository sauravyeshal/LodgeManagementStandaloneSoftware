using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;
namespace Triveni_Executive_Lodge
{

    public partial class NewCustomer : Form
    {

        SqlConnection con = new SqlConnection("Data Source=localhost;initial catalog=Trivenidb;Integrated security=true");
        String imagelocation = "";
        SqlCommand cmd; 
        public NewCustomer()
        {
           
            InitializeComponent();
        }

        private void cmbgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbstate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            picup.Image = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                   
        }

        private void picup_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (picup.Image == null)
            {
                MessageBox.Show("You Dont Have Image");
            }
            try
            {
                //store images
                byte[] images = null;
                FileStream Stream = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Stream);
                images = brs.ReadBytes((int)Stream.Length);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into customer_reg(name,contact,address,email,bookdate,leavingdate,roomno,image) values('" + txtname.Text + "','" + txtcontact.Text + "','" + txtaddress.Text + "','" + txtemail.Text + "','" + dtpbooking.Text + "','" + dtpleaving.Text + "','" + txtroom.Text + "',@images)", con);
                // SqlCommand cmd = new SqlCommand("delete from t1 where no='"+textBox1.Text+"'", con);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                cmd.ExecuteNonQuery();
                MessageBox.Show("record saved");
                this.Close();
            }
            catch(Exception EX)
            {

            }


        }

        private void button8_Click(object sender, EventArgs e)
        {

            OpenFileDialog dia = new OpenFileDialog();
            // String imagelocation = "";
            dia.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dia.ShowDialog() == DialogResult.OK)
            {
                imagelocation = dia.FileName.ToString();
                picup.ImageLocation = imagelocation;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            picup.Image = null;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtname_Enter(object sender, EventArgs e)
        {

        }

        private void txtcontact_Leave(object sender, EventArgs e)
        {
            if ((txtcontact.Text.Length < 10) && (txtcontact.Text.Length > 0))
            {
                MessageBox.Show("Phone number must be 10 digits!");
                txtcontact.Focus();
            }

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtaddress_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtroom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtroom_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_Leave(object sender, EventArgs e)
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

        private void picup_Click_1(object sender, EventArgs e)
        {

        }

        private void picup_Validating(object sender, CancelEventArgs e)
        {
           

        }

        private void picup_Validated(object sender, EventArgs e)
        {
            if (picup.Image != null)
            {
                MessageBox.Show("You Have Image");
            }
            else if (picup.Image == null)
            {
                MessageBox.Show("You Dont Have Image");
            }
        }
    }
}
