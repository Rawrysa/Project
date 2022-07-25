namespace Project.PresentationLayer
{
    partial class Requests
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
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.btnRemoveRequest = new System.Windows.Forms.Button();
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblRequestsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlLoginUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(780, 112);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(141, 20);
            this.txtClientID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(714, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client ID:";
            // 
            // dgvRequests
            // 
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Location = new System.Drawing.Point(222, 87);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.Size = new System.Drawing.Size(472, 285);
            this.dgvRequests.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnBefore);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Location = new System.Drawing.Point(225, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 69);
            this.panel1.TabIndex = 6;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnLast.Location = new System.Drawing.Point(386, 15);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(51, 40);
            this.btnLast.TabIndex = 12;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnNext.Location = new System.Drawing.Point(250, 15);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(51, 40);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnBefore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnBefore.Location = new System.Drawing.Point(168, 15);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(51, 40);
            this.btnBefore.TabIndex = 10;
            this.btnBefore.Text = "<";
            this.btnBefore.UseVisualStyleBackColor = false;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnFirst.Location = new System.Drawing.Point(30, 15);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(51, 40);
            this.btnFirst.TabIndex = 9;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(780, 154);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(141, 20);
            this.txtServiceID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(714, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Service ID:";
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnNewRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnNewRequest.Location = new System.Drawing.Point(720, 206);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(201, 42);
            this.btnNewRequest.TabIndex = 9;
            this.btnNewRequest.Text = "New Request";
            this.btnNewRequest.UseVisualStyleBackColor = false;
            this.btnNewRequest.Click += new System.EventHandler(this.btnNewRequest_Click);
            // 
            // btnRemoveRequest
            // 
            this.btnRemoveRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnRemoveRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnRemoveRequest.Location = new System.Drawing.Point(723, 272);
            this.btnRemoveRequest.Name = "btnRemoveRequest";
            this.btnRemoveRequest.Size = new System.Drawing.Size(201, 42);
            this.btnRemoveRequest.TabIndex = 10;
            this.btnRemoveRequest.Text = "Remove Request";
            this.btnRemoveRequest.UseVisualStyleBackColor = false;
            this.btnRemoveRequest.Click += new System.EventHandler(this.btnRemoveRequest_Click);
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
            this.pnlSidebar.TabIndex = 12;
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
            this.pbLoginIcon.Location = new System.Drawing.Point(28, 21);
            this.pbLoginIcon.Name = "pbLoginIcon";
            this.pbLoginIcon.Size = new System.Drawing.Size(63, 63);
            this.pbLoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoginIcon.TabIndex = 0;
            this.pbLoginIcon.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnMenu.Location = new System.Drawing.Point(813, 436);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(108, 50);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblRequestsTitle
            // 
            this.lblRequestsTitle.AutoSize = true;
            this.lblRequestsTitle.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblRequestsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblRequestsTitle.Location = new System.Drawing.Point(218, 21);
            this.lblRequestsTitle.Name = "lblRequestsTitle";
            this.lblRequestsTitle.Size = new System.Drawing.Size(132, 37);
            this.lblRequestsTitle.TabIndex = 13;
            this.lblRequestsTitle.Text = "Requests";
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.lblRequestsTitle);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnRemoveRequest);
            this.Controls.Add(this.btnNewRequest);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Requests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requests";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLoginUser.ResumeLayout(false);
            this.pnlLoginUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Button btnRemoveRequest;
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
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblRequestsTitle;
    }
}