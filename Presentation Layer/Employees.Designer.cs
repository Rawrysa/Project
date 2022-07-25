namespace Project.PresentationLayer
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.dgrEmployee = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnTechnicians = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnCalls = new System.Windows.Forms.Button();
            this.btnAgents = new System.Windows.Forms.Button();
            this.pnlLoginUser = new System.Windows.Forms.Panel();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.pbLoginIcon = new System.Windows.Forms.PictureBox();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblEmployeeBranch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEmployee)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.pnlLoginUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrEmployee
            // 
            this.dgrEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrEmployee.Location = new System.Drawing.Point(199, 132);
            this.dgrEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.dgrEmployee.Name = "dgrEmployee";
            this.dgrEmployee.RowHeadersWidth = 51;
            this.dgrEmployee.RowTemplate.Height = 24;
            this.dgrEmployee.Size = new System.Drawing.Size(656, 373);
            this.dgrEmployee.TabIndex = 0;
            this.dgrEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrEmployee_CellContentClick);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(270, 509);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(124, 34);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(428, 509);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(124, 34);
            this.btnDeleteEmployee.TabIndex = 3;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(310, 86);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(139, 18);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Enter Employee ID :";
            this.lblEmployee.Click += new System.EventHandler(this.lblEmployee_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(441, 88);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.pnlSidebar.Controls.Add(this.btnLogOut);
            this.pnlSidebar.Controls.Add(this.btnQuit);
            this.pnlSidebar.Controls.Add(this.btnTechnicians);
            this.pnlSidebar.Controls.Add(this.btnRequests);
            this.pnlSidebar.Controls.Add(this.btnJobs);
            this.pnlSidebar.Controls.Add(this.btnEmployees);
            this.pnlSidebar.Controls.Add(this.btnContracts);
            this.pnlSidebar.Controls.Add(this.btnClients);
            this.pnlSidebar.Controls.Add(this.btnCalls);
            this.pnlSidebar.Controls.Add(this.btnAgents);
            this.pnlSidebar.Controls.Add(this.pnlLoginUser);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(186, 577);
            this.pnlSidebar.TabIndex = 13;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnLogOut.Location = new System.Drawing.Point(0, 493);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(186, 42);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnQuit.Location = new System.Drawing.Point(0, 535);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(186, 42);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnTechnicians
            // 
            this.btnTechnicians.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTechnicians.FlatAppearance.BorderSize = 0;
            this.btnTechnicians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechnicians.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnicians.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnTechnicians.Location = new System.Drawing.Point(0, 426);
            this.btnTechnicians.Name = "btnTechnicians";
            this.btnTechnicians.Size = new System.Drawing.Size(186, 42);
            this.btnTechnicians.TabIndex = 1;
            this.btnTechnicians.Text = "Technicians";
            this.btnTechnicians.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTechnicians.UseVisualStyleBackColor = true;
            this.btnTechnicians.Click += new System.EventHandler(this.btnTechnicians_Click);
            // 
            // btnRequests
            // 
            this.btnRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequests.FlatAppearance.BorderSize = 0;
            this.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequests.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnRequests.Location = new System.Drawing.Point(0, 384);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(186, 42);
            this.btnRequests.TabIndex = 1;
            this.btnRequests.Text = "Requests";
            this.btnRequests.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRequests.UseVisualStyleBackColor = true;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJobs.FlatAppearance.BorderSize = 0;
            this.btnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobs.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnJobs.Location = new System.Drawing.Point(0, 342);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(186, 42);
            this.btnJobs.TabIndex = 1;
            this.btnJobs.Text = "Jobs";
            this.btnJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnEmployees.Location = new System.Drawing.Point(0, 300);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(186, 42);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContracts.FlatAppearance.BorderSize = 0;
            this.btnContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContracts.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContracts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnContracts.Location = new System.Drawing.Point(0, 258);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(186, 42);
            this.btnContracts.TabIndex = 1;
            this.btnContracts.Text = "Contracts";
            this.btnContracts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnClients
            // 
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnClients.Location = new System.Drawing.Point(0, 216);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(186, 42);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Clients";
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnCalls
            // 
            this.btnCalls.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalls.FlatAppearance.BorderSize = 0;
            this.btnCalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalls.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnCalls.Location = new System.Drawing.Point(0, 174);
            this.btnCalls.Name = "btnCalls";
            this.btnCalls.Size = new System.Drawing.Size(186, 42);
            this.btnCalls.TabIndex = 1;
            this.btnCalls.Text = "Calls";
            this.btnCalls.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalls.UseVisualStyleBackColor = true;
            this.btnCalls.Click += new System.EventHandler(this.btnCalls_Click);
            // 
            // btnAgents
            // 
            this.btnAgents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgents.FlatAppearance.BorderSize = 0;
            this.btnAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgents.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnAgents.Location = new System.Drawing.Point(0, 132);
            this.btnAgents.Name = "btnAgents";
            this.btnAgents.Size = new System.Drawing.Size(186, 42);
            this.btnAgents.TabIndex = 1;
            this.btnAgents.Text = "Agents";
            this.btnAgents.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgents.UseVisualStyleBackColor = true;
            this.btnAgents.Click += new System.EventHandler(this.btnAgents_Click);
            // 
            // pnlLoginUser
            // 
            this.pnlLoginUser.Controls.Add(this.lblLoginUsername);
            this.pnlLoginUser.Controls.Add(this.pbLoginIcon);
            this.pnlLoginUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoginUser.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginUser.Name = "pnlLoginUser";
            this.pnlLoginUser.Size = new System.Drawing.Size(186, 132);
            this.pnlLoginUser.TabIndex = 0;
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.lblLoginUsername.Location = new System.Drawing.Point(25, 87);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(81, 17);
            this.lblLoginUsername.TabIndex = 1;
            this.lblLoginUsername.Text = "Username";
            // 
            // pbLoginIcon
            // 
            this.pbLoginIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbLoginIcon.Image")));
            this.pbLoginIcon.Location = new System.Drawing.Point(28, 21);
            this.pbLoginIcon.Name = "pbLoginIcon";
            this.pbLoginIcon.Size = new System.Drawing.Size(63, 63);
            this.pbLoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoginIcon.TabIndex = 0;
            this.pbLoginIcon.TabStop = false;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblEmployees.Location = new System.Drawing.Point(192, 21);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(155, 37);
            this.lblEmployees.TabIndex = 14;
            this.lblEmployees.Text = "Employees";
            // 
            // lblEmployeeBranch
            // 
            this.lblEmployeeBranch.AutoSize = true;
            this.lblEmployeeBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeBranch.Location = new System.Drawing.Point(599, 86);
            this.lblEmployeeBranch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeBranch.Name = "lblEmployeeBranch";
            this.lblEmployeeBranch.Size = new System.Drawing.Size(120, 18);
            this.lblEmployeeBranch.TabIndex = 7;
            this.lblEmployeeBranch.Text = "Enter Branch ID :";
            this.lblEmployeeBranch.Click += new System.EventHandler(this.lblEmployeeBranch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(718, 86);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 100);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 15;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEmployeeBranch);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.dgrEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.FrmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrEmployee)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLoginUser.ResumeLayout(false);
            this.pnlLoginUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnTechnicians;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnCalls;
        private System.Windows.Forms.Button btnAgents;
        private System.Windows.Forms.Panel pnlLoginUser;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.PictureBox pbLoginIcon;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Label lblEmployeeBranch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlNav;
    }
}