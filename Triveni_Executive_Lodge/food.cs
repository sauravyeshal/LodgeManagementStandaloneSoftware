using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triveni_Executive_Lodge
{
    public partial class food : Form
    {
        public food()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            MaharashtraPanel mp = new MaharashtraPanel();
            mp.TopLevel = false;
            panel2.Controls.Add(mp);
            mp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mp.Dock=DockStyle.Fill;
            mp.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void food_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            PanjabPanel pp = new PanjabPanel();
            pp.TopLevel = false;
            panel2.Controls.Add(pp);
            pp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pp.Dock = DockStyle.Fill;
            pp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            GujratPanel gp = new GujratPanel();
            gp.TopLevel = false;
            panel2.Controls.Add(gp);
            gp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gp.Dock = DockStyle.Fill;
            gp.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Hydrabad hp = new Hydrabad();
            hp.TopLevel = false;
            panel2.Controls.Add(hp);
            hp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            hp.Dock = DockStyle.Fill;
            hp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            KerlaPanel kp = new KerlaPanel();
            kp.TopLevel = false;
            panel2.Controls.Add(kp);
            kp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            kp.Dock = DockStyle.Fill;
            kp.Show();
        }
    }
}
