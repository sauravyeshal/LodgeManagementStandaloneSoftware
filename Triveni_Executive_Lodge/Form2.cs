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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trivenidbDataSet.custreg' table. You can move, or remove it, as needed.
            this.custregTableAdapter.Fill(this.trivenidbDataSet.custreg);

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
