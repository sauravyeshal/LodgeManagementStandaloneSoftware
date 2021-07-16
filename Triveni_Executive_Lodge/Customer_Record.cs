using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;


namespace Triveni_Executive_Lodge
{
    public partial class Customer_Record : Form
    {
        DataTable dtb1,dtb2;
        String connectionString = @"Data Source=localhost;Initial Catalog=Trivenidb; Integrated Security=True";
        public Customer_Record()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM customer_reg", sqlCon);
                dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                dataGridView1.DataSource = dtb1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM foodprice", sqlCon);
                dtb2 = new DataTable();
                sqlDa.Fill(dtb2);

                dataGridView2.DataSource = dtb2;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtb1);
            DV.RowFilter = string.Format("name LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = DV;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtb2);
            DV.RowFilter = string.Format("name LIKE '%{0}%'", textBox2.Text);
            dataGridView2.DataSource = DV;

        }

        private void Customer_Record_Load(object sender, EventArgs e)
        {

        }
    }
}
