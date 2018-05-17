namespace Assignment_2
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIssuesOnDb = new System.Windows.Forms.Label();
            this.labelLastIssue = new System.Windows.Forms.Label();
            this.labelLastIssueFixed = new System.Windows.Forms.Label();
            this.btnShowIssues = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowIssues);
            this.panel1.Controls.Add(this.labelLastIssueFixed);
            this.panel1.Controls.Add(this.labelLastIssue);
            this.panel1.Controls.Add(this.labelIssuesOnDb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 507);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issues on DB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Issue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Issue Fixed";
            // 
            // labelIssuesOnDb
            // 
            this.labelIssuesOnDb.AutoSize = true;
            this.labelIssuesOnDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssuesOnDb.Location = new System.Drawing.Point(351, 109);
            this.labelIssuesOnDb.Name = "labelIssuesOnDb";
            this.labelIssuesOnDb.Size = new System.Drawing.Size(75, 37);
            this.labelIssuesOnDb.TabIndex = 3;
            this.labelIssuesOnDb.Text = "{ # }";
            // 
            // labelLastIssue
            // 
            this.labelLastIssue.AutoSize = true;
            this.labelLastIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastIssue.Location = new System.Drawing.Point(351, 159);
            this.labelLastIssue.Name = "labelLastIssue";
            this.labelLastIssue.Size = new System.Drawing.Size(229, 37);
            this.labelLastIssue.TabIndex = 4;
            this.labelLastIssue.Text = "{ issue_name }";
            // 
            // labelLastIssueFixed
            // 
            this.labelLastIssueFixed.AutoSize = true;
            this.labelLastIssueFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastIssueFixed.Location = new System.Drawing.Point(351, 217);
            this.labelLastIssueFixed.Name = "labelLastIssueFixed";
            this.labelLastIssueFixed.Size = new System.Drawing.Size(229, 37);
            this.labelLastIssueFixed.TabIndex = 5;
            this.labelLastIssueFixed.Text = "{ issue_name }";
            // 
            // btnShowIssues
            // 
            this.btnShowIssues.Location = new System.Drawing.Point(186, 295);
            this.btnShowIssues.Name = "btnShowIssues";
            this.btnShowIssues.Size = new System.Drawing.Size(240, 23);
            this.btnShowIssues.TabIndex = 6;
            this.btnShowIssues.Text = "Show Bugs List";
            this.btnShowIssues.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 508);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIssuesOnDb;
        private System.Windows.Forms.Label labelLastIssue;
        private System.Windows.Forms.Label labelLastIssueFixed;
        private System.Windows.Forms.Button btnShowIssues;
    }
}