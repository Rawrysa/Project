using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BusinessLayer;
using System.Runtime.InteropServices;

namespace Project.PresentationLayer
{
    public partial class Requests : Form
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

        public Requests()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = 0;
            pnlNav.Top = 0;
            pnlNav.Left = 0;
            //lblLoginUsername.Text = username;

            Text = "Service Requests";

            dgvRequests.DataSource = new ServiceRequest().ViewRequests();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRequests.CurrentCell = dgvRequests.Rows[0].Cells[0];

                txtClientID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[1].Value);
                txtServiceID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[2].Value);
            }
            catch
            {
            }
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRequests.CurrentCell = dgvRequests.Rows[dgvRequests.CurrentRow.Index - 1].Cells[0];

                txtClientID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[1].Value);
                txtServiceID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[2].Value);
            }
            catch
            {
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRequests.CurrentCell = dgvRequests.Rows[dgvRequests.CurrentRow.Index + 1].Cells[0];

                txtClientID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[1].Value);
                txtServiceID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[2].Value);
            }
            catch
            {
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRequests.CurrentCell = dgvRequests.Rows[dgvRequests.RowCount - 2].Cells[0];

                txtClientID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[1].Value);
                txtServiceID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[2].Value);
            }
            catch
            {
            }
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceRequest newrequest = new ServiceRequest();
                newrequest.Client_ID = Convert.ToInt32(txtClientID.Text);
                newrequest.Service_ID = Convert.ToInt32(txtServiceID.Text);

                newrequest.NewRequest();
                dgvRequests.DataSource = new ServiceRequest().ViewRequests();
            }
            catch
            {
            }
        }

        private void btnRemoveRequest_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show($"Are you sure you want to remove {dgvRequests.CurrentRow.Cells[0].Value}", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString() == "Yes")
                {
                    ServiceRequest newrequest = new ServiceRequest();
                    newrequest.Request_ID = Convert.ToInt32(dgvRequests.CurrentRow.Cells[0].Value);

                    newrequest.RemoveRequest();
                    dgvRequests.DataSource = new ServiceRequest().ViewRequests();
                }
            }
            catch
            {
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new SplashScreen().Show();
            this.Hide();
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
    }
}
