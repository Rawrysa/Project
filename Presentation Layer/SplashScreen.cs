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

namespace Project.PresentationLayer
{
    public partial class SplashScreen : Form
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

        public SplashScreen()
        {
            InitializeComponent();
        }

        public SplashScreen(string username)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = 0;
            pnlNav.Top = 0;
            pnlNav.Left = 0;
            lblLoginUsername.Text = username;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
        
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAgents.Height;
            pnlNav.Top = btnAgents.Top;
            pnlNav.Left = btnAgents.Left;
            btnAgents.BackColor = Color.FromArgb(46,51,73);
        }

        private void btnCalls_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalls.Height;
            pnlNav.Top = btnCalls.Top;
            pnlNav.Left = btnCalls.Left;
            btnCalls.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnClients.Height;
            pnlNav.Top = btnClients.Top;
            pnlNav.Left = btnClients.Left;
            btnClients.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContracts.Height;
            pnlNav.Top = btnContracts.Top;
            pnlNav.Left = btnContracts.Left;
            btnContracts.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEmployees.Height;
            pnlNav.Top = btnEmployees.Top;
            pnlNav.Left = btnEmployees.Left;
            btnEmployees.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnJobs.Height;
            pnlNav.Top = btnJobs.Top;
            pnlNav.Left = btnJobs.Left;
            btnJobs.BackColor = Color.FromArgb(46, 51, 73); pnlNav.Height = btnCalls.Height;
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnRequests.Height;
            pnlNav.Top = btnRequests.Top;
            pnlNav.Left = btnRequests.Left;
            btnRequests.BackColor = Color.FromArgb(46, 51, 73); pnlNav.Height = btnCalls.Height;
        }

        private void btnTechnicians_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTechnicians.Height;
            pnlNav.Top = btnTechnicians.Top;
            pnlNav.Left = btnTechnicians.Left;
            btnTechnicians.BackColor = Color.FromArgb(46, 51, 73); pnlNav.Height = btnCalls.Height;
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnQuit.Height;
            pnlNav.Top = btnQuit.Top;
            pnlNav.Left = btnQuit.Left;
            btnQuit.BackColor = Color.FromArgb(46, 51, 73);

            Environment.Exit(0);
        }

        private void btnAgents_Leave(object sender, EventArgs e)
        {
            btnAgents.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnCalls_Leave(object sender, EventArgs e)
        {
            btnCalls.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnClients_Leave(object sender, EventArgs e)
        {
            btnClients.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnContracts_Leave(object sender, EventArgs e)
        {
            btnContracts.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnEmployees_Leave(object sender, EventArgs e)
        {
            btnEmployees.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnJobs_Leave(object sender, EventArgs e)
        {
            btnJobs.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnRequests_Leave(object sender, EventArgs e)
        {
            btnRequests.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnTechnicians_Leave(object sender, EventArgs e)
        {
            btnTechnicians.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
