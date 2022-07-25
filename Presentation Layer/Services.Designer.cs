namespace Project.PresentationLayer
{
    partial class FrmViewServices
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
            this.BtnViewServices = new System.Windows.Forms.Button();
            this.dgrViewServices = new System.Windows.Forms.DataGridView();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnViewServices
            // 
            this.BtnViewServices.Location = new System.Drawing.Point(370, 563);
            this.BtnViewServices.Name = "BtnViewServices";
            this.BtnViewServices.Size = new System.Drawing.Size(169, 41);
            this.BtnViewServices.TabIndex = 0;
            this.BtnViewServices.Text = "View Services";
            this.BtnViewServices.UseVisualStyleBackColor = true;
            this.BtnViewServices.Click += new System.EventHandler(this.BtnViewServices_Click);
            // 
            // dgrViewServices
            // 
            this.dgrViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrViewServices.Location = new System.Drawing.Point(261, 74);
            this.dgrViewServices.Name = "dgrViewServices";
            this.dgrViewServices.RowHeadersWidth = 51;
            this.dgrViewServices.RowTemplate.Height = 24;
            this.dgrViewServices.Size = new System.Drawing.Size(860, 462);
            this.dgrViewServices.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(870, 563);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(147, 41);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(632, 563);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(158, 41);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "SERVICES";
            // 
            // FrmViewServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 648);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.dgrViewServices);
            this.Controls.Add(this.BtnViewServices);
            this.Name = "FrmViewServices";
            this.Text = "ViewServices";
            this.Load += new System.EventHandler(this.FrmViewServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrViewServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnViewServices;
        private System.Windows.Forms.DataGridView dgrViewServices;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}