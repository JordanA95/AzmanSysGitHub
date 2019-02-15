namespace AzmanSys.Forms
{
    partial class Login
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
            this.AzmanSys_title = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.cancelloginbtn = new System.Windows.Forms.Button();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AzmanSys_title
            // 
            this.AzmanSys_title.AutoSize = true;
            this.AzmanSys_title.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AzmanSys_title.ForeColor = System.Drawing.Color.Blue;
            this.AzmanSys_title.Location = new System.Drawing.Point(96, 9);
            this.AzmanSys_title.Name = "AzmanSys_title";
            this.AzmanSys_title.Size = new System.Drawing.Size(200, 52);
            this.AzmanSys_title.TabIndex = 4;
            this.AzmanSys_title.Text = "AzmanSys";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(105, 169);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(106, 57);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            // 
            // cancelloginbtn
            // 
            this.cancelloginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelloginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelloginbtn.Location = new System.Drawing.Point(244, 169);
            this.cancelloginbtn.Name = "cancelloginbtn";
            this.cancelloginbtn.Size = new System.Drawing.Size(106, 57);
            this.cancelloginbtn.TabIndex = 6;
            this.cancelloginbtn.Text = "Cancel";
            this.cancelloginbtn.UseVisualStyleBackColor = false;
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(56, 75);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(87, 20);
            this.usernamelbl.TabIndex = 7;
            this.usernamelbl.Text = "Username:";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(61, 118);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(82, 20);
            this.passwordlbl.TabIndex = 8;
            this.passwordlbl.Text = "Password:";
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(150, 74);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(200, 20);
            this.tbusername.TabIndex = 9;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(150, 117);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(200, 20);
            this.tbpassword.TabIndex = 10;
            // 
            // AzmanSysLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(414, 254);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.cancelloginbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.AzmanSys_title);
            this.Name = "AzmanSysLogin";
            this.Text = "AzmanSysLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AzmanSys_title;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button cancelloginbtn;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
    }
}