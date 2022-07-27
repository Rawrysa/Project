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
    public partial class Jobs : Form
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

        public Jobs()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnJobs.Height;
            pnlNav.Top = btnJobs.Top;
            pnlNav.Left = btnJobs.Left;
            btnJobs.BackColor = Color.FromArgb(46, 51, 73);
            lblLoginUsername.Text = new Logins().Username;

            dgvJobs.DataSource = new Job().ViewJobs();
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

        private void btnEscalateJob_Click(object sender, EventArgs e)
        {
            try
            {
                Job job = new Job();
                job.Job_ID = Convert.ToInt32(dgvJobs.CurrentRow.Cells[0].Value);

                if (MessageBox.Show($"Are you sure you want to escalate {dgvJobs.CurrentRow.Cells[0].Value}", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString() == "Yes")
                {
                    if (dgvJobs.CurrentRow.Cells[1].Value.ToString().ToLower() != "high")
                    {
                        job.Priority = "High";

                        dgvJobs.DataSource = job.ViewJobs();
                    }
                    else
                    {
                        MessageBox.Show("Job already assigned highest priority possible");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to close job", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            try
            {
                Job job = new Job();
                Client client = new Client();
                Technician technician = new Technician();

                client.Client_ID = Convert.ToInt32(txtClientID.Text);

                job.Priority = client.ClientAgreement().Rows[0].ItemArray[2].ToString();
                job.Technician_ID = Convert.ToInt32(txtTechnicianID.Text);
                job.Client_ID = Convert.ToInt32(txtClientID.Text);
                job.Service_ID = Convert.ToInt32(txtServiceID.Text);

                technician.Employee_ID = Convert.ToInt32(txtTechnicianID.Text);

                if (new Validator().NotNull(job))
                {
                    if (technician.SearchTechnician().Rows[0].ItemArray[4].ToString() == "Available")
                    {
                        job.NewJob();

                        dgvJobs.DataSource = job.ViewJobs();

                        MessageBox.Show("Job added successfully", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Technician is unavailable");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the required details", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to assign job", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTechnicianID.Text = dgvJobs.CurrentRow.Cells[2].Value.ToString();
            txtClientID.Text = dgvJobs.CurrentRow.Cells[3].Value.ToString();
            txtServiceID.Text = dgvJobs.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnCloseJob_Click(object sender, EventArgs e)
        {
            try
            {
                Job job = new Job();
                job.Job_ID = Convert.ToInt32(dgvJobs.CurrentRow.Cells[0].Value);

                if (MessageBox.Show($"Are you sure you want to close {dgvJobs.CurrentRow.Cells[0].Value}", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString() == "Yes")
                {
                    job.CloseJob();

                    dgvJobs.DataSource = job.ViewJobs();
                }
            }
            catch
            {
                MessageBox.Show("Failed to close job", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTrackJob_Click(object sender, EventArgs e)
        {
            try
            {
                Job job = new Job();
                job.Job_ID = Convert.ToInt32(dgvJobs.CurrentRow.Cells[0].Value);

                if (new Validator().NotNull(job))
                {
                    dgvJobs.DataSource = job.TrackJob();
                }
                else
                {
                    MessageBox.Show("Please fill in all the required details", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to find job", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReassignJob_Click(object sender, EventArgs e)
        {
            try
            {
                Job job = new Job();
                job.Job_ID = Convert.ToInt32(dgvJobs.CurrentRow.Cells[0].Value);

                Technician technician = new Technician();
                technician.Employee_ID = Convert.ToInt32(txtTechnicianID.Text);

                if (MessageBox.Show($"Are you sure you want to assign {txtTechnicianID.Text} to this job?", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString() == "Yes")
                {
                    if (technician.SearchTechnician().Rows[0].ItemArray[4].ToString() == "Available")
                    {
                        job.Technician_ID = Convert.ToInt32(txtTechnicianID.Text);

                        job.ReassignJob();
                    }
                    else
                    {
                        MessageBox.Show("Technician is unavailable");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to reassign job", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
