﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BusinessLayer;

namespace Project.PresentationLayer
{
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
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
    }
}
