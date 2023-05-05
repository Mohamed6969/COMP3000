namespace RsaAes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(117, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // textBoxusername
            // 
            this.textBoxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxusername.Location = new System.Drawing.Point(162, 156);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(210, 38);
            this.textBoxusername.TabIndex = 3;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpassword.Location = new System.Drawing.Point(162, 212);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(210, 38);
            this.textBoxpassword.TabIndex = 4;
            this.textBoxpassword.UseSystemPasswordChar = true;
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonlogin.Location = new System.Drawing.Point(127, 284);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(142, 45);
            this.buttonlogin.TabIndex = 5;
            this.buttonlogin.Text = "login";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonexit.Location = new System.Drawing.Point(245, 359);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(110, 45);
            this.buttonexit.TabIndex = 6;
            this.buttonexit.Text = "exit";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignup.Location = new System.Drawing.Point(43, 359);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(113, 45);
            this.btnSignup.TabIndex = 7;
            this.btnSignup.Text = "signup";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(407, 423);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button btnSignup;
    }
}