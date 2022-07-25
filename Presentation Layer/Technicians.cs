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

            dgvTechnicians.DataSource = new Technician().ViewTechnicians();
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

        private void btnAddTechnician_Click(object sender, EventArgs e)
        {
            try
            {
                Technician technician = new Technician();

                technician.Name = txtName.Text;
                technician.Surname = txtSurname.Text;
                technician.PhoneNumber = txtNumber.Text;
                technician.Job_Description = txtDescription.Text;
                technician.Employee_ID = Convert.ToInt32(txtTechnicianID.Text);
                technician.Branch = Convert.ToInt32(txtBranch.Text);

                if (new Validator().NotNull(technician))
                {
                    technician.AddTechnician();
                    technician.AddEmployee();

                    dgvTechnicians.DataSource = new ServiceRequest().ViewRequests();

                    MessageBox.Show("Technician added successfully", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Please fill in all the required details",null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to add technician", "Operation Unsuccessful", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnUpdateTechnician_Click(object sender, EventArgs e)
        {
            try
            {
                Technician technician = new Technician();

                technician.Name = txtName.Text;
                technician.Surname = txtSurname.Text;
                technician.PhoneNumber = txtNumber.Text;
                technician.Job_Description = txtDescription.Text;
                technician.Employee_ID = Convert.ToInt32(txtTechnicianID.Text);

                if (new Validator().NotNull(technician))
                {
                    technician.UpdateTechnician();

                    dgvTechnicians.DataSource = new ServiceRequest().ViewRequests();

                    MessageBox.Show("Technician updated successfully", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please fill in all the required details", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to update technician", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTechnician_Click(object sender, EventArgs e)
        {
            try
            {
                Technician technician = new Technician();
                technician.Employee_ID = Convert.ToInt32(txtTechnicianID.Text);

                if (MessageBox.Show($"Are you sure you want to remove {dgvTechnicians.CurrentRow.Cells[0].Value}", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString() == "Yes")
                {
                    technician.DeleteEmployee();

                    dgvTechnicians.DataSource = new ServiceRequest().ViewRequests();
                }
            }
            catch
            {
                MessageBox.Show("Failed to delete technician", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchTechnician_Click(object sender, EventArgs e)
        {
            try
            {
                Technician technician = new Technician();
                technician.Employee_ID = Convert.ToInt32(txtTechnicianID.Text);

                if (new Validator().NotNull(technician))
                {
                    dgvTechnicians.DataSource = technician.SearchTechnician();
                }
                else
                {
                    MessageBox.Show("Please fill in all the required details", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to update technician", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
