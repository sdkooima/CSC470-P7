namespace P5
{
    partial class FormIssueDashboard
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
            this.IssuesByMonth = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IssuesByDiscoverer = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "total number of issues";
            this.label1.AccessibleName = "Total Number of Issues";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Number of Issues:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Issues by Month";
            // 
            // IssuesByMonth
            // 
            this.IssuesByMonth.FormattingEnabled = true;
            this.IssuesByMonth.Location = new System.Drawing.Point(57, 170);
            this.IssuesByMonth.Name = "IssuesByMonth";
            this.IssuesByMonth.Size = new System.Drawing.Size(240, 95);
            this.IssuesByMonth.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Issues By Discoverer";
            // 
            // IssuesByDiscoverer
            // 
            this.IssuesByDiscoverer.FormattingEnabled = true;
            this.IssuesByDiscoverer.Location = new System.Drawing.Point(57, 346);
            this.IssuesByDiscoverer.Name = "IssuesByDiscoverer";
            this.IssuesByDiscoverer.Size = new System.Drawing.Size(240, 95);
            this.IssuesByDiscoverer.TabIndex = 5;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(229, 490);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(68, 29);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormIssueDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 531);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.IssuesByDiscoverer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IssuesByMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormIssueDashboard";
            this.Text = "Issue Dashboard";
            this.Load += new System.EventHandler(this.FormIssueDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox IssuesByMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox IssuesByDiscoverer;
        private System.Windows.Forms.Button buttonClose;
    }
}