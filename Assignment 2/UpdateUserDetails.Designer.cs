namespace Assignment_2
{
    partial class UpdateUserDetails
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
            this.OK = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(0, 260);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(246, 58);
            this.OK.TabIndex = 0;
            this.OK.Text = "Update";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.Location = new System.Drawing.Point(245, 260);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(224, 58);
            this.CANCEL.TabIndex = 1;
            this.CANCEL.Text = "Cancel";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "First name";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(212, 32);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(245, 33);
            this.firstName.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.lastName.Location = new System.Drawing.Point(212, 85);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(245, 33);
            this.lastName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(91, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type";
            // 
            // userType
            // 
            this.userType.Enabled = false;
            this.userType.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.userType.Location = new System.Drawing.Point(212, 135);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(245, 33);
            this.userType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(91, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Role";
            // 
            // comboRole
            // 
            this.comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRole.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Location = new System.Drawing.Point(212, 197);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(245, 34);
            this.comboRole.TabIndex = 9;
            // 
            // UpdateUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 318);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.OK);
            this.Name = "UpdateUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateUserDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboRole;
    }
}