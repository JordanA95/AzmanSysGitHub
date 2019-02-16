namespace AzmanSys
{
    partial class MainForm
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
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageFlights = new System.Windows.Forms.Button();
            this.btnManageBookings = new System.Windows.Forms.Button();
            this.AzmanSys_title = new System.Windows.Forms.Label();
            this.ExitAzmanSys = new System.Windows.Forms.Button();
            this.Usernametxb = new System.Windows.Forms.TextBox();
            this.Passwordtxb = new System.Windows.Forms.TextBox();
            this.signinbtn = new System.Windows.Forms.Button();
            this.signoutbtn = new System.Windows.Forms.Button();
            this.signupbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnManageCustomers.Location = new System.Drawing.Point(37, 86);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(103, 52);
            this.btnManageCustomers.TabIndex = 0;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = false;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageFlights
            // 
            this.btnManageFlights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnManageFlights.Location = new System.Drawing.Point(188, 86);
            this.btnManageFlights.Name = "btnManageFlights";
            this.btnManageFlights.Size = new System.Drawing.Size(94, 52);
            this.btnManageFlights.TabIndex = 1;
            this.btnManageFlights.Text = "Manage Flights";
            this.btnManageFlights.UseVisualStyleBackColor = false;
            this.btnManageFlights.Click += new System.EventHandler(this.btnManageFlights_Click);
            // 
            // btnManageBookings
            // 
            this.btnManageBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnManageBookings.Location = new System.Drawing.Point(328, 86);
            this.btnManageBookings.Name = "btnManageBookings";
            this.btnManageBookings.Size = new System.Drawing.Size(102, 52);
            this.btnManageBookings.TabIndex = 2;
            this.btnManageBookings.Text = "Manage Bookings";
            this.btnManageBookings.UseVisualStyleBackColor = false;
            this.btnManageBookings.Click += new System.EventHandler(this.btnManageBookings_Click);
            // 
            // AzmanSys_title
            // 
            this.AzmanSys_title.AutoSize = true;
            this.AzmanSys_title.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AzmanSys_title.ForeColor = System.Drawing.Color.Blue;
            this.AzmanSys_title.Location = new System.Drawing.Point(28, 9);
            this.AzmanSys_title.Name = "AzmanSys_title";
            this.AzmanSys_title.Size = new System.Drawing.Size(200, 52);
            this.AzmanSys_title.TabIndex = 3;
            this.AzmanSys_title.Text = "AzmanSys";
            // 
            // ExitAzmanSys
            // 
            this.ExitAzmanSys.BackColor = System.Drawing.Color.Red;
            this.ExitAzmanSys.Location = new System.Drawing.Point(140, 153);
            this.ExitAzmanSys.Name = "ExitAzmanSys";
            this.ExitAzmanSys.Size = new System.Drawing.Size(191, 52);
            this.ExitAzmanSys.TabIndex = 4;
            this.ExitAzmanSys.Text = "Exit Azman Sys";
            this.ExitAzmanSys.UseVisualStyleBackColor = false;
            this.ExitAzmanSys.Click += new System.EventHandler(this.ExitAzmanSys_Click);
            // 
            // Usernametxb
            // 
            this.Usernametxb.Location = new System.Drawing.Point(253, 12);
            this.Usernametxb.Name = "Usernametxb";
            this.Usernametxb.Size = new System.Drawing.Size(100, 20);
            this.Usernametxb.TabIndex = 5;
            this.Usernametxb.Text = "Username";
            // 
            // Passwordtxb
            // 
            this.Passwordtxb.Location = new System.Drawing.Point(359, 12);
            this.Passwordtxb.Name = "Passwordtxb";
            this.Passwordtxb.Size = new System.Drawing.Size(100, 20);
            this.Passwordtxb.TabIndex = 6;
            this.Passwordtxb.Text = "Password";
            // 
            // signinbtn
            // 
            this.signinbtn.Location = new System.Drawing.Point(465, 9);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(75, 23);
            this.signinbtn.TabIndex = 7;
            this.signinbtn.Text = "Sign In";
            this.signinbtn.UseVisualStyleBackColor = true;
            // 
            // signoutbtn
            // 
            this.signoutbtn.Location = new System.Drawing.Point(465, 68);
            this.signoutbtn.Name = "signoutbtn";
            this.signoutbtn.Size = new System.Drawing.Size(75, 23);
            this.signoutbtn.TabIndex = 8;
            this.signoutbtn.Text = "Sign Out";
            this.signoutbtn.UseVisualStyleBackColor = true;
            // 
            // signupbtn
            // 
            this.signupbtn.Location = new System.Drawing.Point(465, 39);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(75, 23);
            this.signupbtn.TabIndex = 9;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(552, 225);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.signoutbtn);
            this.Controls.Add(this.signinbtn);
            this.Controls.Add(this.Passwordtxb);
            this.Controls.Add(this.Usernametxb);
            this.Controls.Add(this.ExitAzmanSys);
            this.Controls.Add(this.AzmanSys_title);
            this.Controls.Add(this.btnManageBookings);
            this.Controls.Add(this.btnManageFlights);
            this.Controls.Add(this.btnManageCustomers);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageFlights;
        private System.Windows.Forms.Button btnManageBookings;
        private System.Windows.Forms.Label AzmanSys_title;
        private System.Windows.Forms.Button ExitAzmanSys;
        private System.Windows.Forms.TextBox Usernametxb;
        private System.Windows.Forms.TextBox Passwordtxb;
        private System.Windows.Forms.Button signinbtn;
        private System.Windows.Forms.Button signoutbtn;
        private System.Windows.Forms.Button signupbtn;
    }
}

