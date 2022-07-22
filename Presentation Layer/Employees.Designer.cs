namespace Project.PresentationLayer
{
    partial class FrmEmployees
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
            this.dgrEmployee = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblEmployeeBranch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrEmployee
            // 
            this.dgrEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrEmployee.Location = new System.Drawing.Point(35, 74);
            this.dgrEmployee.Name = "dgrEmployee";
            this.dgrEmployee.RowHeadersWidth = 51;
            this.dgrEmployee.RowTemplate.Height = 24;
            this.dgrEmployee.Size = new System.Drawing.Size(741, 330);
            this.dgrEmployee.TabIndex = 0;
            this.dgrEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrEmployee_CellContentClick);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(59, 429);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(165, 42);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(263, 429);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(165, 42);
            this.btnDeleteEmployee.TabIndex = 3;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(626, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(457, 429);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 42);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(55, 38);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(169, 22);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Enter Employee ID :";
            // 
            // lblEmployeeBranch
            // 
            this.lblEmployeeBranch.AutoSize = true;
            this.lblEmployeeBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeBranch.Location = new System.Drawing.Point(442, 38);
            this.lblEmployeeBranch.Name = "lblEmployeeBranch";
            this.lblEmployeeBranch.Size = new System.Drawing.Size(147, 22);
            this.lblEmployeeBranch.TabIndex = 7;
            this.lblEmployeeBranch.Text = "Enter Branch ID :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(595, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 22);
            this.textBox2.TabIndex = 9;
            // 
            // FrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 498);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEmployeeBranch);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.dgrEmployee);
            this.Name = "FrmEmployees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.FrmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblEmployeeBranch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}