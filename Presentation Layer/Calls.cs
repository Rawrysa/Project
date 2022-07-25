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
using Project.BusinessLayer;

namespace Project.PresentationLayer
{
    public partial class Calls : Form
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

        public Calls()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnAgents.Height;
            pnlNav.Top = btnAgents.Top;
            pnlNav.Left = btnAgents.Left;
            btnAgents.BackColor = Color.FromArgb(46, 51, 73);
            //lblLoginUsername.Text = username;

            dataGridView1.DataSource = new Call().ViewCalls();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Calls_Load(object sender, EventArgs e)
        {

        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            new Agents().Show();
            this.Hide();
        }

        private void btnCalls_Click(object sender, EventArgs e)
        {
            new Calls().Show();
            this.Hide();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            new Clients().Show();
            this.Hide();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            new Contracts().Show();
            this.Hide();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            new Employees().Show();
            this.Hide();
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            new Jobs().Show();
            this.Hide();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            new Requests().Show();
            this.Hide();
        }

        private void btnTechnicians_Click(object sender, EventArgs e)
        {
            new Technicians().Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            new Services().Show();
            this.Hide();
        }

        private void btnNewCall_Click(object sender, EventArgs e)
        {
            try
            {
                Call call = new Call();

                call.Call_Date = DateTime.Today.ToString();
                call.Call_Duration = txtDuration.Text;
                call.Client_Phonenumber = txtNumber.Text;
                call.Client_Problem = txtProblem.Text;
                call.Client_ID = Convert.ToInt32(txtClientID.Text);

                if (new Validator().NotNull(call))
                {
                    call.NewCall();

                    dataGridView1.DataSource = new ServiceRequest().ViewRequests();

                    MessageBox.Show("Call added successfully", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Please fill in all the required details", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to add Call", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
