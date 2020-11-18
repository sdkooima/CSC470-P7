namespace P5
{
    partial class FormSelectFeature
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSelectFeature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(745, 353);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(512, 411);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(109, 27);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSelectFeature
            // 
            this.buttonSelectFeature.Location = new System.Drawing.Point(663, 411);
            this.buttonSelectFeature.Name = "buttonSelectFeature";
            this.buttonSelectFeature.Size = new System.Drawing.Size(109, 27);
            this.buttonSelectFeature.TabIndex = 2;
            this.buttonSelectFeature.Text = "Select Feature";
            this.buttonSelectFeature.UseVisualStyleBackColor = true;
            // 
            // FormSelectFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSelectFeature);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.listView1);
            this.Name = "FormSelectFeature";
            this.Text = "FormSelectFeature";
            this.Load += new System.EventHandler(this.FormSelectFeature_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSelectFeature;
    }
}