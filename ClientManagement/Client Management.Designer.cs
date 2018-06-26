namespace ClientManagement
{
    partial class ClientManagmentForm
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
            this.fileLoadedLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.ListBox();
            this.eliminateDuplicatesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selectedClientName = new System.Windows.Forms.TextBox();
            this.selectedClientPolicy = new System.Windows.Forms.TextBox();
            this.selectedClientStreet = new System.Windows.Forms.TextBox();
            this.selectedClientCSZ = new System.Windows.Forms.TextBox();
            this.selectedClientDOB = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.policySearchBox = new System.Windows.Forms.TextBox();
            this.policySearchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileLoadedLabel
            // 
            this.fileLoadedLabel.AutoSize = true;
            this.fileLoadedLabel.Location = new System.Drawing.Point(13, 13);
            this.fileLoadedLabel.Name = "fileLoadedLabel";
            this.fileLoadedLabel.Size = new System.Drawing.Size(65, 13);
            this.fileLoadedLabel.TabIndex = 0;
            this.fileLoadedLabel.Text = "File Loaded:";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(85, 13);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(85, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "(No File Loaded)";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(13, 30);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load CSV";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(95, 30);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // displayBox
            // 
            this.displayBox.FormattingEnabled = true;
            this.displayBox.Location = new System.Drawing.Point(16, 59);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(260, 342);
            this.displayBox.TabIndex = 5;
            this.displayBox.SelectedIndexChanged += new System.EventHandler(this.displayBox_SelectedIndexChanged);
            // 
            // eliminateDuplicatesButton
            // 
            this.eliminateDuplicatesButton.Enabled = false;
            this.eliminateDuplicatesButton.Location = new System.Drawing.Point(798, 29);
            this.eliminateDuplicatesButton.Name = "eliminateDuplicatesButton";
            this.eliminateDuplicatesButton.Size = new System.Drawing.Size(113, 23);
            this.eliminateDuplicatesButton.TabIndex = 6;
            this.eliminateDuplicatesButton.Text = "Eliminate Duplicates";
            this.eliminateDuplicatesButton.UseVisualStyleBackColor = true;
            this.eliminateDuplicatesButton.Visible = false;
            this.eliminateDuplicatesButton.Click += new System.EventHandler(this.eliminateDuplicatesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selected Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Policy ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Street Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "City State Zip:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DOB:";
            // 
            // selectedClientName
            // 
            this.selectedClientName.Location = new System.Drawing.Point(450, 85);
            this.selectedClientName.Name = "selectedClientName";
            this.selectedClientName.Size = new System.Drawing.Size(241, 20);
            this.selectedClientName.TabIndex = 13;
            // 
            // selectedClientPolicy
            // 
            this.selectedClientPolicy.Location = new System.Drawing.Point(450, 117);
            this.selectedClientPolicy.Name = "selectedClientPolicy";
            this.selectedClientPolicy.ReadOnly = true;
            this.selectedClientPolicy.Size = new System.Drawing.Size(241, 20);
            this.selectedClientPolicy.TabIndex = 14;
            // 
            // selectedClientStreet
            // 
            this.selectedClientStreet.Location = new System.Drawing.Point(450, 149);
            this.selectedClientStreet.Name = "selectedClientStreet";
            this.selectedClientStreet.Size = new System.Drawing.Size(241, 20);
            this.selectedClientStreet.TabIndex = 15;
            // 
            // selectedClientCSZ
            // 
            this.selectedClientCSZ.Location = new System.Drawing.Point(450, 182);
            this.selectedClientCSZ.Name = "selectedClientCSZ";
            this.selectedClientCSZ.Size = new System.Drawing.Size(241, 20);
            this.selectedClientCSZ.TabIndex = 16;
            // 
            // selectedClientDOB
            // 
            this.selectedClientDOB.Location = new System.Drawing.Point(450, 214);
            this.selectedClientDOB.Name = "selectedClientDOB";
            this.selectedClientDOB.Size = new System.Drawing.Size(241, 20);
            this.selectedClientDOB.TabIndex = 17;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(616, 249);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Update Info";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Select By Policy ID:";
            // 
            // policySearchBox
            // 
            this.policySearchBox.Location = new System.Drawing.Point(119, 431);
            this.policySearchBox.Name = "policySearchBox";
            this.policySearchBox.Size = new System.Drawing.Size(157, 20);
            this.policySearchBox.TabIndex = 20;
            // 
            // policySearchButton
            // 
            this.policySearchButton.Location = new System.Drawing.Point(16, 454);
            this.policySearchButton.Name = "policySearchButton";
            this.policySearchButton.Size = new System.Drawing.Size(260, 23);
            this.policySearchButton.TabIndex = 21;
            this.policySearchButton.Text = "Go";
            this.policySearchButton.UseVisualStyleBackColor = true;
            this.policySearchButton.Click += new System.EventHandler(this.policySearchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(513, 249);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 23);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "Delete Client";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ClientManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 489);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.policySearchButton);
            this.Controls.Add(this.policySearchBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.selectedClientDOB);
            this.Controls.Add(this.selectedClientCSZ);
            this.Controls.Add(this.selectedClientStreet);
            this.Controls.Add(this.selectedClientPolicy);
            this.Controls.Add(this.selectedClientName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminateDuplicatesButton);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.fileLoadedLabel);
            this.Name = "ClientManagmentForm";
            this.Text = "Client Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileLoadedLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox displayBox;
        private System.Windows.Forms.Button eliminateDuplicatesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox selectedClientName;
        private System.Windows.Forms.TextBox selectedClientPolicy;
        private System.Windows.Forms.TextBox selectedClientStreet;
        private System.Windows.Forms.TextBox selectedClientCSZ;
        private System.Windows.Forms.TextBox selectedClientDOB;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox policySearchBox;
        private System.Windows.Forms.Button policySearchButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

