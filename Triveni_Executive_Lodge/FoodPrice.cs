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
    public partial class FoodPrice : Form
    {

        SqlConnection con = new SqlConnection("Data Source=localhost;initial catalog=Trivenidb;Integrated security=true");
       // String imagelocation = "";
        SqlCommand cmd; 
        public FoodPrice()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                //byte[] images = null;
                // FileStream Stream = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
                //BinaryReader brs = new BinaryReader(Stream);
                // images = brs.ReadBytes((int)Stream.Length);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into foodprice(name,FoodName,PlateQuantity,Price) values('" + txtcust.Text + "','" + txtfoodname.Text + "','" + cmbquantity.Text + "','" + txtprice.Text + "')", con);
                // SqlCommand cmd = new SqlCommand("delete from t1 where no='"+textBox1.Text+"'", con);
                //cmd.Parameters.Add(new SqlParameter("@images", images));
                cmd.ExecuteNonQuery();
                MessageBox.Show("record saved");
            }
            catch (Exception ex)
            {
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcust_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtcust_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }

        }

        private void txtfoodname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfoodname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }

        }

        private void cmbquantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcust_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcust.Text))
            {
                MessageBox.Show("Enter Customer Name");
            }
        }

        private void txtfoodname_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfoodname.Text))
            {
                MessageBox.Show("Enter Food Name");
            }
        }

        private void cmbquantity_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbquantity.Text))
            {
                MessageBox.Show("Enter Food Quantity");
            }
        }

        private void txtprice_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtprice.Text))
            {
                MessageBox.Show("Enter Price");
            }
        }
    }
}
