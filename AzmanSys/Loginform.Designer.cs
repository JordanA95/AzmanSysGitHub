namespace AzmanSys
{
    partial class Loginform
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
            this.Signinbtn = new System.Windows.Forms.Button();
            this.Usernametxb = new System.Windows.Forms.TextBox();
            this.passwordtxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Signinbtn
            // 
            this.Signinbtn.Location = new System.Drawing.Point(327, 312);
            this.Signinbtn.Name = "Signinbtn";
            this.Signinbtn.Size = new System.Drawing.Size(75, 23);
            this.Signinbtn.TabIndex = 0;
            this.Signinbtn.Text = "Sign In";
            this.Signinbtn.UseVisualStyleBackColor = true;
            this.Signinbtn.Click += new System.EventHandler(this.Signinbtn_Click);
            // 
            // Usernametxb
            // 
            this.Usernametxb.Location = new System.Drawing.Point(230, 133);
            this.Usernametxb.Name = "Usernametxb";
            this.Usernametxb.Size = new System.Drawing.Size(100, 20);
            this.Usernametxb.TabIndex = 1;
            this.Usernametxb.Text = "Username";
            this.Usernametxb.TextChanged += new System.EventHandler(this.Usernametxb_TextChanged);
            // 
            // passwordtxb
            // 
            this.passwordtxb.Location = new System.Drawing.Point(406, 123);
            this.passwordtxb.Name = "passwordtxb";
            this.passwordtxb.Size = new System.Drawing.Size(100, 20);
            this.passwordtxb.TabIndex = 2;
            this.passwordtxb.Text = "Password";
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordtxb);
            this.Controls.Add(this.Usernametxb);
            this.Controls.Add(this.Signinbtn);
            this.Name = "Loginform";
            this.Text = "Loginform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Signinbtn;
        private System.Windows.Forms.TextBox Usernametxb;
        private System.Windows.Forms.TextBox passwordtxb;
    }
}