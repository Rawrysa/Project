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
    public partial class Employees : Form
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

        public Employees()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = 0;
            pnlNav.Top = 0;
            pnlNav.Left = 0;
            //lblLoginUsername.Text = username;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //dgrEmployee.DataSource = new DataHandler().AddEmployee();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            //dgrEmployee.DataSource = new DataHandler().DeleteEmployee();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {

        }

        private void dgrEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmployeeBranch_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
