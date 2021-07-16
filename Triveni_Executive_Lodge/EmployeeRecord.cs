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
    public partial class EmployeeRecord : Form
    {
        DataTable dtb1;
        String connectionString = @"Data Source=localhost;Initial Catalog=Trivenidb; Integrated Security=True";
        public EmployeeRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM empt_reg", sqlCon);
                 dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                dgv2.DataSource = dtb1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtb1);
            DV.RowFilter = string.Format("name LIKE '%{0}%'", textBox1.Text);
            dgv2.DataSource = DV;
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
