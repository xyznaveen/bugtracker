﻿namespace Assignment_2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loginPassword);
            this.panel1.Controls.Add(this.loginUsername);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 327);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(84, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(384, 81);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bug Tracker";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnLogin.Location = new System.Drawing.Point(214, 252);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(254, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(94, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(147, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // loginPassword
            // 
            this.loginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassword.Location = new System.Drawing.Point(214, 191);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(254, 33);
            this.loginPassword.TabIndex = 1;
            this.loginPassword.UseSystemPasswordChar = true;
            // 
            // loginUsername
            // 
            this.loginUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.loginUsername.Location = new System.Drawing.Point(214, 138);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(254, 33);
            this.loginUsername.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 325);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox loginPassword;
    }
}

