using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Forms;

namespace Project
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            Text = "Home Page...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DataHandler().ViewClients();
            //Application.Run(new Forms.SplashScreen());
            new SplashScreen().Show();
            this.Hide();
        }
    }
}
