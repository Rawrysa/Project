﻿using System;
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
    public partial class Contracts : Form
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

        public Contracts()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnContracts.Height;
            pnlNav.Top = btnContracts.Top;
            pnlNav.Left = btnContracts.Left;
            btnContracts.BackColor = Color.FromArgb(46, 51, 73);
            lblLoginUsername.Text = new Logins().Username;

            dgrContracts.DataSource = new Contract().ViewContracts();
        }

        private void btnContractAvailability_Click(object sender, EventArgs e)
        {
            try
            {
                Contract contract = new Contract();
                contract.Contract_ID = Convert.ToInt32(dgrContracts.CurrentRow.Cells[0].Value);

                if (dgrContracts.CurrentRow.Cells[5].Value.ToString() != "Available")
                {
                    contract.Availability = "Available";
                    contract.ContractAvailability();
                }
                else
                {
                    contract.Availability = "Unavailable";
                    contract.ContractAvailability();
                }

                dgrContracts.DataSource = contract.ViewContracts();
            }
            catch
            {
                MessageBox.Show("Failed to change availability", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnContractPerformance_Click(object sender, EventArgs e)
        {
            try
            {
                Contract contract = new Contract();
                contract.Contract_ID = Convert.ToInt32(dgrContracts.CurrentRow.Cells[0].Value);

                MessageBox.Show($"This contract has {contract.ContractPerformance().Rows[0].ItemArray[0]} sales",null,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to retrieve contract information", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
