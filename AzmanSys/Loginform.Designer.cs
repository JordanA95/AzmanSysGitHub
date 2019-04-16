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
            this.logintitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Signinbtn
            // 
            this.Signinbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Signinbtn.Location = new System.Drawing.Point(59, 97);
            this.Signinbtn.Name = "Signinbtn";
            this.Signinbtn.Size = new System.Drawing.Size(106, 51);
            this.Signinbtn.TabIndex = 0;
            this.Signinbtn.Text = "Sign In";
            this.Signinbtn.UseVisualStyleBackColor = false;
            this.Signinbtn.Click += new System.EventHandler(this.Signinbtn_Click);
            // 
            // Usernametxb
            // 
            this.Usernametxb.Location = new System.Drawing.Point(12, 56);
            this.Usernametxb.Name = "Usernametxb";
            this.Usernametxb.Size = new System.Drawing.Size(100, 20);
            this.Usernametxb.TabIndex = 1;
            this.Usernametxb.Text = "Username";
            this.Usernametxb.TextChanged += new System.EventHandler(this.Usernametxb_TextChanged);
            // 
            // passwordtxb
            // 
            this.passwordtxb.Location = new System.Drawing.Point(118, 56);
            this.passwordtxb.Name = "passwordtxb";
            this.passwordtxb.Size = new System.Drawing.Size(100, 20);
            this.passwordtxb.TabIndex = 2;
            this.passwordtxb.Text = "Password";
            // 
            // logintitle
            // 
            this.logintitle.AutoSize = true;
            this.logintitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintitle.ForeColor = System.Drawing.Color.Blue;
            this.logintitle.Location = new System.Drawing.Point(12, 13);
            this.logintitle.Name = "logintitle";
            this.logintitle.Size = new System.Drawing.Size(218, 23);
            this.logintitle.TabIndex = 3;
            this.logintitle.Text = "Please Sign In to DigitalHub";
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(247, 173);
            this.Controls.Add(this.logintitle);
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
        private System.Windows.Forms.Label logintitle;
    }
}