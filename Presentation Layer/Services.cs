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
    public partial class ViewServices : Form
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

        public ViewServices()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = 0;
            pnlNav.Top = 0;
            pnlNav.Left = 0;
            //lblLoginUsername.Text = username;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
        }

        private void BtnViewServices_Click(object sender, EventArgs e)
        {
            //dgrViewServices.DataSource = new DataHandler().ViewServices();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void ViewServices_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
