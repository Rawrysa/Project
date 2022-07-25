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
    public partial class Login : Form
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

        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Logins logins = new Logins();

                logins.username = txtUsername.Text;
                logins.password = txtPassword.Text;

                if (logins.ValidateUser())
                {
                    new SplashScreen(txtUsername.Text).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
            catch
            {
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtUsername_MouseLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
