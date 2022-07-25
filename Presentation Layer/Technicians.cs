using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Project.PresentationLayer
{
    public partial class Technicians : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightWllipse
        );

        public Technicians()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = 0;
            pnlNav.Top = 0;
            pnlNav.Left = 0;
            //lblLoginUsername.Text = username;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            new Agents().Show();
            this.Hide();
        }

        private void btnCalls_Click(object sender, EventArgs e)
        {
            new Agents().Show();
            this.Hide();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            new Agents().Show();
            this.Hide();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            new Agents().Show();
            this.Hide();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            new Agents().Show();
            this.Hide();
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            new Agents().Show();
            this.Hide();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            new Agents().Show();
            this.Hide();
        }

        private void btnTechnicians_Click(object sender, EventArgs e)
        {
            new Agents().Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new Agents().Show();
            this.Hide();
        }
    }
}
