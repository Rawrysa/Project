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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnAgents.Height;
            pnlNav.Top = btnAgents.Top;
            pnlNav.Left = btnAgents.Left;
            btnAgents.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalls.Height;
            pnlNav.Top = btnCalls.Top;
            pnlNav.Left = btnCalls.Left;
            btnCalls.BackColor = Color.FromArgb(46, 51, 73); pnlNav.Height = btnCalls.Height;
            pnlNav.Top = btnCalls.Top;
            pnlNav.Left = btnCalls.Left;
            btnCalls.BackColor = Color.FromArgb(46, 51, 73); pnlNav.Height = btnCalls.Height;
            pnlNav.Top = btnCalls.Top;
            pnlNav.Left = btnCalls.Left;
            btnCalls.BackColor = Color.FromArgb(46, 51, 73);
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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnQuit.Height;
            pnlNav.Top = btnQuit.Top;
            pnlNav.Left = btnQuit.Left;
            btnQuit.BackColor = Color.FromArgb(46, 51, 73);

            Environment.Exit(0);
        }
    }
}
